using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learner
{
    public partial class Form1 : Form
    {
        logic log = new logic();
        int prog;
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = label2.Text = label3.Text = label4.Text = "";
            log.N();
        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            bool tmp = log.Next();
            if (tmp)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                pictureBox1.Visible = true;
            }
            log.showOne(label1);
            progressBar1.Value = (int)(log.CapasityOne() + (int)(log.CapasityTwo()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            log.showTwo(label2);
        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {
            bool tmp = log.Next2();
            label4.Text = "";
            if (tmp)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                pictureBox2.Visible = true;
            }
            log.showThree(label3);
            progressBar1.Value = (int)(log.CapasityOne() + (int)(log.CapasityTwo()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text != "")
            log.showFour(label4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
