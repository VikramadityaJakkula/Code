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
    public partial class Game : Form
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

        //Count the Number of People who have Quit
        int quitcount = 0;


       int qcount = 0;//Count the Questions
        int scount = 0;//Count the Score
        int tcount = 0;//count the Time
        int nplay = 0;
        int nq = 0;
        int tq = 0;
        int curplayer = 0;
        int smode = 0;
        int[] ptime = new int[4];
        int[] pscore = new int[4];
        //CORE CODE TO GENERATE THE QUESTION
        string questions = string.Empty;
        string answers = string.Empty;
        string option1 = string.Empty;
        string option2 = string.Empty;
        string option3 = string.Empty;
        string option4 = string.Empty;
        string selectedanswer = string.Empty;
        string operation = string.Empty;
        int count = 0;
        Point[] questionLoader = new Point[5];
        //Initialize the Questions Type(Number of Digits)
        int qType = 1;
        Random random = new Random();
        // Random Number Generator
        private int RandomNumber(int min, int max)
        {
            try
            {

                return (random.Next(min, max));
            }
            catch (Exception ex)
            {
                return 0;
              
            }
            
        }

        public bool SearchQuestion(int value1, int value2)
        {
            for (int i = 0; i < 5; i++)
            {
                if (((int)questionLoader[i].X == value1) && ((int)questionLoader[i].Y == value2))
                    return true;
            }

            return false;
        }

        //Questions generator
        public void entirequestions()
        {
            try
            {
            if (string.Equals(operation, "add"))
            {
                labsign.Text = "+";
                int value1 = 0, value2 = 0;
                int tamp = 0;
                //Randomize the Number of Digits
                tamp = RandomNumber(1, 4);
                if (qType == tamp)
                {
                    entirequestions();
                    return;
                }            
                if (tamp == 1)
                {
                    value1 = RandomNumber(1, 4);
                    value2 = RandomNumber(5, 9);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 + value2);
                    option1 = Convert.ToString(value1 + value2);
                    option2 = Convert.ToString(value1 + value2 + 2);
                    option3 = Convert.ToString(value1 + value2 + 1);
                    option4 = Convert.ToString(value1 + value2 - 1);
                    qType = 1;
                }
                if (tamp == 2)
                {
                    value1 = RandomNumber(10, 29);
                    value2 = RandomNumber(30, 99);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 + value2);
                    option1 = Convert.ToString(value1 + value2);
                    option2 = Convert.ToString(value1 + value2 + 20);
                    option3 = Convert.ToString(value1 + value2 + 10);
                    option4 = Convert.ToString(value1 + value2 - 10);
                    qType = 2;
                }
                if (tamp == 3)
                {
                    value1 = RandomNumber(100, 200);
                    value2 = RandomNumber(201, 500);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 + value2);
                    option1 = Convert.ToString(value1 + value2);
                    option2 = Convert.ToString(value1 + value2 + 20);
                    option3 = Convert.ToString(value1 + value2 + 10);
                    option4 = Convert.ToString(value1 + value2 - 10);
                    qType = 3;
                }
                if (tamp == 4)
                {
                    value1 = RandomNumber(100, 499);
                    value2 = RandomNumber(500, 999);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }

                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 + value2);
                    option1 = Convert.ToString(value1 + value2);
                    option2 = Convert.ToString(value1 + value2 + 100);
                    option3 = Convert.ToString(value1 + value2 + 10);
                    option4 = Convert.ToString(value1 + value2 - 10);
                    qType = 4;
                }
                labnum1.Text = value1.ToString();
                labnum2.Text = value2.ToString();
            }

            if (string.Equals(operation, "minus"))
            {
                int value1 = 0, value2 = 0;
                int tamp = RandomNumber(1, 3);
                if (qType == tamp)
                    entirequestions();
                if (tamp == 1)
                {
                    value1 = RandomNumber(5, 9);
                    value2 = RandomNumber(1, 4);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 - value2);
                    option1 = Convert.ToString(value1 - value2);
                    option2 = Convert.ToString(value1 - value2 + 1);
                    option3 = Convert.ToString(value1 - value2 - 1);
                    option4 = Convert.ToString(value1 - value2 + 2);
                    qType = 1;
                }
                if (tamp == 2)
                {
                    value1 = RandomNumber(40, 99);
                    value2 = RandomNumber(10, 39);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 - value2);
                    option1 = Convert.ToString(value1 - value2);
                    option2 = Convert.ToString(value1 - value2 + 10);
                    option3 = Convert.ToString(value1 - value2 - 10);
                    option4 = Convert.ToString(value1 - value2 + 20);
                    qType = 2;
                }
                if (tamp == 3)
                {
                    value1 = RandomNumber(500, 999);
                    value2 = RandomNumber(200, 499);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 - value2);
                    option1 = Convert.ToString(value1 - value2);
                    option2 = Convert.ToString(value1 - value2 + 100);
                    option3 = Convert.ToString(value1 - value2 - 100);
                    option4 = Convert.ToString(value1 - value2 + 200);
                    qType = 3;
                }
                labsign.Text = "-";                
                labnum1.Text = value1.ToString();
                labnum2.Text = value2.ToString();
            }

            if (string.Equals(operation, "multiply"))
            {
                int value1 = 0, value2 = 0;
                int tamp = qType;
                if (tamp == 1)
                {
                    value1 = RandomNumber(3, 5);
                    value2 = RandomNumber(1, 7);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 * value2);
                    option1 = Convert.ToString(value1 * value2);
                    option2 = Convert.ToString(value1 * value2 - 1);
                    option3 = Convert.ToString(value1 * value2 + 1);
                    option4 = Convert.ToString(value1 * value2 - 2);
                    qType = 2;
                }

                if (tamp == 2)
                {
                    value1 = RandomNumber(5, 7);
                    value2 = RandomNumber(8, 12);
                    if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                    {
                        entirequestions();
                        return;
                    }
                    questionLoader[count].X = value1;
                    questionLoader[count].Y = value2;
                    answers = Convert.ToString(value1 * value2);
                    option1 = Convert.ToString(value1 * value2);
                    option2 = Convert.ToString(value1 * value2 + 1);
                    option3 = Convert.ToString(value1 * value2 - 1);
                    option4 = Convert.ToString(value1 * value2 + 5);
                    qType = 1;
                }
                labsign.Text = "x";
                labnum1.Text = value1.ToString();
                labnum2.Text = value2.ToString();
            }

            if (string.Equals(operation, "divide"))
            {
                int value1 = RandomNumber(25, 99);
                int value2 = RandomNumber(10, 25);
                while ((value1 % value2 != 0)||(value2==1))
                {
                    value1 = RandomNumber(25, 100);
                    value2 = RandomNumber(1, 20);
                }
                if ((SearchQuestion(value1, value2) == true || (SearchQuestion(value2, value1) == true)))
                {
                    entirequestions();
                    return;
                }
                questionLoader[count].X = value1;
                questionLoader[count].Y = value2;
                labsign.Text = "/";
                answers = Convert.ToString(value1 / value2);
                option1 = Convert.ToString(value1 / value2);
                option2 = Convert.ToString(value1 / value2 + 2);
                option3 = Convert.ToString(value1 / value2 + 1);
                option4 = Convert.ToString(value1 / value2 - 1);
                labnum1.Text = value1.ToString();
                labnum2.Text = value2.ToString();
            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        //Shuffle
        public void shuffle()
        {
            int ranshuffle = RandomNumber(1, 5);
            if (ranshuffle == 1)
            {
                labc1.Text = option1;
                labc2.Text = option2;
                labc3.Text = option3;
                labc4.Text = option4;
            }
            else if (ranshuffle == 2)
            {
                
                labc1.Text = option2;
                labc2.Text = option1;
                labc3.Text = option3;
                labc4.Text = option4;
            }
            else if (ranshuffle == 3)
            {
                
                labc1.Text = option3;
                labc2.Text = option2;
                labc3.Text = option1;
                labc4.Text = option4;
            }
            else
            {
                
                labc1.Text = option4;
                labc2.Text = option2;
                labc3.Text = option3;
                labc4.Text = option1;
            }
        }
        //Question Option shuffler
        public void tagging()
        {
            shuffle();
        }
        public void initsignb()
        {
            //Initialize Sign Board
            if (tq == 1)
            {    //Addition
                labsign.Text = "+";
                operation = "add";
            }
            else if (tq == 2)
            {   //Subtraction
                labsign.Text = "-";
                operation = "minus";
            }
            else if (tq == 3)
            {   //Multiply
                labsign.Text = "x";
                operation = "multiply";
            }
            else
            {   //Division
                labsign.Text = "/";
                operation = "divide";
            }
        }


        public Game(int pnum, int qnum, int qtype)
        {
            try
            {
            nplay = pnum;
            nq = qnum;
            tq = qtype;
            InitializeComponent();
            //Configure for Single Player Mode
            if (nplay == 1)
            {
                smode = 1;
                labtimetype.Text = "Time Left:";
            }
            else
            {
                smode = 0;
                labtimetype.Text = "Time:";
            }      
            //Reset the Scores and Times
            for (int i = 0; i < 4; i++)
                ptime[i] = 0;
            for (int i = 0; i < 4; i++)
                pscore[i] = 0;
            qcount = 0;
            curplayer = 0;          
            //Single Player Game
            //Initialize the Window
            //Initialize Score
            labscore.Text = "0";
            //INITialize sign board
            initsignb();
            //Initialize Player name
            labpname.Text = "Player 1";
            labmik.Text = "Player 1";
            mikeman.Visible = true;
            menuItem1.Text = "";

            menuItem2.Text = "Start";
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        public void leavegame()
        {
            try
            {
            //Check if there is another player on line
            if (curplayer == 0)
            {
                //First Player game incomplete - So, Quit the Game
                this.Dispose();
                return;
            }
            pausegame();
            if(nplay==1)
            {
                //There is only one player
                pausegame();
                
                this.Dispose();


            }
            else if (curplayer == nplay)
            {
                //The Current player is the last player
                pausegame();
                pscore[curplayer - 1] = scount;
                ptime[curplayer - 1] = tcount;

                

                if (quitcount == nplay)
                {
                    //All have Quit
                    Allq allqform = new Allq();
                    allqform.Show();                   
                }
                else
                {

                    final finalForm = new final(ptime, pscore, nplay, tq, nq);
                    finalForm.Show();
                }

                this.Dispose();

            }
            else
            {
                //There are more players. So skip the current one
                //Saving the scores and the times

                //Set the mikeman ON

                mikeman.Visible = true;
                
                menuItem1.Text = "";

                labmik.Text = "Player " + (curplayer + 1).ToString();

                pscore[curplayer - 1] = scount;
                ptime[curplayer - 1] = tcount;

                menuItem2.Text = "Start";

                flasher flashform = new flasher(tcount, scount, nq, curplayer,this);

                flashform.Show();            

            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        public void pausegame()
        {
            //Disable timer and enable pausePic
            if (smode == 0)
                counter.Enabled = false;
            else
                rcounter.Enabled = false;
            playpic.Visible = false;
            pausepic.Visible = true;
        }

        public void playgame()
        {
            //Enable the Game timers and PlayPic
            if (smode == 0)
                counter.Enabled = true;
            else
                rcounter.Enabled = true;
            pausepic.Visible = false;
            playpic.Visible = true;
        }

        private void labc1_Click(object sender, EventArgs e)
        {
            if (labc1.Text.CompareTo(answers)==0)
            {
                //Selected andwer is the right answer


                //Play happy tune
                PlaySound(path+"\\Marimba.wav");

                scount += 1;
                labscore.Text = (Int32.Parse(labscore.Text) + 1).ToString();
                q1r.Visible = true;
            }
            else
            {
                //Wrong Answer
                                //Play Wrong tune
                PlaySound(path + "\\Floop.wav");
                q1w.Visible = true;
            }
            //Prepare for next question
            labc1.Enabled = false;
            labc2.Enabled = false;
            labc3.Enabled = false;
            labc4.Enabled = false;
            //Pause for user to realize the correctness of answer
            pausegame();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {   
            //Wait for confirmation
            if (menuItem1.Text == "")
                return;

            pausegame();
            //Confirm and act
            if (MessageBox.Show("Do you wish to leave the current game?", "End Current Player's turn?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Exit the application
                PlaySound(path + "\\bloop_x.wav");
                quitcount++;

                leavegame();
            }
            else
            {
                //Resume turn
                playgame();
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            try
            {
            if ((menuItem2.Text == "Start") && (mikeman.Visible == true))
            {
                //Play Gong tune
                
                path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                //MessageBox.Show("Im gonna play!:"+path );

                
                PlaySound(path + "\\chime_down.wav");

                mikeman.Visible = false;
                menuItem1.Text = "End Turn";

                //Ask User Questions
                //Display the First Question of the first player                
                //Starting new game for a new player
                menuItem2.Text = "Next";
                curplayer++;
                //Restarting a new game for a new player
                labpname.Text = "Player " + curplayer.ToString();
                labscore.Text = "0";
                if (smode == 1)
                {
                    //Single Player Game

                    //Setting the time duration
                    labtcount.Text = (nq*10).ToString();

                    tcount = (nq*10);

                    MessageBox.Show("You have "+tcount.ToString()+" seconds to complete the challenge! You must answer a minimum of 80% of the questions correctly to clear the game.");
                }
                else
                {
                    labtcount.Text = "0";
                    tcount = 0;
                }
                entirequestions();
                tagging();
                playgame();
                scount = 0;
                //Generate the first Quesiton
                qcount = 0;
                entirequestions();
                tagging();
                q1r.Visible = false;
                q2r.Visible = false;
                q3r.Visible = false;
                q4r.Visible = false;
                q1w.Visible = false;
                q2w.Visible = false;
                q3w.Visible = false;
                q4w.Visible = false;
                labc1.Enabled = true;
                labc2.Enabled = true;
                labc3.Enabled = true;
                labc4.Enabled = true;
                //Resume Game play
                playgame();
                return;
            }
            qcount++;            
            q1r.Visible = false;
            q2r.Visible = false;
            q3r.Visible = false;
            q4r.Visible = false;
            q1w.Visible = false;
            q2w.Visible = false;
            q3w.Visible = false;
            q4w.Visible = false;
            labc1.Enabled = true;
            labc2.Enabled = true;
            labc3.Enabled = true;
            labc4.Enabled = true;
            //Check if another Question is left
            if (qcount < nq)
            {
                //There is another Quesiton left
                entirequestions();
                tagging();
                playgame();
            }
            else
            {
                //Player has completed his turn
                //Stop the game trackers
                pausegame();                
                //Saving the scores and the times
                pscore[curplayer - 1] = scount;
                ptime[curplayer - 1] = tcount;
                menuItem2.Text = "Start";
                if ((nplay != 1) && (curplayer < nplay))
                {
                    mikeman.Visible = true;
                    menuItem1.Text = "";

                    labmik.Text = "Player " + (curplayer + 1).ToString();
                    flasher flashform = new flasher(tcount, scount, nq, curplayer, this );
                    flashform.Show();
                    flashform.BringToFront();                   
                }
                else
                {
                    if (nplay == 1)
                    {
                        //There is only a single player                        
                        //Check for Scores
                        if ((scount >= 0.8 * nq))
                        {
                            //Sufficient scores obtained
                            final finalForm = new final(ptime, pscore, 1, tq, nq);
                            finalForm.Show();
                            this.Dispose();
                        }
                        else
                        {
                            //Insufficient Scoring
                            Nat natForm = new Nat(nq, tq, 2);
                            natForm.Show();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        //This is the last player                                                                        
                        if (quitcount == nplay)
                        {
                            //All have Quit
                            Allq allqform = new Allq();
                            allqform.Show();
                        }
                        else
                        {



                            final finalForm = new final(ptime, pscore, nplay, tq, nq);
                            finalForm.Show();
                        }
                        this.Dispose();
                    }
                }
            }
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void labc2_Click(object sender, EventArgs e)
        {
            try
            {
            if (labc2.Text.CompareTo(answers)==0)
            {
                //Selected andwer is the right answer
                //Play happy tune
                PlaySound(path + "\\Marimba.wav");
                scount += 1;
                labscore.Text = (Int32.Parse(labscore.Text) + 1).ToString();
                q2r.Visible = true;
            }
            else
            {
                //Wrong Answer
                //Play Wrong tune
                PlaySound(path + "\\Floop.wav");
                q2w.Visible = true;
            }
            //Prepare for next question           
            labc1.Enabled = false;
            labc2.Enabled = false;
            labc3.Enabled = false;
            labc4.Enabled = false;
            //Pause for user to realize the correctness of answer
            pausegame();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void labc3_Click(object sender, EventArgs e)
        {
            try
            {
            if (labc3.Text.CompareTo(answers)==0)
            {
                //Selected andwer is the right answer
                //Play happy tune
                PlaySound(path + "\\Marimba.wav");
                scount += 1;
                labscore.Text = (Int32.Parse(labscore.Text) + 1).ToString();               
                q3r.Visible = true;
            }
            else
            {
                //Wrong Answer
                //Play Wrong tune
                PlaySound(path + "\\Floop.wav");
                q3w.Visible = true;
            }
            //Prepare for next question            
            labc1.Enabled = false;
            labc2.Enabled = false;
            labc3.Enabled = false;
            labc4.Enabled = false;
            //Pause for user to realize the correctness of answer
            pausegame();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void labc4_Click(object sender, EventArgs e)
        {
            try
            {
            if (labc4.Text.CompareTo(answers) == 0)
            {
                //Selected answer is the right answer
                //Play happy tune
                PlaySound(path + "\\Marimba.wav");
                scount += 1;
                labscore.Text = (Int32.Parse(labscore.Text) + 1).ToString();
                q4r.Visible = true;
            }
            else
            {
                //Wrong Answer
                //Play Wrong tune
                PlaySound(path + "\\Floop.wav");
                q4w.Visible = true;
            }
            //Prepare for next question
            
            labc1.Enabled = false;
            labc2.Enabled = false;
            labc3.Enabled = false;
            labc4.Enabled = false;
            //Pause for user to realize the correctness of answer
            pausegame();
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }  
      
        private void counter_Tick(object sender, EventArgs e)
        {
            try
            {
            //Check the pervious scores
            //Find the Best Score
            for (int i = 0; i < curplayer-1; i++)
            {
                if (ptime[i] == tcount)
                {
                    if (pscore[i] > scount)
                    {
                        //Break the game
                        //Saving the scores and the times
                        pscore[curplayer - 1] = scount;
                        ptime[curplayer - 1] = tcount;
                        pausegame();
                        PlaySound(path+"\\blip.wav");
                        MessageBox.Show("You have been knocked out. Player " + (i + 1).ToString()+" got "+pscore[i].ToString()+" points by this time!" );                   
                        //Another player is on the roll
                        if ((nplay != 1) && (curplayer < nplay))
                        {
                            menuItem2.Text = "Start";
                            mikeman.Visible = true;
                            menuItem1.Text = "";


                            labmik.Text = "Player " + (curplayer + 1).ToString();
                            flasher flashform = new flasher(tcount, scount, nq, curplayer,this);
                            flashform.Show();
                            flashform.BringToFront();
                        }
                        else
                        {
                            //This is the last player                           

                            if (quitcount == nplay)
                            {
                                //All have Quit
                                Allq allqform = new Allq();
                                allqform.Show();
                            }
                            else
                            {
                                final finalForm = new final(ptime, pscore, nplay, tq, nq);
                                finalForm.Show();
                            }
                            this.Dispose();
                        }
                        return;
                    }
                }
            }                               
            
            labtcount.Text = (Int32.Parse(labtcount.Text) + 1).ToString();
            tcount++;
            }
            catch (Exception ex)
            {
                Application.Exit();
            }
        }

        private void mike_Click(object sender, EventArgs e)
        {

        }

        private void rcounter_Tick(object sender, EventArgs e)
        {
            if (tcount < 1)
            {
                rcounter.Enabled = false;
                pausegame();
                PlaySound(path + "\\boing_spring.wav");
                 Nat natForm = new Nat(nq,tq,1);               
                natForm.Show();
                    this.Dispose();               
            }
            else
            {
                labtcount.Text = (Int32.Parse(labtcount.Text) - 1).ToString();
                tcount--;
            }
        }       
    }
}