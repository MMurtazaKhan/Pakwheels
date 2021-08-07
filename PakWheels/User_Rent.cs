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


namespace car_app
{
    public partial class User_Rent : Form
    {
        public User_Rent()
        {
            InitializeComponent();
        }


        private void User_Rent_Load(object sender, EventArgs e)
        {




            dataGridView1.RowTemplate.Height = 100;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= Pakwheel; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from RentCar";
            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns[5].Width = 300;
        }
        //Search:

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 100;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= Pakwheel; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            dataGridView1.DataSource = null;

            cmd.CommandText = "select * from RentCar where CONVERT(VARCHAR(MAX), Car_Type) = '" + comboBox1.Text + "';";

            //CONVERT(VARCHAR(MAX), Type)

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns[5].Width = 300;
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            int car_id = Convert.ToInt32(text_carid.Text);
            string name = text_name.Text;
            string date = dateTimePicker1.Text;
            string need = comboBox2.Text;
            int contact = Convert.ToInt32(text_contact.Text);
            long cnic = Convert.ToInt64(text_cnic.Text);
            int amount = Convert.ToInt32(text_amount.Text);



            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = HAIER-PC\\SQLEXPRESS; database= Pakwheel; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into RentCar (Car_ID,Name, date,Car_Type, need, contact,amount) values ('" + car_id + "','" + name + "', '" + date + "','" + comboBox1.Text + "','" + need + "','" + contact + "','" + amount + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            MessageBox.Show("Your record has saved ,Please bring your Original CNIC on collection day");

            text_carid.Clear();
            text_name.Clear();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            text_contact.Clear();
            text_cnic.Clear();
            text_amount.Clear();





        }
        int car_cor = 300;
        int car_aq = 200;
        int car_prius = 500;
        int car_alto = 150;
        int car_hil = 1000;
        int car_civ = 700;
        int car_cit = 600;
        double res;

        private void but_amount_Click(object sender, EventArgs e)
        {

            //Corolla:

            if (comboBox1.Text == "Corolla" && comboBox2.Text == "3hrs")
            {
                res = car_cor * 3;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Corolla" && comboBox2.Text == "9hrs")
            {
                res = car_cor * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Corolla" && comboBox2.Text == "1day")
            {
                res = car_cor * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Corolla" && comboBox2.Text == "3days")
            {
                res = car_cor * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Corolla" && comboBox2.Text == "1week")
            {
                res = car_cor * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Corolla" && comboBox2.Text == "1month")
            {
                res = car_cor * 672;
                text_amount.Text = Convert.ToString(res);

            }

            //Aqua:


            else if (comboBox1.Text == "Aqua" && comboBox2.Text == "3hrs")
            {
                res = car_aq * 3;
                text_amount.Text = Convert.ToString(res);
            }

            else if (comboBox1.Text == "Aqua" && comboBox2.Text == "9hrs")
            {
                res = car_aq * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Aqua" && comboBox2.Text == "1day")
            {
                res = car_aq * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Aqua" && comboBox2.Text == "3days")
            {
                res = car_aq * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Aqua" && comboBox2.Text == "1week")
            {
                res = car_aq * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Aqua" && comboBox2.Text == "1month")
            {
                res = car_aq * 672;
                text_amount.Text = Convert.ToString(res);

            }

            //Prius:
            else if (comboBox1.Text == "Prius" && comboBox2.Text == "3hrs")
            {
                res = car_prius * 3;
                text_amount.Text = Convert.ToString(res);
            }

            else if (comboBox1.Text == "Prius" && comboBox2.Text == "9hrs")
            {
                res = car_prius * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Prius" && comboBox2.Text == "1day")
            {
                res = car_prius * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Prius" && comboBox2.Text == "3days")
            {
                res = car_prius * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Prius" && comboBox2.Text == "1week")
            {
                res = car_prius * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Prius" && comboBox2.Text == "1month")
            {
                res = car_prius * 672;
                text_amount.Text = Convert.ToString(res);

            }

            //Alto:
            else if (comboBox1.Text == "Alto" && comboBox2.Text == "3hrs")
            {
                res = car_alto * 3;
                text_amount.Text = Convert.ToString(res);
            }

            else if (comboBox1.Text == "Alto" && comboBox2.Text == "9hrs")
            {
                res = car_alto * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Alto" && comboBox2.Text == "1day")
            {
                res = car_alto * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Alto" && comboBox2.Text == "3days")
            {
                res = car_alto * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Alto" && comboBox2.Text == "1week")
            {
                res = car_alto * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Alto" && comboBox2.Text == "1month")
            {
                res = car_alto * 672;
                text_amount.Text = Convert.ToString(res);

            }

            //Hilux:

            else if (comboBox1.Text == "Hilux" && comboBox2.Text == "3hrs")
            {
                res = car_hil * 3;
                text_amount.Text = Convert.ToString(res);
            }

            else if (comboBox1.Text == "Hilux" && comboBox2.Text == "9hrs")
            {
                res = car_hil * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Hilux" && comboBox2.Text == "1day")
            {
                res = car_hil * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Hilux" && comboBox2.Text == "3days")
            {
                res = car_hil * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Hilux" && comboBox2.Text == "1week")
            {
                res = car_hil * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Hilux" && comboBox2.Text == "1month")
            {
                res = car_hil * 672;
                text_amount.Text = Convert.ToString(res);

            }

            // Civic:
            else if (comboBox1.Text == "Civic" && comboBox2.Text == "3hrs")
            {
                res = car_civ * 3;
                text_amount.Text = Convert.ToString(res);
            }

            else if (comboBox1.Text == "Civic" && comboBox2.Text == "9hrs")
            {
                res = car_civ * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Civic" && comboBox2.Text == "1day")
            {
                res = car_civ * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Civic" && comboBox2.Text == "3days")
            {
                res = car_civ * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Civic" && comboBox2.Text == "1week")
            {
                res = car_civ * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "Civic" && comboBox2.Text == "1month")
            {
                res = car_civ * 672;
                text_amount.Text = Convert.ToString(res);

            }


            //City:

            else if (comboBox1.Text == "City" && comboBox2.Text == "3hrs")
            {
                res = car_cit * 3;
                text_amount.Text = Convert.ToString(res);
            }

            else if (comboBox1.Text == "City" && comboBox2.Text == "9hrs")
            {
                res = car_cit * 9;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "City" && comboBox2.Text == "1day")
            {
                res = car_cit * 24;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "City" && comboBox2.Text == "3days")
            {
                res = car_cit * 72;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "City" && comboBox2.Text == "1week")
            {
                res = car_cit * 168;
                text_amount.Text = Convert.ToString(res);
            }
            else if (comboBox1.Text == "City" && comboBox2.Text == "1month")
            {
                res = car_cit * 672;
                text_amount.Text = Convert.ToString(res);

            }

            else
            {
                MessageBox.Show("Please input all feilds");
            }



        }

        private void butt_clear_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            text_carid.Clear();
            text_name.Clear();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            text_contact.Clear();
            text_cnic.Clear();
            text_amount.Clear();


        }

        
    }
}
