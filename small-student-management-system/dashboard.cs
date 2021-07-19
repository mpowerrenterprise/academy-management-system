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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departmentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            settings_form sf = new settings_form();
            sf.MdiParent = this;
            sf.Show();
        }

        private void logoutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            login_form login_form1 = new login_form();
            login_form1.Show();
            this.Hide();
        }
    }
}
