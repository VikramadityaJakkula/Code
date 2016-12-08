using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Status;

namespace MathRef
{
    
    public partial class detailer : Form
    {


        SystemState _orientationWatcher;
        public detailer()
        {
            InitializeComponent();
           
        }

            private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

            private void detailer_Load(object sender, EventArgs e)
            {

                try{
                //Adjusting pannel dimensions after loading the image
                Size tempsize = new Size();
                //Dynamically Position the Image on Pannel           
                _orientationWatcher = new SystemState(SystemProperty.DisplayRotation);
                _orientationWatcher.Changed += new ChangeEventHandler(OrientationWatcher_Changed);
                int disortemp = SystemState.DisplayRotation;
                if (disortemp == Math.Abs(90) || (disortemp == Math.Abs(270)))
                {
                    //Screen is tilted
                    tempsize.Width = panel.Width - (int)(0.09 * panel.Width);
                    tempsize.Height = (int)(((double)tempsize.Width / pic.Image.Width) * pic.Image.Height);
                    tempsize.Height += (int)(0.3 * panel.Width);
                    pic.Size = tempsize;
                }
                else
                {
                    tempsize.Width = panel.Width - (int)(0.09 * panel.Width);
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
                    tempsize.Width = panel.Width - (int)(0.09 * panel.Width);
                    tempsize.Height = (int)(((double)tempsize.Width / pic.Image.Width) * pic.Image.Height);
                    tempsize.Height += (int)(0.3 * panel.Width);
                    pic.Size = tempsize;
                }
                else
                {
                    tempsize.Width = panel.Width - (int)(0.09 * panel.Width);
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
            private void detailer_Closed(object sender, EventArgs e)
            {
                try
                {
                //Close entire Application
                Application.Exit();
                }
                catch (Exception ex)
                {
                    Application.Exit();
                }
            }

            private void pic_Click(object sender, EventArgs e)
            {

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