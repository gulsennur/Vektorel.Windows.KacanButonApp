﻿ namespace Vektorel.Windows.KacanButonApp
{
    partial class frmOyun
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
            this.btnKac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKac
            // 
            this.btnKac.Location = new System.Drawing.Point(193, 155);
            this.btnKac.Name = "btnKac";
            this.btnKac.Size = new System.Drawing.Size(94, 81);
            this.btnKac.TabIndex = 0;
            this.btnKac.Text = "0";
            this.btnKac.UseVisualStyleBackColor = true;
            this.btnKac.Click += new System.EventHandler(this.Button1_Click);
            this.btnKac.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 429);
            this.Controls.Add(this.btnKac);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKac;
    }
}