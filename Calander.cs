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
    public partial class Calander : Form
    {
        public Calander()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to main Dashboard
            Main main = new Main();
            main.Show();
            //Hide This
            this.Hide();
                 
        }
    }
}
