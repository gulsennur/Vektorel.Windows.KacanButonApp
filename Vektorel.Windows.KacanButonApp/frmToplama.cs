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
    public partial class frmToplama : Form
    {
        int sonuc = 0;
        public frmToplama()
        {
            InitializeComponent();
        }

        private void FrmToplama_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //foreach  (Control item in this.Controls)
            //{
            //    if (item is Button && item.Tag.ToString()=="0")
            //    {
            //        item.Text = rnd.Next(10, 100).ToString();
            //    }
            //}
            foreach (Control item in this.Controls["groupBox1"].Controls)
            {
                item.Text = rnd.Next(10, 100).ToString();
            }
             

        }
        void Click (object s , EventArgs e)
        {
            Button btn = (Button)s; //hangi butona click olduğunu sender yani s söyler . Sender ın getirdiği referansı buton referansına eşitledik.
            sonuc += int.Parse(btn.Text);
            btn.Enabled = false;
           // btn.Visible = false; 
        } 

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sonuc.ToString());
        }
    }
}
