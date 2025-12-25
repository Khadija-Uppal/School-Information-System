using Microsoft.Data.SqlClient; // Isse SqlConnection ka error khatam hoga
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School_Information_System.DataModels;

namespace School_Information_System // Yahan apne project ka sahi naam likhein
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SchoolContext()) // Aapka Bridge
                {
                    // Database se students ki list mangwao
                    var list = db.Students.ToList();

                    // Grid mein show kar do
                    dataGridView1.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
        }

        
            private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SchoolContext()) // Aapka Context Class
                {
                    // 1. Naya Student object banayein
                    var newStudent = new Student()
                    {
                        Name = textBox1.Text, // Table ke column ka naam likhein
                      
                    };

                    // 2. Database context mein add karein
                    db.Students.Add(newStudent);

                    // 3. SQL mein permanently save karein
                    db.SaveChanges(); // Ye line SQL mein data bhejti hai

                    MessageBox.Show("Data successfully saved to SQL Server!");

                    // 4. Grid ko refresh karein taake naya data foran nazar aaye
                    dataGridView1.DataSource = db.Students.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }
