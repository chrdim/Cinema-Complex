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
    public partial class WelcomeForm : Form
    {
        
        public WelcomeForm()
        {
            InitializeComponent();
            timer1.Start();

            



        }
        List<string> letters = new List<string>();
        List<string> letters2 = new List<string>();
        int[] targetColor = { 184,134,11 };
        int[] fadeRGB = new int[3];

        private void timer1_Tick(object sender, EventArgs e)
        {
            fadeIn();
            
        }
        void fadeIn()
        {
            fadeRGB[0] = label1.ForeColor.R;
            fadeRGB[1] = label1.ForeColor.G;
            fadeRGB[2] = label1.ForeColor.B;

            if (fadeRGB[0] > this.targetColor[0])
                fadeRGB[0]--;
            else if (fadeRGB[0] < targetColor[0])
                fadeRGB[0]++;
            if (fadeRGB[1] > targetColor[1])
                fadeRGB[1]--;
            else if (fadeRGB[1] < targetColor[1])
                fadeRGB[1]++;
            if (fadeRGB[2] > targetColor[2])
                fadeRGB[2]--;
            else if (fadeRGB[2] < targetColor[2])
                fadeRGB[2]++;

            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == targetColor[1] && fadeRGB[2] == targetColor[2])
            {
                timer1.Stop();
                timer2.Start();
                
            }
               
           

            label1.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
            
            

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);

            letters.Add("Π");
            letters.Add("α");
            letters.Add("ρ");
            letters.Add("α");
            letters.Add("κ");
            letters.Add("α");
            letters.Add("λ");
            letters.Add("ο");
            letters.Add("ύ");
            letters.Add("μ");
            letters.Add("ε");
            letters.Add(" ");
            letters.Add("ε");
            letters.Add("π");
            letters.Add("ι");
            letters.Add("λ");
            letters.Add("έ");
            letters.Add("ξ");
            letters.Add("τ");
            letters.Add("ε");
            letters.Add(" ");
            letters.Add("ι");
            letters.Add("δ");
            letters.Add("ι");
            letters.Add("ό");
            letters.Add("τ");
            letters.Add("η");
            letters.Add("τ");
            letters.Add("α");

            letters2.Add("C");
            letters2.Add("i");
            letters2.Add("n");
            letters2.Add("e");
            letters2.Add("X");
            letters2.Add("r");
            letters2.Add("i");
            letters2.Add("s");
            letters2.Add("t");
            

            button1.Visible = false;
            button2.Visible = false;

            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            panel1.Visible = false;
            panel2.Visible = false;


            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\Users\xrist\OneDrive\Υπολογιστής\Som do Click do Mouse - Efeito Sonoro.mp3";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text.ToString().Length >= 1)
            {
               label1.Text= label1.Text.Substring(0, label1.Text.ToString().Length - 1);
            }
            else
            {
                timer3.Start();
                timer2.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }


        int counter = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
                if(counter==0)
                {
                    label3.Visible = true;

                }else if (counter ==5 )
                {
                    pictureBox2.Visible = true;
                }
                else if (counter == 10)
                {
                    label4.Visible = true;
                }else if (counter == 15)
                {
                   pictureBox4.Visible = true;
                }else if (counter == 20)
                {
                    label5.Visible = true;
                }
                else if (counter == 25)
                {
                    pictureBox3.Visible = true; 
                }
            else if (counter == 35)
            {
                panel1.Visible = true;
                timer5.Start();
                timer3.Stop();
            }
            counter++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        int counter2 = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (counter2 < letters.Count)
            {
                label1.Text = label1.Text + letters[counter2];
                counter2++;
                
            }
            else
            {
                timer4.Stop();
                button1.Visible = true;
                button2.Visible = true;
            }

        }
        int counter3;
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (counter3 < letters2.Count)
            {
                label2.Text = label2.Text + letters2[counter3];


            }
            else
            {
                panel2.Visible = true;
                timer5.Stop();
                timer6.Start();

            }
            
            counter3++;

        }
        int counter4=0;
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (counter4 == 3)
            {
                timer6.Stop();
                timer4.Start();
            }
            counter4++;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkMagenta;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkMagenta;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DimGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Sienna;
        }


        
       
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            Menu F = new Menu();
            this.Hide();
            F.ShowDialog();
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             WorkerForm F = new WorkerForm();
            this.Hide();
            F.ShowDialog();
        }
    }
}
