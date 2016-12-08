using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace MathRacer
{
    public partial class MainForm : Form
    {

        private enum Flags
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_MEMORY = 0x0004,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_ALIAS = 0x00010000,
            SND_ALIAS_ID = 0x00110000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }


        [DllImport("coredll.dll", EntryPoint = "PlaySound", SetLastError = true)]
        public static extern bool MobilePlaySound(string szSound, IntPtr hMod, int flags);
        // Method to play files
        public static void PlaySound(string fileName)
        {
            MobilePlaySound(fileName, IntPtr.Zero, (int)(Flags.SND_ASYNC | Flags.SND_FILENAME));
        }


        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);



        int varpnum = 0;
        int varqnum = 0;
        int varqtype = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Closed(object sender, EventArgs e)
        {
            Application.Exit();

        }
       
        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Confirm and act
            if (MessageBox.Show("Do you wish to Quit?", "Quit MathRacer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                Application.Exit();
            }
        }



        private void startbut_Click(object sender, EventArgs e)
        {
            try
            {

            if ((varpnum == 0) || (varqnum == 0) || (varqtype == 0))
            {
                MessageBox.Show("Please select a player number, Question Number and Type");

            }
            else
            {
                //Start the Game
   
                Game formG = new Game(varpnum,varqnum,varqtype );
                formG.Show();

            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }
        private void nplayer2_Click(object sender, EventArgs e)
        {
            //Change Colors
            nplayer2.BackColor = Color.GreenYellow;
            nplayer1.BackColor = Color.OliveDrab;
            nplayer3.BackColor = Color.OliveDrab;
            nplayer4.BackColor = Color.OliveDrab;
            varpnum = 2;
        }

        private void nplayer1_Click(object sender, EventArgs e)
        {
            //Change Colors
            nplayer1.BackColor = Color.GreenYellow;
            nplayer2.BackColor = Color.OliveDrab;
            nplayer3.BackColor = Color.OliveDrab;
            nplayer4.BackColor = Color.OliveDrab;
            varpnum = 1;
        }

        private void nplayer3_Click(object sender, EventArgs e)
        {
            //Change Colors
            nplayer3.BackColor = Color.GreenYellow;
            nplayer2.BackColor = Color.OliveDrab;
            nplayer1.BackColor = Color.OliveDrab;
            nplayer4.BackColor = Color.OliveDrab;
            varpnum = 3;
        }

        private void nplayer4_Click(object sender, EventArgs e)
        {
            //Change Colors
            nplayer4.BackColor = Color.GreenYellow;
            nplayer2.BackColor = Color.OliveDrab;
            nplayer3.BackColor = Color.OliveDrab;
            nplayer1.BackColor = Color.OliveDrab;
            varpnum = 4;
        }

        private void nq1_Click(object sender, EventArgs e)
        {
            //Change Colors
            nq1.BackColor = Color.GreenYellow;
            nq2.BackColor = Color.OliveDrab;
            nq3.BackColor = Color.OliveDrab;
            nq4.BackColor = Color.OliveDrab;
            varqnum = 5;
        }

        private void nq2_Click(object sender, EventArgs e)
        {
            nq2.BackColor = Color.GreenYellow;
            nq1.BackColor = Color.OliveDrab;
            nq3.BackColor = Color.OliveDrab;
            nq4.BackColor = Color.OliveDrab;
            varqnum = 10;
        }

        private void nq3_Click(object sender, EventArgs e)
        {
            nq3.BackColor = Color.GreenYellow;
            nq2.BackColor = Color.OliveDrab;
            nq1.BackColor = Color.OliveDrab;
            nq4.BackColor = Color.OliveDrab;
            varqnum = 15;
        }

        private void nq4_Click(object sender, EventArgs e)
        {
            nq4.BackColor = Color.GreenYellow;
            nq2.BackColor = Color.OliveDrab;
            nq3.BackColor = Color.OliveDrab;
            nq1.BackColor = Color.OliveDrab;
            varqnum = 20;
        }

        private void tq1_Click(object sender, EventArgs e)
        {
            //change Colors
            tq1.BackColor = Color.GreenYellow;
            tq2.BackColor = Color.OliveDrab;
            tq3.BackColor = Color.OliveDrab;
            tq4.BackColor = Color.OliveDrab;
            varqtype = 1;
        }

        private void tq2_Click(object sender, EventArgs e)
        {
            //change Colors
            tq2.BackColor = Color.GreenYellow;
            tq1.BackColor = Color.OliveDrab;
            tq3.BackColor = Color.OliveDrab;
            tq4.BackColor = Color.OliveDrab;
            varqtype = 2;
        }

        private void tq3_Click(object sender, EventArgs e)
        {
            //change Colors
            tq3.BackColor = Color.GreenYellow;
            tq2.BackColor = Color.OliveDrab;
            tq1.BackColor = Color.OliveDrab;
            tq4.BackColor = Color.OliveDrab;
            varqtype = 3;
        }

        private void tq4_Click(object sender, EventArgs e)
        {
            //change Colors
            tq4.BackColor = Color.GreenYellow;
            tq2.BackColor = Color.OliveDrab;
            tq3.BackColor = Color.OliveDrab;
            tq1.BackColor = Color.OliveDrab;
            varqtype = 4;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            if ((varpnum == 0) || (varqnum == 0) || (varqtype == 0))
            {
                MessageBox.Show("Please select a player number, Question Number and Type");

            }
            else
            {
                //Start the Game
               
                Game formG = new Game(varpnum, varqnum, varqtype);
                formG.Show();

            }
        }

       
        private void credbut_Click(object sender, EventArgs e)
        {
            aboutus aboutForm = new aboutus();
            aboutForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            report rForm = new report();
            rForm.Show();
            
        }

        private void BackDrop_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
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
