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
    public partial class ManagerReg : Form
    {
        public ManagerReg()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Manager mn = new Manager() { Login = managerLogin.Text, Password = managerPassword.Text, Name = managerName.Text, Surname = managerSurname.Text, PhoneNum = managerPhoneNum.Text, ManLicNum = managerLicNum.Text, isAdmin = isAdmin.Checked.ToString() };
            if (mn.Login == "" || mn.Password == "" || mn.Name == "" || mn.Surname == "" || mn.PhoneNum.Equals("") || mn.ManLicNum.Equals(""))
            {
                MessageBox.Show("Enter all values!");
            }
            else
            {
                Database db = new Database();

                string query = $"INSERT INTO Stuff(Login,Password,Status,FirstName,LastName,PhoneNum,ManLicNum,isAdmin)VALUES('{mn.Login}','{mn.Password}','{"Manager"}','{mn.Name}','{mn.Surname}','{mn.PhoneNum}','{mn.ManLicNum}','{mn.isAdmin}')";
                SqlCommand command = new SqlCommand(query, db.getCon());
                db.open();
                command.ExecuteNonQuery();
                MessageBox.Show("додано!");
                db.close();
            }
        }

        private void ManagerReg_Load(object sender, EventArgs e)
        {

        }

        private void managerLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txt = sender as TextBox;
            char symb = e.KeyChar;
            if (txt.Text.Length > 7 && symb != 8)
            {
                e.Handled = true;
                MessageBox.Show("length of text can not be more then 8!");
            }
            else if ((txt.Name.Equals("managerPhoneNum") || txt.Name.Equals("managerLicNum")) && !Char.IsDigit(symb) && symb != 8)
            {
                e.Handled = true;
            }
            else if ((txt.Name.Equals("managerName") || txt.Name.Equals("managerSurname")) && Char.IsDigit(symb))
            {
                e.Handled = true;
            }
        }
    }
}
