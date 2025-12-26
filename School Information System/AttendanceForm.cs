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
    public partial class AttendanceForm : Form
    {
        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadAttendance();
        }
        private void LoadStudents()
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlDataAdapter da =
                        new SqlDataAdapter("SELECT StudentID, Name FROM Students", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbStudents.DataSource = dt;
                    cmbStudents.DisplayMember = "Name";
                    cmbStudents.ValueMember = "StudentID";
                }
            }
            catch
            {
                // SAFE MODE
                cmbStudents.DataSource = null;
            }
        }
        private void LoadAttendance()
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT * FROM Attendance", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAttendance.DataSource = dt;
                }
            }
            catch
            {
                dgvAttendance.DataSource = null;
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Attendance (StudentID, Date, Status) VALUES (@sid,@d,@s)", con);

                    cmd.Parameters.AddWithValue("@sid", cmbStudents.SelectedValue);
                    cmd.Parameters.AddWithValue("@d", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@s", cmbStatus.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Marked");
                }

                LoadAttendance();
            }
            catch
            {
                MessageBox.Show("Database not available");
            }
        }
    }
}
