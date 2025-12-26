namespace School_Information_System
{
    partial class AddStudentForm
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
            txtName = new TextBox();
            txtClass = new TextBox();
            txtGender = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(330, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 27);
            txtName.TabIndex = 0;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(330, 151);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(171, 27);
            txtClass.TabIndex = 1;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(330, 216);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(171, 27);
            txtGender.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(330, 277);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(171, 27);
            txtPhone.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Info;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(255, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 54);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 107);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 162);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 6;
            label2.Text = "Class: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 223);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 7;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(168, 280);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 8;
            label4.Text = "Phone:";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtGender);
            Controls.Add(txtClass);
            Controls.Add(txtName);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtClass;
        private TextBox txtGender;
        private TextBox txtPhone;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}