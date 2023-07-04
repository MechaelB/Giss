using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using LINQPad.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Giss.Functions
{
    internal class Connection
    {

        public static async Task DiscoverSqlServers(IProgress<int> progress, ToolStripMenuItem tsbtn)
        {
            MainF main = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainF)
                {
                    main = (MainF)form;
                    break;
                }
            }

            tsbtn.DropDownItems.Clear();

            DataTable servers = await Task.Run(() => SqlDataSourceEnumerator.Instance.GetDataSources());

            int totalServers = servers.Rows.Count;
            int currentServer = 0;

            foreach (DataRow server in servers.Rows)
            {
                string serverName = server["ServerName"].ToString();
                string instanceName = server["InstanceName"].ToString();

                tsbtn.DropDownItems.Add(new ToolStripMenuItem("Server Name: " + serverName + '\\' + instanceName));

                foreach (ToolStripMenuItem item in tsbtn.DropDownItems)
                {
                    if (item.Text == "Server Name: " + serverName + '\\' + instanceName)
                    {
                        item.Click += new System.EventHandler(main.Click_New_btn);
                    }
                }

                currentServer++;
                int progressPercentage = (int)Math.Round((double)currentServer / totalServers * 100);
                progress?.Report(progressPercentage);
            }
        }

        static public async Task markSet(MainF mainF, string sourceString)
        {
            GMapControl gMapControl1 = null;
            foreach (var control in mainF.Controls)
            {
                if (control is GMapControl)
                {
                    gMapControl1 = (GMapControl)control;
                }
            }

            mainF.Boreholes.Clear();

            string connectionString = $"Data Source={sourceString};Database=Passports;Trusted_Connection=True;";
            string sqlExpression = "SELECT  Latitude,Longitude  FROM Address";

            SqlConnection connection = new SqlConnection(connectionString);
            {
                await connection.OpenAsync();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlExpression;
                command.Connection = connection;
                try
                {
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    {
                        if (reader.HasRows) // если есть данные
                        {
                            while (reader.Read())   // построчно считываем данные
                            {
                                var Lat = reader.GetValue(0);
                                var Lng = reader.GetValue(1);

                                GMarkerGoogle gMarker = new GMarkerGoogle(new GMap.NET.PointLatLng(Convert.ToDouble(Lat), Convert.ToDouble(Lng)), GMarkerGoogleType.blue_small);
                                mainF.Boreholes.Markers.Add(gMarker);
                            }

                        }
                        else
                        {
                            Exception ex = new Exception("База данных пуста");
                            throw ex;
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally
                {
                    connection.Close();
                    //gMapControl1.Overlays.Add(mainF.Boreholes);
                    gMapControl1.Update();

                }

            }
        }

        static public async Task saveMark(CreateF createF)
        {
            string connectionString = $"Data Source= {createF.sourceString};Database=Passports;Trusted_Connection=True;";
            string sqlExpression = "Insert into Address(Latitude,Longitude)  values(@Lat,@Lng)";

            SqlConnection connection = new SqlConnection(connectionString);
            {
                await connection.OpenAsync();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlExpression;
                command.Connection = connection;
                command.Parameters.Add(new SqlParameter("@Lat", createF.latitude));
                command.Parameters.Add(new SqlParameter("@Lng", createF.longitude));
                await command.ExecuteNonQueryAsync();
                connection.Close();

            }

        }

        static public async Task deleteMark(double latitude, double longitude, string sourceString)
        {
            string connectionString = $"Data Source= {sourceString};Database=Passports;Trusted_Connection=True;";
            string sqlExpression = "Delete Address Where (Latitude = @Lat and Longitude = @Lng)";


            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                {
                    await connection.OpenAsync();

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = sqlExpression;
                    command.Connection = connection;
                    command.Parameters.Add(new SqlParameter("@Lat", latitude));
                    command.Parameters.Add(new SqlParameter("@Lng", longitude));
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async Task<List <SqlParameter>> AddressCheck(string addressString, string sourceString)
        {
            //street,num,locality,area

            string[] adress = addressString.Split(':',';');
            if (string[0])
            {

            }

            List<SqlParameter> sqlParameters = new List<SqlParameter>();


            string connectionString = $"Data Source={sourceString};Database=Passports;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                try
                {
                    await connection.OpenAsync();


                    connection.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }
        private async Task CustomerCheck()
        {

        }
        private async Task CadastralNumCheck()
        {

        }
        private async Task ImageLoad()
        {

        }




    }
}
