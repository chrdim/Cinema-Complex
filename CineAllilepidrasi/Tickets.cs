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
    public partial class Tickets : Form
    {
        public Tickets(string film)
        {
            InitializeComponent();
            label33.Text = film;
       
        }
        List<PictureBox> pictureBoxes3 = new List<PictureBox>();
        List<PictureBox> pictureBoxes2 = new List<PictureBox>();
        List<string> getTxtbuttons = new List<string>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        List<PictureBox> kratimenesTheseis = new List<PictureBox>();
        List<Label> theseis = new List<Label>();
        List<string> onomataThesewn = new List<string>();
        bool light = false;
        private void Tickets_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
              "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
              "</head><body>" +
              "<iframe width=\"1233\" height=\"467\" src=\"{0}\"" +
              "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
              "</body></html>";
            var url = "";
            if (label33.Text == "Birds of prey")
            {
                url= "https://www.youtube.com/embed/f15P5pyPmUc";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\a.png");
                label66.Text = "Cathy Yan";
                label67.Text = "Margot Robbie";
                
            }else if(label33.Text == "No time to die")
            {
                url = "https://www.youtube.com/embed/XCc-q2Ge7pc";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\b.jpg");
                label66.Text = "Cary Joji Fukunaga";
                label67.Text = "Daniel Craig";
            }
            else if (label33.Text == "1917")
            {
                 url = "https://www.youtube.com/embed/isMWZRftNT8";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\c.jpg");
                label66.Text = "Sam Mendes";
                label67.Text = "Daniel Mays,George MacKay,Andy Apollo";
            }
            else if (label33.Text == "Χαλβάη 5-0")
            {
                url = "https://www.youtube.com/embed/qQuGXVfDzJM";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\d.jpg");
                label66.Text = "Μάρκος Σεφερλής";
                label67.Text = "Μάρκος Σεφερλής,Έλενα Τσαβαλιά";
            }
            else if (label33.Text == "Wonder Woman 1984")
            {
                url = "https://www.youtube.com/embed/8RMPgP0HvrE";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\e.jpg");
                label66.Text = "Patty Jenkins";
                label67.Text = "Gal Gadot, Pedro Pascal, Chris Pine, Robin Wright";
            }
            else if (label33.Text == "Fast and Furious 9")
            {
                url = "https://www.youtube.com/embed/Kopyc23VfSw";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\f.jpg");
                label66.Text = "Justin Lin";
                label67.Text = "Vin Diesel,John Cena,Ludacris";
            }
            else if (label33.Text == "The Invisible Man")
            {
                url = "https://www.youtube.com/embed/pkFJmztJ81Y";
                pictureBox2.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\g.jpg");
                label66.Text = "Leigh Whannell";
                label67.Text = "Elisabeth Moss,Oliver Jackson-Cohen";

            }

            this.webBrowser1.DocumentText = string.Format(embed, url);

            label79.Text = label33.Text;

            panel11.Height = 0;
            pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");

            panel7.SendToBack();
            panel17.SendToBack();

            comboBoxes.Add(comboBox1);
            comboBoxes.Add(comboBox2);
            comboBoxes.Add(comboBox3);
            comboBoxes.Add(comboBox4);
            comboBoxes.Add(comboBox5);

            pictureBoxes.Add(A1);
            pictureBoxes.Add(A2);
            pictureBoxes.Add(A3);
            pictureBoxes.Add(A4);
            pictureBoxes.Add(A5);
            pictureBoxes.Add(A6);
            pictureBoxes.Add(A7);
            pictureBoxes.Add(A8);
            pictureBoxes.Add(A9);
            pictureBoxes.Add(A10);
            pictureBoxes.Add(A11);

            pictureBoxes.Add(B1);
            pictureBoxes.Add(B2);
            pictureBoxes.Add(B3);
            pictureBoxes.Add(B4);
            pictureBoxes.Add(B5);
            pictureBoxes.Add(B6);
            pictureBoxes.Add(B7);
            pictureBoxes.Add(B8);
            pictureBoxes.Add(B9);
            pictureBoxes.Add(B10);
            pictureBoxes.Add(B11);

            pictureBoxes.Add(C1);
            pictureBoxes.Add(C2);
            pictureBoxes.Add(C3);
            pictureBoxes.Add(C4);
            pictureBoxes.Add(C5);
            pictureBoxes.Add(C6);
            pictureBoxes.Add(C7);
            pictureBoxes.Add(C8);
            pictureBoxes.Add(C9);
            pictureBoxes.Add(C10);
            pictureBoxes.Add(C11);
            pictureBoxes.Add(C12);

            pictureBoxes.Add(D1);
            pictureBoxes.Add(D2);
            pictureBoxes.Add(D3);
            pictureBoxes.Add(D4);
            pictureBoxes.Add(D5);
            pictureBoxes.Add(D6);
            pictureBoxes.Add(D7);
            pictureBoxes.Add(D8);
            pictureBoxes.Add(D9);
            pictureBoxes.Add(D10);
            pictureBoxes.Add(D11);
            pictureBoxes.Add(D12);
            pictureBoxes.Add(D13);
            pictureBoxes.Add(D14);

            pictureBoxes.Add(E1);
            pictureBoxes.Add(E2);
            pictureBoxes.Add(E3);
            pictureBoxes.Add(E4);
            pictureBoxes.Add(E5);
            pictureBoxes.Add(E6);
            pictureBoxes.Add(E7);
            pictureBoxes.Add(E8);
            pictureBoxes.Add(E9);
            pictureBoxes.Add(E10);
            pictureBoxes.Add(E11);
            pictureBoxes.Add(E12);
            pictureBoxes.Add(E13);
            pictureBoxes.Add(E14);

            pictureBoxes.Add(F1);
            pictureBoxes.Add(F2);
            pictureBoxes.Add(F3);
            pictureBoxes.Add(F4);
            pictureBoxes.Add(F5);
            pictureBoxes.Add(F6);
            pictureBoxes.Add(F7);
            pictureBoxes.Add(F8);
            pictureBoxes.Add(F9);
            pictureBoxes.Add(F10);
            pictureBoxes.Add(F11);
            pictureBoxes.Add(F12);
            pictureBoxes.Add(F13);
            pictureBoxes.Add(F14);
            pictureBoxes.Add(F15);

            pictureBoxes.Add(G1);
            pictureBoxes.Add(G2);
            pictureBoxes.Add(G3);
            pictureBoxes.Add(G4);
            pictureBoxes.Add(G5);
            pictureBoxes.Add(G6);
            pictureBoxes.Add(G7);
            pictureBoxes.Add(G8);
            pictureBoxes.Add(G9);
            pictureBoxes.Add(G10);
            pictureBoxes.Add(G11);
            pictureBoxes.Add(G12);
            pictureBoxes.Add(G13);
            pictureBoxes.Add(G14);
            pictureBoxes.Add(G15);
            pictureBoxes.Add(G16);

            theseis.Add(label53);
            theseis.Add(label54);
            theseis.Add(label55);
            theseis.Add(label56);
            theseis.Add(label57);

            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\red-circle-icon-png-9.png");
            }
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Click += single_PictureBox_Click;
                pictureBoxes[i].DoubleClick += single_PictureBox_DoubleClick;
            }

            label58.Text = null;
            label59.Text = null;
            label60.Text = null;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (light == true)
            {
                this.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                button2.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                label27.ForeColor = Color.Black;
                label28.ForeColor = Color.Black;
                label24.ForeColor = Color.Black;
                label30.ForeColor = Color.Black;
                label29.ForeColor = Color.Black;
                label32.ForeColor = Color.Black;
                label31.ForeColor = Color.Black;
                label26.ForeColor = Color.Black;
                label22.ForeColor = Color.Black;
                label23.ForeColor = Color.Black;
                label25.ForeColor = Color.Black;
                textBox1.ForeColor = Color.Black;

                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button13.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button16.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                button18.ForeColor = Color.Black;
                button22.ForeColor = Color.Black;
                button23.ForeColor = Color.Black;
                button24.ForeColor = Color.Black;
                button25.ForeColor = Color.Black;
                button26.ForeColor = Color.Black;
                label51.ForeColor = Color.Black;
                label36.ForeColor = Color.Black;
                label37.ForeColor = Color.Black;
                label38.ForeColor = Color.Black;
                label39.ForeColor = Color.Black;
                label40.ForeColor = Color.Black;
                label41.ForeColor = Color.Black;
                label42.ForeColor = Color.Black;
                label44.ForeColor = Color.Black;
                label45.ForeColor = Color.Black;
                label47.ForeColor = Color.Black;
                label49.ForeColor = Color.Black;
                label52.ForeColor = Color.Black;
                button27.ForeColor = Color.Black;
                label53.ForeColor = Color.Black;
                label54.ForeColor = Color.Black;
                label55.ForeColor = Color.Black;
                label56.ForeColor = Color.Black;
                label57.ForeColor = Color.Black;
                label58.ForeColor = Color.Black;
                label59.ForeColor = Color.Black;
                label60.ForeColor = Color.Black;
                label61.ForeColor = Color.Black;
                button28.ForeColor = Color.Black;
                label62.ForeColor = Color.Black;
                label63.ForeColor = Color.Black;
                label79.ForeColor = Color.Black;
                label64.ForeColor = Color.Black;
                label65.ForeColor = Color.White;
                label66.ForeColor = Color.White;
                label67.ForeColor = Color.White;



                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");
                light = false;
            }
            else
            {
                this.BackColor = Color.White;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button2.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
                button6.ForeColor = Color.White;
                label27.ForeColor = Color.White;
                label28.ForeColor = Color.White;
                label24.ForeColor = Color.White;
                label30.ForeColor = Color.White;
                label29.ForeColor = Color.White;
                label32.ForeColor = Color.White;
                label31.ForeColor = Color.White;
                label26.ForeColor = Color.White;
                label22.ForeColor = Color.White;
                label23.ForeColor = Color.White;
                label25.ForeColor = Color.White;
                textBox1.ForeColor = Color.White;

                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                button7.ForeColor = Color.White;
                button8.ForeColor = Color.White;
                button9.ForeColor = Color.White;
                button10.ForeColor = Color.White;
                button11.ForeColor = Color.White;
                button12.ForeColor = Color.White;
                button13.ForeColor = Color.White;
                button14.ForeColor = Color.White;
                button15.ForeColor = Color.White;
                button16.ForeColor = Color.White;
                button17.ForeColor = Color.White;
                button18.ForeColor = Color.White;
                button22.ForeColor = Color.White;
                button23.ForeColor = Color.White;
                button24.ForeColor = Color.White;
                button25.ForeColor = Color.White;
                button26.ForeColor = Color.White;
                label51.ForeColor = Color.White;
                label36.ForeColor = Color.White;
                label37.ForeColor = Color.White;
                label38.ForeColor = Color.White;
                label39.ForeColor = Color.White;
                label40.ForeColor = Color.White;
                label41.ForeColor = Color.White;
                label42.ForeColor = Color.White;
                label44.ForeColor = Color.White;
                label45.ForeColor = Color.White;
                label47.ForeColor = Color.White;
                label49.ForeColor = Color.White;
                label52.ForeColor = Color.White;
                button27.ForeColor = Color.White;
                label53.ForeColor = Color.White;
                label54.ForeColor = Color.White;
                label55.ForeColor = Color.White;
                label56.ForeColor = Color.White;
                label57.ForeColor = Color.White;
                label58.ForeColor = Color.White;
                label59.ForeColor = Color.White;
                label60.ForeColor = Color.White;
                label61.ForeColor = Color.White;
                button28.ForeColor = Color.White;
                label62.ForeColor = Color.White;
                label63.ForeColor = Color.White;
                label79.ForeColor = Color.White;
                label64.ForeColor = Color.White;
                label65.ForeColor = Color.White;
                label66.ForeColor = Color.White;
                label67.ForeColor = Color.White;



                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\download.jpg");
                light = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel11.BringToFront();
            
            if (button6.Text == "<")
            {

                timer4.Start();
                button6.Text = ">";
                
            }
            else
            {

                timer4.Stop();
                timer5.Start();
                button6.Text = "<";

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel11.Height < 480)
            {
               
                panel11.Height += 20;
            }
            else
            {
                timer4.Stop();

            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            if (panel11.Height > 0)
            {
                
                panel11.Height -= 20;
            }
            else
            {
                timer5.Stop();
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.BringToFront();
            button1.BringToFront();
            if (button5.Text == "Αναζήτηση")
            {
                textBox1.Visible = true;
                button1.Visible = true;
                button5.Text = "X";
                

            }
            else
            {
                textBox1.Visible = false;
                button1.Visible = false;
                button5.Text = "Αναζήτηση";
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (label26.Text == "↓ Language")
            {
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label26.Text = "x Language";
            }
            else
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label26.Text = "↓ Language";
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

            if (label24.Text == "↓ Αίθουσες")
            {
                label30.Visible = true;
                label29.Visible = true;
                label32.Visible = true;
                label31.Visible = true;
                label24.Text = "x Αίθουσες";
            }
            else
            {
                label30.Visible = false;
                label29.Visible = false;
                label32.Visible = false;
                label31.Visible = false;
                label24.Text = "↓ Αίθουσες";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            button5.BackColor = Color.LightSlateGray;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button6.BackColor = Color.Black;
            }
            else
            {
                button6.BackColor = Color.White;




            }
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightSlateGray;
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

        private void label26_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label26.ForeColor = Color.Black;

            }
            else
            {
                label26.ForeColor = Color.White;

            }

        }

        private void label26_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label26.ForeColor = Color.White;

            }
            else
            {
                label26.ForeColor = Color.Black;

            }
        }

        private void label27_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label27.ForeColor = Color.Black;

            }
            else
            {
                label27.ForeColor = Color.White;

            }
        }

        private void label27_MouseLeave(object sender, EventArgs e)
        {

            if (light == true)
            {
                label27.ForeColor = Color.White;

            }
            else
            {
                label27.ForeColor = Color.Black;

            }
        }

        private void label22_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label22.ForeColor = Color.Black;

            }
            else
            {
                label22.ForeColor = Color.White;

            }
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {

            if (light == true)
            {
                label22.ForeColor = Color.White;

            }
            else
            {
                label22.ForeColor = Color.Black;

            }
        }

        private void label28_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label28.ForeColor = Color.Black;

            }
            else
            {
                label28.ForeColor = Color.White;

            }
        }

        private void label28_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label28.ForeColor = Color.White;

            }
            else
            {
                label28.ForeColor = Color.Black;

            }
        }

        private void label23_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label23.ForeColor = Color.Black;

            }
            else
            {
                label23.ForeColor = Color.White;

            }
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {

            if (light == true)
            {
                label23.ForeColor = Color.White;

            }
            else
            {
                label23.ForeColor = Color.Black;

            }
        }

        private void label24_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label24.ForeColor = Color.Black;

            }
            else
            {
                label24.ForeColor = Color.White;

            }
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {

            if (light == true)
            {
                label24.ForeColor = Color.White;

            }
            else
            {
                label24.ForeColor = Color.Black;

            }
        }

        private void label30_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label30.ForeColor = Color.Black;

            }
            else
            {
                label30.ForeColor = Color.White;

            }
        }

        private void label30_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label30.ForeColor = Color.White;

            }
            else
            {
                label30.ForeColor = Color.Black;

            }
        }

        private void label29_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label29.ForeColor = Color.Black;

            }
            else
            {
                label29.ForeColor = Color.White;

            }
        }

        private void label29_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label29.ForeColor = Color.White;

            }
            else
            {
                label29.ForeColor = Color.Black;

            }
        }

        private void label32_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label32.ForeColor = Color.Black;

            }
            else
            {
                label32.ForeColor = Color.White;

            }
        }

        private void label32_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label32.ForeColor = Color.White;

            }
            else
            {
                label32.ForeColor = Color.Black;

            }
        }

        private void label31_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label31.ForeColor = Color.Black;

            }
            else
            {
                label31.ForeColor = Color.White;

            }
        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label31.ForeColor = Color.White;

            }
            else
            {
                label31.ForeColor = Color.Black;

            }
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label25.ForeColor = Color.Black;

            }
            else
            {
                label25.ForeColor = Color.White;

            }
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label25.ForeColor = Color.White;

            }
            else
            {
                label25.ForeColor = Color.Black;

            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button7.BackColor = Color.Black;

            }
            else
            {
                button7.BackColor = Color.White;

            }
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightSlateGray;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button8.BackColor = Color.Black;

            }
            else
            {
                button8.BackColor = Color.White;

            }

        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightSlateGray;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button9.BackColor = Color.Black;

            }
            else
            {
                button9.BackColor = Color.White;

            }
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightSlateGray;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button10.BackColor = Color.Black;

            }
            else
            {
                button10.BackColor = Color.White;

            }
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightSlateGray;
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button11.BackColor = Color.Black;

            }
            else
            {
                button11.BackColor = Color.White;

            }
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightSlateGray;
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button12.BackColor = Color.Black;

            }
            else
            {
                button12.BackColor = Color.White;

            }
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightSlateGray;
        }
       
        private void button18_MouseHover(object sender, EventArgs e)
        {
            panel21.Visible = true;
            if (light == true)
            {
                button18.BackColor = Color.Black;

            }
            else
            {
                button18.BackColor = Color.White;

            }

        }

        private void button18_MouseLeave(object sender, EventArgs e)
        {
            panel21.Visible = false;
            button18.BackColor = Color.OliveDrab;
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            panel22.Visible = true;
            if (light == true)
            {
                button16.BackColor = Color.Black;

            }
            else
            {
                button16.BackColor = Color.White;

            }
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            panel22.Visible = false;
            button16.BackColor = Color.Goldenrod;
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            panel23.Visible = true;
            if (light == true)
            {
                button14.BackColor = Color.Black;

            }
            else
            {
                button14.BackColor = Color.White;

            }
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.BackColor = Color.OliveDrab;
            panel23.Visible = false;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            panel24.Visible = true;
            if (light == true)
            {
                button13.BackColor = Color.Black;

            }
            else
            {
                button13.BackColor = Color.White;

            }
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            panel24.Visible = false;
            button13.BackColor = Color.Goldenrod;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button22_MouseHover(object sender, EventArgs e)
        {

            if (light == true)
            {
                button22.BackColor = Color.Black;

            }
            else
            {
                button22.BackColor = Color.White;

            }
        }

        private void button22_MouseLeave(object sender, EventArgs e)
        {
            button22.BackColor = Color.DimGray;
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            panel27.Visible = true;
            if (light == true)
            {
                button23.BackColor = Color.Black;

            }
            else
            {
                button23.BackColor = Color.White;

            }
        }

        private void button23_MouseLeave(object sender, EventArgs e)
        {
            panel27.Visible = false;
            button23.BackColor = Color.DimGray;
        }

        private void button24_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button24.BackColor = Color.Black;

            }
            else
            {
                button24.BackColor = Color.White;

            }
        }

        private void button24_MouseLeave(object sender, EventArgs e)
        {
            button24.BackColor = Color.DimGray;
        }

        private void button25_MouseHover(object sender, EventArgs e)
        {
            panel28.Visible = true;
            if (light == true)
            {
                button25.BackColor = Color.Black;

            }
            else
            {
                button25.BackColor = Color.White;

            }
        }

        private void button25_MouseLeave(object sender, EventArgs e)
        {
            panel28.Visible = false;
            button25.BackColor = Color.DimGray;
        }

        private void button26_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button26.BackColor = Color.Black;

            }
            else
            {
                button26.BackColor = Color.White;

            }
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            button26.BackColor = Color.DimGray;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            label58.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            label58.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            label58.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            label58.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            label58.Text = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            label58.Text = button12.Text;
        }
        
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        Button lastClicked;

        private void button18_Click(object sender, EventArgs e)
        {
            panel25.Visible = false;
            button22.Visible = true;
            lastClicked = button18;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel25.Visible = false;
            button22.Visible = true;
            lastClicked = button16;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel25.Visible = false;
            button22.Visible = true;
            lastClicked = button14;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button22.Visible = true;
            lastClicked = button13;
            panel25.Visible = false;

        }
        
        private void button22_Click(object sender, EventArgs e)
        {
            
            if (lastClicked == null)
            {
                panel25.Visible = true;
            }
            else if(lastClicked==button18)
            {
                panel7.BringToFront();
                label59.Text = "14:40";
                label60.Text = "premium1";
                
                for(int i = 10; i < 14; i++)
                {
                    pictureBoxes[i].Image= Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 30; i < 34; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i =70; i < 76; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
            }
            else if (lastClicked == button14)
            {
                label59.Text = "22:40";
                label60.Text = "low cost";
                panel7.BringToFront();
                for (int i = 1; i < 4; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 50; i < 54; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 80; i < 86; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
            }
            else if (lastClicked == button16)
            {
                label59.Text = "20:30";
                label60.Text = "normal cost";
                panel7.BringToFront();

                for (int i = 1; i < 30; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 70; i < 90; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 40; i < 64; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
            }
            else if (lastClicked == button13)
            {
                label59.Text = "1:00";
                label60.Text = "normal cost";
                panel7.BringToFront();
                for (int i = 1; i < 30; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 30; i <50 ; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
                for (int i = 50; i < 84; i++)
                {
                    pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\black-circle.png");
                    pictureBoxes[i].Enabled = false;
                }
            }
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel25.Visible = false;
        }
        int ticketCount = 0;
        private void button23_Click(object sender, EventArgs e)
        {
           
            panel5.Visible = false;
            panel2.BringToFront();
            lastClicked = null;
            for(int i = 0; i < 93; i++)
            {
                pictureBoxes[i].Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\red-circle-icon-png-9.png");
                pictureBoxes[i].Enabled = true;
            }
            ticketCount = 0;
            kratimenesTheseis.Clear();
            
            onomataThesewn.Clear();
        }
        
        private void button24_Click(object sender, EventArgs e)
        {
            if (ticketCount > 5)
            {
                panel26.Visible = true;
            }
            else if (ticketCount >= 1 && ticketCount <= 5)
            {
                panel17.BringToFront();
                if (label60.Text == "premium1" || label60.Text == "premium2")
                {
                    for (int i = 0; i < kratimenesTheseis.Count; i++)
                    {
                        comboBoxes[i].Items.Add("Ενήλικος→20€");
                        comboBoxes[i].Items.Add("Φοιτητής→15€");
                        comboBoxes[i].Items.Add("Ανήλικος→13€");
                        comboBoxes[i].Visible = true;
                        comboBoxes[i].SelectedIndex = comboBoxes[i].FindStringExact("Ενήλικος→20€");
                        theseis[i].Visible = true;
                        theseis[i].Text = onomataThesewn[i];
                    }
                }
            
            else if (label60.Text == "normal cost")
            {
                for (int i = 0; i < kratimenesTheseis.Count; i++)
                {
                    comboBoxes[i].Items.Add("Ενήλικος→15€");
                    comboBoxes[i].Items.Add("Φοιτητής→10€");
                    comboBoxes[i].Items.Add("Ανήλικος→8€");
                    comboBoxes[i].Visible = true;
                    comboBoxes[i].SelectedIndex = comboBoxes[i].FindStringExact("Ενήλικος→15€");
                    theseis[i].Visible = true;
                    theseis[i].Text = onomataThesewn[i];
                }
            }
            else if (label60.Text == "low cost")
            {
                for (int i = 0; i < kratimenesTheseis.Count; i++)
                {
                    comboBoxes[i].Items.Add("Ενήλικος→10€");
                    comboBoxes[i].Items.Add("Φοιτητής→8€");
                    comboBoxes[i].Items.Add("Ανήλικος→5€");
                    comboBoxes[i].Visible = true;
                    comboBoxes[i].SelectedIndex = comboBoxes[i].FindStringExact("Ενήλικος→10€");
                    theseis[i].Visible = true;
                    theseis[i].Text = onomataThesewn[i];

                }
            }
                

            }
        }
        
        
         private void single_PictureBox_Click(object sender, EventArgs e)
        {

            
            PictureBox pb = (PictureBox)sender;
            if (!pictureBoxes2.Contains(pb))
            {
                pb.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\tickett.png");
                ticketCount++;
               
                kratimenesTheseis.Add(pb);
                onomataThesewn.Add(pb.Name);
                pictureBoxes2.Add(pb);
                if (pictureBoxes3.Contains(pb))
                {
                    pictureBoxes3.Remove(pb);
                }
                
            }
            
            
        }
       

        private void F1_Click(object sender, EventArgs e)
        {
          
        }

        private void single_PictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (!pictureBoxes3.Contains(pb))
            {
                pb.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\red-circle-icon-png-9.png");
                ticketCount--;
               
                kratimenesTheseis.Remove(pb);
                onomataThesewn.Remove(pb.Name);
                pictureBoxes3.Add(pb);
                pictureBoxes2.Remove(pb);
            }
            }

        private void button28_Click(object sender, EventArgs e)
        {
            panel26.Visible = false;
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel7.BringToFront();
            for(int i = 0; i < kratimenesTheseis.Count; i++)
            {
                
                comboBoxes[i].Items.Clear();
                theseis[i].Visible = false;
                comboBoxes[i].Visible = false;
            }
        }
        double sumTickets;
        
        private void button26_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< ticketCount; i++)
            {

                Object selectedItem = comboBoxes[i].SelectedItem;

                if (selectedItem.ToString()== "Ενήλικος→10€" || selectedItem.ToString() == "Φοιτητής→10€")
                {
                    sumTickets += 10.0;
                }else if (selectedItem.ToString() == "Ανήλικος→8€" || selectedItem.ToString() == "Φοιτητής→8€")
                {
                    sumTickets += 8.0;
                }else if (selectedItem.ToString() == "Ανήλικος→5€")
                {
                    sumTickets += 5.0;
                }else if (selectedItem.ToString() == "Ενήλικος→15€" || selectedItem.ToString() == "Φοιτητής→15€")
                {
                    sumTickets += 15.0;
                }
                else if (selectedItem.ToString() == "Ενήλικος→20€")
                {
                    sumTickets += 20.0;
                }
                else if (selectedItem.ToString() == "Ανήλικος→13€")
                {
                    sumTickets += 13.0;
                }
            }

            E_bar E1 = new E_bar(sumTickets,label33.Text);
            this.Hide();
            E1.ShowDialog();
            

        }

        private void button29_MouseHover(object sender, EventArgs e)
        {

            if (light == true)
            {
                button29.BackColor = Color.Black;
            }
            else
            {
                button29.BackColor = Color.White;
            }
        }

        private void button29_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                button29.BackColor = Color.White;
            }
            else
            {
                button29.BackColor = Color.Black;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            this.Hide();
            M.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Wonder Woman 1984")
            {
                Tickets T = new Tickets("Wonder Woman 1984");
                this.Hide();
                T.ShowDialog();
                
            }
            else if (textBox1.Text == "Birds of prey")
            {
                Tickets T = new Tickets("Birds of prey");
                this.Hide();
                T.ShowDialog();
                
            }
            else if (textBox1.Text == "No time to die")
            {
                Tickets T = new Tickets("No time to die");
                this.Hide();
                T.ShowDialog();
                
            }
            else if (textBox1.Text == "1917")
            {
                Tickets T = new Tickets("1917");
                this.Hide();
                T.ShowDialog();
               
            }
            else if (textBox1.Text == "Χαλβάη 5-0")
            {
                Tickets T = new Tickets("Χαλβάη 5-0");
                this.Hide();
                T.ShowDialog();
                
            }
            else if (textBox1.Text == "Fast and Furious 9")
            {
                Tickets T = new Tickets("Fast and Furious 9");
                this.Hide();
                T.ShowDialog();
                
            }
            else if (textBox1.Text == "The Invisible Man")
            {
                Tickets T = new Tickets("The Invisible Man");
                this.Hide();
                T.ShowDialog();
               
            }
        }

        private void button30_MouseHover(object sender, EventArgs e)
        {
            button30.ForeColor = Color.Green;

        }

        private void button30_MouseLeave(object sender, EventArgs e)
        {
            button30.ForeColor = Color.Black;
        }

        private void button31_MouseHover(object sender, EventArgs e)
        {
            button31.ForeColor = Color.Green;
        }

        private void button31_MouseLeave(object sender, EventArgs e)
        {
            button31.ForeColor = Color.Black;

        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel30.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel30.Visible = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel32.Visible = true;
            panel33.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel32.Visible = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            panel33.Visible = false;
            
        }
    }
}
