using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch32
{
    public partial class Form1 : Form
    {
        private int elapsedTime;
        Label lblStatus = new Label();
        private object timer1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStatus_Click(object sender, EventArgs e)
        {
            lblStatus.Text += "+";
            tbStatus.Text += "+";
           // if (timer1.Enabled == false)
           // {
            //    timer1.Enabled = true;
           // }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            lblStatus.Text = elapsedTime + " 초 경과";
            tbStatus.Text = elapsedTime + " 초 경과";
            //toolStripProgressBar1 value = elapsedTime;



        }
    }

    public class toolStripProgressBar1
    {
    }
}
