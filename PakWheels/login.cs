using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PakWheels
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= practice; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from loginTable where usrname = '" + textBoxUser.Text + "' and password = '" + textBoxPass.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                admin ad = new admin();
                this.Hide();
                ad.Show();
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/Pakwheels");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/pakwheels");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.instagram.com/pakwheels/");
        }
    }

    
    }

