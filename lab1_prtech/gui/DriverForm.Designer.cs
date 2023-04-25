
namespace lab1_prtech
{
    partial class DriverForm
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
            this.forum = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.truckSelection = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.choose = new System.Windows.Forms.Button();
            this.tripSelection = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forum
            // 
            this.forum.Location = new System.Drawing.Point(38, 40);
            this.forum.Name = "forum";
            this.forum.Size = new System.Drawing.Size(90, 27);
            this.forum.TabIndex = 3;
            this.forum.Text = "Forum";
            this.forum.UseVisualStyleBackColor = true;
            this.forum.Click += new System.EventHandler(this.forum_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.truckSelection);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(318, 273);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Truck management";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose truck";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // truckSelection
            // 
            this.truckSelection.FormattingEnabled = true;
            this.truckSelection.Location = new System.Drawing.Point(35, 81);
            this.truckSelection.Name = "truckSelection";
            this.truckSelection.Size = new System.Drawing.Size(142, 24);
            this.truckSelection.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.choose);
            this.tabPage3.Controls.Add(this.tripSelection);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(318, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Destination management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose trip";
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(213, 88);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(81, 38);
            this.choose.TabIndex = 1;
            this.choose.Text = "Choose";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // tripSelection
            // 
            this.tripSelection.FormattingEnabled = true;
            this.tripSelection.Location = new System.Drawing.Point(40, 88);
            this.tripSelection.Name = "tripSelection";
            this.tripSelection.Size = new System.Drawing.Size(142, 24);
            this.tripSelection.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(34, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 302);
            this.tabControl1.TabIndex = 2;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 431);
            this.Controls.Add(this.forum);
            this.Controls.Add(this.tabControl1);
            this.Name = "DriverForm";
            this.Text = "SimpleDriverForm";
            this.Load += new System.EventHandler(this.SimpleDriverForm_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forum;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox truckSelection;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.ComboBox tripSelection;
        private System.Windows.Forms.TabControl tabControl1;
    }
}