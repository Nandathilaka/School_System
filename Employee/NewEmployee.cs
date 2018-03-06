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

namespace SchoolSystem.Employee
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeProfile employeeProfile = new EmployeeProfile();
            employeeProfile.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
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
                if (radioButtonMale.Checked)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO employee(empid,fname,lname,gender,address,nic,birthday,subject,grade,phonenumber,joineddate) VALUES ('" + txtEmpId.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + radioButtonMale.Text + "','" + txtAddress.Text + "','" + txtNIC.Text + "','" + dateTimePickerBirthday.Value + "','" + comboBoxSubject.Text + "','" + comboBoxGrade.Text + "','" + txtphonenumber.Text + "','" + dateTimePickerJoinedDate.Value + "')", con);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show(i + " Data Insert Successfully");
                    }
                }
                if (radioButtonFemale.Checked)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO employee(empid,fname,lname,gender,address,nic,birthday,subject,grade,phonenumber,joineddate) VALUES ('" + txtEmpId.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + radioButtonFemale.Text + "','" + txtAddress.Text + "','" + txtNIC.Text + "','" + dateTimePickerBirthday.Value + "','" + comboBoxSubject.Text + "','" + comboBoxGrade.Text + "','" + txtphonenumber.Text + "','" + dateTimePickerJoinedDate.Value + "')", con);
                    int i = command.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show(i + " Data Insert Successfully");
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Insert Error :" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

       
    }
}
