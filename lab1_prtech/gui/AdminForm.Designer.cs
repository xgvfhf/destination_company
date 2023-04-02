
namespace lab1_prtech
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.desManagement = new System.Windows.Forms.TabControl();
            this.userManagment = new System.Windows.Forms.TabPage();
            this.managerChoise = new System.Windows.Forms.RadioButton();
            this.driverChoise = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.database = new System.Windows.Forms.DataGridView();
            this.carManagement = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.truckManagement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.desManagement.SuspendLayout();
            this.userManagment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            this.truckManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // desManagement
            // 
            this.desManagement.Controls.Add(this.userManagment);
            this.desManagement.Controls.Add(this.carManagement);
            this.desManagement.Controls.Add(this.tabPage3);
            this.desManagement.Controls.Add(this.truckManagement);
            this.desManagement.Location = new System.Drawing.Point(12, 59);
            this.desManagement.Name = "desManagement";
            this.desManagement.SelectedIndex = 0;
            this.desManagement.Size = new System.Drawing.Size(794, 427);
            this.desManagement.TabIndex = 0;
            // 
            // userManagment
            // 
            this.userManagment.Controls.Add(this.managerChoise);
            this.userManagment.Controls.Add(this.driverChoise);
            this.userManagment.Controls.Add(this.label8);
            this.userManagment.Controls.Add(this.label7);
            this.userManagment.Controls.Add(this.label6);
            this.userManagment.Controls.Add(this.label5);
            this.userManagment.Controls.Add(this.label4);
            this.userManagment.Controls.Add(this.label3);
            this.userManagment.Controls.Add(this.label2);
            this.userManagment.Controls.Add(this.label1);
            this.userManagment.Controls.Add(this.textBox8);
            this.userManagment.Controls.Add(this.textBox7);
            this.userManagment.Controls.Add(this.textBox6);
            this.userManagment.Controls.Add(this.textBox5);
            this.userManagment.Controls.Add(this.textBox4);
            this.userManagment.Controls.Add(this.textBox3);
            this.userManagment.Controls.Add(this.textBox2);
            this.userManagment.Controls.Add(this.textBox1);
            this.userManagment.Controls.Add(this.Update);
            this.userManagment.Controls.Add(this.Delete);
            this.userManagment.Controls.Add(this.Edit);
            this.userManagment.Controls.Add(this.Add);
            this.userManagment.Controls.Add(this.database);
            this.userManagment.Location = new System.Drawing.Point(4, 25);
            this.userManagment.Name = "userManagment";
            this.userManagment.Padding = new System.Windows.Forms.Padding(3);
            this.userManagment.Size = new System.Drawing.Size(786, 398);
            this.userManagment.TabIndex = 0;
            this.userManagment.Text = "User management";
            this.userManagment.UseVisualStyleBackColor = true;
            // 
            // managerChoise
            // 
            this.managerChoise.AutoSize = true;
            this.managerChoise.Location = new System.Drawing.Point(601, 17);
            this.managerChoise.Name = "managerChoise";
            this.managerChoise.Size = new System.Drawing.Size(85, 21);
            this.managerChoise.TabIndex = 22;
            this.managerChoise.TabStop = true;
            this.managerChoise.Text = "Manager";
            this.managerChoise.UseVisualStyleBackColor = true;
            this.managerChoise.CheckedChanged += new System.EventHandler(this.managerChoise_CheckedChanged);
            // 
            // driverChoise
            // 
            this.driverChoise.AutoSize = true;
            this.driverChoise.Location = new System.Drawing.Point(466, 17);
            this.driverChoise.Name = "driverChoise";
            this.driverChoise.Size = new System.Drawing.Size(67, 21);
            this.driverChoise.TabIndex = 21;
            this.driverChoise.TabStop = true;
            this.driverChoise.Text = "Driver";
            this.driverChoise.UseVisualStyleBackColor = true;
            this.driverChoise.CheckedChanged += new System.EventHandler(this.driverChoise_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "med.sert num";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "driver lic.number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "manager lic.number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "login";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(583, 253);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 22);
            this.textBox8.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(583, 225);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 22);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(583, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 22);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(583, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 22);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(583, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 22);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(583, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(583, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 5;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(540, 355);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(633, 314);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(540, 314);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(445, 314);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // database
            // 
            this.database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database.Location = new System.Drawing.Point(17, 17);
            this.database.MultiSelect = false;
            this.database.Name = "database";
            this.database.RowHeadersWidth = 51;
            this.database.RowTemplate.Height = 24;
            this.database.Size = new System.Drawing.Size(402, 386);
            this.database.TabIndex = 0;
            this.database.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_CellClick);
            // 
            // carManagement
            // 
            this.carManagement.Location = new System.Drawing.Point(4, 25);
            this.carManagement.Name = "carManagement";
            this.carManagement.Padding = new System.Windows.Forms.Padding(3);
            this.carManagement.Size = new System.Drawing.Size(773, 432);
            this.carManagement.TabIndex = 1;
            this.carManagement.Text = "Cargo management";
            this.carManagement.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(773, 432);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Destination management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // truckManagement
            // 
            this.truckManagement.Controls.Add(this.button4);
            this.truckManagement.Controls.Add(this.button3);
            this.truckManagement.Controls.Add(this.button2);
            this.truckManagement.Controls.Add(this.label13);
            this.truckManagement.Controls.Add(this.label12);
            this.truckManagement.Controls.Add(this.label11);
            this.truckManagement.Controls.Add(this.label10);
            this.truckManagement.Controls.Add(this.label9);
            this.truckManagement.Controls.Add(this.textBox13);
            this.truckManagement.Controls.Add(this.textBox12);
            this.truckManagement.Controls.Add(this.textBox11);
            this.truckManagement.Controls.Add(this.textBox10);
            this.truckManagement.Controls.Add(this.textBox9);
            this.truckManagement.Controls.Add(this.listView1);
            this.truckManagement.Location = new System.Drawing.Point(4, 25);
            this.truckManagement.Name = "truckManagement";
            this.truckManagement.Padding = new System.Windows.Forms.Padding(3);
            this.truckManagement.Size = new System.Drawing.Size(786, 398);
            this.truckManagement.TabIndex = 3;
            this.truckManagement.Text = "Truck management";
            this.truckManagement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Forum";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(441, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(441, 110);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(441, 151);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(654, 73);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(78, 22);
            this.textBox12.TabIndex = 4;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(654, 110);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(78, 22);
            this.textBox13.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(570, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(570, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "label13";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(654, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desManagement);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.desManagement.ResumeLayout(false);
            this.userManagment.ResumeLayout(false);
            this.userManagment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            this.truckManagement.ResumeLayout(false);
            this.truckManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl desManagement;
        private System.Windows.Forms.TabPage userManagment;
        private System.Windows.Forms.TabPage carManagement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView database;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage truckManagement;
        private System.Windows.Forms.RadioButton managerChoise;
        private System.Windows.Forms.RadioButton driverChoise;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}