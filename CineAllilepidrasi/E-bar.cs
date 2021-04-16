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
    public partial class E_bar : Form
    {
        public E_bar(double sumTickets,string film)
        {
            InitializeComponent();
            label53.Text = sumTickets.ToString();
            label54.Text = film;

        }

        private void E_bar_Load(object sender, EventArgs e)
        {
            label16.Text = label53.Text;
            panel7.Height = 0;
            timer1.Start();
            panel11.Height = 0;
            pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");
        }
        bool light = false;
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
                label2.ForeColor = Color.Black;
                pictureBox1.Image = Image.FromFile(@"C: \Users\xrist\source\repos\CineAllilepidrasi\CineAllilepidrasi\rr.png");
                light = false;

                label4.ForeColor = Color.Pink;
                label5.ForeColor = Color.Pink;
                label8.ForeColor = Color.Pink;
                label7.ForeColor = Color.Pink;
                label11.ForeColor = Color.Pink;
                label10.ForeColor = Color.Pink;
                label14.ForeColor = Color.Pink;
                label13.ForeColor = Color.Pink;

                button7.ForeColor = Color.White;
                button7.BackColor = Color.Black;
                button8.ForeColor = Color.Black;

                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;

                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label20.ForeColor = Color.Black;
                label34.ForeColor = Color.Black;
                label33.ForeColor = Color.Black;
                label21.ForeColor = Color.Black;
                label37.ForeColor = Color.Black;
                label36.ForeColor = Color.Black;
                label35.ForeColor = Color.Black;
                label40.ForeColor = Color.Black;
                label39.ForeColor = Color.Black;
                label38.ForeColor = Color.Black;
                label43.ForeColor = Color.Black;
                label42.ForeColor = Color.Black;
                label41.ForeColor = Color.Black;
                label45.ForeColor = Color.Black;
                label44.ForeColor = Color.Black;
                label46.ForeColor = Color.Black;
                label49.ForeColor = Color.Black;
                label48.ForeColor = Color.Black;
                label47.ForeColor = Color.Black;
                label52.ForeColor = Color.Black;
                label51.ForeColor = Color.Black;
                label50.ForeColor = Color.Black;

                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button13.ForeColor = Color.Black;
                button16.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button18.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                button20.ForeColor = Color.Black;
                button19.ForeColor = Color.Black;
                button22.ForeColor = Color.Black;
                button21.ForeColor = Color.Black;
                button24.ForeColor = Color.Black;
                button23.ForeColor = Color.Black;

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
                label2.ForeColor = Color.White;

                label4.ForeColor = Color.DarkViolet;
                label5.ForeColor = Color.DarkViolet;
                label8.ForeColor = Color.DarkViolet;
                label7.ForeColor = Color.DarkViolet;
                label11.ForeColor = Color.DarkViolet;
                label10.ForeColor = Color.DarkViolet;
                label14.ForeColor = Color.DarkViolet;
                label13.ForeColor = Color.DarkViolet;

                button7.ForeColor = Color.Black;
                button7.BackColor = Color.White;
                button8.ForeColor = Color.White;

                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;

                label18.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label20.ForeColor = Color.White;
                label34.ForeColor = Color.White;
                label33.ForeColor = Color.White;
                label21.ForeColor = Color.White;
                label37.ForeColor = Color.White;
                label36.ForeColor = Color.White;
                label35.ForeColor = Color.White;
                label40.ForeColor = Color.White;
                label39.ForeColor = Color.White;
                label38.ForeColor = Color.White;
                label43.ForeColor = Color.White;
                label42.ForeColor = Color.White;
                label41.ForeColor = Color.White;
                label45.ForeColor = Color.White;
                label44.ForeColor = Color.White;
                label46.ForeColor = Color.White;
                label49.ForeColor = Color.White;
                label48.ForeColor = Color.White;
                label47.ForeColor = Color.White;
                label52.ForeColor = Color.White;
                label51.ForeColor = Color.White;
                label50.ForeColor = Color.White;

                button9.ForeColor = Color.White;
                button10.ForeColor = Color.White;
                button12.ForeColor = Color.White;
                button11.ForeColor = Color.White;
                button14.ForeColor = Color.White;
                button13.ForeColor = Color.White;
                button16.ForeColor = Color.White;
                button15.ForeColor = Color.White;
                button18.ForeColor = Color.White;
                button17.ForeColor = Color.White;
                button20.ForeColor = Color.White;
                button19.ForeColor = Color.White;
                button22.ForeColor = Color.White;
                button21.ForeColor = Color.White;
                button24.ForeColor = Color.White;
                button23.ForeColor = Color.White;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label2.Text=="CineXrist e-bar")
            {
                label2.Text = "Skip the line save your time";
                label2.Location = new Point(300,15);

            }
            else
            {
                label2.Text = "CineXrist e-bar";
                label2.Location = new Point(400, 15);
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button7.BackColor = Color.DarkViolet;
            }
            else
            {
                button7.BackColor = Color.Pink;
            }
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            if (light == true)
            {
                button7.BackColor = Color.White;
            }
            else
            {
                button7.BackColor = Color.Black;
            }
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
            button8.BackColor = Color.DimGray;
        }
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
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
            button9.BackColor = Color.DimGray;
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
            button10.BackColor = Color.DimGray;
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

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.DimGray;
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
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
            button14.BackColor = Color.DimGray;
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
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
            button16.BackColor = Color.DimGray;
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button15.BackColor = Color.Black;
            }
            else
            {
                button15.BackColor = Color.White;
            }
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = Color.DimGray;
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
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
            button18.BackColor = Color.DimGray;
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button17.BackColor = Color.Black;
            }
            else
            {
                button17.BackColor = Color.White;
            }
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.BackColor = Color.DimGray;
        }

        private void button20_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button20.BackColor = Color.Black;
            }
            else
            {
                button20.BackColor = Color.White;
            }
        }

        private void button20_MouseLeave(object sender, EventArgs e)
        {

            button20.BackColor = Color.DimGray;
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button19.BackColor = Color.Black;
            }
            else
            {
                button19.BackColor = Color.White;
            }
        }

        private void button19_MouseLeave(object sender, EventArgs e)
        {
            button19.BackColor = Color.DimGray;
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

        private void button21_MouseHover(object sender, EventArgs e)
        {
            if (light == true)
            {
                button21.BackColor = Color.Black;
            }
            else
            {
                button21.BackColor = Color.White;
            }
        }

        private void button21_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.DimGray;
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

        private void button23_MouseHover(object sender, EventArgs e)
        {
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
            button23.BackColor = Color.DimGray;
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

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.DimGray;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
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
            button13.BackColor = Color.DimGray;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel7.Height < 1560)
            {
                panel7.Height += 20;
            }
            else
            {
                timer2.Stop();
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Εμφάνιση καταλόγου")
            {
                timer2.Start();
                button7.Text = "X";
            }
            else
            {
                timer3.Start();
                button7.Text = "Εμφάνιση καταλόγου";

            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (panel7.Height > 0)
            {
                panel7.Height -= 20;

            }
            else
            {
                timer3.Stop();
            }
        }

        double sumBar = 0;
        int lays;
        int popcorn;
        int chettos;
        int pringles;
        int cola;
        int zero;
        int fanta;
        int lipton;
        private void button9_Click(object sender, EventArgs e)
        {
            sumBar += 2;
            lays += 1;
            button10.Enabled = true;
            label20.Text = lays.ToString();
            label16.Text = (sumBar+Double.Parse(label53.Text)).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sumBar -= 2;
            if (lays == 1)
            {
                button10.Enabled = false;
               
            }
            lays -= 1;
            label20.Text = lays.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sumBar += 1;
            popcorn += 1;
            button11.Enabled = true;
            label21.Text = popcorn.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sumBar -= 1;
            if (popcorn == 1)
            {
                button11.Enabled = false;
                
            }
            popcorn -= 1;
            label21.Text = popcorn.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sumBar += 2;
            chettos += 1;
            button13.Enabled = true;
            label35.Text = chettos.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sumBar -= 2;
            if (chettos == 1)
            {
                button13.Enabled = false;
                
            }
            chettos -= 1;
            label35.Text = chettos.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sumBar += 3;
            pringles += 1;
            button15.Enabled = true;
            label38.Text = pringles.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sumBar -= 3;
            if (pringles == 1)
            {
                button15.Enabled = false;
                
            }
            pringles -= 1;
            label38.Text = pringles.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sumBar += 1.20;
            cola += 1;
            button17.Enabled = true;
            label41.Text = cola.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sumBar -= 1.20;
            if (cola == 1)
            {
                button15.Enabled = false;
                
            }
            cola -= 1;
            label41.Text = cola.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            sumBar += 1.50;
            zero += 1;
            button19.Enabled = true;
            label44.Text = zero.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sumBar -= 1.50;
            if (zero == 1)
            {
                button19.Enabled = false;
                
            }
            zero -= 1;
            label44.Text = zero.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sumBar += 1;
            fanta += 1;
            button21.Enabled = true;
            label47.Text = fanta.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sumBar -= 1;
            if (fanta == 1)
            {
                button21.Enabled = false;
                
            }
            fanta -= 1;
            label47.Text = fanta.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            sumBar += 1.20;
            lipton += 1;
            button23.Enabled = true;
            label50.Text = lipton.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sumBar -= 1.20;
            if (lipton == 1)
            {
                button23.Enabled = false;
                
            }
            lipton -= 1;
            label50.Text = lipton.ToString();
            label16.Text = (sumBar + Double.Parse(label53.Text)).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Card C = new Card(Double.Parse(label53.Text),label54.Text);
            C.ShowDialog();
            this.Hide();
        }

        private void button25_MouseHover(object sender, EventArgs e)
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

        private void button25_MouseLeave(object sender, EventArgs e)
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

        private void button25_Click(object sender, EventArgs e)
        {
            Tickets T = new Tickets(label54.Text);
            this.Hide();
            T.ShowDialog();
            
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

        private void button26_MouseHover(object sender, EventArgs e)
        {
            button26.ForeColor = Color.Green;
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {

            if (light == true)
            {
                button26.ForeColor = Color.Black;
            }
            else
            {
                button26.ForeColor = Color.White;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel30.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel30.Visible = false;
        }
    }
}
