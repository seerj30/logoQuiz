using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atestat
{
    public partial class Form4 : Form
    {
        int nr, ok1 = 0, ok2 = 0, ok3 = 0, ok4 = 0, ok5 = 0, ok6 = 0, pereche=0;
        Image[] img = new Image[52];
        int i, ran1, ran2, ran3;
        Random rnd = new Random();
        public Form4()
        {
            InitializeComponent();
            //1-3,2-4,5-6
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Transparent;  //background-ul de la bara de optiuni transparent
            pictureBox1.BackColor = Color.Transparent; //
            pictureBox2.BackColor = Color.Transparent; //
            pictureBox3.BackColor = Color.Transparent; //fac fundalu' de la fiecare carte transparent
            pictureBox4.BackColor = Color.Transparent; //
            pictureBox5.BackColor = Color.Transparent; //
            pictureBox6.BackColor = Color.Transparent; //

            

            for (i = 0; i <= 51; i++)
                img[i] = Image.FromFile("image" + i + ".png");

            reset();
        }

        private void reset()
        {
            ran1 = rnd.Next(12, 34);
            ran2 = rnd.Next(34, 52);
            ran3 = rnd.Next(0, 12);
        }

        private void vizibil()
        {
            pictureBox1.Image = Image.FromFile("spate_carte.png");
            pictureBox2.Image = Image.FromFile("spate_carte.png");
            pictureBox3.Image = Image.FromFile("spate_carte.png");
            pictureBox4.Image = Image.FromFile("spate_carte.png");
            pictureBox5.Image = Image.FromFile("spate_carte.png");
            pictureBox6.Image = Image.FromFile("spate_carte.png");

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
        }

        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ok1 = 1;
            nr++;
            pictureBox1.Image = img[ran1];
            if (nr == 2)
            {
                if (ok3 == 1)
                {
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pereche++;
                    if (pereche % 3 == 0)
                    {
                        reset();
                        vizibil();
                    }
                }
            }
            else
            {
                if (nr == 3)
                    nr = 1;
                pictureBox1.Image = img[ran1];
                if (ok2 == 1)
                {
                    pictureBox2.Image = Image.FromFile("spate_carte.png");
                    ok2 = 0;
                }
                if (ok3 == 1)
                {
                    pictureBox3.Image = Image.FromFile("spate_carte.png");
                    ok3 = 0;
                }
                if (ok4 == 1)
                {
                    pictureBox4.Image = Image.FromFile("spate_carte.png");
                    ok4 = 0;
                }
                if (ok5 == 1)
                {
                    pictureBox5.Image = Image.FromFile("spate_carte.png");
                    ok5 = 0;
                }
                if (ok6 == 1)
                {
                    pictureBox6.Image = Image.FromFile("spate_carte.png");
                    ok6 = 0;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ok2 = 1;
            nr++;
            pictureBox2.Image = img[ran2];
            if (nr == 2)
            {
                if (ok4 == 1)
                {
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pereche++;
                    if (pereche % 3 == 0)
                    {
                        reset();
                        vizibil();
                    }
                }
            }
            else
            {
                if (nr == 3)
                    nr = 1;
                pictureBox2.Image = img[ran2];
                if (ok1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("spate_carte.png");
                    ok1 = 0;
                }
                if (ok3 == 1)
                {
                    pictureBox3.Image = Image.FromFile("spate_carte.png");
                    ok3 = 0;
                }
                if (ok4 == 1)
                {
                    pictureBox4.Image = Image.FromFile("spate_carte.png");
                    ok4 = 0;
                }
                if (ok5 == 1)
                {
                    pictureBox5.Image = Image.FromFile("spate_carte.png");
                    ok5 = 0;
                }
                if (ok6 == 1)
                {
                    pictureBox6.Image = Image.FromFile("spate_carte.png");
                    ok6 = 0;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ok3 = 1;
            nr++;
            pictureBox3.Image = img[ran1];
            if (nr == 2)
            {
                if (ok1 == 1)
                {
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = false;
                    pereche++;
                    if (pereche % 3 == 0)
                    {
                        reset();
                        vizibil();
                    }
                }
            }
            else
            {
                if (nr == 3)
                    nr = 1;
                pictureBox3.Image = img[ran1];
                if (ok2 == 1)
                {
                    pictureBox2.Image = Image.FromFile("spate_carte.png");
                    ok2 = 0;
                }
                if (ok1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("spate_carte.png");
                    ok1 = 0;
                }
                if (ok4 == 1)
                {
                    pictureBox4.Image = Image.FromFile("spate_carte.png");
                    ok4 = 0;
                }
                if (ok5 == 1)
                {
                    pictureBox5.Image = Image.FromFile("spate_carte.png");
                    ok5 = 0;
                }
                if (ok6 == 1)
                {
                    pictureBox6.Image = Image.FromFile("spate_carte.png");
                    ok6 = 0;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ok4 = 1;
            nr++;
            pictureBox4.Image = img[ran2];
            if (nr == 2)
            {
                if (ok2 == 1)
                {
                    pictureBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pereche++;
                    if (pereche % 3 == 0)
                    {
                        reset();
                        vizibil();
                    }
                }
            }
            else
            {
                if (nr == 3)
                    nr = 1;
                pictureBox4.Image = img[ran2];
                if (ok2 == 1)
                {
                    pictureBox2.Image = Image.FromFile("spate_carte.png");
                    ok2 = 0;
                }
                if (ok3 == 1)
                {
                    pictureBox3.Image = Image.FromFile("spate_carte.png");
                    ok3 = 0;
                }
                if (ok1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("spate_carte.png");
                    ok1 = 0;
                }
                if (ok5 == 1)
                {
                    pictureBox5.Image = Image.FromFile("spate_carte.png");
                    ok5 = 0;
                }
                if (ok6 == 1)
                {
                    pictureBox6.Image = Image.FromFile("spate_carte.png");
                    ok6 = 0;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ok5 = 1;
            nr++;
            pictureBox5.Image = img[ran3];
            if (nr == 2)
            {
                if (ok6 == 1)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pereche++;
                    if (pereche % 3 == 0)
                    {
                        reset();
                        vizibil();
                    }
                }
            }
            else
            {
                if (nr == 3)
                    nr = 1;
                pictureBox5.Image = img[ran3];
                if (ok2 == 1)
                {
                    pictureBox2.Image = Image.FromFile("spate_carte.png");
                    ok2 = 0;
                }
                if (ok3 == 1)
                {
                    pictureBox3.Image = Image.FromFile("spate_carte.png");
                    ok3 = 0;
                }
                if (ok4 == 1)
                {
                    pictureBox4.Image = Image.FromFile("spate_carte.png");
                    ok4 = 0;
                }
                if (ok1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("spate_carte.png");
                    ok1 = 0;
                }
                if (ok6 == 1)
                {
                    pictureBox6.Image = Image.FromFile("spate_carte.png");
                    ok6 = 0;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ok6 = 1;
            nr++;
            pictureBox6.Image = img[ran3];
            if (nr == 2)
            {
                if (ok5 == 1)
                {
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pereche++;
                    if (pereche % 3==0)
                    {
                        reset();
                        vizibil();
                    }
                }
            }
            else
            {

                if (nr == 3)
                    nr = 1;
                pictureBox6.Image = img[ran3];
                if (ok2 == 1)
                {
                    pictureBox2.Image = Image.FromFile("spate_carte.png");
                    ok2 = 0;
                }
                if (ok3 == 1)
                {
                    pictureBox3.Image = Image.FromFile("spate_carte.png");
                    ok3 = 0;
                }
                if (ok4 == 1)
                {
                    pictureBox4.Image = Image.FromFile("spate_carte.png");
                    ok4 = 0;
                }
                if (ok5 == 1)
                {
                    pictureBox5.Image = Image.FromFile("spate_carte.png");
                    ok5 = 0;
                }
                if (ok1 == 1)
                {
                    pictureBox1.Image = Image.FromFile("spate_carte.png");
                    ok1 = 0;
                }
            }
        }

    }

}
