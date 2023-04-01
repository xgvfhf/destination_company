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
           
            string query = $"SELECT isAdmin FROM Stuff WHERE Login = '{textBox1.Text}' AND Password = '{textBox2.Text}' AND Status = '{statusName}'";
            Database db = new Database();          
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();                 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            
            try
            {
                DataRow row = dataTable.Rows[0];
                string selectedId = row.ItemArray[0].ToString();
                if (dataTable != null)
                {
                    switch (selectedId)
                    {
                        case "True":
                            new AdminForm().Show();
                            return;
                        case "False":
                            new SimpleManagerForm().Show();
                            return;
                        case "":
                            new SimpleDriverForm().Show();
                            return;
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("no such user! Please register");
            };

           // reader.Close();
            db.close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void DriverChoise_CheckedChanged(object sender, EventArgs e)
        {
            var snd = sender as RadioButton;
            statusName = snd.Text;
        }
    }
}
