using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Student
{
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go to Student Profile
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();

            //hide this interface
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go to Student Profile
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();

            //hide this interface
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\schoolsystem.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("insert into student(studentid,fname,lname,address,birthday,gender,joineddate,custodian,phonenumber) values ('" + txtStudentID.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtaddress.Text + "','" + dateTimePickerBirthdat.Text + "','" + radioButtonMale.Text + "','" + dateTimePickerJoinedDate.Text + "','" + txtCustodiam.Text + "','" + txtPhoneNumber.Text + "');
            //DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO student(studentid,fname,lname,address,birthday,gender,joineddate,custodian,phonenumber) VALUES ('" + txtStudentID.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtaddress.Text + "','" + dateTimePickerBirthdat.Value + "','" + radioButtonMale.Text + "','" + dateTimePickerJoinedDate.Value + "','" + txtCustodiam.Text + "','" + txtPhoneNumber.Text+ "')", con);
                Console.WriteLine("Thilina");
                command.ExecuteNonQuery();
                Console.WriteLine("Chamika");
                MessageBox.Show("Insert Successfully");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Insert Error :"+ex.Message);
            }
            finally {
                con.Close();
            }
            
            
            
            
        }
    }
}
