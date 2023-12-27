using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class register : Form
    {
        MySqlConnection con;

        public register()
        {
            InitializeComponent();

           con = new MySqlConnection("server = 127.0.0.1; database = person; username = root; password = 123456;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string querystring = "INSERT INTO person.person_info (password, username, mails) VALUES ('" + password.Text + "', '" + username.Text + "', '" + mail.Text + "')";

            
            MySqlCommand cmd = new MySqlCommand(querystring,con);
            if (password.Text == confirmpassword.Text)
            {

                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully Registered");



            }

            else {

                MessageBox.Show("Passwords are not matched");
            
            }
            con.Close();



        }
    }
}
