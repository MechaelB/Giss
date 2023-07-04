using Giss.Functions;
using Giss.Resources;
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
            _=Connection.saveMark(this);
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



    }
}
