using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGames
{
    
    public partial class Form1 : Form
    {
        int yerCekimi = 5;
        int hız = 10;
        int score = 0;
        Random rnd = new Random();
        bool pbboru1kontrol, pbboru2kontrol, pbboru3kontrol, pbboru4kontrol = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space && tmrZaman.Enabled)
            {
                pbKus.Top -= yerCekimi * 10;
            }
            
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            pbKus.Top += yerCekimi;
            pbBoru1.Left -= hız;
            pbBoru2.Left -= hız;
            pbBoru3.Left -= hız;
            pbBoru4.Left -= hız; 

            if (pbBoru1.Left+pbBoru1.Width<0)
            {
                pbBoru1.Left = ClientSize.Width + rnd.Next(200);
                pbboru1kontrol = false;
            }
            if (pbBoru2.Left + pbBoru2.Width < 0)
            {
                pbBoru2.Left = ClientSize.Width + rnd.Next(200);
                pbboru2kontrol = false;
            }
            if (pbBoru3.Left + pbBoru3.Width < 0)
            {
                pbBoru3.Left = ClientSize.Width + rnd.Next(200);
                pbboru3kontrol = false;
            }
            if (pbBoru4.Left + pbBoru4.Width < 0)
            {
                pbBoru4.Left = ClientSize.Width + rnd.Next(200);
                pbboru4kontrol = false;
            }

            if (pbBoru1.Bounds.IntersectsWith(pbKus.Bounds) || pbBoru2.Bounds.IntersectsWith(pbKus.Bounds) || pbBoru3.Bounds.IntersectsWith(pbKus.Bounds) || pbBoru4.Bounds.IntersectsWith(pbKus.Bounds) || pbZemin.Bounds.IntersectsWith(pbKus.Bounds)) 
            {
                tmrZaman.Stop();
                DialogResult result = MessageBox.Show("Tekrar oynamak ister misiniz?", "FlappyBird", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    pbKus.Top = 12;
                    pbKus.Left = 210;

                    pbBoru1.Left += ClientSize.Width;
                    pbBoru2.Left += ClientSize.Width;
                    pbBoru3.Left += ClientSize.Width;
                    pbBoru4.Left += ClientSize.Width;
                    score = 0;
                    tmrZaman.Start();
                }
                else
                {
                    Close();
                }
            }
            if (pbKus.Right > pbBoru1.Left && !pbboru1kontrol ) 
            {
                score++;
                pbboru1kontrol = true;
            }
            if (pbKus.Right > pbBoru2.Left && !pbboru2kontrol) 
            {
                score++;
                pbboru2kontrol = true;
            }
            if (pbKus.Right > pbBoru3.Left && !pbboru3kontrol) 
            {
                score++;
                pbboru3kontrol = true;
            }
            if (pbKus.Right > pbBoru4.Left && !pbboru4kontrol) 
            {
                score++;
                pbboru4kontrol = true;
            }
            lblScore.Text = "skore:" + score;
        }
    }
}
