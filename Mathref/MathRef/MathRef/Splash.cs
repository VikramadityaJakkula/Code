using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathRef
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
           // logoBox.Image = Properties.Resources.splash;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
            //this.Visible = false;
            Form1 xform1 = new Form1();
            xform1.Show();
            xform1.Activate();
            splashTimer.Enabled = false;
            this.Visible = false;
            }
            catch (Exception ex)
            {
                Application.Exit();
            }

        }

        private void Splash_Closed(object sender, EventArgs e)
        {
            //Close the entire application
            Application.Exit();
        }

   

      

   

       
    }
}