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
        Dictionary<string,Destination> destination;
        Dictionary<string, Cargo> cargo = new Dictionary<string, Cargo>();
        Dictionary<string, Truck> truck;

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
            Cargo ct = new Cargo() {Weight = textBox14.Text , Products = textBox15.Text };
            cargo.Add(textBox13.Text,ct);
            listView2.Items.Add(textBox13.Text);
        }
    }
}
