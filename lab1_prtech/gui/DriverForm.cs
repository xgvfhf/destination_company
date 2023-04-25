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
            ReloadTripTruck();
        }

        private void choose_Click(object sender, EventArgs e)
        {
            try
            {

               
                string query2 = $"UPDATE Destenation SET RespDriver = '{RespDriver.Name + " " + RespDriver.Surname}' WHERE Track = '{tripSelection.SelectedItem.ToString()}'";               
                Database db = new Database();               
                SqlCommand command2 = new SqlCommand(query2, db.getCon());
                
                db.open();               
                command2.ExecuteNonQuery();
                db.close();
                MessageBox.Show("Trip selected!");
            }
            catch (Exception)
            {

                MessageBox.Show("Already in table!");
            }
        }

        void ReloadTripTruck()
        {
            Database db = new Database();
            db.open();
            SqlCommand command1 = new SqlCommand($"SELECT Track FROM Destenation WHERE RespDriver IS NULL ", db.getCon());
            SqlCommand command2 = new SqlCommand($"SELECT Model FROM Truck", db.getCon());
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(command1);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(command2);
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter1.Fill(dataTable1);
            sqlDataAdapter2.Fill(dataTable2);
            db.close();
            if (dataTable1 != null && dataTable2 != null)
            {
                for (int i = 0; i < dataTable1.Rows.Count; i++)
                {
                    tripSelection.Items.Add(dataTable1.Rows[i][0].ToString());
                }
                for (int i = 0; i < dataTable2.Rows.Count; i++)
                {
                    truckSelection.Items.Add(dataTable2.Rows[i][0].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string query2 = $"UPDATE Truck SET RespDriv = '{RespDriver.Name + " " + RespDriver.Surname}' WHERE Model = '{truckSelection.SelectedItem.ToString()}'";
                Database db = new Database();
                SqlCommand command2 = new SqlCommand(query2, db.getCon());

                db.open();
                command2.ExecuteNonQuery();
                db.close();
                MessageBox.Show("Truck selected!");
            }
            catch (Exception)
            {

                MessageBox.Show("Already in table!");
            }
        }

        private void forum_Click(object sender, EventArgs e)
        {
            new Chat(Text).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                new AddStop(new Destination() { Track = tripSelection.SelectedItem.ToString() }).Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Enter trip!");
            }
            
        }
    }
}
