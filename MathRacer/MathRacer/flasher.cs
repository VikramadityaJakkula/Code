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
    public partial class flasher : Form
    {
        int xtime, xpscore, xpfscore, xcurpnum;
        Game mitty;

        public flasher(int time,int pscore,int pfscore,int curpnum, Game xmitty)
        {
            try
            {

            mitty = (Game)xmitty;
            
            InitializeComponent();
            xtime = time;
            xpscore = pscore;
            xpfscore = pfscore;
            xcurpnum = curpnum;

            labnextpnum.Text  = (xcurpnum + 1).ToString();
            labpscore.Text = xpscore.ToString();
            labpfullscore.Text = xpfscore.ToString();
            labpseccount.Text = xtime.ToString();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }

        }

        private void flasher_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Confirm and act
            if (MessageBox.Show("Do you wish to Quit?", "Quit Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                mitty.Dispose();
                this.Dispose();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}