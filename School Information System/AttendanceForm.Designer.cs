namespace School_Information_System
{
    partial class AttendanceForm
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
            btnMark = new Button();
            dtpDate = new DateTimePicker();
            cmbStudents = new ComboBox();
            cmbStatus = new ComboBox();
            dgvAttendance = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // btnMark
            // 
            btnMark.BackColor = Color.LightSteelBlue;
            btnMark.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMark.ForeColor = Color.Transparent;
            btnMark.Location = new Point(711, 458);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(256, 68);
            btnMark.TabIndex = 0;
            btnMark.Text = "Save Attendance";
            btnMark.UseVisualStyleBackColor = false;
            btnMark.Click += btnMark_Click;
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDate.Location = new Point(34, 176);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(260, 27);
            dtpDate.TabIndex = 1;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(742, 302);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(199, 28);
            cmbStudents.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Present", "Absent" });
            cmbStatus.Location = new Point(742, 396);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(199, 28);
            cmbStatus.TabIndex = 3;
            // 
            // dgvAttendance
            // 
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(34, 222);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(643, 331);
            dgvAttendance.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(757, 251);
            label1.Name = "label1";
            label1.Size = new Size(169, 31);
            label1.TabIndex = 5;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(768, 349);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 6;
            label2.Text = "Attendance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(377, 62);
            label3.Name = "label3";
            label3.Size = new Size(354, 39);
            label3.TabIndex = 7;
            label3.Text = "Attendance Record";
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1116, 626);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAttendance);
            Controls.Add(cmbStatus);
            Controls.Add(cmbStudents);
            Controls.Add(dtpDate);
            Controls.Add(btnMark);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMark;
        private DateTimePicker dtpDate;
        private ComboBox cmbStudents;
        private ComboBox cmbStatus;
        private DataGridView dgvAttendance;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}