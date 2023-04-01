
namespace lab1_prtech
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carManagement = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.truckManagement = new System.Windows.Forms.TabPage();
            this.driverChoise = new System.Windows.Forms.RadioButton();
            this.managerChoise = new System.Windows.Forms.RadioButton();
            this.desManagement.SuspendLayout();
            this.userManagment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // desManagement
            // 
            this.desManagement.Controls.Add(this.userManagment);
            this.desManagement.Controls.Add(this.carManagement);
            this.desManagement.Controls.Add(this.tabPage3);
            this.desManagement.Controls.Add(this.truckManagement);
            this.desManagement.Location = new System.Drawing.Point(25, 25);
            this.desManagement.Name = "desManagement";
            this.desManagement.SelectedIndex = 0;
            this.desManagement.Size = new System.Drawing.Size(781, 461);
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
            this.userManagment.Controls.Add(this.dataGridView1);
            this.userManagment.Location = new System.Drawing.Point(4, 25);
            this.userManagment.Name = "userManagment";
            this.userManagment.Padding = new System.Windows.Forms.Padding(3);
            this.userManagment.Size = new System.Drawing.Size(773, 432);
            this.userManagment.TabIndex = 0;
            this.userManagment.Text = "User management";
            this.userManagment.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(402, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // carManagement
            // 
            this.carManagement.Location = new System.Drawing.Point(4, 25);
            this.carManagement.Name = "carManagement";
            this.carManagement.Padding = new System.Windows.Forms.Padding(3);
            this.carManagement.Size = new System.Drawing.Size(734, 369);
            this.carManagement.TabIndex = 1;
            this.carManagement.Text = "Cargo management";
            this.carManagement.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(734, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Destination management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // truckManagement
            // 
            this.truckManagement.Location = new System.Drawing.Point(4, 25);
            this.truckManagement.Name = "truckManagement";
            this.truckManagement.Padding = new System.Windows.Forms.Padding(3);
            this.truckManagement.Size = new System.Drawing.Size(734, 369);
            this.truckManagement.TabIndex = 3;
            this.truckManagement.Text = "Truck management";
            this.truckManagement.UseVisualStyleBackColor = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 498);
            this.Controls.Add(this.desManagement);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.desManagement.ResumeLayout(false);
            this.userManagment.ResumeLayout(false);
            this.userManagment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage truckManagement;
        private System.Windows.Forms.RadioButton managerChoise;
        private System.Windows.Forms.RadioButton driverChoise;
    }
}