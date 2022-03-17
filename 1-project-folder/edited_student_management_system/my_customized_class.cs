using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edited_student_management_system
{
    class my_customized_class
    {
        public void custom_error_box_method(string message_data)
        {
            MessageBox.Show(message_data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

     }
}
