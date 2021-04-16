using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineAllilepidrasi
{
    public partial class Card : Form
    {
        public Card(double sumTickets,string film)
        {
            InitializeComponent();
            label4.Text = sumTickets.ToString();
            label5.Text = film;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool light = false;
        bool panel2Front = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (light == true)
            {
                this.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                button4.ForeColor = Color.Black;
                label79.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
                textBox3.ForeColor = Color.Black;
                textBox4.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;

                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");
                light = false;
            }
            else
            {
                this.BackColor = Color.White;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.White;
                label79.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
                textBox3.ForeColor = Color.White;
                textBox4.ForeColor = Color.White;

                label8.ForeColor = Color.White;
                button1.ForeColor = Color.White;
                button2.ForeColor = Color.White;

                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\download.jpg");
                light = true;
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button3.BackColor = Color.White;
            }
            else
            {
                button3.BackColor = Color.Black;
            }
            button3.ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                button3.ForeColor = Color.Black;
            }
            else
            {
                button3.ForeColor = Color.White;
            }

        }

        private void Card_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");
            panel2.SendToBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                panel28.Visible = true;
               

            }
            else
            {
                panel2.BringToFront();
                panel2Front = true;
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {

            if (light == true)
            {
                button4.BackColor = Color.Black;
            }
            else
            {
                button4.BackColor = Color.White;
            }
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightSlateGray;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            if (light == true)
            {
                button1.BackColor = Color.Black;
            }
            else
            {
                button1.BackColor = Color.White;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSlateGray;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button2.BackColor = Color.Black;
            }
            else
            {
                button2.BackColor = Color.White;
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightSlateGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            this.Hide();
            M.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            panel28.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel28.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            panel28.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            panel28.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button5.BackColor = Color.Black;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                button5.BackColor = Color.White;
            }
            else
            {
                button5.BackColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panel2Front == true)
            {
                Menu M = new Menu();
                this.Hide();
                M.ShowDialog();
            }
            else
            {
                E_bar E = new E_bar(double.Parse(label4.Text),label5.Text);
                this.Hide();
                E.ShowDialog();
                
            }
        }
    }
}