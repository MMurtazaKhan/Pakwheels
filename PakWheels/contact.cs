using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PakWheels
{
    public partial class contact : Form
    {
        public contact()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contact_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/pakwheels");
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/pakwheels/");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com/maps/search/pakwheels.com/@24.8716907,67.0555121,17z");

                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
