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

namespace PakWheels
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nam = textBox_name.Text;
            string user_nam = textBox_user.Text;
            string em = textBox_email.Text;
            string add = textBox_add.Text;
            int no = Convert.ToInt32(textBox_no.Text);
            string pass = textBox_pass.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= practice; integrated security = true";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Sign_Up (Name,Username,Email,Address,Contact,Password) values (' " + nam + " ',' " + user_nam + " ',' " + em + " ',' " + add + " ',' " + no + " ',' " + pass + "') ";
            cmd.CommandText = "insert into login (Username,Password) values('" + user_nam + "','" + pass + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("You are signed up!", "Congratulations", MessageBoxButtons.OK,MessageBoxIcon.Information);

            textBox_name.Clear();
            textBox_user.Clear();
            textBox_email.Clear();
            textBox_add.Clear();
            textBox_no.Clear();
            textBox_pass.Clear();
        }
    }
}
