using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_Kelompok9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foods_division1.BringToFront();

            button1.BackColor = Color.DimGray;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drinks_division1.BringToFront();
            button2.BackColor = Color.DimGray;
            button1.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            delivery_division1.BringToFront();
            button3.BackColor = Color.DimGray;
            button2.BackColor = Color.Black;
            button1.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aboutus1.BringToFront();
            button4.BackColor = Color.DimGray;
            button3.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button1.BackColor = Color.Black;           
            button5.BackColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contactus1.BringToFront();
            button5.BackColor = Color.DimGray;
            button4.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button1.BackColor = Color.Black;         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void contactus1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;
        }
    }
}
