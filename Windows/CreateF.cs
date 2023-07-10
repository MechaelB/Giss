using Giss.Functions;
using Giss.Resources;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giss
{
    public partial class CreateF : Form
    {
        public double latitude;
        public double longitude;
        public string sourceString;
        public List<string> controlsList = new List<string>();
        public List<string> imageList = new List<string>();

        public CreateF()
        {
            InitializeComponent();
        }

        public CreateF(double latitude, double longitude, string sourceString)
        {
            InitializeComponent();
            this.latitude = latitude;
            this.longitude = longitude;
            this.sourceString = sourceString;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            foreach(Control control in this.tabPage1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    this.controlsList.Add(textBox.Text);
                }
                else if(control is DateTimePicker)
                {
                    DateTimePicker datePicker = (DateTimePicker)control;
                    this.controlsList.Add(datePicker.Value.ToString());
                }
                else if(control is RichTextBox)
                {
                    RichTextBox textBox = (RichTextBox)control;
                    this.controlsList.Add(textBox.Text);
                }
            }


            _ =Connection.saveMark(this);

        }

        private void lb_aquifer_MouseHover(object sender, EventArgs e)
        {

            if (sender is Label)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(lb_aquifer,Ru.tt_aquifers);
            }
            else if (sender is TextBox)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(tb_aqiufers, Ru.tt_aquifers);
            }
        }

        private void lb_address_MouseHover(object sender, EventArgs e)
        {
            if(sender is Label)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(lb_address, Ru.tt_address);
            }
            else if (sender is TextBox)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(tb_address, Ru.tt_address);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите\nдобавить графический файл?","Внимание!",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Изображения (*.jpg; *.jpeg; *.png; *.gif), Все файлы (*.*)|*.jpg; *.jpeg; *.png; *.gif; *.*";
                openFileDialog.ShowDialog();
            }

            Button clickedButton = (Button)sender;

            if (Convert.ToInt32(clickedButton.Tag.ToString().Substring(clickedButton.Tag.ToString().Length - 1)) < 3)
            {

            }
            else
            {

            }

        }
    }
}
