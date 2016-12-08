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
    public partial class Splash : Form
    {

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            
            MainForm mainForm = new MainForm();
            mainForm.Activate();
            mainForm.Show();
            splashTimer.Enabled = false;
            this.Visible = false;
            

        }
    }
}