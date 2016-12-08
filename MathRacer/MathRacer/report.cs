using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace MathRacer
{
    public partial class report : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        public report()
        {
            try
            {
            InitializeComponent();

            //Load the Scores

            System.IO.StreamReader scoreReader;
            

            scoreReader = new System.IO.StreamReader(path + @"\scores.txt");
            //Clear ScoreCard
            scoreCard.Text = "";
            int linecount = 0;

            while (scoreReader.Peek() != -1)
            {
                //Read the content
                scoreCard.Text  += scoreReader.ReadLine()+"\r\n";
                linecount++;
            }
            
            //Tune the scoreCard size

            scoreCard.Height = (int)((3 * linecount - 1) * scoreCard.Font.Size)+50;
            scoreReader.Close();
            scoreReader.Dispose();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void report_Closed(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to Quit?", "Quit MathRacer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void report_KeyDown(object sender, KeyEventArgs e)
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
    }
}