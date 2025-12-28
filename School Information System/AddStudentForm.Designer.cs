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
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(685, 164);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 27);
            txtName.TabIndex = 0;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(685, 216);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(187, 27);
            txtClass.TabIndex = 1;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(685, 271);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(187, 27);
            txtGender.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(685, 324);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(187, 27);
            txtPhone.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RosyBrown;
            btnSave.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(578, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 55);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(481, 164);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 216);
            label2.Name = "label2";
            label2.Size = new Size(89, 27);
            label2.TabIndex = 6;
            label2.Text = "Class: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(482, 271);
            label3.Name = "label3";
            label3.Size = new Size(108, 27);
            label3.TabIndex = 7;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SeaShell;
            label4.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(494, 324);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 8;
            label4.Text = "Phone:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25, 50, 25, 50);
            panel1.Size = new Size(265, 644);
            panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RosyBrown;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(43, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 38);
            textBox1.TabIndex = 0;
            textBox1.Text = "Student";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.RosyBrown;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(15, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 38);
            textBox2.TabIndex = 1;
            textBox2.Text = "Registration";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.RosyBrown;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(56, 335);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 38);
            textBox3.TabIndex = 2;
            textBox3.Text = "Form";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1062, 634);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}