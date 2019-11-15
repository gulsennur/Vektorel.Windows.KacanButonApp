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
    public partial class frmOyun : Form
    {
        int count=0;
        public frmOyun()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //GitHub'a proje yükleme - Vs GitHub extension 
            //Repository -> Depo
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            count++;
            if(count%10==0)
            {
                this.Size = new Size(this.Width + 10, this.Height + 10);
            }
            btnKac.Text = count.ToString();

            Random rnd = new Random();
              
            btnKac.Location = new Point(rnd.Next (this.ClientSize.Width-btnKac.Width), rnd.Next(this.ClientSize.Height-btnKac.Height));
        }
    }
}
