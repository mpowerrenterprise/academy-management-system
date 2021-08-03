using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edited_student_management_system
{
    class curd_function
    {
        public string server_IP_domain_name = "";
        public string database_name = "";
        public string server_username = "";
        public string server_password = "";

        public MySqlDataReader mysql_select_method(string s_sqlcode)
        {
            MySqlConnection my_s_connect = new MySqlConnection("SERVER="+server_IP_domain_name+" ; DATABASE=edited_student_management_system ; USER=root ; PASSWORD= ");
            my_s_connect.Open();

            MySqlCommand my_s_command = new MySqlCommand(s_sqlcode, my_s_connect);

            MySqlDataReader my_data = my_s_command.ExecuteReader();

            return my_data;
        }
        
        public void mysql_insert_update_delete_method(string uid_sqlcode)
        {
            MySqlConnection my_uid_connect = new MySqlConnection("SERVER=" + server_IP_domain_name + " ; DATABASE=edited_student_management_system ; USER=root ; PASSWORD= ");
            my_uid_connect.Open();

            MySqlCommand my_uid_command = new MySqlCommand(uid_sqlcode, my_uid_connect);

            my_uid_command.ExecuteNonQuery();
        }

    }
}
