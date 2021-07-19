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


namespace small_student_management_system
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        public string addition_method()
        {
            int num1 = 10;
            int num2 = 6;
            int total = num1 + num2;

            return total.ToString();          
        }

        public MySqlDataReader mysql_select_method(string sqlcode) {

            MySqlConnection my_connect = new MySqlConnection("SERVER=localhost;DATABASE=small-student-management-system;UID=root;PASSWORD=");
            my_connect.Open();

            MySqlCommand my_command = new MySqlCommand(sqlcode, my_connect);

            MySqlDataReader my_data = my_command.ExecuteReader();
            
            return my_data;
            
        }

       
        private void login_btn_Click(object sender, EventArgs e)
        {
            
            if (username_textbox.Text != "" && password_textbox.Text != "")
            {

                string database_username = "";
                string database_password = "";

                MySqlDataReader returned_my_data = mysql_select_method("SELECT username, password FROM user_account");

                while (returned_my_data.Read()) {

                    database_username = returned_my_data.GetString("username");
                    database_password = returned_my_data.GetString("password");
                        
                }

                if (username_textbox.Text == database_username && password_textbox.Text == database_password)
                {

                    dashboard dash = new dashboard();
                    dash.Show();
                    this.Hide();
                }
                else {

                    MessageBox.Show("Your password or username is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    username_textbox.Clear();
                    password_textbox.Clear();
                }

            }
            else {
                
                MessageBox.Show("Please enter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string total_value = addition_method();
            MessageBox.Show(total_value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            students_class student1 = new students_class();
            student1.fname = "guna";
            student1.attendSchool("dasdsa");


            students_class student2 = new students_class();
            student2.attendSchool("dsadsa");
 
        }
    }
}
