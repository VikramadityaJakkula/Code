using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Status;
using System.Reflection;

namespace MathRef
{
    public partial class Geometry : Form
    {
       

        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);


        SystemState _orientationWatcher;
        public Geometry()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Geometry_Load(object sender, EventArgs e)
        {
            try
            {
            //Load the picture
            Bitmap Img = new Bitmap(path + "\\Geometry.png");
            pic.Image = Img;


            //Adjusting pannel dimensions after loading the image
            Size tempsize = new Size();
            //Dynamically Position the Image on Pannel           
            _orientationWatcher = new SystemState(SystemProperty.DisplayRotation);
            _orientationWatcher.Changed += new ChangeEventHandler(OrientationWatcher_Changed);
            int disortemp = SystemState.DisplayRotation;
            if (disortemp == Math.Abs(90) || (disortemp == Math.Abs(270)))
            {
                //Screen is tilted
                tempsize.Width = panel1.Width - (int)(0.09 * panel1.Width);
                tempsize.Height = (int)(((double)tempsize.Width / pic.Image.Width) * pic.Image.Height);
                tempsize.Height += (int)(0.3 * panel1.Width);
                pic.Size = tempsize;
            }
            else
            {
                tempsize.Width = panel1.Width - (int)(0.09 * panel1.Width);
                tempsize.Height = (int)(((double)tempsize.Width / pic.Image.Width) * pic.Image.Height);
                pic.Size = tempsize;
            }
            pic.Refresh();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        void OrientationWatcher_Changed(object sender, ChangeEventArgs args)
        {
            try
            {
            //Adjusting pannel dimensions after loading the image
            Size tempsize = new Size();
            //Dynamically Position the Image on Pannel           
          //  _orientationWatcher = new SystemState(SystemProperty.DisplayRotation);
          //  _orientationWatcher.Changed += new ChangeEventHandler(OrientationWatcher_Changed);
            int disortemp = SystemState.DisplayRotation;
            if (disortemp == Math.Abs(90) || (disortemp == Math.Abs(270)))
            {
                //Screen is tilted
                tempsize.Width = panel1.Width - (int)(0.09 * panel1.Width);
                tempsize.Height = (int)(((double)tempsize.Width / pic.Image.Width) * pic.Image.Height);
                tempsize.Height += (int)(0.3 * panel1.Width);
                pic.Size = tempsize;
            }
            else
            {
                tempsize.Width = panel1.Width - (int)(0.09 * panel1.Width);
                tempsize.Height = (int)(((double)tempsize.Width / pic.Image.Width) * pic.Image.Height);
                pic.Size = tempsize;
            }
            pic.Refresh();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void Geometry_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            try
            {
            //Confirm and act
            if (MessageBox.Show("Do you wish to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                Application.Exit();
            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }
    }
}