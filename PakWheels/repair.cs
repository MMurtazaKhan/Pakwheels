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
    public partial class repair : Form
    {
        public repair()
        {
            InitializeComponent();
        }

        private void repair_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBoxName.Text;
            int contact = Convert.ToInt32(textBoxContact.Text);
            string fault = comboBoxFault.Text;
            string date = dateTimeSchedule.Text;
            string desc = textBoxDesc.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into Repair (name, contact, fault, date, description) values ('" + name + "', '" + contact + "','" + fault + "','" + date + "','" + desc + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Your record has been submitted, Our mechanic will be there at your given time!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
