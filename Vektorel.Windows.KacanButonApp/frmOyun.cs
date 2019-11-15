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
        int count = 0;
        int sure = 5;
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
            Random rnd = new Random();
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            count++;
            if(count%10==0)
            {
                this.Size = new Size(this.Width + 100, this.Height + 100);
            }
            btnKac.Text = count.ToString();

            btnKac.Location = new Point(rnd.Next (this.ClientSize.Width-btnKac.Width), rnd.Next(this.ClientSize.Height-btnKac.Height));
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            this.Text = sure.ToString();
            if (sure==0)
            {
                tmrSure.Stop();
                DialogResult cvp = MessageBox.Show($"Süreniz doldu , puanınız:{ count}\n Yeniden oynamak istiyor musunuz?", "Oyun bitti",MessageBoxButtons.YesNo,MessageBoxIcon.Question );
                if (cvp == DialogResult.Yes)
                {
                    sure = 5;
                    count = 0;
                    btnKac.Text = count.ToString();
                    this.Size = new Size(300, 300);
                    tmrSure.Start();
                }
                else
                {
                    btnKac.Text = ":D";
                    btnKac.Enabled = false;
                }
            }
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrSure.Start();
        }
    }
}
