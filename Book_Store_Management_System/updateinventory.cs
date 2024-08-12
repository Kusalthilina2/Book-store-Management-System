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
    public partial class updateinventory : Form
    {
        public updateinventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Inventory set Price=@Price,Stock_Level=@Stock_Level where Book_Title=@Book_Title", conn);
            cmd.Parameters.AddWithValue("@Book_Title", textBox1.Text);
            cmd.Parameters.AddWithValue("@Price", float.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Stock_Level", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3= new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
