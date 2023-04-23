
namespace lab1_prtech
{
    partial class ManagerForm
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
            this.driverMedSertNumLine = new System.Windows.Forms.TextBox();
            this.driverLicNumLine = new System.Windows.Forms.TextBox();
            this.managerLicNumLine = new System.Windows.Forms.TextBox();
            this.phoneNumLine = new System.Windows.Forms.TextBox();
            this.surnameLine = new System.Windows.Forms.TextBox();
            this.nameLine = new System.Windows.Forms.TextBox();
            this.passwordLine = new System.Windows.Forms.TextBox();
            this.loginLine = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.allStuffDatabase = new System.Windows.Forms.DataGridView();
            this.carManagement = new System.Windows.Forms.TabPage();
            this.cargoNameLine = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cargoDatabase = new System.Windows.Forms.DataGridView();
            this.DeleteCargo = new System.Windows.Forms.Button();
            this.EditCargo = new System.Windows.Forms.Button();
            this.addCargo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cargoProductLine = new System.Windows.Forms.TextBox();
            this.cargoWeightLine = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.destinationDatabase = new System.Windows.Forms.DataGridView();
            this.DeleteDestenation = new System.Windows.Forms.Button();
            this.EditDestenation = new System.Windows.Forms.Button();
            this.AddDestenation = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.finishPointLine = new System.Windows.Forms.TextBox();
            this.startPointLine = new System.Windows.Forms.TextBox();
            this.truckManagement = new System.Windows.Forms.TabPage();
            this.Reload = new System.Windows.Forms.Button();
            this.truckDatabase = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cargoSelection = new System.Windows.Forms.ComboBox();
            this.tripSelection = new System.Windows.Forms.ComboBox();
            this.DeleteTruck = new System.Windows.Forms.Button();
            this.EditTruck = new System.Windows.Forms.Button();
            this.AddTruck = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fuelLine = new System.Windows.Forms.TextBox();
            this.odometrLine = new System.Windows.Forms.TextBox();
            this.modelLine = new System.Windows.Forms.TextBox();
            this.yearLine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addDriver = new System.Windows.Forms.Button();
            this.desManagement.SuspendLayout();
            this.userManagment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allStuffDatabase)).BeginInit();
            this.carManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoDatabase)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabase)).BeginInit();
            this.truckManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckDatabase)).BeginInit();
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
            this.desManagement.Size = new System.Drawing.Size(797, 445);
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
            this.userManagment.Controls.Add(this.driverMedSertNumLine);
            this.userManagment.Controls.Add(this.driverLicNumLine);
            this.userManagment.Controls.Add(this.managerLicNumLine);
            this.userManagment.Controls.Add(this.phoneNumLine);
            this.userManagment.Controls.Add(this.surnameLine);
            this.userManagment.Controls.Add(this.nameLine);
            this.userManagment.Controls.Add(this.passwordLine);
            this.userManagment.Controls.Add(this.loginLine);
            this.userManagment.Controls.Add(this.Delete);
            this.userManagment.Controls.Add(this.Edit);
            this.userManagment.Controls.Add(this.Add);
            this.userManagment.Controls.Add(this.allStuffDatabase);
            this.userManagment.Location = new System.Drawing.Point(4, 25);
            this.userManagment.Name = "userManagment";
            this.userManagment.Padding = new System.Windows.Forms.Padding(3);
            this.userManagment.Size = new System.Drawing.Size(789, 416);
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
            // driverMedSertNumLine
            // 
            this.driverMedSertNumLine.Location = new System.Drawing.Point(583, 253);
            this.driverMedSertNumLine.Name = "driverMedSertNumLine";
            this.driverMedSertNumLine.Size = new System.Drawing.Size(125, 22);
            this.driverMedSertNumLine.TabIndex = 12;
            this.driverMedSertNumLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // driverLicNumLine
            // 
            this.driverLicNumLine.Location = new System.Drawing.Point(583, 225);
            this.driverLicNumLine.Name = "driverLicNumLine";
            this.driverLicNumLine.Size = new System.Drawing.Size(125, 22);
            this.driverLicNumLine.TabIndex = 11;
            this.driverLicNumLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // managerLicNumLine
            // 
            this.managerLicNumLine.Location = new System.Drawing.Point(583, 197);
            this.managerLicNumLine.Name = "managerLicNumLine";
            this.managerLicNumLine.Size = new System.Drawing.Size(125, 22);
            this.managerLicNumLine.TabIndex = 10;
            this.managerLicNumLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // phoneNumLine
            // 
            this.phoneNumLine.Location = new System.Drawing.Point(583, 169);
            this.phoneNumLine.Name = "phoneNumLine";
            this.phoneNumLine.Size = new System.Drawing.Size(125, 22);
            this.phoneNumLine.TabIndex = 9;
            this.phoneNumLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // surnameLine
            // 
            this.surnameLine.Location = new System.Drawing.Point(583, 141);
            this.surnameLine.Name = "surnameLine";
            this.surnameLine.Size = new System.Drawing.Size(125, 22);
            this.surnameLine.TabIndex = 8;
            this.surnameLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // nameLine
            // 
            this.nameLine.Location = new System.Drawing.Point(583, 113);
            this.nameLine.Name = "nameLine";
            this.nameLine.Size = new System.Drawing.Size(125, 22);
            this.nameLine.TabIndex = 7;
            this.nameLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // passwordLine
            // 
            this.passwordLine.Location = new System.Drawing.Point(583, 85);
            this.passwordLine.Name = "passwordLine";
            this.passwordLine.Size = new System.Drawing.Size(125, 22);
            this.passwordLine.TabIndex = 6;
            this.passwordLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
            // 
            // loginLine
            // 
            this.loginLine.Location = new System.Drawing.Point(583, 57);
            this.loginLine.Name = "loginLine";
            this.loginLine.Size = new System.Drawing.Size(125, 22);
            this.loginLine.TabIndex = 5;
            this.loginLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginLine_KeyPress);
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
            // allStuffDatabase
            // 
            this.allStuffDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allStuffDatabase.Location = new System.Drawing.Point(17, 17);
            this.allStuffDatabase.MultiSelect = false;
            this.allStuffDatabase.Name = "allStuffDatabase";
            this.allStuffDatabase.RowHeadersWidth = 51;
            this.allStuffDatabase.RowTemplate.Height = 24;
            this.allStuffDatabase.Size = new System.Drawing.Size(402, 386);
            this.allStuffDatabase.TabIndex = 0;
            this.allStuffDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allStuffDatabase_CellClick);
            // 
            // carManagement
            // 
            this.carManagement.Controls.Add(this.cargoNameLine);
            this.carManagement.Controls.Add(this.label13);
            this.carManagement.Controls.Add(this.cargoDatabase);
            this.carManagement.Controls.Add(this.DeleteCargo);
            this.carManagement.Controls.Add(this.EditCargo);
            this.carManagement.Controls.Add(this.addCargo);
            this.carManagement.Controls.Add(this.label15);
            this.carManagement.Controls.Add(this.label14);
            this.carManagement.Controls.Add(this.cargoProductLine);
            this.carManagement.Controls.Add(this.cargoWeightLine);
            this.carManagement.Location = new System.Drawing.Point(4, 25);
            this.carManagement.Name = "carManagement";
            this.carManagement.Padding = new System.Windows.Forms.Padding(3);
            this.carManagement.Size = new System.Drawing.Size(789, 416);
            this.carManagement.TabIndex = 1;
            this.carManagement.Text = "Cargo management";
            this.carManagement.UseVisualStyleBackColor = true;
            // 
            // cargoNameLine
            // 
            this.cargoNameLine.Location = new System.Drawing.Point(521, 53);
            this.cargoNameLine.Name = "cargoNameLine";
            this.cargoNameLine.Size = new System.Drawing.Size(234, 22);
            this.cargoNameLine.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Cargo name:";
            // 
            // cargoDatabase
            // 
            this.cargoDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cargoDatabase.Location = new System.Drawing.Point(17, 12);
            this.cargoDatabase.MultiSelect = false;
            this.cargoDatabase.Name = "cargoDatabase";
            this.cargoDatabase.RowHeadersWidth = 51;
            this.cargoDatabase.RowTemplate.Height = 24;
            this.cargoDatabase.Size = new System.Drawing.Size(360, 391);
            this.cargoDatabase.TabIndex = 15;
            this.cargoDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cargoDatabase_CellClick);
            // 
            // DeleteCargo
            // 
            this.DeleteCargo.Location = new System.Drawing.Point(662, 317);
            this.DeleteCargo.Name = "DeleteCargo";
            this.DeleteCargo.Size = new System.Drawing.Size(93, 30);
            this.DeleteCargo.TabIndex = 12;
            this.DeleteCargo.Text = "delete";
            this.DeleteCargo.UseVisualStyleBackColor = true;
            this.DeleteCargo.Click += new System.EventHandler(this.DeleteCargo_Click);
            // 
            // EditCargo
            // 
            this.EditCargo.Location = new System.Drawing.Point(552, 317);
            this.EditCargo.Name = "EditCargo";
            this.EditCargo.Size = new System.Drawing.Size(93, 30);
            this.EditCargo.TabIndex = 11;
            this.EditCargo.Text = "update";
            this.EditCargo.UseVisualStyleBackColor = true;
            this.EditCargo.Click += new System.EventHandler(this.EditCargo_Click);
            // 
            // addCargo
            // 
            this.addCargo.Location = new System.Drawing.Point(438, 317);
            this.addCargo.Name = "addCargo";
            this.addCargo.Size = new System.Drawing.Size(93, 30);
            this.addCargo.TabIndex = 10;
            this.addCargo.Text = "submit";
            this.addCargo.UseVisualStyleBackColor = true;
            this.addCargo.Click += new System.EventHandler(this.addCargo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Products";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Weight";
            // 
            // cargoProductLine
            // 
            this.cargoProductLine.Location = new System.Drawing.Point(521, 132);
            this.cargoProductLine.Multiline = true;
            this.cargoProductLine.Name = "cargoProductLine";
            this.cargoProductLine.Size = new System.Drawing.Size(234, 142);
            this.cargoProductLine.TabIndex = 2;
            // 
            // cargoWeightLine
            // 
            this.cargoWeightLine.Location = new System.Drawing.Point(521, 93);
            this.cargoWeightLine.Name = "cargoWeightLine";
            this.cargoWeightLine.Size = new System.Drawing.Size(234, 22);
            this.cargoWeightLine.TabIndex = 1;
            this.cargoWeightLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargoWeightLine_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.destinationDatabase);
            this.tabPage3.Controls.Add(this.DeleteDestenation);
            this.tabPage3.Controls.Add(this.EditDestenation);
            this.tabPage3.Controls.Add(this.AddDestenation);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.finishPointLine);
            this.tabPage3.Controls.Add(this.startPointLine);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Destination management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // destinationDatabase
            // 
            this.destinationDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.destinationDatabase.Location = new System.Drawing.Point(16, 18);
            this.destinationDatabase.Name = "destinationDatabase";
            this.destinationDatabase.RowHeadersWidth = 51;
            this.destinationDatabase.RowTemplate.Height = 24;
            this.destinationDatabase.Size = new System.Drawing.Size(360, 391);
            this.destinationDatabase.TabIndex = 19;
            this.destinationDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.destinationDatabase_CellClick);
            // 
            // DeleteDestenation
            // 
            this.DeleteDestenation.Location = new System.Drawing.Point(644, 212);
            this.DeleteDestenation.Name = "DeleteDestenation";
            this.DeleteDestenation.Size = new System.Drawing.Size(93, 30);
            this.DeleteDestenation.TabIndex = 9;
            this.DeleteDestenation.Text = "delete";
            this.DeleteDestenation.UseVisualStyleBackColor = true;
            this.DeleteDestenation.Click += new System.EventHandler(this.DeleteDestenation_Click);
            // 
            // EditDestenation
            // 
            this.EditDestenation.Location = new System.Drawing.Point(534, 212);
            this.EditDestenation.Name = "EditDestenation";
            this.EditDestenation.Size = new System.Drawing.Size(93, 30);
            this.EditDestenation.TabIndex = 8;
            this.EditDestenation.Text = "update";
            this.EditDestenation.UseVisualStyleBackColor = true;
            this.EditDestenation.Click += new System.EventHandler(this.EditDestenation_Click);
            // 
            // AddDestenation
            // 
            this.AddDestenation.Location = new System.Drawing.Point(420, 212);
            this.AddDestenation.Name = "AddDestenation";
            this.AddDestenation.Size = new System.Drawing.Size(93, 30);
            this.AddDestenation.TabIndex = 6;
            this.AddDestenation.Text = "submit";
            this.AddDestenation.UseVisualStyleBackColor = true;
            this.AddDestenation.Click += new System.EventHandler(this.AddDestenation_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(430, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "point B";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(430, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "point A";
            // 
            // finishPointLine
            // 
            this.finishPointLine.Location = new System.Drawing.Point(547, 149);
            this.finishPointLine.Name = "finishPointLine";
            this.finishPointLine.Size = new System.Drawing.Size(172, 22);
            this.finishPointLine.TabIndex = 3;
            // 
            // startPointLine
            // 
            this.startPointLine.Location = new System.Drawing.Point(547, 108);
            this.startPointLine.Name = "startPointLine";
            this.startPointLine.Size = new System.Drawing.Size(172, 22);
            this.startPointLine.TabIndex = 2;
            // 
            // truckManagement
            // 
            this.truckManagement.Controls.Add(this.addDriver);
            this.truckManagement.Controls.Add(this.Reload);
            this.truckManagement.Controls.Add(this.truckDatabase);
            this.truckManagement.Controls.Add(this.label20);
            this.truckManagement.Controls.Add(this.label19);
            this.truckManagement.Controls.Add(this.cargoSelection);
            this.truckManagement.Controls.Add(this.tripSelection);
            this.truckManagement.Controls.Add(this.DeleteTruck);
            this.truckManagement.Controls.Add(this.EditTruck);
            this.truckManagement.Controls.Add(this.AddTruck);
            this.truckManagement.Controls.Add(this.label12);
            this.truckManagement.Controls.Add(this.label11);
            this.truckManagement.Controls.Add(this.label10);
            this.truckManagement.Controls.Add(this.label9);
            this.truckManagement.Controls.Add(this.fuelLine);
            this.truckManagement.Controls.Add(this.odometrLine);
            this.truckManagement.Controls.Add(this.modelLine);
            this.truckManagement.Controls.Add(this.yearLine);
            this.truckManagement.Location = new System.Drawing.Point(4, 25);
            this.truckManagement.Name = "truckManagement";
            this.truckManagement.Padding = new System.Windows.Forms.Padding(3);
            this.truckManagement.Size = new System.Drawing.Size(789, 416);
            this.truckManagement.TabIndex = 3;
            this.truckManagement.Text = "Truck management";
            this.truckManagement.UseVisualStyleBackColor = true;
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(455, 304);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(91, 34);
            this.Reload.TabIndex = 22;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // truckDatabase
            // 
            this.truckDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.truckDatabase.Location = new System.Drawing.Point(6, 15);
            this.truckDatabase.Name = "truckDatabase";
            this.truckDatabase.RowHeadersWidth = 51;
            this.truckDatabase.RowTemplate.Height = 24;
            this.truckDatabase.Size = new System.Drawing.Size(334, 384);
            this.truckDatabase.TabIndex = 20;
            this.truckDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.truckDatabase_CellClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(581, 174);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 18;
            this.label20.Text = "Cargo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(368, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 17);
            this.label19.TabIndex = 17;
            this.label19.Text = "Trip";
            // 
            // cargoSelection
            // 
            this.cargoSelection.FormattingEnabled = true;
            this.cargoSelection.Location = new System.Drawing.Point(651, 171);
            this.cargoSelection.Name = "cargoSelection";
            this.cargoSelection.Size = new System.Drawing.Size(121, 24);
            this.cargoSelection.TabIndex = 16;
            // 
            // tripSelection
            // 
            this.tripSelection.FormattingEnabled = true;
            this.tripSelection.Location = new System.Drawing.Point(434, 171);
            this.tripSelection.Name = "tripSelection";
            this.tripSelection.Size = new System.Drawing.Size(100, 24);
            this.tripSelection.TabIndex = 15;
            // 
            // DeleteTruck
            // 
            this.DeleteTruck.Location = new System.Drawing.Point(679, 239);
            this.DeleteTruck.Name = "DeleteTruck";
            this.DeleteTruck.Size = new System.Drawing.Size(93, 37);
            this.DeleteTruck.TabIndex = 13;
            this.DeleteTruck.Text = "Delete";
            this.DeleteTruck.UseVisualStyleBackColor = true;
            this.DeleteTruck.Click += new System.EventHandler(this.DeleteTruck_Click);
            // 
            // EditTruck
            // 
            this.EditTruck.Location = new System.Drawing.Point(527, 239);
            this.EditTruck.Name = "EditTruck";
            this.EditTruck.Size = new System.Drawing.Size(94, 37);
            this.EditTruck.TabIndex = 12;
            this.EditTruck.Text = "Edit";
            this.EditTruck.UseVisualStyleBackColor = true;
            this.EditTruck.Click += new System.EventHandler(this.EditTruck_Click);
            // 
            // AddTruck
            // 
            this.AddTruck.Location = new System.Drawing.Point(374, 239);
            this.AddTruck.Name = "AddTruck";
            this.AddTruck.Size = new System.Drawing.Size(91, 37);
            this.AddTruck.TabIndex = 11;
            this.AddTruck.Text = "Add";
            this.AddTruck.UseVisualStyleBackColor = true;
            this.AddTruck.Click += new System.EventHandler(this.AddTruck_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(583, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Fuel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(581, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Odometr";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Year";
            // 
            // fuelLine
            // 
            this.fuelLine.Location = new System.Drawing.Point(651, 75);
            this.fuelLine.Name = "fuelLine";
            this.fuelLine.Size = new System.Drawing.Size(100, 22);
            this.fuelLine.TabIndex = 4;
            this.fuelLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargoWeightLine_KeyPress);
            // 
            // odometrLine
            // 
            this.odometrLine.Location = new System.Drawing.Point(651, 122);
            this.odometrLine.Name = "odometrLine";
            this.odometrLine.Size = new System.Drawing.Size(100, 22);
            this.odometrLine.TabIndex = 3;
            this.odometrLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargoWeightLine_KeyPress);
            // 
            // modelLine
            // 
            this.modelLine.Location = new System.Drawing.Point(434, 119);
            this.modelLine.Name = "modelLine";
            this.modelLine.Size = new System.Drawing.Size(100, 22);
            this.modelLine.TabIndex = 2;
            // 
            // yearLine
            // 
            this.yearLine.Location = new System.Drawing.Point(434, 75);
            this.yearLine.Name = "yearLine";
            this.yearLine.Size = new System.Drawing.Size(100, 22);
            this.yearLine.TabIndex = 1;
            this.yearLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cargoWeightLine_KeyPress);
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
            // addDriver
            // 
            this.addDriver.Location = new System.Drawing.Point(586, 304);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(92, 34);
            this.addDriver.TabIndex = 23;
            this.addDriver.Text = "add driver";
            this.addDriver.UseVisualStyleBackColor = true;
            this.addDriver.Click += new System.EventHandler(this.addDriver_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desManagement);
            this.Name = "ManagerForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.desManagement.ResumeLayout(false);
            this.userManagment.ResumeLayout(false);
            this.userManagment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allStuffDatabase)).EndInit();
            this.carManagement.ResumeLayout(false);
            this.carManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoDatabase)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationDatabase)).EndInit();
            this.truckManagement.ResumeLayout(false);
            this.truckManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckDatabase)).EndInit();
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
        private System.Windows.Forms.TextBox driverMedSertNumLine;
        private System.Windows.Forms.TextBox driverLicNumLine;
        private System.Windows.Forms.TextBox managerLicNumLine;
        private System.Windows.Forms.TextBox phoneNumLine;
        private System.Windows.Forms.TextBox surnameLine;
        private System.Windows.Forms.TextBox nameLine;
        private System.Windows.Forms.TextBox passwordLine;
        private System.Windows.Forms.TextBox loginLine;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView allStuffDatabase;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage truckManagement;
        private System.Windows.Forms.RadioButton managerChoise;
        private System.Windows.Forms.RadioButton driverChoise;
        private System.Windows.Forms.Button DeleteTruck;
        private System.Windows.Forms.Button EditTruck;
        private System.Windows.Forms.Button AddTruck;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fuelLine;
        private System.Windows.Forms.TextBox odometrLine;
        private System.Windows.Forms.TextBox modelLine;
        private System.Windows.Forms.TextBox yearLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cargoProductLine;
        private System.Windows.Forms.TextBox cargoWeightLine;
        private System.Windows.Forms.Button AddDestenation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox finishPointLine;
        private System.Windows.Forms.TextBox startPointLine;
        private System.Windows.Forms.Button DeleteCargo;
        private System.Windows.Forms.Button EditCargo;
        private System.Windows.Forms.Button addCargo;
        private System.Windows.Forms.Button DeleteDestenation;
        private System.Windows.Forms.Button EditDestenation;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cargoSelection;
        private System.Windows.Forms.ComboBox tripSelection;
        private System.Windows.Forms.DataGridView cargoDatabase;
        private System.Windows.Forms.DataGridView destinationDatabase;
        private System.Windows.Forms.DataGridView truckDatabase;
        private System.Windows.Forms.TextBox cargoNameLine;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button addDriver;
    }
}