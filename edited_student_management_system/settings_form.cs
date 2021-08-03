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
    public partial class settings_form : Form
    {
        curd_function database1 = new curd_function();
        my_customized_class my_custom_obj = new my_customized_class();

        public settings_form()
        {
            InitializeComponent();
        }

        private void settings_form_Load(object sender, EventArgs e)
        {
            //DATABASE connection
            database1.server_IP_domain_name = "localhost";
            database1.database_name = "edited_student_management_system";
            database1.server_username = "root";
            database1.server_password = "";
        }

        private void password_change_btn_Click(object sender, EventArgs e)
        {
            //for SELECT Method
            string current_server_password = "";

            MySqlDataReader my_data = database1.mysql_select_method("SELECT password from login_table");

            while (my_data.Read())
            {
                current_server_password = my_data.GetString("password");

                if (current_password_textbox.Text != "" && new_password_textbox.Text != "" && confirm_password_textbox.Text != "")
                {
                    if (current_server_password == current_password_textbox.Text)
                    {
                        if (new_password_textbox.Text == confirm_password_textbox.Text)
                        {
                            //for UPDATE Method
                            database1.mysql_insert_update_delete_method("UPDATE login_table SET password ='"+confirm_password_textbox.Text+"'");

                            MessageBox.Show("Password changed successfully");
                            this.Hide();
                        }
                        else
                        {
                            my_custom_obj.custom_error_box_method("Confirm password doesn't match");
                            new_password_textbox.Clear();
                            confirm_password_textbox.Clear();
                        }
                    }
                    else
                    {
                        my_custom_obj.custom_error_box_method("Please check your current password");
                        current_password_textbox.Clear();
                    }
                }
                else
                {
                    my_custom_obj.custom_error_box_method("Please fill all fields");

                }
            }
        }
    }
}
