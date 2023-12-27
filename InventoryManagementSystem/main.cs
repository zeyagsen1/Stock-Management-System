using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem
{
    public partial class main : Form
    {

        MySqlConnection conn;string codee, namee, statuss;

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string t1 = textBox1.Text;
                string t2 = textBox2.Text;

                string productCodeToRemove = t1; // Replace this with the product code you want to remove
                string productNameToRemove = t2;

                foreach (DataGridViewRow row in data.Rows)
                {
                    // Access the cell value in the "product_code" column (replace with your column name)
                    string productCode = row.Cells["product_code"].Value?.ToString();
                    string productName = row.Cells["product_name"].Value?.ToString();

                    // Check if the product code matches the one you want to remove
                    if (productCode == productCodeToRemove)
                    {
                        // Remove the row from the DataGridView
                        data.Rows.Remove(row);
                        break; // Exit the loop after removing the row
                    }

                    if (productName == productNameToRemove)
                    {
                        // Remove the row from the DataGridView
                        data.Rows.Remove(row);
                        break; // Exit the loop after removing the row
                    }


                }
               /* string query = "DELETE FROM products.product_info WHERE product_code='" + productCodeToRemove + "'AND product_name='"+productNameToRemove+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
               */
             
                string queryy = "DELETE FROM products.product_info WHERE product_code='" + productCodeToRemove + "'OR product_name='" + productNameToRemove + "'";
                MySqlCommand cmdd = new MySqlCommand(queryy, conn);
                cmdd.ExecuteNonQuery();
                TableUpdate();

                
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }

        }
        int price, stock;

        public void TableUpdate() {





            try
            {
               
                sales1.Hide();
                data.Rows.Clear();
                conn = new MySqlConnection("server = 127.0.0.1; database = products; username = root; password = 123456;");
                conn.Open();
                string query = "SELECT * FROM product_info;";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {

                    codee = rd.GetString("product_code");
                    namee = rd.GetString("product_name");
                    statuss = rd.GetString("product_status");
                    price = rd.GetInt32("prdouct_price");
                    stock = rd.GetInt32("product_stock");





                    data.Rows.Add(codee, namee, statuss, price, stock);

                }
                rd.Close();

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }


        }


        public void rowSearch() {

            string t1 = textBox1.Text;
            string t2 = textBox2.Text;

            string productCodeToSearch = t1;
            string productNameToSearch = t2;

            foreach (DataGridViewRow row in data.Rows)
            {
                DataGridViewCell cell = row.Cells["product_code"];
                DataGridViewCell celll = row.Cells["product_name"];


                if (cell.Value != null && cell.Value.ToString().Contains(t1)&&celll.Value.ToString().Contains(t2))
                {
                    row.Visible = true;  // Show the row if the search text is found in the specific column
                }
                else
                {
                    row.Visible = false; // Hide the row if the search text is not found in the specific column
                }


               
            }

           


        }

        private void searchh_Click(object sender, EventArgs e)
        {
            rowSearch();







        }

        private void sales_Click(object sender, EventArgs e)
        {
           sales1.Show();
            sales1.BringToFront();
            






        }

        private void products_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableUpdate();

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        public main()
        {
            



            InitializeComponent();

            conn = new MySqlConnection("server = 127.0.0.1; database = products; username = root; password = 123456;");
            conn.Open();
            string query = "SELECT * FROM product_info;";
            MySqlCommand command = new MySqlCommand(query,conn);
            MySqlDataReader rd = command.ExecuteReader();
            while (rd.Read()) {

              codee=  rd.GetString( "product_code" );
              namee = rd.GetString("product_name");
              statuss = rd.GetString("product_status");
              price = rd.GetInt32("prdouct_price");
              stock = rd.GetInt32("product_stock");


             


                data.Rows.Add(codee,namee,statuss,price,stock);

            }
            rd.Close();

          
            




        }


        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string t1 = textBox1.Text;
                string t2 = textBox2.Text;
                string t3 = textBox3.Text;
                string t4 = textBox4.Text;
                data.Rows.Add(t1, t2, 1, t3, t4);
                string q = "INSERT INTO products.product_info (product_code, product_name,product_status,prdouct_price,product_stock) VALUES (@Value1, @Value2, @Value3,@Value4,@Value5)";

                MySqlCommand c = new MySqlCommand(q, conn);

                c.Parameters.AddWithValue("@Value1", t1);
                c.Parameters.AddWithValue("@Value2", t2);
                c.Parameters.AddWithValue("@Value3", true);
                c.Parameters.AddWithValue("@Value4", t3);
                c.Parameters.AddWithValue("@Value5", t4);



                c.ExecuteNonQuery();
            }

            catch (Exception ex) { 
            
            MessageBox.Show( "Product IDs Are The Same Or You Did Not Enter All Values!!!" );
            
            }
            TableUpdate();


            




        }
    }
}
