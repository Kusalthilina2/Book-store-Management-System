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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Store_Management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection();

            
            con.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;  
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Customer(Customer_Name,Contact_Number,Address,Book_Title,Purchase_Date,Purchase_Price) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox6.Text + "')";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully entered values!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Customer where Customer_Name='" + textBox1.Text + "'";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Update cu = new Customer_Update();
            cu.Show();
            this.Hide();
        }
    }
}
