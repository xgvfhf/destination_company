
namespace lab1_prtech
{
    partial class ManagerReg
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
            this.submitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.managerLicNum = new System.Windows.Forms.TextBox();
            this.managerPhoneNum = new System.Windows.Forms.TextBox();
            this.managerSurname = new System.Windows.Forms.TextBox();
            this.managerName = new System.Windows.Forms.TextBox();
            this.managerPassword = new System.Windows.Forms.TextBox();
            this.managerLogin = new System.Windows.Forms.TextBox();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(236, 267);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 32);
            this.submitButton.TabIndex = 29;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "manager license number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "passsword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "login";
            // 
            // managerLicNum
            // 
            this.managerLicNum.Location = new System.Drawing.Point(202, 186);
            this.managerLicNum.Name = "managerLicNum";
            this.managerLicNum.Size = new System.Drawing.Size(118, 22);
            this.managerLicNum.TabIndex = 20;
            this.managerLicNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerLogin_KeyPress);
            // 
            // managerPhoneNum
            // 
            this.managerPhoneNum.Location = new System.Drawing.Point(202, 158);
            this.managerPhoneNum.Name = "managerPhoneNum";
            this.managerPhoneNum.Size = new System.Drawing.Size(118, 22);
            this.managerPhoneNum.TabIndex = 19;
            this.managerPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerLogin_KeyPress);
            // 
            // managerSurname
            // 
            this.managerSurname.Location = new System.Drawing.Point(202, 130);
            this.managerSurname.Name = "managerSurname";
            this.managerSurname.Size = new System.Drawing.Size(118, 22);
            this.managerSurname.TabIndex = 18;
            this.managerSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerLogin_KeyPress);
            // 
            // managerName
            // 
            this.managerName.Location = new System.Drawing.Point(202, 102);
            this.managerName.Name = "managerName";
            this.managerName.Size = new System.Drawing.Size(118, 22);
            this.managerName.TabIndex = 17;
            this.managerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerLogin_KeyPress);
            // 
            // managerPassword
            // 
            this.managerPassword.Location = new System.Drawing.Point(202, 74);
            this.managerPassword.Name = "managerPassword";
            this.managerPassword.Size = new System.Drawing.Size(118, 22);
            this.managerPassword.TabIndex = 16;
            this.managerPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerLogin_KeyPress);
            // 
            // managerLogin
            // 
            this.managerLogin.Location = new System.Drawing.Point(202, 46);
            this.managerLogin.Name = "managerLogin";
            this.managerLogin.Size = new System.Drawing.Size(118, 22);
            this.managerLogin.TabIndex = 15;
            this.managerLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.managerLogin_KeyPress);
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(26, 225);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(82, 21);
            this.isAdmin.TabIndex = 30;
            this.isAdmin.Text = "is admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // ManagerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 320);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerLicNum);
            this.Controls.Add(this.managerPhoneNum);
            this.Controls.Add(this.managerSurname);
            this.Controls.Add(this.managerName);
            this.Controls.Add(this.managerPassword);
            this.Controls.Add(this.managerLogin);
            this.Name = "ManagerReg";
            this.Text = "ManagerReg";
            this.Load += new System.EventHandler(this.ManagerReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox managerLicNum;
        private System.Windows.Forms.TextBox managerPhoneNum;
        private System.Windows.Forms.TextBox managerSurname;
        private System.Windows.Forms.TextBox managerName;
        private System.Windows.Forms.TextBox managerPassword;
        private System.Windows.Forms.TextBox managerLogin;
        private System.Windows.Forms.CheckBox isAdmin;
    }
}