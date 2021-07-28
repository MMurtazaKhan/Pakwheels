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
    public partial class buyConfirm : Form
    {
        public buyConfirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textName.Text;
            int contact = Convert.ToInt32(textContact.Text);
            string address = textAddress.Text;
            int VehicleID = Convert.ToInt32(textVehicleID.Text);
            string payment = comboBoxPay.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into Buy (Name, Contact, Address, VehicleID, Payment) values ('" + name + "', '" + contact + "','" + address + "','" + VehicleID + "','" + payment + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Your record hass been submitted, We will contact you in couple of hours!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buyConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
