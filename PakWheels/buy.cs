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
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private void buy_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 100;
        
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Sell";
            //cmd.CommandText = "select * from Sell";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            buyConfirm buyC = new buyConfirm();
            buyC.Show();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 100;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            dataGridView1.DataSource = null;
             cmd.CommandText = "select * from Sell where CONVERT(VARCHAR(MAX), Type) = '" + comboBox1.Text + "';";
            
            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

      
    }
}
