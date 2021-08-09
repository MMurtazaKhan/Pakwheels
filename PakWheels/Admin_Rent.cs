using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace car_app
{
    public partial class Admin_Rent : Form
    {
        public Admin_Rent()
        {
            InitializeComponent();
        }

            string imgLocation = "";
        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            byte[] images = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);

            int contact = Convert.ToInt32(text_contact.Text);
            string car_type = comboBox1.Text;
            string driver_name = text_dname.Text;
            string driver_contact = text_dcon.Text;



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= Pakwheel; integrated security = true";
            con.Open();
            string sqlQuery = "insert into RentCarAdmin (Contact,Car_Type,Driver_Name, Driver_Contact,Picture) values('" + contact + "','" + car_type + "','" + driver_name + "','" + driver_contact + "',@images) ";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int n = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved");


            text_contact.Clear();
            text_dcon.Clear();
            comboBox1.ResetText();
            text_dname.ResetText();
            pictureBox1.ResetText();
            
        }

        private void Admin_Rent_Load(object sender, EventArgs e)
        {

        }
    }
}
