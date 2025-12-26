namespace School_Information_System
{
    partial class DashboardForm
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
            lblStudents = new Label();
            lblTeachers = new Label();
            lblAttendance = new Label();
            lblResults = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Location = new Point(66, 39);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(66, 20);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "Students";
            // 
            // lblTeachers
            // 
            lblTeachers.AutoSize = true;
            lblTeachers.Location = new Point(238, 39);
            lblTeachers.Name = "lblTeachers";
            lblTeachers.Size = new Size(66, 20);
            lblTeachers.TabIndex = 1;
            lblTeachers.Text = "Teachers";
            // 
            // lblAttendance
            // 
            lblAttendance.AutoSize = true;
            lblAttendance.Location = new Point(439, 39);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(85, 20);
            lblAttendance.TabIndex = 2;
            lblAttendance.Text = "Attendance";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(659, 39);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(55, 20);
            lblResults.TabIndex = 3;
            lblResults.Text = "Results";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblStudents);
            panel1.Controls.Add(lblResults);
            panel1.Controls.Add(lblTeachers);
            panel1.Controls.Add(lblAttendance);
            panel1.Location = new Point(2, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 116);
            panel1.TabIndex = 4;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStudents;
        private Label lblTeachers;
        private Label lblAttendance;
        private Label lblResults;
        private Panel panel1;
    }
}