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
    public partial class Form1 : Form
    {

        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void menuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            if (button3.Visible == false)
            {
                //Display the new buttons
                button1.Visible = false;
                button2.Visible = false;
                exitButton1.Visible = false;

                button3.Visible = true;
                button4.Visible = true;

                menuItem1.Text = "Back";

            }
            else
            {
                //Hide the new buttons
                button1.Visible = true;
                button2.Visible = true;
                exitButton1.Visible = true;

                button3.Visible = false;
                button4.Visible = false;

                menuItem1.Text = "Start";




            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            if (button3.Visible == false)
            {
                //Display the new buttons
                button1.Visible = false;
                button2.Visible = false;
                exitButton1.Visible = false;

                button3.Visible = true;
                button4.Visible = true;

                menuItem1.Text = "Back";

            }
            else
            {
                //Hide the new buttons
                button1.Visible = true ;
                button2.Visible = true ;
                exitButton1.Visible = true ;

                button3.Visible = false ;
                button4.Visible = false;

                menuItem1.Text = "Start";




            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
            

        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            try
            {
            //Confirm and act
            if(MessageBox.Show("Do you wish to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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

        private void Form1_Closed(object sender, EventArgs e)
        {
            //End the entire application
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutus aform = new aboutus();
            aform.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainIndex f4 = new MainIndex();
            f4.Show();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            //Load the Simple math thing
            subindex f4 = new subindex();
            f4.Show();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { 
            Bitmap ImG = new Bitmap(path+"\\Slice 1.png");
            pictureBox1.Image = ImG;
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

    
    }
}