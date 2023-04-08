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
    public partial class SimpleManagerForm : Form
    {
        Manager RespMan;
        public SimpleManagerForm(Manager man)
        {
            InitializeComponent();
            RespMan = man;
            Text = man.Name + " " + man.Surname + " manager";
        }
        public SimpleManagerForm()
        {
            InitializeComponent();
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        //TabControl
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void SimpleManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void forum_Click(object sender, EventArgs e)
        {

        }
    }
}
