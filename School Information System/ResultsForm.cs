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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadResults();
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
                cmbStudents.DataSource = null;
            }
        }
        private void LoadResults()
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT s.Name, r.Subject, r.Marks FROM Results r JOIN Students s ON r.StudentID = s.StudentID",
                        con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvResults.DataSource = dt;
                }
            }
            catch
            {
                dgvResults.DataSource = null;
            }
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Results (StudentID, Subject, Marks) VALUES (@sid,@sub,@m)", con);

                    cmd.Parameters.AddWithValue("@sid", cmbStudents.SelectedValue);
                    cmd.Parameters.AddWithValue("@sub", txtSubject.Text);
                    cmd.Parameters.AddWithValue("@m", txtMarks.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Result Added");
                }

                LoadResults();
            }
            catch
            {
                MessageBox.Show("Database not available");
            }
        }
    }
}
