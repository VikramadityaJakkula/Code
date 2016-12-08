using System;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathRef
{
    public partial class MainIndex : Form
    {
        public MainIndex()
        {
            InitializeComponent();
        }

        private void MainIndex_Load(object sender, EventArgs e)
        {
            try
            {
            
            //Load the List

                listBox1.Items.Add("1. Trigonometry");
                listBox1.Items.Add("");
                listBox1.Items.Add("2. LinearAlgebra");
                listBox1.Items.Add("");
                listBox1.Items.Add("3. Series and  Sequences");
                listBox1.Items.Add("");
                listBox1.Items.Add("4. Derivatives");
                listBox1.Items.Add("");
                listBox1.Items.Add("5. Integration");
                listBox1.Items.Add("");
                listBox1.Items.Add("6. Probability and Statistics");
                listBox1.Items.Add("");
                listBox1.Items.Add("7. Conversions");
            //Set Default Selection
            //listBox1.SelectedIndex = 0;
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

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //Go back
            this.Dispose();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            //Go for the selected Menu Item

                if (listBox1.SelectedIndex == 0)
                {
                    //Trigonometry
                    Trig trigo = new Trig();
                    trigo.Show();

                }

                else if (listBox1.SelectedIndex == 2)
                {
                    //Linear Algebra
                    lalg linalg = new lalg();
                    linalg.Show();
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    //Seq and Series
                    series fser = new series();
                    fser.Show();

                }
                else if (listBox1.SelectedIndex == 6)
                {
                    //Derivatives
                    deriv fder = new deriv();
                    fder.Show();

                }
                else if (listBox1.SelectedIndex == 8)
                {
                    //Integration
                    integ finteg = new integ();
                    finteg.Show();

                }
                else if (listBox1.SelectedIndex == 10)
                {
                    //Probability
                    prob fprob = new prob();
                    fprob.Show();

                }
                else if (listBox1.SelectedIndex == 12)
                {
                    //Conversions
                    conv fcon = new conv();
                    fcon.Show();

                }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void MainIndex_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

              

       

      
        

    }
}