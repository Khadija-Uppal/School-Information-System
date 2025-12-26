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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }
        private void LoadDashboardData() {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    lblStudents.Text =
                        new SqlCommand("SELECT COUNT(*) FROM Students", con)
                        .ExecuteScalar().ToString();

                    lblTeachers.Text =
                        new SqlCommand("SELECT COUNT(*) FROM Teachers", con)
                        .ExecuteScalar().ToString();

                    lblAttendance.Text =
                        new SqlCommand("SELECT COUNT(*) FROM Attendance", con)
                        .ExecuteScalar().ToString();

                    lblResults.Text =
                        new SqlCommand("SELECT COUNT(*) FROM Results", con)
                        .ExecuteScalar().ToString();
                }
            }
            catch
            {
                // SAFE MODE (No DB on your PC)
                lblStudents.Text = "—";
                lblTeachers.Text = "—";
                lblAttendance.Text = "—";
                lblResults.Text = "—";
            }
        }

    }
}
