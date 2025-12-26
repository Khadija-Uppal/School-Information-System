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
            lblStudents.ForeColor = SystemColors.ButtonHighlight;
            lblStudents.Location = new Point(99, 35);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(103, 31);
            lblStudents.TabIndex = 0;
            lblStudents.Text = "Students";
            // 
            // lblTeachers
            // 
            lblTeachers.AutoSize = true;
            lblTeachers.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblTeachers.ForeColor = SystemColors.ButtonHighlight;
            lblTeachers.Location = new Point(99, 188);
            lblTeachers.Name = "lblTeachers";
            lblTeachers.Size = new Size(106, 31);
            lblTeachers.TabIndex = 1;
            lblTeachers.Text = "Teachers";
            // 
            // lblAttendance
            // 
            lblAttendance.AutoSize = true;
            lblAttendance.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAttendance.ForeColor = SystemColors.ButtonHighlight;
            lblAttendance.Location = new Point(510, 35);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(131, 31);
            lblAttendance.TabIndex = 2;
            lblAttendance.Text = "Attendance";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResults.ForeColor = SystemColors.ButtonHighlight;
            lblResults.Location = new Point(527, 188);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(88, 31);
            lblResults.TabIndex = 3;
            lblResults.Text = "Results";
            lblResults.Click += lblResults_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnResults);
            panel1.Controls.Add(btnAttendance);
            panel1.Controls.Add(btnTeachers);
            panel1.Controls.Add(btnStudents);
            panel1.Controls.Add(lblStudents);
            panel1.Controls.Add(lblResults);
            panel1.Controls.Add(lblTeachers);
            panel1.Controls.Add(lblAttendance);
            panel1.Location = new Point(12, 80);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50, 25, 50, 25);
            panel1.Size = new Size(776, 356);
            panel1.TabIndex = 4;
            // 
            // btnResults
            // 
            btnResults.BackColor = SystemColors.ButtonHighlight;
            btnResults.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResults.Location = new Point(477, 226);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(203, 67);
            btnResults.TabIndex = 7;
            btnResults.Text = "CHECK RESULTS";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = SystemColors.ButtonHighlight;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.Location = new Point(477, 69);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(203, 79);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "VIEW ATTENDANCE";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.BackColor = SystemColors.ButtonHighlight;
            btnTeachers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTeachers.Location = new Point(53, 226);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(229, 79);
            btnTeachers.TabIndex = 5;
            btnTeachers.Text = "VIEW TEACHERS";
            btnTeachers.UseVisualStyleBackColor = false;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = SystemColors.ButtonHighlight;
            btnStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(53, 69);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(210, 79);
            btnStudents.TabIndex = 4;
            btnStudents.Text = "VIEW STUDENTS";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(181, 25);
            label1.Name = "label1";
            label1.Size = new Size(448, 38);
            label1.TabIndex = 5;
            label1.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
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