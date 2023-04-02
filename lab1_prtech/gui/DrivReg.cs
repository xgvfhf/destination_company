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
    public partial class DrivReg : Form
    {
        public DrivReg()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Driver dr = new Driver() {Login = driverLogin.Text ,Password = driverPassword.Text ,Name = driverName.Text,Surname = driverSurname.Text,PhoneNum = driverPhoneNum.Text,MedSert = driverMedNum.Text,DrivLicNum = driverLicNum.Text };
            if (dr.Login == "" || dr.Password == "" || dr.Name == "" || dr.Surname == "" || dr.PhoneNum.Equals("") || dr.MedSert.Equals("") || dr.DrivLicNum.Equals(""))
            {
                MessageBox.Show("Enter all values!");
            }
            else
            {
                Database db = new Database();
                
                string query = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,MedSert,DrivLicNum)VALUES('{dr.Login}','{dr.Password}','{"Driver"}','{dr.Name}','{dr.Surname}',{dr.PhoneNum},{dr.MedSert},{dr.DrivLicNum})";
                SqlCommand command = new SqlCommand(query, db.getCon());
                db.open();
                command.ExecuteNonQuery();               
                MessageBox.Show("Страву додано!");
                db.close();
            }
        }

        private void DrivReg_Load(object sender, EventArgs e)
        {

        }

        private void driverLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            char symb = e.KeyChar;
            if (txt.Text.Length > 7 && symb != 8)
            {
                e.Handled = true;
                MessageBox.Show("length of text can not be more then 8!");
            }
             else if ((txt.Name.Equals("DriverPhoneNum") || txt.Name.Equals("driverLicNum") || txt.Name.Equals("driverMedNum")) && !Char.IsDigit(symb) && symb != 8)
             {
                e.Handled = true;
             }
             else if ((txt.Name.Equals("driverName") || txt.Name.Equals("driverSurname"))&& Char.IsDigit(symb))
             {
                e.Handled = true;
             }
        }
    }
}
