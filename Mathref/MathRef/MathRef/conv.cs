﻿using System;
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
    public partial class conv : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        public conv()
        {
            InitializeComponent();
        }
        SystemState _orientationWatcher;

        private void conv_Load(object sender, EventArgs e)
        {
            //Adjusting pannel dimensions after loading the image
            try{

            //Load the picture
            Bitmap a = new Bitmap(path + "\\Conversions.png");
            pic.Image = a;
                       

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

        private void conv_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void conv_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void panel1_GotFocus(object sender, EventArgs e)
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

        private void pic_Click(object sender, EventArgs e)
        {

        }

       

       }
}