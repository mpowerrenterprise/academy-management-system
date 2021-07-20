using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace small_student_management_system
{
    public partial class student_management_form : Form
    {
        public student_management_form()
        {
            InitializeComponent();
        }

        my_customized_forms mycustomObj = new my_customized_forms();
        curd_function curdObj = new curd_function();


        private void Form1_Load(object sender, EventArgs e)
        {
            curdObj.database_name = "small-student-management-system";
            curdObj.server_IP_domain_name = "localhost";
            curdObj.server_username = "root";
            curdObj.server_password = "";

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void clearTextBoxes() {

            student_id_box.Clear();
            firstname_box.Clear();
            batch_no_box.Clear();
            lastname_box.Clear();
            department_box.Text = "";
            phone__box.Clear();
            email__box.Clear();
            born_date.Clear();
            male_button.Checked = false;
            female_button.Checked = false;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (student_id_box.Text != "" && batch_no_box.Text != "" && firstname_box.Text != "" && lastname_box.Text != "" && email__box.Text != "" && phone__box.Text != "" && female_button.Checked == true || male_button.Checked == true)
            {

                string gender = "";

                if (female_button.Checked == true) {

                    gender = "female";

                } else {

                    gender = "male";
                }

                string sqlcode = "INSERT INTO student_info VALUES('','"+ student_id_box.Text + "', '"+firstname_box.Text+"', '"+lastname_box.Text+"', '"+gender+"','"+born_date.Text+"','"+email__box.Text+"','"+phone__box.Text+"','"+department_box.Text+"')";
                curdObj.mysql_update_delete_insert_method(sqlcode);
                clearTextBoxes();
                MessageBox.Show("Data Enterd Successfully");

            }

            else {

                mycustomObj.CustomErrorBox("Please fill all colunms");
            }
        }
    }
}
