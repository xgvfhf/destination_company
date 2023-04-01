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
    public partial class Main : Form
    {
        private object[] data;
        public Main(object[] ob)
        {
            InitializeComponent();
            data = ob;
        }
        public Main()
        {
            InitializeComponent();
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.open();
            SqlCommand command = new SqlCommand("SELECT * FROM Stuff", db.getCon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            db.close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string query = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,MedSert,DrivLicNum)VALUES('{dr.Login}','{dr.Password}','{"Driver"}','{dr.Name}','{dr.Surname}',{dr.PhoneNum},{dr.MedSert},{dr.DrivLicNum})";
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            command.ExecuteNonQuery();
            MessageBox.Show("Страву додано!");
            db.close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void driverChoise_CheckedChanged(object sender, EventArgs e)
        {
            if (driverChoise.Checked)
            {
                label6.Visible = false;
                textBox6.Visible = false;
            }
            else 
            {
                label6.Visible = true;
                textBox6.Visible = true;
            }
            
        }

        private void managerChoise_CheckedChanged(object sender, EventArgs e)
        {
            if (managerChoise.Checked)
            {
                label7.Visible = false;
                label8.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            else
            {
                label7.Visible = true;
                label8.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
            }
        }
    }
}
