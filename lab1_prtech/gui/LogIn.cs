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
           
            string query = $"SELECT isAdmin FROM Stuff WHERE Login = '{textBox1.Text}' AND Password = '{textBox2.Text}'";
            Database db = new Database();
            
            
            SqlCommand command = new SqlCommand(query, db.getCon());
            db.open();
         
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            // dataTable.Rows[0].ItemArray;
            
            try
            {
                DataRow row = dataTable.Rows[0];
                if (dataTable != null)
                {
                    Main m = new Main();             
                    m.Show();
                    
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
    }
}
