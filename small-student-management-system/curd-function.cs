using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace small_student_management_system
{
    class curd_function
    {

        public string database_name = "";
        public string server_IP_domain_name = "";
        public string server_username = "";
        public string server_password = "";


        public MySqlDataReader mysql_select_method(string sqlcode)
        {

            MySqlConnection my_connect = new MySqlConnection("SERVER="+server_IP_domain_name+";DATABASE="+database_name+";UID="+server_username+";PASSWORD="+server_password+"");
            my_connect.Open();

            MySqlCommand my_command = new MySqlCommand(sqlcode, my_connect);

            MySqlDataReader my_data = my_command.ExecuteReader();

            return my_data;

        }

        public void mysql_update_delete_insert_method(string sqlcode)
        {

            MySqlConnection my_connect = new MySqlConnection("SERVER=" + server_IP_domain_name + ";DATABASE=" + database_name + ";UID=" + server_username + ";PASSWORD=" + server_password + "");
            my_connect.Open();
            
            MySqlCommand myCommand = new MySqlCommand(sqlcode, my_connect);
            myCommand.ExecuteNonQuery();
            

        }


    }
}
