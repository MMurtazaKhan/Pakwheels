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
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DataSet DS = new DataSet();

        private void buy_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            cmd.Connection = con;
            dataGridView1.RowTemplate.Height = 100;
            cmd.CommandText = "select * from Sell";
            //cmd.CommandText = "select * from Sell";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Signed in?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                buyConfirm buyC = new buyConfirm();
                buyC.Show();
            }
            else
            {
                MessageBox.Show("Please Sign Up", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataSet DS = new DataSet();
            dataGridView1.RowTemplate.Height = 100;
          
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
          
            cmd.Connection = con;
            dataGridView1.DataSource = null;
             cmd.CommandText = "select * from Sell where CONVERT(VARCHAR(MAX), Type) = '" + comboBox1.Text + "';";
            
            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

      
    }
}
