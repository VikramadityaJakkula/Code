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
    public partial class Allq : Form
    {
        public Allq()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Confirm and act
            if (MessageBox.Show("Do you wish to Quit?", "Quit MathRacer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                Application.Exit();
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Allq_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}