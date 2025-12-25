
namespace School_Information_System
{
    partial class Dashboard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            datagridview1 = new DataGridView();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridview1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(89, 173);
            button1.Name = "button1";
            button1.Size = new Size(134, 63);
            button1.TabIndex = 0;
            button1.Text = "Student Management";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(270, 173);
            button2.Name = "button2";
            button2.Size = new Size(107, 63);
            button2.TabIndex = 1;
            button2.Text = "Teacher Management";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(411, 190);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Classes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(632, 373);
            button4.Name = "button4";
            button4.Size = new Size(75, 34);
            button4.TabIndex = 0;
            button4.Text = "Exit";
            // 
            // panel1
            // 
            panel1.Location = new Point(158, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 3;
            // 
            // datagridview1
            // 
            datagridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridview1.Location = new Point(181, 250);
            datagridview1.Name = "datagridview1";
            datagridview1.RowHeadersWidth = 51;
            datagridview1.Size = new Size(300, 188);
            datagridview1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 142);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 239);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datagridview1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Dashboard";
            Text = "Form1";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)datagridview1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private DataGridView datagridview1;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
    }
}