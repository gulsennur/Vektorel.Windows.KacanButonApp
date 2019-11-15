namespace Vektorel.Windows.KacanButonApp
{
    partial class frmToplama
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 40);
            this.button1.TabIndex = 0;
            this.button1.Tag = "0";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 39);
            this.button2.TabIndex = 1;
            this.button2.Tag = "0";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 47);
            this.button3.TabIndex = 2;
            this.button3.Tag = "0";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 97);
            this.button4.TabIndex = 3;
            this.button4.Tag = "1";
            this.button4.Text = "Sonucu Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(145, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayılar";
            // 
            // frmToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Name = "frmToplama";
            this.Text = "frmToplama";
            this.Load += new System.EventHandler(this.FrmToplama_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}