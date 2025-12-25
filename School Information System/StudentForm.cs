using School_Information_System.DataModels;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace School_Information_System
{
    public partial class StudentForm : System.Windows.Forms.Form
    {
        private DataGridView dgvStudents;
        private TextBox txtName, txtRollNo, txtMarks, txtGender;
        private Button btnAdd, btnUpdate, btnDelete, btnClear;
        private Label lblName, lblRoll, lblMarks, lblGender;
        private SchoolContext db = new SchoolContext();
        private int selectedId = 0;

        public StudentForm()
        {
            InitializeComponent();
        }

       /* private void InitializeComponent()
        {
            this.Text = "Manage Students";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblName = new Label() { Text = "Name:", Location = new Point(20, 30), Width = 80 };
            lblRoll = new Label() { Text = "Roll No:", Location = new Point(20, 70), Width = 80 };
            lblMarks = new Label() { Text = "Marks:", Location = new Point(20, 110), Width = 80 };
            lblGender = new Label() { Text = "Gender:", Location = new Point(20, 150), Width = 80 };

            txtName = new TextBox() { Location = new Point(100, 30), Width = 200 };
            txtRollNo = new TextBox() { Location = new Point(100, 70), Width = 200 };
            txtMarks = new TextBox() { Location = new Point(100, 110), Width = 200 };
            txtGender = new TextBox() { Location = new Point(100, 150), Width = 200 };

            btnAdd = new Button() { Text = "Add", Location = new Point(20, 200), Width = 80 };
            btnUpdate = new Button() { Text = "Update", Location = new Point(110, 200), Width = 80 };
            btnDelete = new Button() { Text = "Delete", Location = new Point(200, 200), Width = 80 };
            btnClear = new Button() { Text = "Clear", Location = new Point(290, 200), Width = 80 };

            dgvStudents = new DataGridView()
            {
                Location = new Point(350, 30),
                Width = 400,
                Height = 300,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            this.Controls.Add(lblName);
            this.Controls.Add(lblRoll);
            this.Controls.Add(lblMarks);
            this.Controls.Add(lblGender);
            this.Controls.Add(txtName);
            this.Controls.Add(txtRollNo);
            this.Controls.Add(txtMarks);
            this.Controls.Add(txtGender);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);
            this.Controls.Add(dgvStudents);

            this.Load += StudentForm_Load;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            dgvStudents.CellClick += DgvStudents_CellClick;
        }*/

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = db.Students.Select(s => new
            {
                s.Id,
                s.Name,
                s.RollNo,
                s.Marks,
                s.Gender
            }).ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student()
            {
                Name = txtName.Text,
                RollNo = txtRollNo.Text,
                Marks = Convert.ToInt32(txtMarks.Text),
                Gender = txtGender.Text
            };
            db.Students.Add(s);
            db.SaveChanges();
            MessageBox.Show("Student Added!");
            LoadStudents();
            Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var student = db.Students.Find(selectedId);
            if (student != null)
            {
                student.Name = txtName.Text;
                student.RollNo = txtRollNo.Text;
                student.Marks = Convert.ToInt32(txtMarks.Text);
                student.Gender = txtGender.Text;
                db.SaveChanges();
                MessageBox.Show("Student Updated!");
                LoadStudents();
                Clear();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var student = db.Students.Find(selectedId);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                MessageBox.Show("Student Deleted!");
                LoadStudents();
                Clear();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e) => Clear();

        private void Clear()
        {
            txtName.Clear();
            txtRollNo.Clear();
            txtMarks.Clear();
            txtGender.Clear();
            selectedId = 0;
        }

        private void DgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dgvStudents.Rows[e.RowIndex].Cells["Id"].Value);
                txtName.Text = dgvStudents.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtRollNo.Text = dgvStudents.Rows[e.RowIndex].Cells["RollNo"].Value.ToString();
                txtMarks.Text = dgvStudents.Rows[e.RowIndex].Cells["Marks"].Value.ToString();
                txtGender.Text = dgvStudents.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
            }
        }
    }
}