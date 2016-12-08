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
    public partial class Nat : Form
    {

        //Sound Player

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




        int qnum, qtype;
        public Nat(int xqnum,int xqtype,int floptype)
        {
            try
            {
            InitializeComponent();
            qnum = xqnum;
            qtype = xqtype;

            if (floptype == 1)
            {
                //Time Out

                //Play timeout Gong

                PlaySound(path + "//Glass.wav");

                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                //Score Not Enough
                PlaySound(path + "//Glass.wav");

                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
            
        }

        private void Nat_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            //ReStart the Game
           
            Game formG = new Game(1, qnum , qtype );
            formG.Show();
            this.Dispose();

        }        
    }
}