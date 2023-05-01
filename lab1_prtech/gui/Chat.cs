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
    public partial class Chat : Form
    {
       
        public Chat()
        {
            InitializeComponent();
        }
        public Chat(string user)
        {
            InitializeComponent();
            Text = user;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
           // UpdateChat();
        }
        //void UpdateChat()
        //{
        //    Database db = new Database();
        //    db.open();
        //    SqlCommand command = new SqlCommand("SELECT * FROM Chat", db.getCon());
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);
        //    ChatOfWorkers.DataSource = dataTable;
        //    db.close();
        //}

        

        private void send_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TreeNode nd = new TreeNode(Text+":   " + textBox1.Text);
                treeView1.Nodes.Add(nd);
            }
            else
                MessageBox.Show("Enter message");
            




            //string query = $"INSERT INTO Chat(Sender,Message) VALUES('{Text}','{textBox1.Text}')";
            //Database db = new Database();
            //db.open();
            //SqlCommand command = new SqlCommand(query, db.getCon());
            //command.ExecuteNonQuery();
            //db.close();
            //UpdateChat();
        }

        private void answer_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null &&textBox1.Text != "")
            {
                TreeNode nd = new TreeNode(Text+":   "+textBox1.Text);
                treeView1.SelectedNode.Nodes.Add(nd);
            }
            else
                MessageBox.Show("Select message you want to reply");
        }
    }
}
