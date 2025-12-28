namespace School_Information_System
{
    partial class ResultsForm
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
            btnAddResult = new Button();
            txtSubject = new TextBox();
            txtMarks = new TextBox();
            cmbStudents = new ComboBox();
            dgvResults = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnAddResult
            // 
            btnAddResult.BackColor = Color.LightSteelBlue;
            btnAddResult.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddResult.Location = new Point(98, 456);
            btnAddResult.Name = "btnAddResult";
            btnAddResult.Size = new Size(187, 78);
            btnAddResult.TabIndex = 0;
            btnAddResult.Text = "Add Result";
            btnAddResult.UseVisualStyleBackColor = false;
            btnAddResult.Click += btnAddResult_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(188, 179);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(151, 27);
            txtSubject.TabIndex = 1;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(188, 250);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(151, 27);
            txtMarks.TabIndex = 2;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(188, 325);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 3;
            // 
            // dgvResults
            // 
            dgvResults.BackgroundColor = Color.LightSteelBlue;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(536, 131);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(571, 445);
            dgvResults.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 177);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 5;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 248);
            label2.Name = "label2";
            label2.Size = new Size(104, 27);
            label2.TabIndex = 6;
            label2.Text = "Marks: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 326);
            label3.Name = "label3";
            label3.Size = new Size(115, 27);
            label3.TabIndex = 7;
            label3.Text = "Student:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(536, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 38);
            textBox1.TabIndex = 8;
            textBox1.Text = "Results ";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(98, 564);
            button1.Name = "button1";
            button1.Size = new Size(187, 73);
            button1.TabIndex = 9;
            button1.Text = "Dasboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1419, 668);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResults);
            Controls.Add(cmbStudents);
            Controls.Add(txtMarks);
            Controls.Add(txtSubject);
            Controls.Add(btnAddResult);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddResult;
        private TextBox txtSubject;
        private TextBox txtMarks;
        private ComboBox cmbStudents;
        private DataGridView dgvResults;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}