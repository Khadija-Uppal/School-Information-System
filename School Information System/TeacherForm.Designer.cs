namespace School_Information_System
{
    partial class TeacherForm
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
            btnAddTeacher = new Button();
            btnRefresh = new Button();
            dgvTeachers = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.BackColor = Color.LightSteelBlue;
            btnAddTeacher.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddTeacher.Location = new Point(303, 415);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(184, 69);
            btnAddTeacher.TabIndex = 0;
            btnAddTeacher.Text = "Add Teacher";
            btnAddTeacher.UseVisualStyleBackColor = false;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightSteelBlue;
            btnRefresh.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(572, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(167, 69);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvTeachers
            // 
            dgvTeachers.BackgroundColor = Color.LightSteelBlue;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Location = new Point(244, 136);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.RowHeadersWidth = 51;
            dgvTeachers.Size = new Size(561, 258);
            dgvTeachers.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(426, 60);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 3;
            label1.Text = "Teachers ";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1075, 606);
            Controls.Add(label1);
            Controls.Add(dgvTeachers);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddTeacher);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTeacher;
        private Button btnRefresh;
        private DataGridView dgvTeachers;
        private Label label1;
    }
}