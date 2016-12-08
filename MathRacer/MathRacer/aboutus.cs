using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathRacer
{
    public partial class aboutus : Form
    {
        public aboutus()
        {
            InitializeComponent();
        }

        private void aboutus_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to quit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                Application.Exit();
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}