using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Information_System
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT * FROM Students", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStudents.DataSource = dt;
                }
            }
            catch
            {
                // SAFE MODE (No DB on your PC)
                dgvStudents.DataSource = null;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.ShowDialog();
            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm f = new DashboardForm();
            f.Show();
        }
    }
}
