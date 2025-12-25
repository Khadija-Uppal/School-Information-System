using School_Information_System.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Information_System
{
    public partial class Dashboard : Form
    {
        SchoolContext db = new SchoolContext();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadCounts();
            LoadTopStudents();
         //   LoadGenderChart();
        }
        private void LoadCounts()
        {
            label1.Text = db.Students.Count().ToString();
            label2.Text = db.Teachers.Count().ToString();
        }
        private void LoadTopStudents()
        {
            datagridview1.DataSource = db.Students
                .OrderByDescending(s => s.Marks).Take(5)
                .Select(s => new{
                    s.Name,
                    s.RollNo,
                    s.Marks
                })
                .ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
        }
    }
}
