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
    public partial class subindex : Form
    {
        public subindex()
        {
            InitializeComponent();
        }

        private void subindex_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("1. Numbers");
                listBox1.Items.Add("");
                listBox1.Items.Add("2. Fractions");
                listBox1.Items.Add("");
                listBox1.Items.Add("3. Percentages");
                listBox1.Items.Add("");
                listBox1.Items.Add("4. Rounding");
                listBox1.Items.Add("");
                listBox1.Items.Add("5. Simple Interest");
                listBox1.Items.Add("");
                listBox1.Items.Add("6. Algebra");
                listBox1.Items.Add("");
                listBox1.Items.Add("7. Geometry");
                listBox1.Items.Add("");
                listBox1.Items.Add("8. Graphs");
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void subindex_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex == 0)
                {
                    numb f3 = new numb();

                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 2)
                {

                    frac f3 = new frac();
                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    perc f3 = new perc();
                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 6)
                {
                    round f3 = new round();
                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 8)
                {
                    si f3 = new si();
                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 10)
                {
                    detailer f3 = new detailer();
                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 12)
                {

                    Geometry f3 = new Geometry();
                    f3.Show();
                }
                else if (listBox1.SelectedIndex == 14)
                {
                    grap f3 = new grap();
                    f3.Show();
                }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }


        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            try{
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