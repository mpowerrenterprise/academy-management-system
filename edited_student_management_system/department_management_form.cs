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
    public partial class department_management_form : Form
    {
        //from CLASS_forms for creating new objects
        curd_function database1 = new curd_function();
        my_customized_class my_custom_obj = new my_customized_class();

        public department_management_form()
        {
            InitializeComponent();
        }

        private void department_management_form_Load(object sender, EventArgs e)
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
            DataTable depart_table = new DataTable();
            depart_table.Columns.Add("Auto ID");
            depart_table.Columns.Add("Department ID");
            depart_table.Columns.Add("Department Name");
            depart_table.Columns.Add("Guardian");
            depart_table.Columns.Add("Description");
            depart_table.Columns.Add("Income");

            MySqlDataReader data_for_grid = database1.mysql_select_method("SELECT * FROM department_info_table");

            while (data_for_grid.Read())
            {
                depart_table.Rows.Add(data_for_grid.GetString(0), data_for_grid.GetString(1), data_for_grid.GetString(2), data_for_grid.GetString(3), data_for_grid.GetString(4), data_for_grid.GetString(5));
            }
            department_dataGridView.DataSource = depart_table;
        }

        //method for CLEAR-ALL-TEXTBOXES
        public void clear_all_textboxes()
        {
            department_id_textbox.Clear();
            department_name_combo_box.Text = "";
            guardian_textbox.Clear();
            description_textbox.Clear();
            income_textbox.Clear();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //INSERT method for insert whole datas
            if (department_id_textbox.Text != "" && department_name_combo_box.Text != "" && guardian_textbox.Text != "" && description_textbox.Text != "" &&
                income_textbox.Text != "")
            {
                string uid_sqlcode = "INSERT INTO department_info_table VALUES('' , '" + department_id_textbox.Text + "', '" + department_name_combo_box.Text + "', '" + guardian_textbox.Text + "', '" + description_textbox.Text + "' , '" + income_textbox.Text + "' )";

                database1.mysql_insert_update_delete_method(uid_sqlcode);

                MessageBox.Show("Data Enterted Successfully");
                clear_all_textboxes();
            }
        }

        //for GET button - get datas using department-id from server
        //SELECT code using Search-ID
        private void get_btn_Click(object sender, EventArgs e)
        {
            string s_sqlcode = "SELECT * FROM department_info_table WHERE department_id = '" + search_id_textbox.Text + "' ";

            MySqlDataReader my_data = database1.mysql_select_method(s_sqlcode);

            while (my_data.Read())
            {
                //REFILLING textboxes from server datas
                department_id_textbox.Text = my_data.GetString("department_id");
                department_name_combo_box.Text = my_data.GetString("department_name");
                guardian_textbox.Text = my_data.GetString("guardian");
                description_textbox.Text = my_data.GetString("description");
                income_textbox.Text = my_data.GetString("income");
            }
        }

        //textboxes UPDATE code
        private void update_btn_Click(object sender, EventArgs e)
        {
            string uid_sqlcode = "UPDATE department_info_table SET department_name='" + department_name_combo_box.Text + "' , guardian='" + guardian_textbox.Text + "' , description='" + description_textbox.Text + "' , income='" + income_textbox.Text + "' WHERE department_id ='" + search_id_textbox.Text + "' ";
            database1.mysql_insert_update_delete_method(uid_sqlcode);
            MessageBox.Show("Successfully Updated");
            clear_all_textboxes();
        }

        //DELETE department datas code using subject-ID
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Dialog_Box code for Before deleting something
            DialogResult dialog_result = MessageBox.Show("Are you sure you want to delete this?", "Deletion", MessageBoxButtons.YesNo);

            if (dialog_result == DialogResult.Yes)
            {
                string uid_sqlcode = "DELETE FROM department_info_table WHERE department_id = '" + search_id_textbox.Text + "' ";
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
