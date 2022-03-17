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
    public partial class guardian_management_form : Form
    {
        //from CLASS_forms for creating new objects
        curd_function database1 = new curd_function();
        my_customized_class my_custom_obj = new my_customized_class();

        public guardian_management_form()
        {
            InitializeComponent();
        }


        private void guardian_management_form_Load(object sender, EventArgs e)
        {
            //DATABASE connection
            database1.server_IP_domain_name = "localhost";
            database1.database_name = "edited_student_management_system";
            database1.server_username = "root";
            database1.server_password = "";

            //for GridView
            selection_gridview_data_method();
        }

        //method for GridView
        public void selection_gridview_data_method()
        {
            DataTable gur_table = new DataTable();
            gur_table.Columns.Add("Auto ID");
            gur_table.Columns.Add("Guardian ID");
            gur_table.Columns.Add("First Name");
            gur_table.Columns.Add("Last Name");
            gur_table.Columns.Add("Date of Birth");
            gur_table.Columns.Add("Gender");
            gur_table.Columns.Add("Email");
            gur_table.Columns.Add("Contact No");
            gur_table.Columns.Add("Department");

            MySqlDataReader data_for_grid = database1.mysql_select_method("SELECT * FROM guardian_info_table");

            while (data_for_grid.Read())
            {
                gur_table.Rows.Add(data_for_grid.GetString(0), data_for_grid.GetString(1), data_for_grid.GetString(2), data_for_grid.GetString(3), data_for_grid.GetString(4), data_for_grid.GetString(5), data_for_grid.GetString(6), data_for_grid.GetString(7), data_for_grid.GetString(8) );
            }
            guardian_dataGridView.DataSource = gur_table;
        }

        //method for CLEAR-ALL-TEXTBOXES
        public void clear_all_textboxes()
        {
            guardian_id_textbox.Clear();
            firstname_textbox.Clear();
            lastname_textbox.Clear();
            dob_textbox.Clear();
            email_textbox.Clear();
            contact_no_textbox.Clear();
            department_combo_box.Text = "";
            female_radio_btn.Checked = false;
            male_radio_btn.Checked = false;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //INSERT method for insert whole datas
            if (guardian_id_textbox.Text != "" && firstname_textbox.Text != "" && lastname_textbox.Text != "" && dob_textbox.Text != "" &&
                email_textbox.Text != "" && contact_no_textbox.Text != "" && department_combo_box.Text != "" && female_radio_btn.Checked == true || male_radio_btn.Checked == true)
            {
                string gender = "";
                if (male_radio_btn.Checked == true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }

                string uid_sqlcode = "INSERT INTO guardian_info_table VALUES('' , '" + guardian_id_textbox.Text + "', '" + firstname_textbox.Text + "', '" + lastname_textbox.Text + "', '" + dob_textbox.Text + "', '" + gender + "' , '" + email_textbox.Text + "', '" + contact_no_textbox.Text + "' ,'" + department_combo_box.Text + "' )"; 
                
                database1.mysql_insert_update_delete_method(uid_sqlcode);

                MessageBox.Show("Data Enterted Successfully");
                clear_all_textboxes();
            }
            else
            {
                my_custom_obj.custom_error_box_method("Please fill all the fields");
            }
        }

        //for GET button - get datas using guardian-id from server
        //SELECT code using Search-ID
        private void get_btn_Click(object sender, EventArgs e)
        {
            string s_sqlcode = "SELECT * FROM guardian_info_table WHERE guardian_id = '" + search_id_textbox.Text + "' ";

            MySqlDataReader my_data = database1.mysql_select_method(s_sqlcode);

            while (my_data.Read())
            {
                //REFILLING textboxes from server datas
                guardian_id_textbox.Text = my_data.GetString("guardian_id");
                firstname_textbox.Text = my_data.GetString("first_name");
                lastname_textbox.Text = my_data.GetString("last_name");
                dob_textbox.Text = my_data.GetString("dob");

                string gender = my_data.GetString("gender");
                if (gender == "male")
                {
                    male_radio_btn.Checked = true;
                }
                else
                {
                    female_radio_btn.Checked = true;
                }
                email_textbox.Text = my_data.GetString("email");
                contact_no_textbox.Text = my_data.GetString("contact_no");
                department_combo_box.Text = my_data.GetString("department");
            }
        }

        //textboxes UPDATE code
        private void update_btn_Click(object sender, EventArgs e)
        {
            string gender = "";
                if (male_radio_btn.Checked == true)
                {
                    gender = "male";
                }
                else
                {
                    gender = "female";
                }

            string uid_sqlcode = "UPDATE guardian_info_table SET first_name='" + firstname_textbox.Text + "' , last_name='" + lastname_textbox.Text + "' , dob='" + dob_textbox.Text + "' , gender='" + gender + "' , email='" + email_textbox.Text + "' , contact_no='" + contact_no_textbox.Text + "' , department='" + department_combo_box.Text + "' WHERE guardian_id ='"+search_id_textbox.Text+"' ";
            database1.mysql_insert_update_delete_method(uid_sqlcode);
            MessageBox.Show("Successfully Updated");
            clear_all_textboxes();
        }

        //DELETE guardian datas code using gurdian-ID
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Dialog_Box code for Before deleting something
            DialogResult dialog_result = MessageBox.Show("Are you sure you want to delete this?" , "Deletion", MessageBoxButtons.YesNo);
            
            if (dialog_result == DialogResult.Yes){
                string uid_sqlcode = "DELETE FROM guardian_info_table WHERE gurdian_id = '" + search_id_textbox.Text + "' ";
                database1.mysql_insert_update_delete_method(uid_sqlcode);
                MessageBox.Show("Successfully Deleted");
                clear_all_textboxes();
            }
            else
            {
                clear_all_textboxes();
            }
        }
    }
}
