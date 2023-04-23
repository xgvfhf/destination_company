using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_prtech
{
    public partial class DriverForm : Form
    {
        Driver RespDriver;
        public DriverForm()
        {
            InitializeComponent();
        }

        public DriverForm(Driver dr)
        {
            InitializeComponent();
            RespDriver = dr;
            Text = dr.Name + " " + dr.Surname + " driver";
        }

        private void SimpleDriverForm_Load(object sender, EventArgs e)
        {

        }
    }
}
