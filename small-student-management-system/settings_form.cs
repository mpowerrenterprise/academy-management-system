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
    public partial class settings_form : Form
    {

        curd_function database1 = new curd_function();
        my_customized_forms myform = new my_customized_forms();

        //curd_function database2 = new curd_function();
        
        public settings_form()
        {
            InitializeComponent();
        }
        

        private void settings_form_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void change_password_Click(object sender, EventArgs e)
        {
            if (current_password_box.Text != "" && new_password_box.Text != "" && confirm_password_box.Text != "")
            {

                database1.database_name = "small-student-management-system";
                database1.server_IP_domain_name = "localhost";
                database1.server_username = "root";
                database1.server_password = "";
                
               string current_server_password = "";

               MySqlDataReader mydata = database1.mysql_select_method("SELECT password FROM user_account");
                
                while (mydata.Read()) {

                    current_server_password = mydata.GetString("password");
               }

                
                if (current_password_box.Text == current_server_password)
                {
                    if (confirm_password_box.Text == new_password_box.Text)
                    {
                        database1.mysql_update_delete_insert_method("UPDATE user_account SET password = '" + new_password_box.Text + "'");
                        MessageBox.Show("Password changed");
                        this.Hide();
                    }
                    else {
                        myform.CustomErrorBox("Confirm password is wrong!");
                        new_password_box.Clear();
                        confirm_password_box.Clear();
                    }    
                }
                else {
                    myform.CustomErrorBox("Your current password is wrong");
                    current_password_box.Clear();
                }

            }
            else {
                myform.CustomErrorBox("Please enter all data");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
