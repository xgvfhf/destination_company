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
    public partial class ManagerForm : Form
    {
        string userId;
        string cargoId;
        string destId;
        string truckId;
        string cargoDictionaryKey;
        string truckDictionaryKey;
        string destDictionaryKey;
        Manager RespMan;
        Dictionary<string,Destination> destination = new Dictionary<string, Destination>();
        Dictionary<string, Cargo> cargo = new Dictionary<string, Cargo>();
        Dictionary<string, Truck> truck = new Dictionary<string, Truck>();

        public ManagerForm(Manager man)
        {
            InitializeComponent();
            RespMan = man;
            
            if (man.isAdmin.Equals("False"))
            {
                driverChoise.Visible = false;
                managerChoise.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                loginLine.Visible = false;
                passwordLine.Visible = false;
                nameLine.Visible = false;
                surnameLine.Visible = false;
                phoneNumLine.Visible = false;
                managerLicNumLine.Visible = false;
                driverLicNumLine.Visible = false;
                driverMedSertNumLine.Visible = false;
                allStuffDatabase.Width = 700;
                Add.Visible = false;
                Edit.Visible = false;
                Delete.Visible = false;
                Text = man.Name + " " + man.Surname + " manager";
            }
            else
                Text = man.Name + " " + man.Surname + " administrator";
            //destination = dest;
            //cargo = crg;
            //truck = trck;
        }
        public ManagerForm()
        {
            InitializeComponent();
           
        }


        private void Main_Load(object sender, EventArgs e)
        {
            
            Update("Stuff", allStuffDatabase);
            Update("Cargo", cargoDatabase);
            Update("Destenation", destinationDatabase);
            Update("Truck", truckDatabase);
            ReloadTripCargo();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.open();
            SqlCommand command = new SqlCommand("SELECT * FROM Stuff", db.getCon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            allStuffDatabase.DataSource = dataTable;
            db.close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();

                string query1 = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,MedSert,DrivLicNum) VALUES('{loginLine.Text}','{passwordLine.Text}','{"Driver"}','{nameLine.Text}','{surnameLine.Text}','{phoneNumLine.Text}','{driverLicNumLine.Text}','{driverMedSertNumLine.Text}')";
                string query2 = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,ManLicNum) VALUES('{loginLine.Text}','{passwordLine.Text}','{"Manager"}','{nameLine.Text}','{surnameLine.Text}','{phoneNumLine.Text}','{managerLicNumLine.Text}')";
                if (driverChoise.Checked)
                {
                    DoAction(query1, db);
                    MessageBox.Show("Added");
                    Update("Stuff", allStuffDatabase);
                }
                else if (managerChoise.Checked)
                {
                    DoAction(query2, db);
                    MessageBox.Show("Added");
                    Update("Stuff", allStuffDatabase);
                }
                else
                    MessageBox.Show("Enter all values!");
        }
            catch (Exception)
            {
                MessageBox.Show("You must enter all values and your login must be unique!");
            }

}
        
        private void Edit_Click(object sender, EventArgs e)
        {
            if (userId != null)
            {
                Database db = new Database();

                string query1 = $"UPDATE Stuff SET Login = '{loginLine.Text}',Password = '{passwordLine.Text}',FirstName = '{nameLine.Text}',LastName='{surnameLine.Text}',PhoneNum='{phoneNumLine.Text}',MedSert='{driverLicNumLine.Text}',DrivLicNum='{driverMedSertNumLine.Text}' WHERE Id = '{userId}'";
                string query2 = $"UPDATE Stuff SET Login = '{loginLine.Text}',Password = '{passwordLine.Text}',FirstName = '{nameLine.Text}',LastName='{surnameLine.Text}',PhoneNum='{phoneNumLine.Text}',ManLicNum='{managerLicNumLine.Text}' WHERE Id = '{userId}'";
                if (driverChoise.Checked)
                {
                    DoAction(query1, db);
                    MessageBox.Show("Edited!");
                    Update("Stuff",allStuffDatabase);
                    
                }
                else
                {
                    DoAction(query2, db);
                    MessageBox.Show("Edited!");
                    Update("Stuff", allStuffDatabase);

                }
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteRow("Stuff",userId, allStuffDatabase);
        }

        private void driverChoise_CheckedChanged(object sender, EventArgs e)
        {
            if (driverChoise.Checked)
            {
                label6.Visible = false;
                managerLicNumLine.Visible = false;
            }
            else 
            {
                label6.Visible = true;
                managerLicNumLine.Visible = true;
            }
            
        }

        private void managerChoise_CheckedChanged(object sender, EventArgs e)
        {
            if (managerChoise.Checked)
            {
                label7.Visible = false;
                label8.Visible = false;
                driverLicNumLine.Visible = false;
                driverMedSertNumLine.Visible = false;
            }
            else
            {
                label7.Visible = true;
                label8.Visible = true;
                driverLicNumLine.Visible = true;
                driverMedSertNumLine.Visible = true;
            }
        }

        void DoAction(string query, Database db)
        {
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            command.ExecuteNonQuery();          
            db.close();
        }
        void Update(string table,DataGridView datagrid)
        {
            Database db = new Database();
            db.open();
            SqlCommand command = new SqlCommand($"SELECT * FROM {table} ", db.getCon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            datagrid.DataSource = dataTable;
            db.close();

        }

        void DeleteRow(string table, string id, DataGridView datagrid)
        {
            if (id != null)
            {
                Database db = new Database();
                string query = $"DELETE FROM {table} WHERE Id = '{id}'";
                DoAction(query, db);
                MessageBox.Show("deleted!");
                Update(table, datagrid);
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
        }

       

        

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void addCargo_Click(object sender, EventArgs e)
        {
            if (cargoNameLine.Text != "" && cargoWeightLine.Text != "" && cargoProductLine.Text != "")
            {
                Database db = new Database();
                string query1 = $"INSERT INTO Cargo(CargoName,Weight,Products)VALUES('{cargoNameLine.Text}','{cargoWeightLine.Text}','{cargoProductLine.Text}')";
                DoAction(query1, db);
                //cargo.Add(cargoNameLine.Text,new Cargo() {CargoName = cargoNameLine.Text,Weight = cargoWeightLine.Text,Products = cargoProductLine.Text });
;               MessageBox.Show("Added");
                Update("Cargo", cargoDatabase);

            }
            else
            {
                MessageBox.Show("enter all values!");
            }
        }

        

        private void allStuffDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = allStuffDatabase.CurrentRow.Cells[0].Value.ToString();
            loginLine.Text = allStuffDatabase.CurrentRow.Cells[1].Value.ToString();
            passwordLine.Text = allStuffDatabase.CurrentRow.Cells[2].Value.ToString();
            nameLine.Text = allStuffDatabase.CurrentRow.Cells[4].Value.ToString();
            surnameLine.Text = allStuffDatabase.CurrentRow.Cells[5].Value.ToString();
            phoneNumLine.Text = allStuffDatabase.CurrentRow.Cells[6].Value.ToString();
            managerLicNumLine.Text = allStuffDatabase.CurrentRow.Cells[7].Value.ToString();
            driverLicNumLine.Text = allStuffDatabase.CurrentRow.Cells[8].Value.ToString();
            driverMedSertNumLine.Text = allStuffDatabase.CurrentRow.Cells[9].Value.ToString();
        }

        private void cargoDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargoId = cargoDatabase.CurrentRow.Cells[0].Value.ToString();            
            cargoNameLine.Text = cargoDatabase.CurrentRow.Cells[1].Value.ToString();
            cargoWeightLine.Text = cargoDatabase.CurrentRow.Cells[2].Value.ToString();
            cargoProductLine.Text = cargoDatabase.CurrentRow.Cells[3].Value.ToString();
            cargoDictionaryKey = cargoNameLine.Text;
        }

        private void EditCargo_Click(object sender, EventArgs e)
        {
            if (cargoId != null)
            {
                Database db = new Database();
                string query1 = $"UPDATE Cargo SET Weight = '{cargoWeightLine.Text}',Products = '{cargoProductLine.Text}' WHERE Id = '{cargoId}'";               
                DoAction(query1, db);
               // cargo[cargoDictionaryKey] = new Cargo() { CargoName = cargoNameLine.Text, Weight = cargoWeightLine.Text, Products = cargoProductLine.Text };

                MessageBox.Show("Edited!");
                Update("Cargo", cargoDatabase);                
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
        }

        private void loginLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            char symb = e.KeyChar;
            if (txt.Text.Length > 7 && symb != 8)
            {
                e.Handled = true;
                MessageBox.Show("length of text can not be more then 8!");
            }
            else if ((txt.Name.Equals("phoneNumLine") || txt.Name.Equals("managerLicNumLine") || txt.Name.Equals("driverLicNumLine") || txt.Name.Equals("driverMedSertNumLine")) && !Char.IsDigit(symb) && symb != 8)
            {
                e.Handled = true;
            }
            else if ((txt.Name.Equals("nameLine") || txt.Name.Equals("surnameLine")) && Char.IsDigit(symb))
            {
                e.Handled = true;
            }

        }

        private void DeleteCargo_Click(object sender, EventArgs e)
        {
            DeleteRow("Cargo", cargoId, cargoDatabase);
        }

        private void AddDestenation_Click(object sender, EventArgs e)
        {
            if (startPointLine.Text != "" && finishPointLine.Text != "" && departureDate != null && arrivalDate != null)
            {
                Database db = new Database();
                string query1 = $"INSERT INTO Destenation(Track,RespMan,Departure,Arrival)VALUES('{startPointLine.Text+"-"+finishPointLine.Text}','{RespMan.Name+" "+RespMan.Surname}','{departureDate.Value}','{arrivalDate.Value}')";
                DoAction(query1, db);
                
                MessageBox.Show("Added");
                Update("Destenation", destinationDatabase);

            }
            else
            {
                MessageBox.Show("enter all values!");
            }
        }

        private void EditDestenation_Click(object sender, EventArgs e)
        {
            if (destId != null)
            {
                Database db = new Database();
                string query1 = $"UPDATE Destenation SET Track = '{startPointLine.Text + "-" + finishPointLine.Text}',Departure='{departureDate.Value}',Arrival='{arrivalDate.Value}' WHERE Id = '{destId}'";
                DoAction(query1, db);
                
                MessageBox.Show("Edited!");
                Update("Destenation", destinationDatabase);
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
        }

        private void destinationDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            destId = destinationDatabase.CurrentRow.Cells[0].Value.ToString();
            var arr = destinationDatabase.CurrentRow.Cells[1].Value.ToString().Split('-');
            startPointLine.Text = arr[0];
            finishPointLine.Text = arr[1];
            departureDate.Value = DateTime.Parse(destinationDatabase.CurrentRow.Cells[5].Value.ToString());
            arrivalDate.Value = DateTime.Parse(destinationDatabase.CurrentRow.Cells[6].Value.ToString());
        }

        private void DeleteDestenation_Click(object sender, EventArgs e)
        {
            if (destinationDatabase.CurrentRow.Cells[5].Value.ToString() == null && RespMan.isAdmin.Equals("False"))
            {
                DeleteRow("Destenation", destId, destinationDatabase);
            }
            else if (RespMan.isAdmin.Equals("True"))
            {
                DeleteRow("Destenation", destId, destinationDatabase);
            }
            else
                MessageBox.Show("This order's already in progress!");

            
            
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            ReloadTripCargo();
        }

        private void AddTruck_Click(object sender, EventArgs e)
        {                
            try
            {
                Database db = new Database();
                string query1 = $"INSERT INTO Truck(Model,Year,Odometr,Fuel,RespMan)VALUES('{modelLine.Text}','{yearLine.Text}','{odometrLine.Text}','{fuelLine.Text}','{RespMan.Name + " " + RespMan.Surname}')";
                string query2 = $"INSERT INTO Truck(Model,Year,Odometr,Fuel,Destenation,Cargo,RespMan)VALUES('{modelLine.Text}','{yearLine.Text}','{odometrLine.Text}','{fuelLine.Text}','{tripSelection.SelectedItem}','{cargoSelection.SelectedItem}','{RespMan.Name + " " + RespMan.Surname}')";
                if (tripSelection.SelectedItem != null && cargoSelection.SelectedItem != null && modelLine.Text != "" && yearLine.Text != "" && fuelLine.Text != "" && odometrLine.Text != "")
                {
                    DoAction(query2, db);
                    MessageBox.Show("Added");
                    Update("Truck", truckDatabase);
                }
                else if (modelLine.Text != "" && yearLine.Text != "" && fuelLine.Text != "" && odometrLine.Text != "")
                {
                    DoAction(query1, db);
                    MessageBox.Show("Added");
                    Update("Truck", truckDatabase);
                }
                else
                    MessageBox.Show("Enter all values!");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter all values!");
            }
            

        }

        private void truckDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            truckId = truckDatabase.CurrentRow.Cells[0].Value.ToString();
            modelLine.Text = truckDatabase.CurrentRow.Cells[1].Value.ToString();
            yearLine.Text = truckDatabase.CurrentRow.Cells[2].Value.ToString();
            odometrLine.Text = truckDatabase.CurrentRow.Cells[3].Value.ToString();
            fuelLine.Text = truckDatabase.CurrentRow.Cells[4].Value.ToString();
            //tripSelection.SelectedItem = truckDatabase.CurrentRow.Cells[5].Value;
           // cargoSelection.SelectedItem = truckDatabase.CurrentRow.Cells[6].Value;
            cargoDictionaryKey = truckDatabase.Text;
        }
        void ReloadTripCargo()
        {
            tripSelection.Items.Clear();
            cargoSelection.Items.Clear();
            Database db = new Database();
            db.open();
            SqlCommand command1 = new SqlCommand($"SELECT Track FROM Destenation WHERE RespDriver IS NULL ", db.getCon());
            SqlCommand command2 = new SqlCommand($"SELECT CargoName FROM Cargo  ", db.getCon());
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
                    cargoSelection.Items.Add(dataTable2.Rows[i][0].ToString());
                }
                MessageBox.Show("Comboboxes updated!");
            }
            
        }
        private void EditTruck_Click(object sender, EventArgs e)
        {
            if (truckId != null)
            {
                Database db = new Database();
                string query1 = $"UPDATE Truck SET Model = '{modelLine.Text}',Year= '{yearLine.Text}',Odometr = '{odometrLine.Text}',Fuel='{fuelLine.Text}' WHERE Id = '{truckId}'";
                DoAction(query1, db);

                MessageBox.Show("Edited!");
                Update("Truck", truckDatabase);
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
        }

        private void DeleteTruck_Click(object sender, EventArgs e)
        {
            if (truckDatabase.CurrentRow.Cells[8].Value.ToString() == null && RespMan.isAdmin.Equals("False"))
            {
                DeleteRow("Truck", truckId, truckDatabase);
            }
            else if (RespMan.isAdmin.Equals("True"))
            {
                DeleteRow("Truck", truckId, truckDatabase);
            }
            else
                MessageBox.Show("This order's already in progress!");
            
        }

        private void cargoWeightLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtbox = sender as TextBox;
            char symb = e.KeyChar;
            if (symb != 8 && !Char.IsDigit(symb))
            {
                e.Handled = true;
            }
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            try
            {
                if (tripSelection.SelectedItem != null && cargoSelection.SelectedItem != null && modelLine.Text != "" && yearLine.Text != "" && fuelLine.Text != "" && odometrLine.Text != "")
                {
                    new AddDriver(new Truck() { Year = yearLine.Text, Model = modelLine.Text, Odometr = odometrLine.Text, Fuel = fuelLine.Text, Destination = new Destination() { Track = tripSelection.SelectedItem.ToString() }, Cargo = new Cargo() { CargoName = cargoSelection.SelectedItem.ToString() }, RespManager = RespMan }).Show();
                }
                else
                    MessageBox.Show("Enter all values!");
            }
            catch (Exception)
            {

                MessageBox.Show("Enter all values!");
            }
        }
        void ShowData(DataGridView data,string query)
        {
            Database db = new Database();
            db.open();
            SqlCommand command = new SqlCommand(query, db.getCon());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            data.DataSource = dataTable;
            db.close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Chat(Text).Show();
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            if (filterCondition.SelectedItem != null)
            {
                if (filterCondition.SelectedItem.ToString().Equals("departure date"))
                {
                    string query = $"SELECT * FROM Destenation WHERE Departure LIKE '{filter.Text + "%"}'";
                    ShowData(destinationDatabase, query);
                }
                else if (filterCondition.SelectedItem.ToString().Equals("arrival date"))
                {
                    string query = $"SELECT * FROM Destenation WHERE Arrival LIKE '{filter.Text + "%"}'";
                    ShowData(destinationDatabase, query);
                }
                else if (filterCondition.SelectedItem.ToString().Equals("carrier"))
                {
                    string query = $"SELECT * FROM Destenation WHERE RespDriver LIKE '{filter.Text + "%"}'";
                    ShowData(destinationDatabase, query);
                }
                else
                    MessageBox.Show("Wrong value!");

            }
            else
                MessageBox.Show("Choose filter condition!");
        }
    }
}
