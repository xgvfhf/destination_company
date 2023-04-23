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
    public partial class LogIn : Form
    {
        string statusName;
        Dictionary<string, Cargo> cargo = new Dictionary<string, Cargo>();
        Dictionary<string, Destination> destination = new Dictionary<string, Destination>();
        Dictionary<string, Truck> truck = new Dictionary<string, Truck>();
        public LogIn()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (!DriverChoise.Checked && !ManagerChoise.Checked)
            {
                MessageBox.Show("Choose profession");
            }
            else
            {
                if (DriverChoise.Checked)
                {
                    new DrivReg().Show();
                }
                else
                    new ManagerReg().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = $"SELECT * FROM Stuff WHERE Login = '{textBox1.Text}' AND Password = '{textBox2.Text}' AND Status = '{statusName}'";
            Database db = new Database();
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            try
            {
                DataRow row = dataTable.Rows[0];
                string selectedId = row.ItemArray[10].ToString();
                if (dataTable != null)
                {
                    if (selectedId.Equals(""))                   
                        new DriverForm(new Driver() { Login = row.ItemArray[1].ToString(), Password = row.ItemArray[2].ToString(), Name = row.ItemArray[4].ToString(), Surname = row.ItemArray[5].ToString(), PhoneNum = row.ItemArray[6].ToString(), DrivLicNum = row.ItemArray[8].ToString(), MedSert = row.ItemArray[7].ToString() }).Show();
                    
                    else
                        new ManagerForm(new Manager() { Login = row.ItemArray[1].ToString(), Password = row.ItemArray[2].ToString(), Name = row.ItemArray[4].ToString(), Surname = row.ItemArray[5].ToString(), PhoneNum = row.ItemArray[6].ToString(), ManLicNum = row.ItemArray[9].ToString(), isAdmin = row.ItemArray[10].ToString() }).Show();
                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("no such user! Please register");
            };

            // reader.Close();
            db.close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //FillDict("Cargo");
            //FillDict("Destenation");
            //FillDict("Truck");
        }
        
        void FillDict(string table)
        {
            string query = $"SELECT * FROM {table}";
            Database db = new Database();
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    switch (table)
                    {
                        case "Cargo":
                            cargo.Add(dataTable.Rows[i][1].ToString(), new Cargo() { CargoName = dataTable.Rows[i][1].ToString(), Weight = dataTable.Rows[i][2].ToString(), Products = dataTable.Rows[i][3].ToString() });
                            break;
                        case "Destenation":
                            destination.Add(dataTable.Rows[i][1].ToString() + "-" + dataTable.Rows[i][2].ToString(), new Destination(dataTable.Rows[i][1].ToString(), dataTable.Rows[i][2].ToString(), new Stop() { Info = dataTable.Rows[i][3].ToString() ?? "" }));
                            break;
                        case "Truck":
                            //truck.Add(dataTable.Rows[i][1].ToString(), new Truck() { Model = dataTable.Rows[i][1].ToString(), Year = dataTable.Rows[i][2].ToString(), Odometr = dataTable.Rows[i][3].ToString(),Fuel = dataTable.Rows[i][4].ToString(),Cargo = cargo[dataTable.Rows[i][5].ToString()],Destination = destination[dataTable.Rows[i][6].ToString()] });
                            break;

                    }


                }
            }
            
        }
        private void DriverChoise_CheckedChanged(object sender, EventArgs e)
        {
            var snd = sender as RadioButton;
            statusName = snd.Text;
        }
    }
}
