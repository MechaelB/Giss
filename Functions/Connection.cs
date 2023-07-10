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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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



            await PasportWrite(createF, createF.controlsList);

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

        static public async Task PasportWrite(CreateF createF,List<string> values)
        {

            string sourceString = createF.sourceString;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            string connectionString = $"Data Source={sourceString};Database=Passports;Trusted_Connection=True;";
            int i = 0;

            foreach (string value in values)
            {
                    SqlParameter sql = new SqlParameter("@passportParameter" + i, value);
                    sqlParameters.Add(sql);
                    i++;
            }
            Task<SqlParameter> addressId = AddressWrite(createF);
            SqlParameter idParam = await addressId;
            sqlParameters.Add(idParam);

            //SqlParameter idParameter = new SqlParameter();
            //idParameter = await addressId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    

                    await connection.OpenAsync();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "Insert Into Passport(Cadastral_Number, Aquifers, Customer, Debit, Depth, Date, Notes, Address) VALUES(@passportParameter1,@passportParameter7,@passportParameter2,@passportParameter3,@passportParameter4,@passportParameter6,@passportParameter8, @id)";
                    foreach (SqlParameter sqlParameter in sqlParameters)
                    {
                        command.Parameters.Add(sqlParameter);
                    }
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        
        static private async Task<SqlParameter> AddressWrite(CreateF createF)
        {//street,num,locality,area
            string addressString = createF.tb_address.Text;
            string sourceString = createF.sourceString;
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            string[] adress = addressString.Split(':', ';');
            int i = 0;
            foreach (string adress_part in adress)
            {
                SqlParameter sql = new SqlParameter("@adress_part" + i, adress_part);
                sqlParameters.Add(sql);
                i++;
            }

            string connectionString = $"Data Source={sourceString};Database=Passports;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "Insert Into Address(Street, Plot_number, Locality, Area, Latitude,Longitude) VALUES(@adress_part0,@adress_part1,@adress_part2,@adress_part3,@Lat,@Lng);SET @id=SCOPE_IDENTITY()";
                    foreach (SqlParameter sqlParameter in sqlParameters)
                    {
                        command.Parameters.Add(sqlParameter);
                    }
                    command.Parameters.Add(new SqlParameter("@Lat", createF.latitude));
                    command.Parameters.Add(new SqlParameter("@Lng", createF.longitude));
                    SqlParameter idParam = new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output // параметр выходной
                    };
                    command.Parameters.Add(idParam);
                    await command.ExecuteNonQueryAsync();
                    SqlParameter addresId = new SqlParameter(idParam.ParameterName,idParam.Value);
                    connection.Close();
                    return addresId;
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                    SqlParameter nullParameter = null;
                    return nullParameter;
                }

            }
        }

        //static private async Task<SqlParameter> ImageLoad(CreateF createF)
        //{
        //    string sourceString = createF.sourceString;
        //    List<SqlParameter> sqlParameters = new List<SqlParameter>();
        //    int i = 0;
        //    foreach (string adress_part in )
        //    {
        //        SqlParameter sql = new SqlParameter("@adress_part" + i, adress_part);
        //        sqlParameters.Add(sql);
        //        i++;
        //    }

        //    string connectionString = $"Data Source={sourceString};Database=Passports;Trusted_Connection=True;";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            await connection.OpenAsync();
        //            SqlCommand command = connection.CreateCommand();
        //            command.CommandText = "Insert Into Address(Street, Plot_number, Locality, Area, Latitude,Longitude) VALUES(@adress_part0,@adress_part1,@adress_part2,@adress_part3,@Lat,@Lng);SET @id=SCOPE_IDENTITY()";
        //            foreach (SqlParameter sqlParameter in sqlParameters)
        //            {
        //                command.Parameters.Add(sqlParameter);
        //            }
        //            command.Parameters.Add(new SqlParameter("@Lat", createF.latitude));
        //            command.Parameters.Add(new SqlParameter("@Lng", createF.longitude));
        //            SqlParameter idParam = new SqlParameter
        //            {
        //                ParameterName = "@id",
        //                SqlDbType = SqlDbType.Int,
        //                Direction = ParameterDirection.Output // параметр выходной
        //            };
        //            command.Parameters.Add(idParam);
        //            await command.ExecuteNonQueryAsync();
        //            SqlParameter addresId = new SqlParameter(idParam.ParameterName, idParam.Value);
        //            connection.Close();
        //            return addresId;
        //        }
        //        catch (Exception ex)
        //        {
        //            _ = MessageBox.Show(ex.Message);
        //            SqlParameter nullParameter = null;
        //            return nullParameter;
        //        }
        //    }
        //}




    }
}
