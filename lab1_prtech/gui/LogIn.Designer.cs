
namespace lab1_prtech
{
    partial class LogIn
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
            this.DriverChoise = new System.Windows.Forms.RadioButton();
            this.ManagerChoise = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DriverChoise
            // 
            this.DriverChoise.AutoSize = true;
            this.DriverChoise.Location = new System.Drawing.Point(26, 25);
            this.DriverChoise.Name = "DriverChoise";
            this.DriverChoise.Size = new System.Drawing.Size(67, 21);
            this.DriverChoise.TabIndex = 0;
            this.DriverChoise.TabStop = true;
            this.DriverChoise.Text = "Driver";
            this.DriverChoise.UseVisualStyleBackColor = true;
            this.DriverChoise.CheckedChanged += new System.EventHandler(this.DriverChoise_CheckedChanged);
            // 
            // ManagerChoise
            // 
            this.ManagerChoise.AutoSize = true;
            this.ManagerChoise.Location = new System.Drawing.Point(203, 25);
            this.ManagerChoise.Name = "ManagerChoise";
            this.ManagerChoise.Size = new System.Drawing.Size(85, 21);
            this.ManagerChoise.TabIndex = 1;
            this.ManagerChoise.TabStop = true;
            this.ManagerChoise.Text = "Manager";
            this.ManagerChoise.UseVisualStyleBackColor = true;
            this.ManagerChoise.CheckedChanged += new System.EventHandler(this.DriverChoise_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 5;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(26, 168);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(81, 34);
            this.register.TabIndex = 6;
            this.register.Text = "register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "log in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 235);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.register);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerChoise);
            this.Controls.Add(this.DriverChoise);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton DriverChoise;
        private System.Windows.Forms.RadioButton ManagerChoise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button button2;
    }
}