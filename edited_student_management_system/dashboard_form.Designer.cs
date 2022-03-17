namespace edited_student_management_system
{
    partial class dashboard_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traineeManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gurdianManagemenrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gurdianManagemenrToolStripMenuItem,
            this.traineeManagementToolStripMenuItem,
            this.toolStripMenuItem1,
            this.subjectManagementToolStripMenuItem,
            this.departmentManagementToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 7, 0, 7);
            this.menuStrip1.Size = new System.Drawing.Size(1736, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(268, 29);
            this.toolStripMenuItem1.Text = "Student Management";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // subjectManagementToolStripMenuItem
            // 
            this.subjectManagementToolStripMenuItem.Name = "subjectManagementToolStripMenuItem";
            this.subjectManagementToolStripMenuItem.Size = new System.Drawing.Size(266, 29);
            this.subjectManagementToolStripMenuItem.Text = "Subject Management";
            this.subjectManagementToolStripMenuItem.Click += new System.EventHandler(this.subjectManagementToolStripMenuItem_Click);
            // 
            // departmentManagementToolStripMenuItem
            // 
            this.departmentManagementToolStripMenuItem.Name = "departmentManagementToolStripMenuItem";
            this.departmentManagementToolStripMenuItem.Size = new System.Drawing.Size(318, 29);
            this.departmentManagementToolStripMenuItem.Text = "Department Management";
            this.departmentManagementToolStripMenuItem.Click += new System.EventHandler(this.departmentManagementToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.resultsToolStripMenuItem.Text = "Results";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // traineeManagementToolStripMenuItem
            // 
            this.traineeManagementToolStripMenuItem.Name = "traineeManagementToolStripMenuItem";
            this.traineeManagementToolStripMenuItem.Size = new System.Drawing.Size(269, 29);
            this.traineeManagementToolStripMenuItem.Text = "Trainee Management";
            this.traineeManagementToolStripMenuItem.Click += new System.EventHandler(this.traineeManagementToolStripMenuItem_Click_1);
            // 
            // gurdianManagemenrToolStripMenuItem
            // 
            this.gurdianManagemenrToolStripMenuItem.Name = "gurdianManagemenrToolStripMenuItem";
            this.gurdianManagemenrToolStripMenuItem.Size = new System.Drawing.Size(274, 29);
            this.gurdianManagemenrToolStripMenuItem.Text = "Gurdian Management";
            this.gurdianManagemenrToolStripMenuItem.Click += new System.EventHandler(this.gurdianManagemenrToolStripMenuItem_Click_1);
            // 
            // dashboard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1736, 893);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subjectManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gurdianManagemenrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traineeManagementToolStripMenuItem;
    }
}