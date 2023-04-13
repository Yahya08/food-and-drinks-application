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
    public partial class contactus : UserControl
    {
        public contactus()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://wa.me/6281325982636");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://wa.me/6282279934134");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://wa.me/6281325982636");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://wa.me/6282279934134");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://www.instagram.com/yahyahnda_/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://www.instagram.com/zulfa_fakaha/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://www.instagram.com/zulfa_fakaha/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("MIcrosoftEdge", "https://www.instagram.com/yahyahnda_/");
        }

        private void contactus_Load(object sender, EventArgs e)
        {

        }
    }
}
