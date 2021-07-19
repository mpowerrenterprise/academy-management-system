using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace small_student_management_system
{
    class my_customized_forms
    {
        public void CustomErrorBox(string message_data) {

            MessageBox.Show(message_data, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
