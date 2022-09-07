using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM6";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

timer1.Start();

            if (!serialPort1.IsOpen) return;
           MessageBox.Show("Baglandi", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        private void DisplayText(object sender, EventArgs e)
        {

            richTextBox1.Text = richTextBox1.Text + RxString;
            //timer1.Start();

        }
        string RxString;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            string kelime3 = richTextBox1.Text;
            textBox11.Text = kelime3.IndexOf('*').ToString();

            if (textBox11.Text == "-1")
            {
            }
            else
            {

                richTextBox1.Text = richTextBox1.Text.Remove(0, Convert.ToInt32(textBox11.Text) + 1);

                string kelime4 = richTextBox1.Text;
                textBox11.Text = kelime4.IndexOf('*').ToString();

                if (textBox11.Text == "-1")
                {
                }
                else
                {

                    textBox8.Text = richTextBox1.Text.Substring(0, Convert.ToInt32(textBox11.Text));



                    string s = textBox8.Text;

                    if (s.IndexOf("KapiAcildi") != -1)
                    {
                        textBox8.Text = "Ev_Sahibi_Evde";
                        listBox1.Items.Add(textBox8.Text + "   -   " + DateTime.Now.ToString());
                        admin.Visible = true;
                        guest.Visible = false;

                   
                        label9.Text = "Ev_Sahibi_Evde";
                    }
                    else
                    {
                        textBox8.Text = "Misafir_Geldi";
                        listBox1.Items.Add(textBox8.Text + "   -   " + DateTime.Now.ToString());
                        guest.Visible = true;
                        admin.Visible = false;

                       
                        label9.Text = "Misafir_Geldi";
                    }





                }

            }



            //______________________________________________________
            string kelime = richTextBox1.Text;
            textBox9.Text = kelime.IndexOf('|').ToString();

            if (textBox9.Text == "-1")
            {
            }
            else
            {

                richTextBox1.Text = richTextBox1.Text.Remove(0, Convert.ToInt32(textBox9.Text) + 1);
            }



            string kelime2 = richTextBox1.Text;
            textBox9.Text = kelime2.IndexOf('|').ToString();
            if (textBox9.Text == "-1")
            {
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, Convert.ToInt32(textBox9.Text));
                listBox1.Items.Add(richTextBox1.Text + "   -   " + DateTime.Now.ToString());
            






            ////_____________________________________________


            char[] boluculer = { '-' };
            string[] parcalar = richTextBox1.Text.Split(boluculer);

            foreach (string parca in parcalar)
            {



                if (parcalar[0] != "NULL")
                {
                    textBox1.Text = (parcalar[0]);
                    textBox1.ForeColor = Color.Red;
                }
                else
                {
                    textBox1.Text = "";

                }


            if (parcalar[1] != "NULL")
            {
                textBox2.Text = (parcalar[1]);
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                textBox2.Text = "";
            }

            if (parcalar[2] != "NULL")
            {
                textBox3.Text = (parcalar[2]);
                textBox3.ForeColor = Color.Red;
            }
            else
            {
                textBox3.Text = "";
            }


            if (parcalar[3] != "NULL")
            {
                textBox4.Text = (parcalar[3]);
                textBox4.ForeColor = Color.Red;
            }
            else
            {
                textBox4.Text = "";
            }


            if (parcalar[4] != "NULL")
            {
                textBox5.Text = (parcalar[4]);
                textBox5.ForeColor = Color.Red;
            }
            else
            {
                textBox5.Text = "";
            }

            if (parcalar[5] != "NULL")
            {
                textBox6.Text = (parcalar[5]);
                textBox6.ForeColor = Color.Red;
            }
            else
            {
                textBox6.Text = "";
            }



            if (parcalar[6] != "NULL")
            {
                textBox7.Text = (parcalar[6]);
                textBox7.ForeColor = Color.Red;
            }
            else
            {
                textBox7.Text = "";
            }

                }
            }



            string ayr = richTextBox1.Text;
            textBox10.Text = ayr.IndexOf('-').ToString();
            if (textBox10.Text == "-1")
            {
            }
            else
            {
                textBox1.Text = richTextBox1.Text.Substring(0, Convert.ToInt32(textBox10.Text)).ToString();
                richTextBox1.Text = richTextBox1.Text.Remove(0, Convert.ToInt32(textBox10.Text)).ToString();

                textBox2.Text = richTextBox1.Text.Substring(0, Convert.ToInt32(textBox10.Text)).ToString();
                richTextBox1.Text = richTextBox1.Text.Remove(0, Convert.ToInt32(textBox10.Text)).ToString();
            }




        }




    }


}





        

    
