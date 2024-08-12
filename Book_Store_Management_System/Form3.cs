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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Book_Store_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
            SqlCommand cmd = new SqlCommand("Insert Into Inventory values(@Book_Title,@Author,@Publisher,@Category,@Price,@Stock_Level)",con);
            cmd.Parameters.AddWithValue("@Book_Title", textBox1.Text);
            cmd.Parameters.AddWithValue("@Author", textBox2.Text);
            cmd.Parameters.AddWithValue("@Publisher", textBox3.Text);
            cmd.Parameters.AddWithValue("@Category", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price",float.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Stock_Level",int.Parse(textBox6.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully");






        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Inventory where Book_Title='" + textBox1.Text + "'";
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Deleted");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateinventory ups= new updateinventory();
            ups.Show();
            this.Show();
                
        }
    }
}
