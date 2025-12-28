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
            btnResults = new Button();
            btnAttendance = new Button();
            btnTeachers = new Button();
            btnStudents = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStudents.ForeColor = Color.Snow;
            lblStudents.Location = new Point(112, 35);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(0, 31);
            lblStudents.TabIndex = 0;
            // 
            // lblTeachers
            // 
            lblTeachers.AutoSize = true;
            lblTeachers.BackColor = Color.LavenderBlush;
            lblTeachers.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblTeachers.ForeColor = Color.RosyBrown;
            lblTeachers.Location = new Point(109, 188);
            lblTeachers.Name = "lblTeachers";
            lblTeachers.Size = new Size(0, 31);
            lblTeachers.TabIndex = 1;
            // 
            // lblAttendance
            // 
            lblAttendance.AutoSize = true;
            lblAttendance.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAttendance.ForeColor = Color.Snow;
            lblAttendance.Location = new Point(527, 35);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(0, 31);
            lblAttendance.TabIndex = 2;
            lblAttendance.Click += lblAttendance_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResults.ForeColor = Color.RosyBrown;
            lblResults.Location = new Point(548, 188);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(26, 31);
            lblResults.TabIndex = 3;
            lblResults.Text = "  ";
            lblResults.Click += lblResults_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(btnResults);
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(btnTeachers);
            panel1.Controls.Add(btnStudents);
            panel1.Controls.Add(lblStudents);
            panel1.Controls.Add(lblResults);
            panel1.Controls.Add(lblTeachers);
            panel1.Controls.Add(lblAttendance);
            panel1.Location = new Point(12, 89);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50, 25, 50, 25);
            panel1.Size = new Size(1082, 516);
            panel1.TabIndex = 4;
            // 
            // btnResults
            // 
            btnResults.BackColor = Color.RosyBrown;
            btnResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResults.Location = new Point(619, 268);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(233, 79);
            btnResults.TabIndex = 7;
            btnResults.Text = "RESULTS";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.RosyBrown;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.Location = new Point(619, 123);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(233, 79);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "ATTENDANCE";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = Color.RosyBrown;
            btnTeachers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeachers.Location = new Point(210, 268);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(229, 79);
            btnTeachers.TabIndex = 5;
            btnTeachers.Text = "TEACHERS";
            btnTeachers.UseVisualStyleBackColor = false;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.RosyBrown;
            btnStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(210, 123);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(229, 79);
            btnStudents.TabIndex = 4;
            btnStudents.Text = "STUDENTS";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(237, 31);
            label1.Name = "label1";
            label1.Size = new Size(642, 39);
            label1.TabIndex = 5;
            label1.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1106, 619);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudents;
        private Label lblTeachers;
        private Label lblAttendance;
        private Label lblResults;
        private Panel panel1;
        private Button btnAttendance;
        private Button btnTeachers;
        private Button btnStudents;
        private Button btnResults;
        private Label label1;
    }
}