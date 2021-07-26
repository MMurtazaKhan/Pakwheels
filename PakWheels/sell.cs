using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PakWheels
{
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }
        string imgLocation = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxx.ImageLocation = imgLocation;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] images = null;
            FileStream streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);
            
            string name = textBoxName.Text;
            int contact = Convert.ToInt32(textBoxContact.Text);
            int price = Convert.ToInt32(textBoxPrice.Text);
            string manufacture = comboBoxManuf.Text;
            string model = textBoxModel.Text;
            string type = comboBoxType.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= Pakwheel; integrated security = true";
            con.Open();
            string sqlQuery = "Insert into Sell(Name, Contact, price,Type, manufacture, model, picture) values('" + name + "','" + contact + "','" + price + "','" + type + "','" + manufacture + "','" + model + "',@images)";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int n = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data saved");
            // cmd.CommandText = "Insert into cars(name, contact, price, manufacture, model, picture) values('" + name + "','" + contact + "','" + price + "','" + manufacture + "','" + model + "',@images)";
        }

        private void sell_Load(object sender, EventArgs e)
        {

        }
        string[] bike = { "Honda", "Unique", "Super Power", "Union Star" };
        string[] car = { "Honda", "Suzuki", "Toyota", "Hyundai", "Nissan", "MG", "Other" };
        string[] commercial = { "Afzal Motors", "Atlas Honda", "DYL", "Al Haj Faw", "Others"};
        string[] rickshaw = { "Charsadda", "Super Green", "Sazgar" ,"Others"};
        string[] other = { "Honda", "Toyota", "Suzuki", "Others" };
        private void comboBoxManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBoxType.Text == "Bike")
            {
                comboBoxManuf.Items.Clear();
                comboBoxManuf.Items.AddRange(bike);
            }
            else if (comboBoxType.Text == "Car")
            {
                comboBoxManuf.Items.Clear();
                comboBoxManuf.Items.AddRange(car);
            }
            else if (comboBoxType.Text == "Rickshaw")
            {
                comboBoxManuf.Items.Clear();
                comboBoxManuf.Items.AddRange(rickshaw);
            }
            else if (comboBoxType.Text == "Commercial Vehicles")
            {
                comboBoxManuf.Items.Clear();
                comboBoxManuf.Items.AddRange(commercial);
            }
            else
            {
                comboBoxManuf.Items.Clear();
                comboBoxManuf.Items.AddRange(other);
            }
        }
    }
}
