using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace atestat
{

    public struct joc
    {
       public Image img;
       public int nr;
    };

    public partial class Form2 : Form
    {
        joc [] v = new joc[52];
        PictureBox[] pb = new PictureBox[5];
        int i, ran1, ran2, ran3, ran4, ranpb, ranpb1, ranpb2, ranpb3;
        int [] ap= new int[52];
        int [] ap2 = new int[5];
        Random rnd = new Random();
        public bool rr = false;
        
        public Form2()
        {
            InitializeComponent();

            pb[1] = pictureBox1;
            pb[2] = pictureBox2;
            pb[3] = pictureBox3;
            pb[4] = pictureBox4;

            for (i = 0; i <= 51; i++)
            {
                v[i].img = Image.FromFile("image" + i + ".png");
                v[i].nr = i;
            }
            random();
        }

       public void random()
        {
           int i;
            for (i = 1; i <= 4; i++)
                pb[i].Enabled = true;

            label1.Visible = false;
            label2.Visible = false;

            
            for (i = 1; i <= 51; i++)
            {
                ap[i] = 0;
            }
            for (i = 1; i <= 4; i++)
            {
                ap2[i] = 0;
            }

                ran1 = rnd.Next(0, 12);
            ran2 = rnd.Next(0, 12);
            ran3 = rnd.Next(0, 12);
            ran4 = rnd.Next(12, 34); // intrusul

            ranpb = rnd.Next(1, 5);
            ranpb1 = rnd.Next(1, 5);
            ranpb2 = rnd.Next(1, 5);
            ranpb3 = rnd.Next(1, 5);
            

            do
            {
                ranpb1 = rnd.Next(1, 5);
            } while (ap2[ranpb1] == 1);
            ap2[ranpb1] = 1;

            do
            {
                ranpb2 = rnd.Next(1, 5);
            } while (ap2[ranpb2] == 1);
            ap2[ranpb2] = 1;

            do
            {
                ranpb3 = rnd.Next(1, 5);
            } while (ap2[ranpb3] == 1);
            ap2[ranpb3] = 1;

            do
            {
                ranpb = rnd.Next(1, 5);
            } while (ap2[ranpb] == 1);
            ap2[ranpb] = 1;


            //ma asigur ca nu generez random acceasi valoare de mai multe ori
            do
            {
                ran1 = rnd.Next(0, 12);


            } while (ap[ran1] == 1);
            ap[ran1] = 1;

            do
            {
                ran2 = rnd.Next(0, 12);
            } while (ap[ran2] == 1);
            ap[ran2] = 1;

            do
            {
                ran3 = rnd.Next(0, 12);
            } while (ap[ran3] == 1);
            ap[ran3] = 1;

            do
            {
                ran4 = rnd.Next(12, 34);
            } while (ap[ran4] == 1);
            ap[ran4] = 1;


            pb[ranpb1].Image = v[ran1].img;
            pb[ranpb2].Image = v[ran2].img;
            pb[ranpb3].Image = v[ran3].img;
            pb[ranpb].Image = v[ran4].img;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        //fac background-ul transparent
        private void Form2_Load(object sender, EventArgs e)
        {

            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            menuStrip1.BackColor = Color.Transparent;
        }
        
        //deschid meniul de pe bara de optiuni
        private void meniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }


        //inchid jocul de pe bara de optiuni
        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if ((ranpb1 == 1 && (v[ran1].nr >= 0 && v[ran1].nr < 12)) ||
                (ranpb2 == 1 && (v[ran2].nr >= 0 && v[ran2].nr < 12)) ||
                (ranpb3 == 1 && (v[ran3].nr >= 0 && v[ran3].nr < 12)) ||
                (ranpb == 1 && (v[ran4].nr >= 0 && v[ran4].nr < 12)))
            {
                label2.Visible = true;
                label1.Visible = false;
            }
                
            else
            {
                label2.Visible = false;
                label1.Visible = true;
            }
            if (label1.Visible == true)
            {
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if ((ranpb1 == 2 && (v[ran1].nr >= 0 && v[ran1].nr < 12)) ||
                 (ranpb2 == 2 && (v[ran2].nr >= 0 && v[ran2].nr < 12)) ||
                 (ranpb3 == 2 && (v[ran3].nr >= 0 && v[ran3].nr < 12)) ||
                 (ranpb == 2 && (v[ran4].nr >= 0 && v[ran4].nr < 12)))
            {
                label2.Visible = true;
                label1.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label1.Visible = true;
            }
            if (label1.Visible == true)
            {
                pictureBox1.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((ranpb1 == 3 && (v[ran1].nr >= 0 && v[ran1].nr < 12)) ||
                (ranpb2 == 3 && (v[ran2].nr >= 0 && v[ran2].nr < 12)) ||
                (ranpb3 == 3 && (v[ran3].nr >= 0 && v[ran3].nr < 12)) ||
                (ranpb == 3 && (v[ran4].nr >= 0 && v[ran4].nr < 12)))
            {
                label2.Visible = true;
                label1.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label1.Visible = true;
            }
            if (label1.Visible == true)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox4.Enabled = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if ((ranpb1 == 4 && (v[ran1].nr >= 0 && v[ran1].nr < 12)) ||
               (ranpb2 == 4 && (v[ran2].nr >= 0 && v[ran2].nr < 12)) ||
               (ranpb3 == 4 && (v[ran3].nr >= 0 && v[ran3].nr < 12)) ||
               (ranpb == 4 && (v[ran4].nr >= 0 && v[ran4].nr < 12)))
            {
                label2.Visible = true;
                label1.Visible = false;
            }
            else
            {
                label2.Visible = false;
                label1.Visible = true;
            }
            if (label1.Visible == true)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            rr = false;
            if (e.KeyCode == Keys.Space)
            {
                rr = true;
            }
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rr == true && label1.Visible==true)
                random();
        }




    }
}
