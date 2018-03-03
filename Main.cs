using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to Student Profile
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
            //Hide Main Dashboard
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //go to Employee Profile
            EmployeeProfile employeeProfile = new EmployeeProfile();
            employeeProfile.Show();
            //Hide Main Dashboard
            this.Close();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go to Student Attendance 
            StudentAttendence studentAttendence = new StudentAttendence();
            studentAttendence.Show();
            //Hide Main Dashboard
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //go to Employee Attendance Sheet
            EmployeeAttendance employeeAttendance = new EmployeeAttendance();
            employeeAttendance.Show();
            //Hide Main Dashboard
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //go to Time Table
            TimeTable timeTable = new TimeTable();
            timeTable.Show();
            //Hide Main Dashboard
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // go to Calander
            Calander calander = new Calander();
            calander.Show();
            //Hide Main Dashboard
            this.Hide();
        }
    }
}
