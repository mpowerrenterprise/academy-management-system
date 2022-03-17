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
    public partial class subject_management_form : Form
    {
        //from CLASS_forms for creating new objects
        curd_function database1 = new curd_function();
        my_customized_class my_custom_obj = new my_customized_class();

        public subject_management_form()
        {
            InitializeComponent();
        }

        private void subject_management_form_Load(object sender, EventArgs e)
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
            DataTable subject_table = new DataTable();
            subject_table.Columns.Add("Auto ID");
            subject_table.Columns.Add("Subject ID");
            subject_table.Columns.Add("Subject Name");
            subject_table.Columns.Add("Trainee");
            subject_table.Columns.Add("Description");
            subject_table.Columns.Add("Duration");

            MySqlDataReader data_for_grid = database1.mysql_select_method("SELECT * FROM subject_info_table");

            while (data_for_grid.Read())
            {
                subject_table.Rows.Add(data_for_grid.GetString(0), data_for_grid.GetString(1), data_for_grid.GetString(2), data_for_grid.GetString(3), data_for_grid.GetString(4), data_for_grid.GetString(5));
            }
            subjects_dataGridView.DataSource = subject_table;
        }

        //method for CLEAR-ALL-TEXTBOXES
        public void clear_all_textboxes()
        {
            subject_id_textbox.Clear();
            subject_name_combo_box.Text = "";
            trainee_textbox.Clear();
            subject_description_textbox.Clear();
            duration_textbox.Clear();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            //INSERT method for insert whole datas
            if (subject_id_textbox.Text != "" && subject_name_combo_box.Text != "" && trainee_textbox.Text != "" && subject_description_textbox.Text != "" &&
                duration_textbox.Text != "")
            {
                string uid_sqlcode = "INSERT INTO subject_info_table VALUES('' , '" + subject_id_textbox.Text + "', '" + subject_name_combo_box.Text + "', '" + trainee_textbox.Text + "', '" + subject_description_textbox.Text + "' , '" + duration_textbox.Text + "' )";

                database1.mysql_insert_update_delete_method(uid_sqlcode);

                MessageBox.Show("Data Enterted Successfully");
                clear_all_textboxes();
            }
        }

        //for GET button - get datas using subject-id from server
        //SELECT code using Search-ID
        private void get_btn_Click(object sender, EventArgs e)
        {
            string s_sqlcode = "SELECT * FROM subject_info_table WHERE subject_id = '" + subject_search_id_textbox.Text + "' ";

            MySqlDataReader my_data = database1.mysql_select_method(s_sqlcode);

            while (my_data.Read())
            {
                //REFILLING textboxes from server datas
                subject_id_textbox.Text = my_data.GetString("subject_id");
                subject_name_combo_box.Text = my_data.GetString("subject_name");
                trainee_textbox.Text = my_data.GetString("trainee");
                subject_description_textbox.Text = my_data.GetString("description");
                duration_textbox.Text = my_data.GetString("duration");
            }
        }

        //textboxes UPDATE code
        private void update_btn_Click(object sender, EventArgs e)
        {
            string uid_sqlcode = "UPDATE subject_info_table SET subject_name='" + subject_name_combo_box.Text + "' , trainee='" + trainee_textbox.Text + "' , description='" + subject_description_textbox.Text + "' , duration='" + duration_textbox.Text + "' WHERE subject_id ='" + subject_search_id_textbox.Text + "' ";
            database1.mysql_insert_update_delete_method(uid_sqlcode);
            MessageBox.Show("Successfully Updated");
            clear_all_textboxes();
        }

        //DELETE subject datas code using subject-ID
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //Dialog_Box code for Before deleting something
            DialogResult dialog_result = MessageBox.Show("Are you sure you want to delete this?", "Deletion", MessageBoxButtons.YesNo);

            if (dialog_result == DialogResult.Yes)
            {
                string uid_sqlcode = "DELETE FROM subject_info_table WHERE subject_id = '" + subject_search_id_textbox.Text + "' ";
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
