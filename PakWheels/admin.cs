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
        string x;
        public void button3_Click(object sender, EventArgs e)
        {
           

            /*Label head = new Label();
            head.Location = new Point(342, 76);
            head.Text = "Vehicles Data";
            head.Font = new Font("Times New Roman", 20);
            head.BackColor = Color.Transparent;
            head.ForeColor = Color.Blue;
            head.Size = new Size(395, 35);
            this.Controls.Add(head);*/

            string[] vehicles = {"Car", "Bike", "Rickshaw", "Commercial Vehicles", "Other" };
            type.Items.AddRange(vehicles);
            /*ComboBox type = new ComboBox();
            type.Location = new Point(562, 100);
            this.Controls.Add(type);

            Button search = new Button();
            search.Size = new Size(97, 34);
            search.Location = new Point(749, 90);
            search.Text = "Search";
            this.Controls.Add(search);
            EventHandler search_Click = null;
            search.Click += new EventHandler(search_Click);

            Button dynamicButton = new Button();*/

            x = "Sell";


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
            x = "Repair";
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
            x = "InspectData";
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
            cmd.CommandText = "Delete from '" + x + "' where ID = '" + Convert.ToInt32(textID.Text) + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted");
        }
    }
}
