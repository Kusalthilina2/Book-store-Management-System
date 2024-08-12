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
    public partial class SalesUpdate : Form
    {
        public SalesUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Sale set Contact_No=@Contact_No where Customer_Name=@Customer_Name", conn);
            cmd.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Contact_No", int.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
