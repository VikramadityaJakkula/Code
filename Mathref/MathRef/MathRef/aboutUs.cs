using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace MathRef
{
    public partial class aboutus : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

        public aboutus()
        {
            InitializeComponent();
        }

        private void aboutus_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Confirm and act
            if (MessageBox.Show("Do you wish to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutus_Load(object sender, EventArgs e)
        {
            Bitmap ImTemp = new Bitmap(path + "\\aboutus.png");
            pictureBox1.Image = ImTemp;

        }
    }
}