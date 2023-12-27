using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        MySqlConnection mysqlConnection;

        public Form1()
        {
            InitializeComponent();

            mysqlConnection = new MySqlConnection("server=127.0.0.1;database=person;username=root;password=123456;");
            


                    
            





          

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                mysqlConnection.Open();
                string l = "";
                string k = "";
                string passwordd = "";
                string maill="";
                


                string name = username.Text;
                string queryy;
                string pwd = password.Text;

                string query = "SELECT * FROM person.person_info WHERE username='" + name + "'AND password='"+pwd+"'AND mails='"+mail.Text +"'";


                MySqlCommand command = new MySqlCommand(query, mysqlConnection);
                MySqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    l = rd.GetString("username");

                    passwordd = rd.GetString("password");

                    maill=rd.GetString("mails");

                }
                rd.Close();


                mysqlConnection.Close();

                if (name == l && pwd == passwordd && maill == mail.Text)
                {


                    MessageBox.Show("Succesully Logged In ");
                    new main().Show();


                }

                else {

                    MessageBox.Show("Username or Password is Not Correct");


                }




            

            

               


            






          
            


            

            

                
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new register().Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            new forgot_password().Show();






        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
