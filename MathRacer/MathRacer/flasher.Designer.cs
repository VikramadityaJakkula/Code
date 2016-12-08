namespace MathRacer
{
    partial class flasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flasher));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labpseccount = new System.Windows.Forms.Label();
            this.labpscore = new System.Windows.Forms.Label();
            this.labpfullscore = new System.Windows.Forms.Label();
            this.labnextpnum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Next Player";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Quit Game";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 640);
            // 
            // labpseccount
            // 
            this.labpseccount.BackColor = System.Drawing.Color.GreenYellow;
            this.labpseccount.Location = new System.Drawing.Point(173, 246);
            this.labpseccount.Name = "labpseccount";
            this.labpseccount.Size = new System.Drawing.Size(51, 28);
            this.labpseccount.Text = "90";
            this.labpseccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labpscore
            // 
            this.labpscore.BackColor = System.Drawing.Color.GreenYellow;
            this.labpscore.Location = new System.Drawing.Point(112, 285);
            this.labpscore.Name = "labpscore";
            this.labpscore.Size = new System.Drawing.Size(46, 25);
            this.labpscore.Text = "20";
            this.labpscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labpfullscore
            // 
            this.labpfullscore.BackColor = System.Drawing.Color.GreenYellow;
            this.labpfullscore.Location = new System.Drawing.Point(185, 286);
            this.labpfullscore.Name = "labpfullscore";
            this.labpfullscore.Size = new System.Drawing.Size(54, 24);
            this.labpfullscore.Text = "20";
            this.labpfullscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labnextpnum
            // 
            this.labnextpnum.BackColor = System.Drawing.Color.PaleGreen;
            this.labnextpnum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labnextpnum.Location = new System.Drawing.Point(273, 407);
            this.labnextpnum.Name = "labnextpnum";
            this.labnextpnum.Size = new System.Drawing.Size(42, 32);
            this.labnextpnum.Text = "2";
            this.labnextpnum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(244, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Next Player";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labnextpnum);
            this.Controls.Add(this.labpfullscore);
            this.Controls.Add(this.labpscore);
            this.Controls.Add(this.labpseccount);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "flasher";
            this.Text = "Quizmine MathRacer";
            this.Closed += new System.EventHandler(this.flasher_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labpseccount;
        private System.Windows.Forms.Label labpscore;
        private System.Windows.Forms.Label labpfullscore;
        private System.Windows.Forms.Label labnextpnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}