
namespace lab1_prtech
{
    partial class Chat
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(605, 22);
            this.textBox1.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(643, 347);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(114, 39);
            this.send.TabIndex = 2;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "type your message:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(210, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(379, 212);
            this.treeView1.TabIndex = 6;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(35, 347);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(120, 39);
            this.answer.TabIndex = 7;
            this.answer.Text = "answer";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox1);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button answer;
    }
}