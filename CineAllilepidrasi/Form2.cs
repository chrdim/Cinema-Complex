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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       
        bool light = false;
        List<Label> Toplebels = new List<Label>();
        List<Image> posters = new List<Image>();
        List<PictureBox> boxes = new List<PictureBox>();

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
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (light == true)
            {
                this.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;

                button11.ForeColor = Color.White;
                button2.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label20.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                textBox1.ForeColor = Color.Black;
                textBox2.ForeColor = Color.Black;
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


                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");
                light = false;
            }
            else if(light==false)
            {
                this.BackColor = Color.White;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button2.ForeColor = Color.White;
                button4.ForeColor = Color.White;
                button5.ForeColor = Color.White;
                button6.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label20.ForeColor = Color.White;
                label21.ForeColor = Color.White;
                textBox1.ForeColor = Color.White;
                textBox2.ForeColor = Color.White;
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

                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\download.jpg");
                light = true;
            }
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            panel11.Height = 0;
            timer3.Start();
            var embed = "<html><head>" +
              "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
              "</head><body>" +
              "<iframe width=\"1025\" height=\"450\" src=\"{0}\"" +
              "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
              "</body></html>";
            var url = "https://www.youtube.com/embed/isMWZRftNT8";
            this.webBrowser1.DocumentText = string.Format(embed, url);


            pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");

            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\a.png"));
            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\b.jpg"));
            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\c.jpg"));
            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\d.jpg"));
            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\e.jpg"));
            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\f.jpg"));
            posters.Add(Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\g.jpg"));



            boxes.Add(p1);
            boxes.Add(p2);
            boxes.Add(p3);
            boxes.Add(p4);

            p1.Image = posters[0];
            p2.Image = posters[1];
            p3.Image = posters[2];
            p4.Image = posters[3];


            Toplebels.Add(label33);
            Toplebels.Add(label34);
            Toplebels.Add(label35);
            Toplebels.Add(label36);

            timer1.Start();
            timer2.Start();



              
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
        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter <= 2)
            {
                for (int i = 0; i < boxes.Count; i++)
                {

                    boxes[i].Image = posters[i + counter + 1];
                }
                counter++;
            }
            else if(counter<=3)
            {
                boxes[0].Image = posters[4];
                boxes[1].Image = posters[5];
                boxes[2].Image = posters[6];
                boxes[3].Image = posters[0];
                counter++;
            }
            else if(counter<=4)
            {
                boxes[0].Image = posters[5];
                boxes[1].Image = posters[6];
                boxes[2].Image = posters[0];
                boxes[3].Image = posters[1];
                counter++;
            }
            else if (counter <= 5)
            {
                boxes[0].Image = posters[6];
                boxes[1].Image = posters[0];
                boxes[2].Image = posters[1];
                boxes[3].Image = posters[2];
                counter++;
            }
            else if (counter <= 6)
            {
                boxes[0].Image = posters[0];
                boxes[1].Image = posters[1];
                boxes[2].Image = posters[2];
                boxes[3].Image = posters[3];
                counter++;
            }
            else
            {
                counter = 0;
            }

            for(int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].Image == posters[0])
                {
                    Toplebels[i].Text = "Birds of prey";
                }
                else if (boxes[i].Image == posters[1])
                {
                    Toplebels[i].Text = "No time to die";
                }
                else if (boxes[i].Image == posters[2])
                {
                    Toplebels[i].Text = "1917";
                }
                else if (boxes[i].Image == posters[3])
                {
                    Toplebels[i].Text = "Χαλβάη 5-0";
                }
                else if (boxes[i].Image == posters[4])
                {
                    Toplebels[i].Text = "Wonder Woman 1984";
                }
                else if (boxes[i].Image == posters[5])
                {
                    Toplebels[i].Text = "Fast and Furious 9";
                }
                else if (boxes[i].Image == posters[6])
                {
                    Toplebels[i].Text = "The Invisible Man";
                }
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
            else
            {
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
            else
            {
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            else
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
            else
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
            else
            {
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
            }
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
            }
            else
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
            else
            {
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
            else
            {
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
            else
            {
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
            }
            else
            {
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
            }
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            else
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
            else
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
            else
            {
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
            }
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
            }
            else
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
            else
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
            }
            else
            {
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
            }
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
            }
            else
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            }
            else
            {
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
            }
        }
        int x = 255;
        int y = 255;
        int z = 255;
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();



            label10.ForeColor = Color.FromArgb(rand.Next(0, x + 1), rand.Next(0, y + 1), rand.Next(0, z + 1));
            label11.ForeColor = Color.FromArgb(rand.Next(0, x -1), rand.Next(0, y -1), rand.Next(0, z - 1));
            label12.ForeColor = Color.FromArgb(rand.Next(0, x), rand.Next(0, y ), rand.Next(0, z ));
            label13.ForeColor = Color.FromArgb(rand.Next(0, x -2), rand.Next(0, y ), rand.Next(0, z + 1));
            label14.ForeColor = Color.FromArgb(rand.Next(0, x - 1), rand.Next(0, y - 1), rand.Next(0, z - 1));
            label15.ForeColor = Color.FromArgb(rand.Next(0, x ), rand.Next(0, y + 1), rand.Next(0, z ));
            label16.ForeColor = Color.FromArgb(rand.Next(0, x + 0), rand.Next(0, y + 1), rand.Next(0, z +0));
            label17.ForeColor = Color.FromArgb(rand.Next(0, x -1), rand.Next(0, y +1), rand.Next(0, z ));
            label18.ForeColor = Color.FromArgb(rand.Next(0, x -2), rand.Next(0, y -2), rand.Next(0, z -2));
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
           
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        int timeCounter=1;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((timeCounter % 2) == 0)
            {
                panel8.Show();
            }
            else
            {
                panel8.Hide();
            }
            timeCounter++;
        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
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

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\fb.png");
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\fb-Black.png");
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\insta.png");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\insta-black.png");
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\twitter.png");
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"C:\Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\twitterBlack.png");
        }
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text =="<") {
               
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
            if (panel11.Height < 500)
            {
                if (panel11.Height == 400)
                {
                    button10.Visible = false;
                }
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
                if (panel11.Height == 420)
                {
                    button10.Visible = true;
                }
                panel11.Height -= 20;
            }
            else
            {
                timer5.Stop();
               
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            if(label26.Text=="↓ Language")
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
            if(label24.Text=="↓ Αίθουσες")
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

        private void label27_Click(object sender, EventArgs e)
        {

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

        private void button14_Click(object sender, EventArgs e)
        {

        }

        

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.Gold;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.Gold;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.Gold;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.White;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.Gold;
        }
        string film;
        private void button7_Click(object sender, EventArgs e)
        {
            if (p1.Image == posters[0])
            {
                film = "Birds of prey";
            }
            else if (p1.Image == posters[1])
            {
                film = "No time to die";
            }
            else if (p1.Image == posters[2])
            {
                film = "1917";
            }
            else if (p1.Image == posters[3])
            {
                film = "Χαλβάη 5-0";
            }
            else if (p1.Image == posters[4])
            {
                film = "Wonder Woman 1984";
            }
            else if (p1.Image == posters[5])
            {
                film = "Fast and Furious 9";
            }
            else if (p1.Image == posters[6])
            {
                film = "The Invisible Man";
            }

            Tickets T1 = new Tickets(film);
            this.Hide();
            T1.ShowDialog();
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p2.Image == posters[0])
            {
                film = "Birds of prey";
            }
            else if (p2.Image == posters[1])
            {
                film = "No time to die";
            }
            else if (p2.Image == posters[2])
            {
                film = "1917";
            }
            else if (p2.Image == posters[3])
            {
                film = "Χαλβάη 5-0";
            }
            else if (p2.Image == posters[4])
            {
                film = "Wonder Woman 1984";
            }
            else if (p2.Image == posters[5])
            {
                film = "Fast and Furious 9";
            }
            else if (p2.Image == posters[6])
            {
                film = "The Invisible Man";
            }
            Tickets T1 = new Tickets(film);
            this.Hide();
            T1.ShowDialog();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (p3.Image == posters[0])
            {
                film = "Birds of prey";
            }
            else if (p3.Image == posters[1])
            {
                film = "No time to die";
            }
            else if (p3.Image == posters[2])
            {
                film = "1917";
            }
            else if (p3.Image == posters[3])
            {
                film = "Χαλβάη 5-0";
            }
            else if (p3.Image == posters[4])
            {
                film = "Wonder Woman 1984";
            }
            else if (p3.Image == posters[5])
            {
                film = "Fast and Furious 9";
            }
            else if (p3.Image == posters[6])
            {
                film = "The Invisible Man";
            }
            Tickets T1 = new Tickets(film);
            this.Hide();
            T1.ShowDialog();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (p4.Image == posters[0])
            {
                film = "Birds of prey";
            }
            else if (p4.Image == posters[1])
            {
                film = "No time to die";
            }
            else if (p4.Image == posters[2])
            {
                film = "1917";
            }
            else if (p4.Image == posters[3])
            {
                film = "Χαλβάη 5-0";
            }
            else if (p4.Image == posters[4])
            {
                film = "Wonder Woman 1984";
            }
            else if (p4.Image == posters[5])
            {
                film = "Fast and Furious 9";
            }
            else if (p4.Image == posters[6])
            {
                film = "The Invisible Man";
            }
            Tickets T1 = new Tickets(film);
            this.Hide();
            T1.ShowDialog();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="Wonder Woman 1984")
            {
                Tickets T = new Tickets("Wonder Woman 1984");
                this.Hide();
                T.ShowDialog();
                
            }else if (textBox1.Text == "Birds of prey")
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            
            button11.ForeColor = Color.Green;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                button11.ForeColor = Color.Black;
            }
            else
            {
                button11.ForeColor = Color.White;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
            panel13.Visible = true;
            panel14.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            panel14.Visible = false;
        }
    }
}
