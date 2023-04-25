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
    public partial class AddDriver : Form
    {
        Driver RespDriver;
        Truck selectedTruck;
        public AddDriver()
        {
            InitializeComponent();
        }
        public AddDriver(Truck tr)
        {
            InitializeComponent();
            selectedTruck = tr;
        }
        private void AddDriver_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Stuff WHERE Status = 'Driver'";
            Database db = new Database();
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            Drivers.DataSource = dataTable;
            db.close();
        }

        private void Drivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            RespDriver = new Driver() { Name = Drivers.CurrentRow.Cells[4].Value.ToString(), Surname = Drivers.CurrentRow.Cells[5].Value.ToString() };
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query1 = $"INSERT INTO Truck(Model,Year,Odometr,Fuel,Destenation,Cargo,RespMan,RespDriv)VALUES('{selectedTruck.Model}','{selectedTruck.Year}','{selectedTruck.Odometr}','{selectedTruck.Fuel}','{selectedTruck.Destination.Track}','{selectedTruck.Cargo.CargoName}','{selectedTruck.RespManager.Name + " " + selectedTruck.RespManager.Surname}','{RespDriver.Name+" "+RespDriver.Surname}')";
                string query2 = $"UPDATE Destenation SET RespDriver = '{RespDriver.Name + " " + RespDriver.Surname}' WHERE Track = '{selectedTruck.Destination.Track}'";
                string query3 = $"UPDATE Cargo SET RespDriver = '{RespDriver.Name + " " + RespDriver.Surname}' WHERE Track = '{selectedTruck.Destination.Track}'";
                Database db = new Database();
                SqlCommand command1 = new SqlCommand(query1, db.getCon());
                SqlCommand command2 = new SqlCommand(query2, db.getCon());
                SqlCommand command3 = new SqlCommand(query3, db.getCon());
                db.open();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                db.close();
            }
            catch (Exception)
            {

                MessageBox.Show("Already in table!");
            }
        }
    }
}
