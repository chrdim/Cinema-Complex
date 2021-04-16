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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
            dateLabels.Add(label7);
            dateLabels.Add(label8);
            dateLabels.Add(label9);
            dateLabels.Add(label22);
            dateLabels.Add(label23);

            roomsLabels.Add(label24);
            roomsLabels.Add(label25);
            roomsLabels.Add(label26);
            roomsLabels.Add(label27);
            roomsLabels.Add(label28);

            batteryPanels.Add(battery1);
            batteryPanels.Add(battery2);
            batteryPanels.Add(battery3);
            batteryPanels.Add(battery4);



        }
        List<DateTime> dates = new List<DateTime>();
        List<string> rooms = new List<string>();
        List<Label> dateLabels = new List<Label>();
        List<Label> roomsLabels = new List<Label>();
        List<Panel> batteryPanels = new List<Panel>();


        private void timer1_Tick(object sender, EventArgs e)
        {

            label48.Text = "";
            label49.Text = "";
            label32.Text = "";
            label30.Text = "";


            if (vacuumBox.Location.Y < 180)
            {
                vacuumBox.Location = new Point(vacuumBox.Location.X, vacuumBox.Location.Y + 27);


            }
            else
            {
                if (vacuumBox.Location.X < 550)
                {
                    vacuumBox.Location = new Point(vacuumBox.Location.X + 34, vacuumBox.Location.Y);
                    timer1.Stop();
                    timer2.Start();
                }
                else
                {
                    timer1.Stop();
                    vacuumBox.Location = new Point(60, 3);
                    rooms.RemoveAt(0);
                    dates.RemoveAt(0);
                    label48.Text = "G15,A8";
                    label49.Text = "E18,C19";
                    label32.Text = "Tα email εστάλησαν";
                    label30.Text = "Αποθηκεύτηκαν στην βάση";
                    timer4.Start();
                }
            }

        }

        private void F_Load(object sender, EventArgs e)
        {
            timer3.Start();
            panel1.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (vacuumBox.Location.X > 400)
            {
                battery2.BackColor = Color.Transparent;
            }
            else if (vacuumBox.Location.X > 200)
            {
                battery4.BackColor = Color.Transparent;
                battery3.BackColor = Color.Transparent;

            }

            if (vacuumBox.Location.Y > 3)
            {
                vacuumBox.Location = new Point(vacuumBox.Location.X, vacuumBox.Location.Y - 27);


            }
            else
            {
                if (vacuumBox.Location.X < 550)
                {
                    vacuumBox.Location = new Point(vacuumBox.Location.X + 34, vacuumBox.Location.Y);
                    timer2.Stop();
                    timer1.Start();
                }
                else
                {
                    battery1.BackColor = Color.Transparent;
                    timer2.Stop();


                    vacuumBox.Location = new Point(60, 3);
                    rooms.RemoveAt(0);
                    dates.RemoveAt(0);
                    label48.Text = "G15,A8";
                    label49.Text = "E18,C19";
                    label32.Text = "Tα email εστάλησαν";
                    label30.Text = "Αποθηκεύτηκαν στην βάση";
                    timer4.Start();
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (rooms.Count > 0)
            {

                if (DateTime.Now.ToString("HH:mm:ss") == dates[0].ToString("HH:mm:ss"))
                {

                    label36.Text = "Σκουπίζει";
                    label31.Text = rooms[0];
                    timer1.Start();
                    timer3.Stop();

                }



            }
            else
            {
                label36.Text = "Αδράνεια";

            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool alreadyExists = false;
            bool validHour = true;
            bool validHour2 = true;


            if (textBox1.Text != "" && (textBox1.Text == "premium 1" || textBox1.Text == "premium 2" || textBox1.Text == "normal 1" || textBox1.Text == "normal 2" || textBox1.Text == "low cost 1" || textBox1.Text == "low cost 2"))
            {

                for (int i = 0; i < rooms.Count() && i < 5; i++)
                {
                    if (rooms[i] == textBox1.Text && dates[i] == dateTimePicker1.Value)
                    {
                        alreadyExists = true;
                    }


                    if (Math.Abs((dateTimePicker1.Value - dates[i]).TotalSeconds) < 25)
                    {
                        validHour = false;
                    }

                }

                if (dateTimePicker1.Value < DateTime.Now)
                {

                    validHour2 = false;
                }
                if (alreadyExists == false)
                {
                    if (validHour == true)
                    {
                        if (validHour2 == true)
                        {
                            rooms.Add(textBox1.Text);
                            dates.Add(dateTimePicker1.Value);
                            if (rooms.Count > 1)
                            {
                                if (dates[dates.Count - 2] > dateTimePicker1.Value)
                                {
                                    DateTime temp = dates[dates.Count - 2];
                                    string temp2 = rooms[rooms.Count - 2];

                                    dates[dates.Count - 2] = dateTimePicker1.Value;
                                    dates[dates.Count - 1] = temp;

                                    rooms[rooms.Count - 2] = textBox1.Text;
                                    rooms[rooms.Count - 1] = temp2;


                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Λάθος καταχώρηση ώρας");
                        }
                    }
                    else
                    {
                        MessageBox.Show("H σκούπα δεν θα είναι διαθέσιμη την ώρα που καταχωρήσατε");
                    }
                }
                else
                {
                    MessageBox.Show("Το σκούπισμα έχει ήδη προγραμματιστεί");

                }
            }
            else
            {
                MessageBox.Show("Δεν βρέθηκε αίθουσα");
            }

        }


    

        private void button4_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel4.Visible = true;

            for (int i = 0; i < 5; i++)
            {
                roomsLabels[i].Text = "";
                dateLabels[i].Text = "";
            }

            for (int i = 0; i < rooms.Count() && i < 5; i++)
            {
                roomsLabels[i].Text = rooms[i];
            }

            for (int i = 0; i < dates.Count() && i < 5; i++)
            {
                dateLabels[i].Text = dates[i].ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel7.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                roomsLabels[i].Text = "";
                dateLabels[i].Text = "";
            }

            for (int i = 0; i < rooms.Count() && i < 5; i++)
            {
                roomsLabels[i].Text = rooms[i];
            }

            for (int i = 0; i < dates.Count() && i < 5; i++)
            {
                dateLabels[i].Text = dates[i].ToString();
            }
        }


        int counter = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            label36.Text = "Φόρτιση";
            label31.Text = "";
            if (counter < 4)
            {
                batteryPanels[counter].BackColor = Color.Lime;
                counter++;
            }
            else
            {
                
                timer4.Stop();
                label36.Text = "Αδράνεια";
                counter = 0;
                timer3.Start();
            }
            
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = true;
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = true;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.Visible = false;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = false;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = true;
            pictureBox18.Visible = true;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.Visible = false;
            pictureBox18.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox37.Visible = true;
            pictureBox21.Visible = true;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.Visible = false;
            pictureBox21.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox36.Visible = true;
            pictureBox23.Visible = true;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Visible = false;
            pictureBox23.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = true;
            pictureBox22.Visible = true;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Visible = false;
            pictureBox22.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox34.Visible = true;
            pictureBox24.Visible = true;
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Visible = false;
            pictureBox24.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = true;
            pictureBox19.Visible = true;
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Visible = false;
            pictureBox19.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible = true;
            pictureBox20.Visible = true;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Visible =false;
            pictureBox20.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox31.Visible = true;
            pictureBox25.Visible = true;
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.Visible = false;
            pictureBox25.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = true;
            pictureBox16.Visible = true;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Visible = false;
            pictureBox16.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = true;
            pictureBox15.Visible = true;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Visible = false;
            pictureBox15.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox28.Visible = true;
            pictureBox17.Visible = true;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Visible = false;
            pictureBox17.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel11.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel37.Visible = true;
            panel36.Visible = true;
            panel38.Visible = true;
            panel34.Visible = true;
            panel35.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel37.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel36.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel38.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel34.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel35.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel39.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel39.Visible = false;
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
