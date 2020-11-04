using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ben_Rado___Annelerin_Yok_Olusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int Can = 3;
        private static int Puan = 0;
        private static List<Hedef> Hedefler = new List<Hedef>();

        private Timer GameTime = new Timer()
        {
            Interval = 40
        };

        private Timer SpawnerTimer = new Timer()
        {
            Interval = 1000
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Karakteri hareket ettirmek için W ve S tuşlarını kullanınız.", "Ben Rado - Annelerin Yok Oluşu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SpawnerTimer.Tick += SpawnerTimer_Tick;
            SpawnerTimer.Start();
            GameTime.Tick += GameTime_Tick;
            GameTime.Start();
        }

        private void SpawnerTimer_Tick(object sender, EventArgs e)
        {
            var hedef = new Hedef();
            hedef.SizeMode = PictureBoxSizeMode.StretchImage;
            hedef.Image = Properties.Resources.Anne;
            hedef.Size = new Size(96, 96);
            hedef.Location = new Point(600, new Random().Next(0, 441));
            this.Controls.Add(hedef);
            Hedefler.Add(hedef);
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            foreach(var hedef in Hedefler)
            {
                hedef.Location = new Point(hedef.Location.X - 5, hedef.Location.Y);
                if (AnaKarakter.Bounds.IntersectsWith(hedef.Bounds) && hedef.VurulduMu == false)
                {
                    hedef.VurulduMu = true;
                    this.Controls.Remove(hedef);
                    hedef.Dispose();
                    Puan++;
                }

                if (hedef.Location.X < -96 && hedef.VurulduMu == false)
                {
                    Can--;
                    hedef.VurulduMu = true;
                    this.Controls.Remove(hedef);
                    hedef.Dispose();

                    if(Can == 0)
                    {
                        foreach(var hedef2 in Hedefler)
                        {
                            this.Controls.Remove(hedef2);
                            hedef2.VurulduMu = true;
                            hedef2.Dispose();
                        }
                        AnaKarakter.Location = new Point(13, 203);
                        GameTime.Stop();
                        SpawnerTimer.Stop();

                        MessageBox.Show("Oyunu Kaybettin", "Ben Rado: Annelerin Yok Oluşu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Can = 3;
                        Puan = 0;
                        GameTime.Start();
                        SpawnerTimer.Start();
                    }
                }
            }

            PuanSayaci.Text = "Puan: " + Puan.ToString();
            CanSayaci.Text = "Can: " + Can.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                AnaKarakter.Location = new Point(AnaKarakter.Location.X, AnaKarakter.Location.Y - 5);
            }
            else if (e.KeyCode == Keys.S)
            {
                AnaKarakter.Location = new Point(AnaKarakter.Location.X, AnaKarakter.Location.Y + 5);
            }
        }
    }
}
