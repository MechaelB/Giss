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
    public partial class ViewF : Form
    {

        public double latitude;
        public double longitude;

        public ViewF()
        {
            InitializeComponent();
        }
        public ViewF(double latitude, double longitude)
        {
            InitializeComponent();
        }
    }
}
