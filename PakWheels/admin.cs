using car_app;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {

            string[] vehicles = {"Car", "Bike", "Rickshaw", "Commercial Vehicles", "Other" };
            type.Items.AddRange(vehicles);


        SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            dataGridView1.RowTemplate.Height = 100;
            string query = "select * from Sell";
            cmd.CommandText = query;
            //cmd.CommandText = "select * from Sell";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            labeldatabase.Text = "Sell";

        }

        public void button1_Click(object sender, EventArgs e)
        {
         
            this.Controls.Remove(type);
            this.Controls.Remove(search);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Repair";
            //cmd.CommandText = "select * from Sell";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            labeldatabase.Text = "Repair";
        }

        public void button4_Click(object sender, EventArgs e)
        {
          
            this.Controls.Remove(type);
            this.Controls.Remove(search);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from InspectData";
            //cmd.CommandText = "select * from Sell";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            labeldatabase.Text = "InspectData";
        }

        public void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            dataGridView1.RowTemplate.Height = 100;
            cmd.CommandText = "Select * from Sell where CONVERT(VARCHAR(MAX), Type) = '" + type.Text + "';";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            dataGridView1.RowTemplate.Height = 100;
            cmd.CommandText = "Delete from " + labeldatabase.Text + " where ID = '" + Convert.ToInt32(textID.Text) + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted");
        }

         AddBlog ab = new AddBlog();
        private void button5_Click(object sender, EventArgs e)
        {
            ab.Show();
        }

         Admin_Rent ar = new Admin_Rent();
        private void button6_Click(object sender, EventArgs e)
        {
            ar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ab.Hide();
            ar.Hide();
            
        }

    }
}
