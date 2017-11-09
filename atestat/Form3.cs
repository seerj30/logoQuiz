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
    public struct poza
    {
        public Image img;
        public string m;
    }
    public partial class Form3 : Form
    {
        poza[] v = new poza[999];
        int[] a = new int[26];
        int ran;
        Random rnd = new Random();
        int[] ap = new int[999];
        public bool rr = false;

        public Form3()
        {
            InitializeComponent();
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Logo-ul cărei companii este ?";
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        void restart()
        {
            textBox2.Focus();
            ran = rnd.Next(0, 25);
            do
            {
                ran = rnd.Next(0, 25);

            } while (ap[ran] == 1);

            pictureBox1.Image = v[ran].img;
        }

        //fac background-ul de la bara de optiuni transparent
        private void Form3_Load(object sender, EventArgs e)
        {
            this.textBox1.Enter += new EventHandler(textBox1_Enter);
            this.textBox1.Leave += new EventHandler(textBox1_Leave);

            v[0].img = Image.FromFile("image11.png");
            v[0].m="Apple";
            v[1].img = Image.FromFile("image13.png");
            v[1].m="Jaguar";
            v[2].img = Image.FromFile("image14.png");
            v[2].m="Mazda";
            v[3].img = Image.FromFile("image15.png");
            v[3].m="Mercedes";
            v[4].img = Image.FromFile("image16.png");
            v[4].m="Mitsubishi";
            v[5].img = Image.FromFile("image17.png");
            v[5].m="Mustang";
            v[6].img = Image.FromFile("image21.png");
            v[6].m="Seat";
            v[7].img = Image.FromFile("image22.png");
            v[7].m="Skoda";
            v[8].img = Image.FromFile("image23.png");
            v[8].m="Volkswagen";
            v[9].img = Image.FromFile("image25.png");
            v[9].m="Dodge";
            v[10].img = Image.FromFile("image28.png");
            v[10].m="Audi";
            v[11].img = Image.FromFile("image30.png");
            v[11].m="Citroen";
            v[12].img = Image.FromFile("image33.png");
            v[12].m="Toyota";
            v[13].img = Image.FromFile("image34.png");
            v[13].m="Instagram";
            v[14].img = Image.FromFile("image37.png");
            v[14].m="Messenger";
            v[15].img = Image.FromFile("image38.png");
            v[15].m="Pinterest";
            v[16].img = Image.FromFile("image39.png");
            v[16].m="Skype";
            v[17].img = Image.FromFile("image40.png");
            v[17].m="Snapchat";
            v[18].img = Image.FromFile("image41.png");
            v[18].m="Twitter";
            v[19].img = Image.FromFile("image42.png");
            v[19].m="Viber";
            v[20].img = Image.FromFile("image43.png");
            v[20].m="WhatsApp";
            v[21].img = Image.FromFile("image44.png");
            v[21].m="YahooMail";
            v[22].img = Image.FromFile("image45.png");
            v[22].m="Youtube";
            v[23].img = Image.FromFile("image46.png");
            v[23].m="Facebook";
            v[24].img = Image.FromFile("image47.png");
            v[24].m="Google+";

            restart();

            pictureBox1.BackColor = Color.Transparent;
            menuStrip1.BackColor = Color.Transparent;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Logo-ul cărei companii este ?")
            {
                textBox1.Text = string.Empty;
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = string.Empty;
                textBox1.Text = "Logo-ul cărei companii este ?";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                rr = true;
        }

        private void meniuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void ieșireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rr == true && textBox1.Text.ToLower() == v[ran].m.ToLower() && pictureBox1.Image == v[ran].img)
            {
                textBox1.Text = string.Empty;
                restart();
            }
        }


    }
    

}
