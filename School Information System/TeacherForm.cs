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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }
        private void LoadTeachers()
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT * FROM Teachers", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTeachers.DataSource = dt;
                }
            }
            catch
            {
                // SAFE MODE (No DB on your PC)
                dgvTeachers.DataSource = null;
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm frm = new AddTeacherForm();
            frm.ShowDialog();
            LoadTeachers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }
    }
}
