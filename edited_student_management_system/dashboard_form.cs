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
    public partial class dashboard_form : Form
    {
        public dashboard_form()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form login_form1 = new login_form();
            login_form1.Show();
            this.Hide();
        }

        // mdiParent forms are in below
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings_form settings_form1 = new settings_form();
            settings_form1.MdiParent = this;
            settings_form1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            student_management_form student_management1 = new student_management_form();
            student_management1.MdiParent = this;
            student_management1.Show();
        }

        private void gurdianManagemenrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardian_management_form guardian_management1 = new guardian_management_form();
            guardian_management1.MdiParent = this;
            guardian_management1.Show();
        }

        private void traineeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void subjectManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subject_management_form subject_management1 = new subject_management_form();
            subject_management1.MdiParent = this;
            subject_management1.Show();
        }

        private void departmentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department_management_form department_management1 = new department_management_form();
            department_management1.MdiParent = this;
            department_management1.Show();
        }

        private void gurdianManagemenrToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            guardian_management_form guardian_management1 = new guardian_management_form();
            guardian_management1.MdiParent = this;
            guardian_management1.Show();

        }

        private void traineeManagementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            trainee_management_form trainee_management1 = new trainee_management_form();
            trainee_management1.MdiParent = this;
            trainee_management1.Show();
        }
    }
}
