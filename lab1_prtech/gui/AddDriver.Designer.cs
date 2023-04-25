
namespace lab1_prtech
{
    partial class AddDriver
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
            this.Drivers = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Drivers)).BeginInit();
            this.SuspendLayout();
            // 
            // Drivers
            // 
            this.Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Drivers.Location = new System.Drawing.Point(26, 45);
            this.Drivers.MultiSelect = false;
            this.Drivers.Name = "Drivers";
            this.Drivers.RowHeadersWidth = 51;
            this.Drivers.RowTemplate.Height = 24;
            this.Drivers.Size = new System.Drawing.Size(420, 278);
            this.Drivers.TabIndex = 0;
            this.Drivers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Drivers_CellClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(344, 348);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(102, 39);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select driver";
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Drivers);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            this.Load += new System.EventHandler(this.AddDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Drivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Drivers;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
    }
}