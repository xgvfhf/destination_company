using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab1_prtech
{
    public partial class AddStop : Form
    {
        string RespPerson;
        Destination dest;
        public AddStop()
        {
            InitializeComponent();
        }

        

        public AddStop(Destination dest)
        {
            InitializeComponent();
          
            this.dest = dest;
        }

        private void AddStop_Load(object sender, EventArgs e)
        {

        }
        void DoAction(string query, Database db)
        {
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            command.ExecuteNonQuery();
            db.close();
        }
        private void addInfo_Click(object sender, EventArgs e)
        {
           
             string query = $"UPDATE Destenation SET Stops = '{textBox1.Text}' WHERE Track = '{dest.Track}'";
             DoAction(query,new Database());
             MessageBox.Show("Stop added!");
        }
    }
}
