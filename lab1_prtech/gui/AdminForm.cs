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
    public partial class AdminForm : Form
    {
        string id;
        Manager RespMan;
        Dictionary<string,Destination> destination = new Dictionary<string, Destination>();
        Dictionary<string, Cargo> cargo = new Dictionary<string, Cargo>();
        Dictionary<string, Truck> truck = new Dictionary<string, Truck>();

        public AdminForm(Manager man)
        {
            InitializeComponent();
            RespMan = man;
            Text = man.Name + " " + man.Surname + " administrator";
        }
        public AdminForm()
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
            database.DataSource = dataTable;
            db.close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();

                string query1 = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,MedSert,DrivLicNum)VALUES('{textBox1.Text}','{textBox2.Text}','{"Driver"}','{textBox3.Text}','{textBox4.Text}',{textBox5.Text},{textBox7.Text},{textBox8.Text})";
                string query2 = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,ManLicNum)VALUES('{textBox1.Text}','{textBox2.Text}','{"Manager"}','{textBox3.Text}','{textBox4.Text}',{textBox5.Text},{textBox6.Text})";
                if (driverChoise.Checked)
                {
                    DoAction(query1, db);
                    MessageBox.Show("Added");
                }
                else
                {
                    DoAction(query2, db);
                    MessageBox.Show("Added");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("enter all values!");
            }
            
        }
        
        private void Edit_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                Database db = new Database();

                string query1 = $"UPDATE Stuff SET Login = '{textBox1.Text}',Password = '{textBox2.Text}',FirstName = '{textBox3.Text}',LastName='{textBox4.Text}',PhoneNum='{textBox5.Text}',MedSert='{textBox7.Text}',DrivLicNum='{textBox8.Text}' WHERE Id = '{id}'";
                string query2 = $"UPDATE Stuff SET Login = '{textBox1.Text}',Password = '{textBox2.Text}',FirstName = '{textBox3.Text}',LastName='{textBox4.Text}',PhoneNum='{textBox5.Text}',ManLicNum='{textBox6.Text}' WHERE Id = '{id}'";
                if (driverChoise.Checked)
                {
                    DoAction(query1, db);
                    MessageBox.Show("Edited!");
                    
                }
                else
                {
                    DoAction(query2, db);
                    MessageBox.Show("Edited!");
                    
                }
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                Database db = new Database();
                string query = $"DELETE FROM Stuff WHERE Id = '{id}'";
                DoAction(query, db);
                MessageBox.Show("deleted!");
            }
            else
            {
                MessageBox.Show("Choose row!");
            }
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

        private void database_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = database.CurrentRow.Cells[0].Value.ToString(); 
            Text = id;
            textBox1.Text = database.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = database.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = database.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = database.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = database.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = database.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = database.CurrentRow.Cells[8].Value.ToString();
            textBox8.Text = database.CurrentRow.Cells[9].Value.ToString();
        }

        void DoAction(string query, Database db)
        {
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
            command.ExecuteNonQuery();          
            db.close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Cargo ct = new Cargo() { Weight = textBox14.Text, Products = textBox15.Text };
                cargo.Add(textBox13.Text, ct);
                listBox1.Items.Add(textBox13.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Already added!");
            }           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cargo[textBox13.Text] = new Cargo() {Weight = textBox14.Text,Products = textBox15.Text };
            MessageBox.Show("Updated!");
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox13.Text = listBox1.SelectedItem.ToString();
                textBox14.Text = cargo[textBox13.Text].Weight;
                textBox15.Text = cargo[textBox13.Text].Products;
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    cargo.Remove(listBox1.SelectedItem.ToString());
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    MessageBox.Show("Deleted!");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Select item you want to delete!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Destination ds = new Destination() { PointA = textBox16.Text, PointB = textBox17.Text };
                destination.Add(textBox18.Text, ds);
                listBox2.Items.Add(textBox18.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Already added!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            destination[textBox18.Text] = new Destination() { PointA = textBox16.Text, PointB = textBox17.Text };
            MessageBox.Show("Updated!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                destination.Remove(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove(listBox2.SelectedItem);
                MessageBox.Show("Deleted!");
            }
            catch (Exception)
            {
                MessageBox.Show("Select item you want to delete!");
            }
        }

        private void listBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                textBox18.Text = listBox2.SelectedItem.ToString();
                textBox16.Text = destination[textBox18.Text].PointA;
                textBox17.Text = destination[textBox18.Text].PointB;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Truck tr = new Truck() { Year = textBox2.Text, Model = textBox10.Text,Fuel = textBox12.Text ,Odometr = textBox11.Text };
                truck.Add(textBox10.Text, tr);
                listBox3.Items.Add(textBox10.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Already added!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            truck[textBox18.Text] = new Truck() { Year = textBox2.Text, Model = textBox10.Text, Fuel = textBox12.Text, Odometr = textBox11.Text };
            MessageBox.Show("Updated!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                truck.Remove(listBox3.SelectedItem.ToString());
                listBox3.Items.Remove(listBox3.SelectedItem);
                MessageBox.Show("Deleted!");
            }
            catch (Exception)
            {
                MessageBox.Show("Select item you want to delete!");
            }
        }

        private void listBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                textBox10.Text = listBox3.SelectedItem.ToString();
                textBox2.Text = truck[textBox10.Text].Year;
                textBox12.Text = truck[textBox10.Text].Fuel;
                textBox11.Text = truck[textBox10.Text].Odometr;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count == destination.Keys.Count && comboBox2.Items.Count == cargo.Keys.Count)
            {
                MessageBox.Show("Already updated!");
            }
            else
            {
                comboBox1.Items.AddRange(destination.Keys.ToArray());
                comboBox2.Items.AddRange(cargo.Keys.ToArray());
            }
            
        }
    }
}
