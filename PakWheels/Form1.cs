using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using car_app;

namespace PakWheels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            inspect i = new inspect();
            i.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buy b = new buy();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            repair r = new repair();
            r.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome back", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Blog bl = new Blog();
            bl.Show();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            signup sign = new signup();
            sign.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            contact con = new contact();
            con.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Rent ur = new User_Rent();
            ur.Show();
        }
    }
}
