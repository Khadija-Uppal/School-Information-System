namespace School_Information_System
{
    partial class AddTeacherForm
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
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtSubject = new TextBox();
            txtPhone = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSteelBlue;
            btnSave.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(675, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 52);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(595, 153);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(595, 223);
            label2.Name = "label2";
            label2.Size = new Size(109, 27);
            label2.TabIndex = 2;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 302);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 3;
            label3.Text = "Phone: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(746, 157);
            txtName.Name = "txtName";
            txtName.Size = new Size(141, 27);
            txtName.TabIndex = 4;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(746, 224);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(141, 27);
            txtSubject.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(746, 302);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(141, 27);
            txtPhone.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 682);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(62, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 38);
            textBox1.TabIndex = 0;
            textBox1.Text = "Teacher";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightSteelBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(25, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 38);
            textBox2.TabIndex = 1;
            textBox2.Text = "Registration";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightSteelBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(77, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 38);
            textBox3.TabIndex = 2;
            textBox3.Text = "Form";
            // 
            // AddTeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 624);
            Controls.Add(panel1);
            Controls.Add(txtPhone);
            Controls.Add(txtSubject);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "AddTeacherForm";
            Text = "AddTeacherForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtSubject;
        private TextBox txtPhone;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}