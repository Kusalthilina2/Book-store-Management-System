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

namespace Book_Store_Management_System
{
    public partial class Customer_Update : Form
    {
        public Customer_Update()
        {
            InitializeComponent();
        }

        private void Customer_Update_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Customer set Contact_Number=@Contact_Number,Address=@Address where Customer_Name=@Customer_Name", conn);
            cmd.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact_Number", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Address", textBox3.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4= new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
