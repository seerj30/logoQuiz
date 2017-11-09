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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  //inchid jocul cand dau X
        }

        //fac background-ul de la buton1 transparent
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        //fac background-ul de la buton3 transparent
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        //fac scrisul de pe buton1 alb cand tin mouse-ul pe el
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        //fac scrisul de pe buton3 alb, cand tin mouse-ul pe el
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        //fac scrisul de pe buton1 inapoi negru, cand iau mouse-ul de pe el
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        //fac scrisul de pe buton3 inapoi negru, cand iau mouse-ul de pe el
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        //fac background-ul de la buton2 transparent
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        //fac background-ul de la buton4 transparent
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        //fac scrisul de pe buton2 alb, cand tin mouse-ul pe el
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        //fac scrisul de pe buton4 alb, cand tin mouse-ul pe el
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        //fac scrisul de pe buton2 inapoi negru, cand iau mouse-ul de pe el
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        //fac scrisul de pe buton4 inapoi negru, cand iau mouse-ul de pe el
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }

        //deschid form 3
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }


        //deschid form 4
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
