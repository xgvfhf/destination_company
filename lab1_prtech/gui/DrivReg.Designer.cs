
namespace lab1_prtech
{
    partial class DrivReg
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
            this.driverLogin = new System.Windows.Forms.TextBox();
            this.driverPassword = new System.Windows.Forms.TextBox();
            this.driverName = new System.Windows.Forms.TextBox();
            this.driverSurname = new System.Windows.Forms.TextBox();
            this.driverPhoneNum = new System.Windows.Forms.TextBox();
            this.driverLicNum = new System.Windows.Forms.TextBox();
            this.driverMedNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driverLogin
            // 
            this.driverLogin.Location = new System.Drawing.Point(199, 39);
            this.driverLogin.Name = "driverLogin";
            this.driverLogin.Size = new System.Drawing.Size(118, 22);
            this.driverLogin.TabIndex = 0;
            this.driverLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // driverPassword
            // 
            this.driverPassword.Location = new System.Drawing.Point(199, 67);
            this.driverPassword.Name = "driverPassword";
            this.driverPassword.Size = new System.Drawing.Size(118, 22);
            this.driverPassword.TabIndex = 1;
            this.driverPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // driverName
            // 
            this.driverName.Location = new System.Drawing.Point(199, 95);
            this.driverName.Name = "driverName";
            this.driverName.Size = new System.Drawing.Size(118, 22);
            this.driverName.TabIndex = 2;
            this.driverName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // driverSurname
            // 
            this.driverSurname.Location = new System.Drawing.Point(199, 123);
            this.driverSurname.Name = "driverSurname";
            this.driverSurname.Size = new System.Drawing.Size(118, 22);
            this.driverSurname.TabIndex = 3;
            this.driverSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // driverPhoneNum
            // 
            this.driverPhoneNum.Location = new System.Drawing.Point(199, 151);
            this.driverPhoneNum.Name = "driverPhoneNum";
            this.driverPhoneNum.Size = new System.Drawing.Size(118, 22);
            this.driverPhoneNum.TabIndex = 4;
            this.driverPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // driverLicNum
            // 
            this.driverLicNum.Location = new System.Drawing.Point(199, 179);
            this.driverLicNum.Name = "driverLicNum";
            this.driverLicNum.Size = new System.Drawing.Size(118, 22);
            this.driverLicNum.TabIndex = 5;
            this.driverLicNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // driverMedNum
            // 
            this.driverMedNum.Location = new System.Drawing.Point(199, 207);
            this.driverMedNum.Name = "driverMedNum";
            this.driverMedNum.Size = new System.Drawing.Size(118, 22);
            this.driverMedNum.TabIndex = 6;
            this.driverMedNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driverLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "passsword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "phone number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "driver license number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "medsertificate number";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(233, 260);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 32);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // DrivReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 320);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.driverMedNum);
            this.Controls.Add(this.driverLicNum);
            this.Controls.Add(this.driverPhoneNum);
            this.Controls.Add(this.driverSurname);
            this.Controls.Add(this.driverName);
            this.Controls.Add(this.driverPassword);
            this.Controls.Add(this.driverLogin);
            this.Name = "DrivReg";
            this.Text = "DrivReg";
            this.Load += new System.EventHandler(this.DrivReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox driverLogin;
        private System.Windows.Forms.TextBox driverPassword;
        private System.Windows.Forms.TextBox driverName;
        private System.Windows.Forms.TextBox driverSurname;
        private System.Windows.Forms.TextBox driverPhoneNum;
        private System.Windows.Forms.TextBox driverLicNum;
        private System.Windows.Forms.TextBox driverMedNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submitButton;
    }
}