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
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // btnAddResult
            // 
            btnAddResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddResult.Location = new Point(83, 343);
            btnAddResult.Name = "btnAddResult";
            btnAddResult.Size = new Size(158, 59);
            btnAddResult.TabIndex = 0;
            btnAddResult.Text = "Add Result";
            btnAddResult.UseVisualStyleBackColor = true;
            btnAddResult.Click += btnAddResult_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(169, 110);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(125, 27);
            txtSubject.TabIndex = 1;
            // 
            // txtMarks
            // 
            txtMarks.Location = new Point(169, 185);
            txtMarks.Name = "txtMarks";
            txtMarks.Size = new Size(125, 27);
            txtMarks.TabIndex = 2;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(90, 273);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 3;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(324, 72);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(437, 330);
            dgvResults.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 106);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 5;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 181);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 6;
            label2.Text = "Marks: ";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}