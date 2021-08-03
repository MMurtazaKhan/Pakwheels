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
    public partial class Blog : Form
    {
        public Blog()
        {
            InitializeComponent();
        }

        private void Blog_Load(object sender, EventArgs e)
        {

            labelHead.Visible = false;
            richTextBoxCont.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.RowTemplate.Height = 100;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= Pakwheel; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Blog";
            //cmd.CommandText = "select * from Sell";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns[2].Width = 3000;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string head = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string content = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                labelHead.Visible = true;
                richTextBoxCont.Visible = true;
                labelHead.Text = head;
                richTextBoxCont.Text = content;
            }
        }
    }
    }

