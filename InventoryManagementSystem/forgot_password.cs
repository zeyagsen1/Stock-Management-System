using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Net.Configuration;

namespace InventoryManagementSystem
{
    public partial class forgot_password : Form
    {
        MySqlConnection conn;
        public forgot_password()
        {
            InitializeComponent();
            timer1.Start();
            label2.Enabled = false; 
             code.Enabled = false;
            label3.Enabled = false;
            new_password.Enabled = false;

            confirm.Enabled = false;
            conn = new MySqlConnection("server=127.0.0.1;database=person;username=root;password=123456;");
            

        }
        int vcode=4; string s="";
        string us = "",ma="";
        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query="Select username,mails FROM person.person_info WHERE username='"+username_text.Text+"'AND mails='"+mailText.Text+"'";
            MySqlCommand mc = new MySqlCommand(query,conn);

            MySqlDataReader rd=mc.ExecuteReader();
             while (rd.Read()) {

                us = rd.GetString("username");
                ma = rd.GetString("mails");


            }
            rd.Close();

            if (ma == mailText.Text && us == username_text.Text)
            {

                timer1.Stop();
                MailMessage mail = new MailMessage();
                mail.To.Add(mailText.Text);
                mail.From = new MailAddress("your mail address");
                mail.Subject = "Verification Code: ";
                mail.Body = "Verification code is " + vcode;
                SmtpClient stmp = new SmtpClient("smtp.gmail.com");
                stmp.Port = 587;
                stmp.EnableSsl = true;
                stmp.DeliveryMethod = SmtpDeliveryMethod.Network;
                stmp.Credentials = new NetworkCredential("your mail adress ", "get app code for your google account and write here");
                 

                 
                stmp.Send(mail);



                MessageBox.Show("Verification code sent succesfully");

                label2.Enabled = true;
                code.Enabled = true;
                label3.Enabled = true;
                new_password.Enabled = true;
                confirm.Enabled = true;




            }

            else {

                MessageBox.Show("Username and Mail Address are not matched");
            
            }



            conn.Close();


          



                




            

            



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (vcode > 9999) {

                vcode = 1000;
            }

            vcode += 1;
          


        }
        string maill="";
        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "Select username,mails FROM person.person_info WHERE username='" + username_text.Text + "'AND mails='"+mailText.Text+"'";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    s = rd.GetString("username");
                    maill = rd.GetString("mails");

                }
                rd.Close();


                if (s == username_text.Text && mailText.Text == maill && vcode.ToString() == code.Text)
                {


                    string queryyy = "UPDATE person.person_info SET password='" + new_password.Text + "'" + "WHERE username='" + s + "'AND mails='" + maill + "'";
                    MySqlCommand commandd = new MySqlCommand(queryyy, conn);
                    commandd.ExecuteNonQuery();


                    MessageBox.Show("Password is updated succesfully!");


                }

                else {


                    MessageBox.Show("Verification Code,Username Or Mail Adress are not correct!");
                }


                conn.Close();

                
            }


            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }




            


            
        }
    }
}
