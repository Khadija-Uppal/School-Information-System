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
            lblName = new Label();
            lblRoll = new Label();
            lblMarks = new Label();
            lblGender = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(176, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.Location = new Point(176, 118);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(50, 20);
            lblRoll.TabIndex = 1;
            lblRoll.Text = "label2";
            // 
            // lblMarks
            // 
            lblMarks.AutoSize = true;
            lblMarks.Location = new Point(176, 172);
            lblMarks.Name = "lblMarks";
            lblMarks.Size = new Size(50, 20);
            lblMarks.TabIndex = 2;
            lblMarks.Text = "label3";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(176, 227);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(50, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "label4";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGender);
            Controls.Add(lblMarks);
            Controls.Add(lblRoll);
            Controls.Add(lblName);
            Name = "StudentForm";
            Text = "Form1";
            Load += StudentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblRoll;
        private Label lblMarks;
        private Label lblGender;
    }
}