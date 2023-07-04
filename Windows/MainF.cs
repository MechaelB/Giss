using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Giss.Resources;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using Giss.Functions;
using System.Runtime.CompilerServices;
using System.Data.Sql;

namespace Giss
{
    public partial class MainF : Form
    {
        private string sourceString;
        public static bool access;
        GMapOverlay Company = new GMapOverlay();
        public GMapOverlay Boreholes = new GMapOverlay();
        private GMapMarker item;

        public static MainF Instance { get; private set; }


        public MainF()
        {
            Connection connection = new Connection();
            Instance = this;
            InitializeComponent();             
        }


        private void MainF_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;//выбор подгрузки карты – онлайн или из ресурсов
            GMaps.Instance.ImportFromGMDB(@"~\MapLocal.gmdb");
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.ArcGIS_World_Topo_Map; //какой провайдер карт используется 
            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 16; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(43.2621593197834, 76.8585920333862);// точка в центре карты при открытии 
            GMarkerGoogle gMarker = new GMarkerGoogle(new PointLatLng(43.2621593197834, 76.8585920333862), GMarkerGoogleType.red_small);
            Company.Markers.Add(gMarker);
            gMapControl1.Overlays.Add(Company);
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = true; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
            GMaps.Instance.ExportToGMDB(@"~\MapLocal.gmdb");
            gMapControl1.Overlays.Add(Boreholes);
            
        }


        private void tbtn_access_Click(object sender, EventArgs e)
        {
            new AccessF().ShowDialog();
            if (access)
            {
                btn_create.Enabled = true;
                btn_find.Enabled = true;
                btn_open.Enabled = true;
                gMapControl1.Enabled = true;
                btn_server_find.Enabled = true;
                btn_cache.Enabled = true;
                btn_cache_use.Enabled = true;
            }
        }


        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && item.Overlay == Boreholes)
            {
                ViewF open = new ViewF(item.Position.Lat, item.Position.Lng);
                open.ShowDialog();
                open.Dispose();
            }
            else if (e.Button == MouseButtons.Right && item.Overlay == Boreholes)
            {
                contextMark.Show(MousePosition.X, MousePosition.Y);
                this.item = item;

            }
        }

        private void gMapControl1_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_OnMapDoubleClick(PointLatLng pointClick, MouseEventArgs e)
        {
            CreateF create = new CreateF(Coords.CoordsDMSToDD(Coords.CoordsDDToDMS(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat)), Coords.CoordsDMSToDD(Coords.CoordsDDToDMS(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng)),sourceString);
            create.ShowDialog();

            if (create.DialogResult == DialogResult.OK)
            {
                GMarkerGoogle gMarker = new GMarkerGoogle(new PointLatLng(Coords.CoordsDMSToDD(Coords.CoordsDDToDMS(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat)), Coords.CoordsDMSToDD(Coords.CoordsDDToDMS(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng))), GMarkerGoogleType.blue_small);
                Boreholes.Markers.Add(gMarker);
            }
            create.Dispose();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewF open = new ViewF(item.Position.Lat, item.Position.Lng);
            open.ShowDialog();
            open.Dispose();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            item.Overlay.Markers.Remove(item);
            _ = Connection.deleteMark(item.Position.Lat, item.Position.Lng, sourceString);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
        }

        private void найтиСерверToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Connection.DiscoverSqlServers(btn_server_find);
            _=Main(progressBar,btn_server_find);
        }
        

        public void Click_New_btn (object sender, EventArgs e)
        {            
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            string item = menuItem.Text.Substring(13);
            sourceString = item;

            _=Connection.markSet(this,sourceString);
        }

        static async Task Main(ProgressBar progressBar, ToolStripMenuItem tsbtn)
        {
            // Устанавливаем стиль для показа прогресса
            progressBar.Style = ProgressBarStyle.Continuous;

            // Устанавливаем значения для минимума и максимума
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;

            // Создаем объект Progress для отслеживания прогресса
            Progress<int> progress = new Progress<int>(value =>
            {
                progressBar.Value = value;
            });

            // Запускаем асинхронную операцию поиска SQL-серверов с отслеживанием прогресса
            await Connection.DiscoverSqlServers(progress, tsbtn);
            await Task.Delay(750);
            progressBar.Value = progressBar.Minimum;
        }

    }
}
