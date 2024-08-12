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
    public partial class Order_Update : Form
    {
        public Order_Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=BookStoreDataBase;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Orders set Supplier_No=@Supplier_No,Order_Quantity=@Order_Quantity where Book_Title=@Book_Title", conn);
            cmd.Parameters.AddWithValue("@Book_Title", textBox1.Text);
            cmd.Parameters.AddWithValue("@Supplier_No", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Order_Quantity", int.Parse(comboBox1.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6= new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
