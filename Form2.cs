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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Controller co = new Controller(bunifuMaterialTextbox2.Text,bunifuMaterialTextbox1.Text);
          richTextBox1.Text =  co.GetMessage();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
           
            this.Visible = false;
            form1.Visible = true;
            
        }
    }
}
