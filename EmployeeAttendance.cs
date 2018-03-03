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
    public partial class EmployeeAttendance : Form
    {
        public EmployeeAttendance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Go to Main dashboard
            Main main = new Main();
            main.Show();
            this.Close();

        }
    }
}
