using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class Sales : UserControl
    {
        MySqlConnection conn;
        int f;
        public Sales()
        {
            InitializeComponent();

            conn = new MySqlConnection("server = 127.0.0.1; database = products; username = root; password = 123456;");
            conn.Open();
            
        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string code;
        private void button1_Click(object sender, EventArgs e)
        {

            string query = "SELECT * FROM products.product_info WHERE product_code='"+textBox1.Text+"'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader rd = command.ExecuteReader();
            while (rd.Read()) {

                f = rd.GetInt32("product_stock");
               

            
            }
            rd.Close();

         int newStock=   f - (Int32.Parse(textBox2.Text));

            if (newStock < 0) {

                MessageBox.Show("Your Stock Can Not Be Less Than Zero! Set To 0 ");
                newStock = 0;
            
            }
            string queryy = "UPDATE products.product_info SET product_stock ='"+newStock+"'WHERE product_code='"+textBox1.Text+"'";
            MySqlCommand commandd = new MySqlCommand(queryy, conn);
            commandd.ExecuteNonQuery();




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
