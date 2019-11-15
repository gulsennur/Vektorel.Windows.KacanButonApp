using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.KacanButonApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Size = new Size(100, 30);
            btn.Text = "Bizim Buton";
            //btn.Click += Btn_Click;
            btn.Click += BizimButonClick;

            this.Controls.Add(btn);

            
        }
        void BizimButonClick(object o , EventArgs e) //metoda iki parametre gönderince event la
        {
            MessageBox.Show("Test");
        }
        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Test");
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;

            MessageBox.Show( buton.Text + " Clicklendi");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X:{e.X.ToString()} Y:{e.Y.ToString()}";
        }
    }
}
