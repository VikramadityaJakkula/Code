namespace MathRacer
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.l = new System.Windows.Forms.PictureBox();
            this.labpname = new System.Windows.Forms.Label();
            this.labscore = new System.Windows.Forms.Label();
            this.labnum1 = new System.Windows.Forms.Label();
            this.labnum2 = new System.Windows.Forms.Label();
            this.labsign = new System.Windows.Forms.Label();
            this.labc1 = new System.Windows.Forms.Button();
            this.labc2 = new System.Windows.Forms.Button();
            this.labc3 = new System.Windows.Forms.Button();
            this.labc4 = new System.Windows.Forms.Button();
            this.q1r = new System.Windows.Forms.PictureBox();
            this.q2r = new System.Windows.Forms.PictureBox();
            this.q3r = new System.Windows.Forms.PictureBox();
            this.q4r = new System.Windows.Forms.PictureBox();
            this.q1w = new System.Windows.Forms.PictureBox();
            this.q2w = new System.Windows.Forms.PictureBox();
            this.q3w = new System.Windows.Forms.PictureBox();
            this.q4w = new System.Windows.Forms.PictureBox();
            this.playpic = new System.Windows.Forms.PictureBox();
            this.pausepic = new System.Windows.Forms.PictureBox();
            this.labtcount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Timer();
            this.mikeman = new System.Windows.Forms.Panel();
            this.labmik = new System.Windows.Forms.Label();
            this.mike = new System.Windows.Forms.PictureBox();
            this.rcounter = new System.Windows.Forms.Timer();
            this.labtimetype = new System.Windows.Forms.Label();
            this.mikeman.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "End Turn";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Next";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // l
            // 
            this.l.Image = ((System.Drawing.Image)(resources.GetObject("l.Image")));
            this.l.Location = new System.Drawing.Point(0, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(480, 640);
            // 
            // labpname
            // 
            this.labpname.BackColor = System.Drawing.Color.YellowGreen;
            this.labpname.Location = new System.Drawing.Point(30, 21);
            this.labpname.Name = "labpname";
            this.labpname.Size = new System.Drawing.Size(190, 29);
            this.labpname.Text = "PlayerName";
            // 
            // labscore
            // 
            this.labscore.BackColor = System.Drawing.Color.YellowGreen;
            this.labscore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labscore.Location = new System.Drawing.Point(384, 22);
            this.labscore.Name = "labscore";
            this.labscore.Size = new System.Drawing.Size(63, 29);
            this.labscore.Text = "0";
            // 
            // labnum1
            // 
            this.labnum1.BackColor = System.Drawing.Color.GreenYellow;
            this.labnum1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labnum1.Location = new System.Drawing.Point(46, 183);
            this.labnum1.Name = "labnum1";
            this.labnum1.Size = new System.Drawing.Size(127, 38);
            this.labnum1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labnum2
            // 
            this.labnum2.BackColor = System.Drawing.Color.GreenYellow;
            this.labnum2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labnum2.ForeColor = System.Drawing.Color.Black;
            this.labnum2.Location = new System.Drawing.Point(316, 183);
            this.labnum2.Name = "labnum2";
            this.labnum2.Size = new System.Drawing.Size(115, 38);
            this.labnum2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labsign
            // 
            this.labsign.BackColor = System.Drawing.Color.Olive;
            this.labsign.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labsign.ForeColor = System.Drawing.Color.White;
            this.labsign.Location = new System.Drawing.Point(226, 184);
            this.labsign.Name = "labsign";
            this.labsign.Size = new System.Drawing.Size(30, 35);
            // 
            // labc1
            // 
            this.labc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labc1.Location = new System.Drawing.Point(125, 368);
            this.labc1.Name = "labc1";
            this.labc1.Size = new System.Drawing.Size(274, 50);
            this.labc1.TabIndex = 7;
            this.labc1.Click += new System.EventHandler(this.labc1_Click);
            // 
            // labc2
            // 
            this.labc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labc2.Location = new System.Drawing.Point(125, 431);
            this.labc2.Name = "labc2";
            this.labc2.Size = new System.Drawing.Size(274, 50);
            this.labc2.TabIndex = 8;
            this.labc2.Click += new System.EventHandler(this.labc2_Click);
            // 
            // labc3
            // 
            this.labc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labc3.Location = new System.Drawing.Point(123, 497);
            this.labc3.Name = "labc3";
            this.labc3.Size = new System.Drawing.Size(276, 50);
            this.labc3.TabIndex = 9;
            this.labc3.Click += new System.EventHandler(this.labc3_Click);
            // 
            // labc4
            // 
            this.labc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labc4.Location = new System.Drawing.Point(123, 565);
            this.labc4.Name = "labc4";
            this.labc4.Size = new System.Drawing.Size(274, 50);
            this.labc4.TabIndex = 10;
            this.labc4.Click += new System.EventHandler(this.labc4_Click);
            // 
            // q1r
            // 
            this.q1r.Image = ((System.Drawing.Image)(resources.GetObject("q1r.Image")));
            this.q1r.Location = new System.Drawing.Point(417, 368);
            this.q1r.Name = "q1r";
            this.q1r.Size = new System.Drawing.Size(46, 48);
            this.q1r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1r.Visible = false;
            // 
            // q2r
            // 
            this.q2r.Image = ((System.Drawing.Image)(resources.GetObject("q2r.Image")));
            this.q2r.Location = new System.Drawing.Point(417, 432);
            this.q2r.Name = "q2r";
            this.q2r.Size = new System.Drawing.Size(46, 48);
            this.q2r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q2r.Visible = false;
            // 
            // q3r
            // 
            this.q3r.Image = ((System.Drawing.Image)(resources.GetObject("q3r.Image")));
            this.q3r.Location = new System.Drawing.Point(417, 498);
            this.q3r.Name = "q3r";
            this.q3r.Size = new System.Drawing.Size(46, 48);
            this.q3r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q3r.Visible = false;
            // 
            // q4r
            // 
            this.q4r.Image = ((System.Drawing.Image)(resources.GetObject("q4r.Image")));
            this.q4r.Location = new System.Drawing.Point(417, 565);
            this.q4r.Name = "q4r";
            this.q4r.Size = new System.Drawing.Size(46, 48);
            this.q4r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q4r.Visible = false;
            // 
            // q1w
            // 
            this.q1w.Image = ((System.Drawing.Image)(resources.GetObject("q1w.Image")));
            this.q1w.Location = new System.Drawing.Point(417, 368);
            this.q1w.Name = "q1w";
            this.q1w.Size = new System.Drawing.Size(46, 48);
            this.q1w.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1w.Visible = false;
            // 
            // q2w
            // 
            this.q2w.Image = ((System.Drawing.Image)(resources.GetObject("q2w.Image")));
            this.q2w.Location = new System.Drawing.Point(417, 432);
            this.q2w.Name = "q2w";
            this.q2w.Size = new System.Drawing.Size(46, 48);
            this.q2w.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q2w.Visible = false;
            // 
            // q3w
            // 
            this.q3w.Image = ((System.Drawing.Image)(resources.GetObject("q3w.Image")));
            this.q3w.Location = new System.Drawing.Point(417, 498);
            this.q3w.Name = "q3w";
            this.q3w.Size = new System.Drawing.Size(46, 48);
            this.q3w.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q3w.Visible = false;
            // 
            // q4w
            // 
            this.q4w.Image = ((System.Drawing.Image)(resources.GetObject("q4w.Image")));
            this.q4w.Location = new System.Drawing.Point(417, 565);
            this.q4w.Name = "q4w";
            this.q4w.Size = new System.Drawing.Size(46, 48);
            this.q4w.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q4w.Visible = false;
            // 
            // playpic
            // 
            this.playpic.Image = ((System.Drawing.Image)(resources.GetObject("playpic.Image")));
            this.playpic.Location = new System.Drawing.Point(442, 74);
            this.playpic.Name = "playpic";
            this.playpic.Size = new System.Drawing.Size(34, 34);
            this.playpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playpic.Visible = false;
            // 
            // pausepic
            // 
            this.pausepic.Image = ((System.Drawing.Image)(resources.GetObject("pausepic.Image")));
            this.pausepic.Location = new System.Drawing.Point(442, 74);
            this.pausepic.Name = "pausepic";
            this.pausepic.Size = new System.Drawing.Size(0, 0);
            this.pausepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pausepic.Visible = false;
            // 
            // labtcount
            // 
            this.labtcount.BackColor = System.Drawing.Color.Olive;
            this.labtcount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labtcount.ForeColor = System.Drawing.Color.White;
            this.labtcount.Location = new System.Drawing.Point(129, 74);
            this.labtcount.Name = "labtcount";
            this.labtcount.Size = new System.Drawing.Size(91, 26);
            this.labtcount.Text = "0";
            this.labtcount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.Text = "seconds";
            // 
            // counter
            // 
            this.counter.Interval = 1000;
            this.counter.Tick += new System.EventHandler(this.counter_Tick);
            // 
            // mikeman
            // 
            this.mikeman.AutoScroll = true;
            this.mikeman.Controls.Add(this.labmik);
            this.mikeman.Controls.Add(this.mike);
            this.mikeman.Location = new System.Drawing.Point(0, 0);
            this.mikeman.Name = "mikeman";
            this.mikeman.Size = new System.Drawing.Size(480, 640);
            this.mikeman.Visible = false;
            // 
            // labmik
            // 
            this.labmik.BackColor = System.Drawing.Color.YellowGreen;
            this.labmik.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Regular);
            this.labmik.Location = new System.Drawing.Point(45, 334);
            this.labmik.Name = "labmik";
            this.labmik.Size = new System.Drawing.Size(329, 97);
            this.labmik.Text = "Player 1";
            this.labmik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mike
            // 
            this.mike.Image = ((System.Drawing.Image)(resources.GetObject("mike.Image")));
            this.mike.Location = new System.Drawing.Point(0, 0);
            this.mike.Name = "mike";
            this.mike.Size = new System.Drawing.Size(480, 640);
            this.mike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mike.Click += new System.EventHandler(this.mike_Click);
            // 
            // rcounter
            // 
            this.rcounter.Interval = 1000;
            this.rcounter.Tick += new System.EventHandler(this.rcounter_Tick);
            // 
            // labtimetype
            // 
            this.labtimetype.BackColor = System.Drawing.Color.Olive;
            this.labtimetype.ForeColor = System.Drawing.Color.White;
            this.labtimetype.Location = new System.Drawing.Point(48, 72);
            this.labtimetype.Name = "labtimetype";
            this.labtimetype.Size = new System.Drawing.Size(73, 28);
            this.labtimetype.Text = "Time:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.Controls.Add(this.mikeman);
            this.Controls.Add(this.labtimetype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labtcount);
            this.Controls.Add(this.pausepic);
            this.Controls.Add(this.playpic);
            this.Controls.Add(this.q4w);
            this.Controls.Add(this.q3w);
            this.Controls.Add(this.q2w);
            this.Controls.Add(this.q1w);
            this.Controls.Add(this.q4r);
            this.Controls.Add(this.q3r);
            this.Controls.Add(this.q2r);
            this.Controls.Add(this.q1r);
            this.Controls.Add(this.labc4);
            this.Controls.Add(this.labc3);
            this.Controls.Add(this.labc2);
            this.Controls.Add(this.labc1);
            this.Controls.Add(this.labsign);
            this.Controls.Add(this.labnum2);
            this.Controls.Add(this.labnum1);
            this.Controls.Add(this.labscore);
            this.Controls.Add(this.labpname);
            this.Controls.Add(this.l);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.Name = "Game";
            this.Text = "Quizmine MathRacer";
            this.mikeman.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.PictureBox l;
        private System.Windows.Forms.Label labpname;
        private System.Windows.Forms.Label labscore;
        private System.Windows.Forms.Label labnum1;
        private System.Windows.Forms.Label labnum2;
        private System.Windows.Forms.Label labsign;
        private System.Windows.Forms.Button labc1;
        private System.Windows.Forms.Button labc2;
        private System.Windows.Forms.Button labc3;
        private System.Windows.Forms.Button labc4;
        private System.Windows.Forms.PictureBox q1r;
        private System.Windows.Forms.PictureBox q2r;
        private System.Windows.Forms.PictureBox q3r;
        private System.Windows.Forms.PictureBox q4r;
        private System.Windows.Forms.PictureBox q1w;
        private System.Windows.Forms.PictureBox q2w;
        private System.Windows.Forms.PictureBox q3w;
        private System.Windows.Forms.PictureBox q4w;
        private System.Windows.Forms.PictureBox playpic;
        private System.Windows.Forms.PictureBox pausepic;
        private System.Windows.Forms.Label labtcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer counter;
        private System.Windows.Forms.Panel mikeman;
        private System.Windows.Forms.PictureBox mike;
        private System.Windows.Forms.Label labmik;
        private System.Windows.Forms.Timer rcounter;
        private System.Windows.Forms.Label labtimetype;
    }
}