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
    public partial class InspectionConfirm : Form
    {
        public InspectionConfirm()
        {
            InitializeComponent();
        }

        private void InspectionConfirm_Load(object sender, EventArgs e)
        {
            Label l = new Label();
            l.AutoSize = true;
            if(comboBoxCC.SelectedIndex == 0)
            {
                l.Text = "Your Car inspection Price is 3,000 Rs";
            }
            else if (comboBoxCC.SelectedIndex == 1)
            {
                l.Text = "Your Car inspection Price is 5,000 Rs";
            }
            else if(comboBoxCC.SelectedIndex==3)
            {
                l.Text = "Your Car inspection Price is 7,000 Rs";
            }
            l.Location = new Point(386, 268);
            l.Font = new Font("Microsoft YaHei UI", 16);
            l.ForeColor = Color.White;
            
            this.Controls.Add(l);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            int contact = Convert.ToInt32(textContact.Text);
            string address = textAddress.Text;
            string CC = comboBoxCC.Text;
            string date = dateTimeSchedule.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database = PakWheel; Integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into InspectData (Name, Contact, Address, Capacity, Schedule) values ('" + name + "', '" + contact + "','" + address + "','" + CC + "','" + date + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Your record hass been submitted, We will contact you in couple of hours!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
