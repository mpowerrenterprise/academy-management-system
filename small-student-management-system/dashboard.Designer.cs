namespace small_student_management_system
{
    partial class dashboard
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardianManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardianManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagementToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.departmentManagementToolStripMenuItem,
            this.resultsManagementToolStripMenuItem,
            this.logoutToolStripMenuItem1,
            this.logoutToolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1924, 36);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            this.studentManagementToolStripMenuItem.Click += new System.EventHandler(this.studentManagementToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjectManagementToolStripMenuItem});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.logoutToolStripMenuItem.Text = "Trainer Management";
            // 
            // subjectManagementToolStripMenuItem
            // 
            this.subjectManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardianManagementToolStripMenuItem});
            this.subjectManagementToolStripMenuItem.Name = "subjectManagementToolStripMenuItem";
            this.subjectManagementToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.subjectManagementToolStripMenuItem.Text = "Subject Management";
            // 
            // guardianManagementToolStripMenuItem
            // 
            this.guardianManagementToolStripMenuItem.Name = "guardianManagementToolStripMenuItem";
            this.guardianManagementToolStripMenuItem.Size = new System.Drawing.Size(307, 32);
            this.guardianManagementToolStripMenuItem.Text = "Guardian Management";
            // 
            // departmentManagementToolStripMenuItem
            // 
            this.departmentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardianManagementToolStripMenuItem1});
            this.departmentManagementToolStripMenuItem.Name = "departmentManagementToolStripMenuItem";
            this.departmentManagementToolStripMenuItem.Size = new System.Drawing.Size(270, 32);
            this.departmentManagementToolStripMenuItem.Text = "Department Management";
            this.departmentManagementToolStripMenuItem.Click += new System.EventHandler(this.departmentManagementToolStripMenuItem_Click);
            // 
            // guardianManagementToolStripMenuItem1
            // 
            this.guardianManagementToolStripMenuItem1.Name = "guardianManagementToolStripMenuItem1";
            this.guardianManagementToolStripMenuItem1.Size = new System.Drawing.Size(307, 32);
            this.guardianManagementToolStripMenuItem1.Text = "Guardian Management";
            // 
            // resultsManagementToolStripMenuItem
            // 
            this.resultsManagementToolStripMenuItem.Name = "resultsManagementToolStripMenuItem";
            this.resultsManagementToolStripMenuItem.Size = new System.Drawing.Size(223, 32);
            this.resultsManagementToolStripMenuItem.Text = "Results Management";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(101, 32);
            this.logoutToolStripMenuItem1.Text = "Settings";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem2
            // 
            this.logoutToolStripMenuItem2.Name = "logoutToolStripMenuItem2";
            this.logoutToolStripMenuItem2.Size = new System.Drawing.Size(90, 32);
            this.logoutToolStripMenuItem2.Text = "Logout";
            this.logoutToolStripMenuItem2.Click += new System.EventHandler(this.logoutToolStripMenuItem2_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1045);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subjectManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardianManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardianManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem2;
    }
}