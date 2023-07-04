using Giss.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace Giss
{
    public partial class AccessF : Form
    {
        public AccessF()
        {
            InitializeComponent();
        }

        private void AccessF_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string passwordDB;
            string passwordHASH;
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(txtb_password.Text));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                passwordHASH = builder.ToString();
            }

            SQLiteConnection conn = new SQLiteConnection("Data Source=users.db;Cache=Shared;Mode=ReadWriteCreate");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT Password FROM Users WHERE(Username = {txtb_login.Text} )";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                var val = reader.GetString(0);
                reader.Close();
                passwordDB = val.ToString();
                if (passwordDB == passwordHASH)
                {
                    DialogResult = DialogResult.OK;
                    MainF.access = true;
                }
                else
                {
                    MessageBox.Show("Неправильное имя пользователя\n или пароль", "Внимание!");
                    MainF.access = false;
                }
            }
            else
            {
                MessageBox.Show("Нет такого пользователя", "Внимание!");
                MainF.access = false;
            }
            conn.Close();
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            Dispose(); 
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            WindowsPrincipal currentPrincipal = new WindowsPrincipal(currentIdentity);

            if (currentPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
            {
             CheckRegPass(txtb_login.Text, txtb_password.Text);
            }
            else
            {
                MessageBox.Show("Ошибка доступа!");
            }

        }

        private void CheckRegPass( string login,string password)
        {
            string passwordHASH;
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                passwordHASH = builder.ToString();
            }

            SQLiteConnection conn = new SQLiteConnection("Data Source=users.db;Cache=Shared;Mode=ReadWriteCreate");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
            cmd.CommandText = " SELECT name FROM sqlite_master WHERE type='table' AND name='Users';";
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                cmd.CommandText = "INSERT INTO Users(Username, Password) Values(@login, @password)";
                cmd.Parameters.Add("@login", DbType.String).Value = login;
                cmd.Parameters.Add("@password", DbType.String).Value = passwordHASH;
                try 
                {
                    cmd.ExecuteNonQuery(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                reader.Close();
                cmd.CommandText = "CREATE TABLE \"Users\" (\r\n\t\"id\"\tINTEGER NOT NULL,\r\n\t\"Username\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Password\"\tTEXT NOT NULL, \r\n\tPRIMARY KEY(\"id\" AUTOINCREMENT));";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO Users(Username, Password) Values(@login, @password)";
                cmd.Parameters.Add("@login", DbType.String).Value = login;
                cmd.Parameters.Add("@password", DbType.String).Value = passwordHASH;
                cmd.ExecuteNonQuery();
            }


            conn.Close();
        }
    }
}
