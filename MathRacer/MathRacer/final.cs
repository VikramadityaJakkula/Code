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
    public partial class final : Form
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


        
        int[] ptime = new int[4];
        int[] pscore=new int[4];
        int[] rank = new int[4];

        int nplay;
        int nques;
        int gametype;

        public final(int[] xptime,int[] xpscore,int xnplay, int xgametype,int xnques)
        {
            try
            {

            nplay = xnplay;
            gametype = xgametype;
            nques = xnques;


            for (int i = 0; i < xnplay; i++)
            {
                ptime[i] = xptime[i];
                pscore[i] = xpscore[i];
                rank[i] = i + 1;
               
            }

            InitializeComponent();

            PlaySound(path + "//chime_up.wav");

            if (nplay >= 1)
            {
                labp1.Text = "Player " + rank[0].ToString();
                labp1s.Text = pscore[0].ToString();
                labp1t.Text = ptime[0].ToString();
                labr1.Visible = true;
            }
            if (nplay >= 2)
            {
                labp2.Text = "Player " + rank[1].ToString();
                labp2s.Text = pscore[1].ToString();
                labp2t.Text = ptime[1].ToString();
                labr2.Visible = true;
            }
            if (nplay >= 3)
            {
                labp3.Text = "Player " + rank[2].ToString();
                labp3s.Text = pscore[2].ToString();
                labp3t.Text = ptime[2].ToString();
                labr3.Visible = true;
            }
            if (nplay >= 4)
            {
                labp4.Text = "Player " + rank[3].ToString();
                labp4s.Text = pscore[3].ToString();
                labp4t.Text = ptime[3].ToString();
                labr4.Visible = true;
            }
            //Sort the ranks based on the scores
            for (int i = 0; i < nplay; i++)
            {
                for (int j = i; j < nplay; j++)
                {
                    if (i == j) continue;

                    if (pscore[i] < pscore[j])
                    {
                     
                        //Swap the Ranks,Times and Scores
                        //Algo Used: Bubble Sort
                        int temp = 0;
                        temp = rank[i];
                        rank[i] = rank[j];
                        rank[j] = temp;

                        temp = ptime[i];
                        ptime[i] = ptime[j];
                        ptime[j] = temp;

                        temp = pscore[i];
                        pscore[i] = pscore[j];
                        pscore[j] = temp;
                   }
                    else if (pscore[i] == pscore[j])
                    {
                        //Swap based on the Timing
                        if (ptime[i] > ptime[j])
                        {                          
                            //Swap the Ranks,Times and Scores
                            //Algo Used: Bubble Sort
                            int temp = 0;
                            temp = rank[i];
                            rank[i] = rank[j];
                            rank[j] = temp;

                            temp = ptime[i];
                            ptime[i] = ptime[j];
                            ptime[j] = temp;

                            temp = pscore[i];
                            pscore[i] = pscore[j];
                            pscore[j] = temp;

                        }
                        
                    }
                }
            }

            

            //Load the details into the form

            //Scores, Times and Ranks

            if (nplay >= 1)
            {
                labp1.Text = "Player " + rank[0].ToString();
                labp1s.Text = pscore[0].ToString();
                labp1t.Text = ptime[0].ToString();
                labr1.Visible = true;
            }
            if (nplay >= 2)
            {
                labp2.Text = "Player " + rank[1].ToString();
                labp2s.Text = pscore[1].ToString();
                labp2t.Text = ptime[1].ToString();
                labr2.Visible = true;
            }
            if (nplay >= 3)
            {
                labp3.Text = "Player " + rank[2].ToString();
                labp3s.Text = pscore[2].ToString();
                labp3t.Text = ptime[2].ToString();
                labr3.Visible = true;
            }
            if (nplay >= 4)
            {
                labp4.Text = "Player " + rank[3].ToString();
                labp4s.Text = pscore[3].ToString();
                labp4t.Text = ptime[3].ToString();
                labr4.Visible = true;
            }           

            //Store the score in the Score Board
            //Prepare the string to be store
            
            string xtype;
            if (gametype == 1)
                xtype = "Addition";
            else if (gametype == 2)
                xtype = "Subtraction";
            else if (gametype == 3)
                xtype = "Multiplication";
            else
                xtype = "Division";

            //Time Correction for Single Player game
            if (nplay == 1)
            {
                ptime[0] = nques * 10 - ptime[0];
                labp1t.Text = ptime[0].ToString();
            }

            string finalString;
            //Tie Announcer
            if ((ptime[0] == ptime[1]) && (ptime[0] != 0) && (nplay != 1) && (pscore[0] == pscore[1]))
            {
                labwinner.Text = "Tie !";
                finalString = "Game 1:\n" + "Winners: " + labp1.Text+" & "+labp2.Text+"(Tie)"  + "\nNo.of.Players: " + nplay.ToString() + "\nType.of.Questions: " + xtype + "\nNo.of.Questions: " + nques.ToString() + "\nScore: " + labp1s.Text + "\nTime.to.complete: " + labp1t.Text + " seconds\r\n\r\n";
                //Preparing the Player String
                if(nplay==2)
                {
                    //Two Players
                    string tempplayer1="Player Info:\r\n\r\nRank 1:\r\n"+labp1.Text +"\r\nTime Taken:"+labp1t.Text+"\r\nScore:"+labp1s.Text+"\r\n";
                    string tempplayer2 = "\r\n\r\nRank 1(tie):\r\n" + labp2.Text + "\r\nTime Taken:" + labp2t.Text + "\r\nScore:" + labp2s.Text + "\r\n";
                    finalString = finalString + tempplayer1 + tempplayer2 + "\r\n\r\n";
                }
                else if(nplay==3)
                {
                    //Three Players
                    string tempplayer1 = "Player Info:\r\n\r\nRank 1:\r\n" + labp1.Text + "\r\nTime Taken:" + labp1t.Text + "\r\nScore:" + labp1s.Text + "\r\n";
                    string tempplayer2 = "\r\n\r\nRank 1(tie):\r\n" + labp2.Text + "\r\nTime Taken:" + labp2t.Text + "\r\nScore:" + labp2s.Text + "\r\n";
                    string tempplayer3 = "\r\n\r\nRank 2:\r\n" + labp3.Text + "\r\nTime Taken:" + labp3t.Text + "\r\nScore:" + labp3s.Text + "\r\n";
                    finalString = finalString + tempplayer1 + tempplayer2 + tempplayer3 + "\r\n\r\n";

                }
                else if(nplay==4)
                {
                    //Four Players
                    string tempplayer1 = "Player Info:\r\n\r\nRank 1:\r\n" + labp1.Text + "\r\nTime Taken:" + labp1t.Text + "\r\nScore:" + labp1s.Text + "\r\n";
                    string tempplayer2 = "\r\n\r\nRank 1(tie):\r\n" + labp2.Text + "\r\nTime Taken:" + labp2t.Text + "\r\nScore:" + labp2s.Text + "\r\n";
                    string tempplayer3 = "\r\n\r\nRank 2:\r\n" + labp3.Text + "\r\nTime Taken:" + labp3t.Text + "\r\nScore:" + labp3s.Text + "\r\n";
                    string tempplayer4 = "\r\n\r\nRank 3:\r\n" + labp4.Text + "\r\nTime Taken:" + labp4t.Text + "\r\nScore:" + labp4s.Text + "\r\n";
                    finalString = finalString + tempplayer1 + tempplayer2 + tempplayer3+tempplayer4+"\r\n\r\n" ;
                }
                
            }
            else
            {
                //No tie.. Announce result
                labwinner.Text = "Player " + rank[0].ToString();


                finalString = "Game 1:\n" + "Winner: " + labp1.Text + "\nNo.of.Players: " + nplay.ToString() + "\nType.of.Questions: " + xtype + "\nNo.of.Questions: " + nques.ToString() + "\nScore: " + labp1s.Text + "\nTime.to.complete: " + labp1t.Text + " seconds\r\n\r\n";

                //Preparing the New String
                if (nplay == 2)
                {
                    //Two Players
                    string tempplayer1 = "Player Info:\r\n\r\nRank 1:\r\n" + labp1.Text + "\r\nTime Taken:" + labp1t.Text + "\r\nScore:" + labp1s.Text + "\r\n";
                    string tempplayer2 = "\r\n\r\nRank 2:\r\n" + labp2.Text + "\r\nTime Taken:" + labp2t.Text + "\r\nScore:" + labp2s.Text + "\r\n";
                    finalString = finalString + tempplayer1 + tempplayer2 + "\r\n\r\n";
                }
                else if (nplay == 3)
                {
                    //Three Players
                    string tempplayer1 = "Player Info:\r\n\r\nRank 1:\r\n" + labp1.Text + "\r\nTime Taken:" + labp1t.Text + "\r\nScore:" + labp1s.Text + "\r\n";
                    string tempplayer2 = "\r\n\r\nRank 2:\r\n" + labp2.Text + "\r\nTime Taken:" + labp2t.Text + "\r\nScore:" + labp2s.Text + "\r\n";
                    string tempplayer3 = "\r\n\r\nRank 3:\r\n" + labp3.Text + "\r\nTime Taken:" + labp3t.Text + "\r\nScore:" + labp3s.Text + "\r\n";
                    finalString = finalString + tempplayer1 + tempplayer2 + tempplayer3 + "\r\n\r\n";

                }
                else if (nplay == 4)
                {
                    //Four Players
                    string tempplayer1 = "Player Info:\r\n\r\nRank 1:\r\n" + labp1.Text + "\r\nTime Taken:" + labp1t.Text + "\r\nScore:" + labp1s.Text + "\r\n";
                    string tempplayer2 = "\r\n\r\nRank 2:\r\n" + labp2.Text + "\r\nTime Taken:" + labp2t.Text + "\r\nScore:" + labp2s.Text + "\r\n";
                    string tempplayer3 = "\r\n\r\nRank 3:\r\n" + labp3.Text + "\r\nTime Taken:" + labp3t.Text + "\r\nScore:" + labp3s.Text + "\r\n";
                    string tempplayer4 = "\r\n\r\nRank 4:\r\n" + labp4.Text + "\r\nTime Taken:" + labp4t.Text + "\r\nScore:" + labp4s.Text + "\r\n";
                    finalString = finalString + tempplayer1 + tempplayer2 + tempplayer3 + tempplayer4 + "\r\n\r\n";
                }
            }
                       
            //Remove the String from the Previous ScoreCard
            string oldScores;
            //Load the Scores

            System.IO.StreamReader scoreReader;
            
            scoreReader = new System.IO.StreamReader(path + @"\scores.txt");
            //Clear ScoreCard
            oldScores = "";          

            //Skip till Game2is reached
            while (scoreReader.Peek() != -1)
            {
                //Read the content
                oldScores += scoreReader.ReadLine() + "\r\n";
                
            }

            scoreReader.Close();
            scoreReader.Dispose();

            

            //Removal
            char[] Seditor = new char[2000];

            int yi=oldScores.IndexOf("Game 1:");
            int zi = oldScores.IndexOf("Game 5:");

            int xi;
            for (xi = 0; xi < (zi-yi); xi++)
                Seditor[xi] = oldScores[xi+yi];
            Seditor[xi] = '\0';

            string finalNewString = new string(Seditor);
            //Shift the game Labels
            finalNewString= finalNewString.Replace("Game 4:", "Game 5:");

            finalNewString = finalNewString.Replace("Game 3:", "Game 4:");
            finalNewString = finalNewString.Replace("Game 2:", "Game 3:");
            finalNewString = finalNewString.Replace("Game 1:", "Game 2:");

            finalNewString = finalString + finalNewString;

            //Write it in the Scores.txt

            System.IO.StreamWriter scoreWriter;
            scoreWriter = new System.IO.StreamWriter(path + @"\scores.txt");
            scoreWriter.Flush();
            scoreWriter.Write(finalNewString);
            scoreWriter.Close();
            scoreWriter.Dispose();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }     
        private void final_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuItem1_Click(object sender, EventArgs e)
        {
            //Restart the game
            Game formGame = new Game(nplay, nques, gametype);
            formGame.Show();
            this.Dispose();
        }

        private void final_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}



