namespace Mesajlaşma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerIPtextBox1 = new System.Windows.Forms.TextBox();
            this.ServerPorttextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.MesajYazmatextBox = new System.Windows.Forms.TextBox();
            this.Başlabutton = new System.Windows.Forms.Button();
            this.Bağlabutton = new System.Windows.Forms.Button();
            this.Gönderbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(338, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(338, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "PORT";
            // 
            // ServerIPtextBox1
            // 
            this.ServerIPtextBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerIPtextBox1.Location = new System.Drawing.Point(147, 84);
            this.ServerIPtextBox1.Name = "ServerIPtextBox1";
            this.ServerIPtextBox1.Size = new System.Drawing.Size(125, 31);
            this.ServerIPtextBox1.TabIndex = 6;
            // 
            // ServerPorttextBox
            // 
            this.ServerPorttextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerPorttextBox.Location = new System.Drawing.Point(400, 74);
            this.ServerPorttextBox.Name = "ServerPorttextBox";
            this.ServerPorttextBox.Size = new System.Drawing.Size(125, 31);
            this.ServerPorttextBox.TabIndex = 7;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientIPtextBox.Location = new System.Drawing.Point(147, 190);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(125, 31);
            this.ClientIPtextBox.TabIndex = 8;
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientPorttextBox.Location = new System.Drawing.Point(414, 190);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(125, 31);
            this.ClientPorttextBox.TabIndex = 9;
            // 
            // MesajYazmatextBox
            // 
            this.MesajYazmatextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MesajYazmatextBox.Location = new System.Drawing.Point(49, 502);
            this.MesajYazmatextBox.Multiline = true;
            this.MesajYazmatextBox.Name = "MesajYazmatextBox";
            this.MesajYazmatextBox.Size = new System.Drawing.Size(414, 78);
            this.MesajYazmatextBox.TabIndex = 11;
            this.MesajYazmatextBox.TextChanged += new System.EventHandler(this.MesajYazmatextBox_TextChanged);
            // 
            // Başlabutton
            // 
            this.Başlabutton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Başlabutton.Location = new System.Drawing.Point(642, 52);
            this.Başlabutton.Name = "Başlabutton";
            this.Başlabutton.Size = new System.Drawing.Size(128, 75);
            this.Başlabutton.TabIndex = 12;
            this.Başlabutton.Text = "BAŞLA";
            this.Başlabutton.UseVisualStyleBackColor = true;
            this.Başlabutton.Click += new System.EventHandler(this.Başlabutton_Click);
            // 
            // Bağlabutton
            // 
            this.Bağlabutton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bağlabutton.Location = new System.Drawing.Point(642, 168);
            this.Bağlabutton.Name = "Bağlabutton";
            this.Bağlabutton.Size = new System.Drawing.Size(128, 75);
            this.Bağlabutton.TabIndex = 13;
            this.Bağlabutton.Text = "BAĞLAN";
            this.Bağlabutton.UseVisualStyleBackColor = true;
            this.Bağlabutton.Click += new System.EventHandler(this.Bağlabutton_Click);
            // 
            // Gönderbutton
            // 
            this.Gönderbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Gönderbutton.Location = new System.Drawing.Point(521, 518);
            this.Gönderbutton.Name = "Gönderbutton";
            this.Gönderbutton.Size = new System.Drawing.Size(123, 62);
            this.Gönderbutton.TabIndex = 14;
            this.Gönderbutton.Text = "GÖNDER";
            this.Gönderbutton.UseVisualStyleBackColor = false;
            this.Gönderbutton.Click += new System.EventHandler(this.Gönderbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(39, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(595, 204);
            this.listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 701);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Gönderbutton);
            this.Controls.Add(this.Bağlabutton);
            this.Controls.Add(this.Başlabutton);
            this.Controls.Add(this.MesajYazmatextBox);
            this.Controls.Add(this.ClientPorttextBox);
            this.Controls.Add(this.ClientIPtextBox);
            this.Controls.Add(this.ServerPorttextBox);
            this.Controls.Add(this.ServerIPtextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServerIPtextBox1;
        private System.Windows.Forms.TextBox ServerPorttextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.TextBox MesajYazmatextBox;
        private System.Windows.Forms.Button Başlabutton;
        private System.Windows.Forms.Button Bağlabutton;
        private System.Windows.Forms.Button Gönderbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ListBox listBox1;
    }
}
