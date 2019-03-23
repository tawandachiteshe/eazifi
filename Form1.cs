using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EaziFi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            timer1.Start();
            timer1.Enabled = true;
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkSpeed ls = new NetworkSpeed();
            Controller hotspot = new Controller();
            hotspot.start();
          //  ls.showSpeed();
          //  this.BackColor = Color.Green;
          /*  label3.Text = "Eazify is now on";
            label4.Text = hotspot.GetMessage();
            
            label5.Text = ls.BytesReceivede()+"";
            label6.Text = ls.ByteSende() + "";*/
           
           
      
        }

        private void button3_DragLeave(object sender, EventArgs e)
        {
           // textBox2.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            //textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Controller.stop();
            
           this.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            NetworkSpeed ls = new NetworkSpeed();
            ls.showSpeed();

            if (ls.ByteSend() >= 1000 || ls.BytesReceived() >= 1000)
            {
                bytesReceived.Text = ls.BytesReceived()/1000 + " Kb";
                bytesSend.Text = ls.ByteSend()/1000 + " Kb";
            }
          else if (ls.BytesReceived() >= 1000000|| ls.ByteSend()>=1000000)
            {

                bytesReceived.Text = ls.BytesReceived()/1000000 + " Mb";
                bytesSend.Text = ls.ByteSend()/1000000 + " Mb";

            }
            else if (ls.ByteSend() >= 1000000000 || ls.BytesReceived() >= 1000000000)
            {

                bytesReceived.Text = ls.BytesReceived()/1000000000 + " Gb";
                bytesSend.Text = ls.ByteSend()/1000000000 + " Gb";
            }
           

            

            
        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            NetworkSpeed ls = new NetworkSpeed();
            Controller hotspot = new Controller();
            hotspot.start();
            if (bunifuiOSSwitch1.Value == true)
            {
                
                hotspot.start();
                StatusLabel.Text = "ON";
            }
            else  if(bunifuiOSSwitch1.Value == false)
            {
                StatusLabel.Text = "OFF";
                Controller.stop();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Activate();
            this.Visible = false;
            form2.Visible = true;
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
