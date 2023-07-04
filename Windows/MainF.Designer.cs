using Giss.Resources;
using System.Windows.Forms;

namespace Giss
{
    partial class MainF
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_main = new System.Windows.Forms.ToolStripSplitButton();
            this.tbtn_access = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_server_find = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cache = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cache_use = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_close = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_create = new System.Windows.Forms.ToolStripButton();
            this.btn_find = new System.Windows.Forms.ToolStripSplitButton();
            this.поискПоНаселенномуПунктуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКоординатамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКадастровомуНомеруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоЗаказчикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMark = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            this.contextMark.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.Enabled = false;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 36);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(776, 418);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapDoubleClick += new GMap.NET.WindowsForms.MapDoubleClick(this.gMapControl1_OnMapDoubleClick);
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.gMapControl1_OnMarkerDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_main,
            this.btn_create,
            this.btn_find});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_main
            // 
            this.btn_main.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtn_access,
            this.btn_server_find,
            this.btn_open,
            this.btn_cache,
            this.btn_cache_use,
            this.btn_close});
            this.btn_main.Image = ((System.Drawing.Image)(resources.GetObject("btn_main.Image")));
            this.btn_main.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(52, 22);
            this.btn_main.Text = global::Giss.Resources.Ru.text_btn_main;
            // 
            // tbtn_access
            // 
            this.tbtn_access.Name = "tbtn_access";
            this.tbtn_access.Size = new System.Drawing.Size(215, 22);
            this.tbtn_access.Text = global::Giss.Resources.Ru.text_btn_login;
            this.tbtn_access.Click += new System.EventHandler(this.tbtn_access_Click);
            // 
            // btn_server_find
            // 
            this.btn_server_find.Enabled = false;
            this.btn_server_find.Name = "btn_server_find";
            this.btn_server_find.Size = new System.Drawing.Size(215, 22);
            this.btn_server_find.Text = "Найти сервер";
            this.btn_server_find.Click += new System.EventHandler(this.найтиСерверToolStripMenuItem_Click);
            // 
            // btn_open
            // 
            this.btn_open.Enabled = false;
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(215, 22);
            this.btn_open.Text = global::Giss.Resources.Ru.text_btn_open;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_cache
            // 
            this.btn_cache.Enabled = false;
            this.btn_cache.Name = "btn_cache";
            this.btn_cache.Size = new System.Drawing.Size(215, 22);
            this.btn_cache.Text = global::Giss.Resources.Ru.text_btn_cache;
            // 
            // btn_cache_use
            // 
            this.btn_cache_use.Enabled = false;
            this.btn_cache_use.Name = "btn_cache_use";
            this.btn_cache_use.Size = new System.Drawing.Size(215, 22);
            this.btn_cache_use.Text = global::Giss.Resources.Ru.text_btn_cache_use;
            // 
            // btn_close
            // 
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(215, 22);
            this.btn_close.Text = global::Giss.Resources.Ru.text_btn_close;
            // 
            // btn_create
            // 
            this.btn_create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_create.Enabled = false;
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(95, 22);
            this.btn_create.Text = global::Giss.Resources.Ru.text_btn_create;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_find
            // 
            this.btn_find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_find.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоНаселенномуПунктуToolStripMenuItem,
            this.поискПоКоординатамToolStripMenuItem,
            this.поискПоКадастровомуНомеруToolStripMenuItem,
            this.поискПоЗаказчикуToolStripMenuItem});
            this.btn_find.Enabled = false;
            this.btn_find.Image = ((System.Drawing.Image)(resources.GetObject("btn_find.Image")));
            this.btn_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_find.Name = "btn_find";
            this.btn_find.RightToLeftAutoMirrorImage = true;
            this.btn_find.Size = new System.Drawing.Size(58, 22);
            this.btn_find.Text = global::Giss.Resources.Ru.text_btn_find;
            // 
            // поискПоНаселенномуПунктуToolStripMenuItem
            // 
            this.поискПоНаселенномуПунктуToolStripMenuItem.Name = "поискПоНаселенномуПунктуToolStripMenuItem";
            this.поискПоНаселенномуПунктуToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.поискПоНаселенномуПунктуToolStripMenuItem.Text = "Поиск по населенному пункту";
            // 
            // поискПоКоординатамToolStripMenuItem
            // 
            this.поискПоКоординатамToolStripMenuItem.Name = "поискПоКоординатамToolStripMenuItem";
            this.поискПоКоординатамToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.поискПоКоординатамToolStripMenuItem.Text = "Поиск по координатам";
            // 
            // поискПоКадастровомуНомеруToolStripMenuItem
            // 
            this.поискПоКадастровомуНомеруToolStripMenuItem.Name = "поискПоКадастровомуНомеруToolStripMenuItem";
            this.поискПоКадастровомуНомеруToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.поискПоКадастровомуНомеруToolStripMenuItem.Text = "Поиск по кадастровому номеру";
            // 
            // поискПоЗаказчикуToolStripMenuItem
            // 
            this.поискПоЗаказчикуToolStripMenuItem.Name = "поискПоЗаказчикуToolStripMenuItem";
            this.поискПоЗаказчикуToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.поискПоЗаказчикуToolStripMenuItem.Text = "Поиск по заказчику";
            // 
            // contextMark
            // 
            this.contextMark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMark.Name = "contextMark";
            this.contextMark.Size = new System.Drawing.Size(107, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(630, 460);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(158, 23);
            this.progressBar.TabIndex = 2;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "MainF";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainF_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMark.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton btn_main;
        private System.Windows.Forms.ToolStripMenuItem btn_open;
        private System.Windows.Forms.ToolStripMenuItem btn_close;
        private System.Windows.Forms.ToolStripButton btn_create;
        private System.Windows.Forms.ToolStripSplitButton btn_find;
        private System.Windows.Forms.ToolStripMenuItem tbtn_access;
        private ToolStripMenuItem btn_cache;
        private ToolStripMenuItem btn_cache_use;
        private ToolStripMenuItem поискПоНаселенномуПунктуToolStripMenuItem;
        private ToolStripMenuItem поискПоКоординатамToolStripMenuItem;
        private ToolStripMenuItem поискПоКадастровомуНомеруToolStripMenuItem;
        private ToolStripMenuItem поискПоЗаказчикуToolStripMenuItem;
        private ContextMenuStrip contextMark;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem btn_server_find;
        private ProgressBar progressBar;
    }
}

