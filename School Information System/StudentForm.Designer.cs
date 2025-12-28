namespace School_Information_System
{
    partial class StudentForm
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
            btnAddStudent = new Button();
            btnRefresh = new Button();
            dgvStudents = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.RosyBrown;
            btnAddStudent.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddStudent.ForeColor = Color.Azure;
            btnAddStudent.Location = new Point(293, 469);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(179, 59);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.RosyBrown;
            btnRefresh.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Azure;
            btnRefresh.Location = new Point(647, 469);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(161, 59);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = Color.RosyBrown;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(145, 145);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(822, 288);
            dgvStudents.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.RosyBrown;
            textBox1.Location = new Point(456, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 38);
            textBox1.TabIndex = 3;
            textBox1.Text = "Students";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1130, 607);
            Controls.Add(textBox1);
            Controls.Add(dgvStudents);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddStudent);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Button btnRefresh;
        private DataGridView dgvStudents;
        private TextBox textBox1;
    }
}