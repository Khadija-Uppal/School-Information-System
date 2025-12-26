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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Students (Name, Class, Gender, Phone) VALUES (@n,@c,@g,@p)", con);

                    cmd.Parameters.AddWithValue("@n", txtName.Text);
                    cmd.Parameters.AddWithValue("@c", txtClass.Text);
                    cmd.Parameters.AddWithValue("@g", txtGender.Text);
                    cmd.Parameters.AddWithValue("@p", txtPhone.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added Successfully");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Database not available");
            }
        }
    }
}
