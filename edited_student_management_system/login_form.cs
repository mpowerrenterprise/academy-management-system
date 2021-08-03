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

namespace edited_student_management_system
{
    public partial class login_form : Form
    {
        curd_function databse1 = new curd_function();
        my_customized_class my_custom_obj = new my_customized_class();

        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            //for SELECT Method

            databse1.server_IP_domain_name = "localhost";
            databse1.database_name = "edited_student_management_system";
            databse1.server_username = "root";
            databse1.server_password = "";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string current_server_username = "";
            string current_server_password = "";

            MySqlDataReader my_data = databse1.mysql_select_method("SELECT username, password FROM login_table");

            while (my_data.Read()){

                current_server_username = my_data.GetString("username");
                current_server_password = my_data.GetString("password");

                if (username_textbox.Text != "" && password_textbox.Text != "")
                {
                    if (current_server_username == username_textbox.Text && current_server_password == password_textbox.Text)
                    {
                        MessageBox.Show("You're logged in");
                        this.Hide();

                        dashboard_form dashboard_form1 = new dashboard_form();
                        dashboard_form1.Show();
                        this.Hide();
                    }
                    else
                    {
                       my_custom_obj.custom_error_box_method("Please check your Username or Password");
                       username_textbox.Clear();
                       password_textbox.Clear();
                    }
                }
                else
                {
                    my_custom_obj.custom_error_box_method("Please fill all fields");                    
                    username_textbox.Clear();
                    password_textbox.Clear();
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
