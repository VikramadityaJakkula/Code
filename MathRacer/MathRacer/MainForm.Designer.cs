namespace MathRacer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.BackDrop = new System.Windows.Forms.PictureBox();
            this.nplayer2 = new System.Windows.Forms.Button();
            this.nplayer3 = new System.Windows.Forms.Button();
            this.nplayer4 = new System.Windows.Forms.Button();
            this.nq1 = new System.Windows.Forms.Button();
            this.nq2 = new System.Windows.Forms.Button();
            this.nq3 = new System.Windows.Forms.Button();
            this.nq4 = new System.Windows.Forms.Button();
            this.tq1 = new System.Windows.Forms.Button();
            this.tq2 = new System.Windows.Forms.Button();
            this.tq3 = new System.Windows.Forms.Button();
            this.tq4 = new System.Windows.Forms.Button();
            this.credbut = new System.Windows.Forms.Button();
            this.startbut = new System.Windows.Forms.Button();
            this.nplayer1 = new System.Windows.Forms.Button();
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
            this.menuItem1.Text = "Start";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Quit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // BackDrop
            // 
            this.BackDrop.Image = ((System.Drawing.Image)(resources.GetObject("BackDrop.Image")));
            this.BackDrop.Location = new System.Drawing.Point(0, 0);
            this.BackDrop.Name = "BackDrop";
            this.BackDrop.Size = new System.Drawing.Size(480, 640);
            this.BackDrop.Click += new System.EventHandler(this.BackDrop_Click);
            // 
            // nplayer2
            // 
            this.nplayer2.BackColor = System.Drawing.Color.OliveDrab;
            this.nplayer2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nplayer2.ForeColor = System.Drawing.Color.White;
            this.nplayer2.Location = new System.Drawing.Point(141, 209);
            this.nplayer2.Name = "nplayer2";
            this.nplayer2.Size = new System.Drawing.Size(95, 65);
            this.nplayer2.TabIndex = 30;
            this.nplayer2.Text = "2";
            this.nplayer2.Click += new System.EventHandler(this.nplayer2_Click);
            // 
            // nplayer3
            // 
            this.nplayer3.BackColor = System.Drawing.Color.OliveDrab;
            this.nplayer3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nplayer3.ForeColor = System.Drawing.Color.White;
            this.nplayer3.Location = new System.Drawing.Point(245, 209);
            this.nplayer3.Name = "nplayer3";
            this.nplayer3.Size = new System.Drawing.Size(95, 65);
            this.nplayer3.TabIndex = 31;
            this.nplayer3.Text = "3";
            this.nplayer3.Click += new System.EventHandler(this.nplayer3_Click);
            // 
            // nplayer4
            // 
            this.nplayer4.BackColor = System.Drawing.Color.OliveDrab;
            this.nplayer4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nplayer4.ForeColor = System.Drawing.Color.White;
            this.nplayer4.Location = new System.Drawing.Point(350, 209);
            this.nplayer4.Name = "nplayer4";
            this.nplayer4.Size = new System.Drawing.Size(95, 65);
            this.nplayer4.TabIndex = 32;
            this.nplayer4.Text = "4";
            this.nplayer4.Click += new System.EventHandler(this.nplayer4_Click);
            // 
            // nq1
            // 
            this.nq1.BackColor = System.Drawing.Color.OliveDrab;
            this.nq1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nq1.ForeColor = System.Drawing.Color.White;
            this.nq1.Location = new System.Drawing.Point(38, 347);
            this.nq1.Name = "nq1";
            this.nq1.Size = new System.Drawing.Size(95, 65);
            this.nq1.TabIndex = 33;
            this.nq1.Text = "5";
            this.nq1.Click += new System.EventHandler(this.nq1_Click);
            // 
            // nq2
            // 
            this.nq2.BackColor = System.Drawing.Color.OliveDrab;
            this.nq2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nq2.ForeColor = System.Drawing.Color.White;
            this.nq2.Location = new System.Drawing.Point(141, 347);
            this.nq2.Name = "nq2";
            this.nq2.Size = new System.Drawing.Size(95, 65);
            this.nq2.TabIndex = 34;
            this.nq2.Text = "10";
            this.nq2.Click += new System.EventHandler(this.nq2_Click);
            // 
            // nq3
            // 
            this.nq3.BackColor = System.Drawing.Color.OliveDrab;
            this.nq3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nq3.ForeColor = System.Drawing.Color.White;
            this.nq3.Location = new System.Drawing.Point(245, 347);
            this.nq3.Name = "nq3";
            this.nq3.Size = new System.Drawing.Size(95, 65);
            this.nq3.TabIndex = 35;
            this.nq3.Text = "15";
            this.nq3.Click += new System.EventHandler(this.nq3_Click);
            // 
            // nq4
            // 
            this.nq4.BackColor = System.Drawing.Color.OliveDrab;
            this.nq4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nq4.ForeColor = System.Drawing.Color.White;
            this.nq4.Location = new System.Drawing.Point(350, 347);
            this.nq4.Name = "nq4";
            this.nq4.Size = new System.Drawing.Size(95, 65);
            this.nq4.TabIndex = 36;
            this.nq4.Text = "20";
            this.nq4.Click += new System.EventHandler(this.nq4_Click);
            // 
            // tq1
            // 
            this.tq1.BackColor = System.Drawing.Color.OliveDrab;
            this.tq1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.tq1.ForeColor = System.Drawing.Color.White;
            this.tq1.Location = new System.Drawing.Point(36, 481);
            this.tq1.Name = "tq1";
            this.tq1.Size = new System.Drawing.Size(95, 65);
            this.tq1.TabIndex = 37;
            this.tq1.Text = "Add";
            this.tq1.Click += new System.EventHandler(this.tq1_Click);
            // 
            // tq2
            // 
            this.tq2.BackColor = System.Drawing.Color.OliveDrab;
            this.tq2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.tq2.ForeColor = System.Drawing.Color.White;
            this.tq2.Location = new System.Drawing.Point(141, 481);
            this.tq2.Name = "tq2";
            this.tq2.Size = new System.Drawing.Size(97, 65);
            this.tq2.TabIndex = 38;
            this.tq2.Text = "Subtract";
            this.tq2.Click += new System.EventHandler(this.tq2_Click);
            // 
            // tq3
            // 
            this.tq3.BackColor = System.Drawing.Color.OliveDrab;
            this.tq3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.tq3.ForeColor = System.Drawing.Color.White;
            this.tq3.Location = new System.Drawing.Point(245, 481);
            this.tq3.Name = "tq3";
            this.tq3.Size = new System.Drawing.Size(95, 65);
            this.tq3.TabIndex = 39;
            this.tq3.Text = "Multiply";
            this.tq3.Click += new System.EventHandler(this.tq3_Click);
            // 
            // tq4
            // 
            this.tq4.BackColor = System.Drawing.Color.OliveDrab;
            this.tq4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.tq4.ForeColor = System.Drawing.Color.White;
            this.tq4.Location = new System.Drawing.Point(350, 481);
            this.tq4.Name = "tq4";
            this.tq4.Size = new System.Drawing.Size(95, 65);
            this.tq4.TabIndex = 40;
            this.tq4.Text = "Divide";
            this.tq4.Click += new System.EventHandler(this.tq4_Click);
            // 
            // credbut
            // 
            this.credbut.BackColor = System.Drawing.Color.YellowGreen;
            this.credbut.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.credbut.Location = new System.Drawing.Point(24, 562);
            this.credbut.Name = "credbut";
            this.credbut.Size = new System.Drawing.Size(125, 48);
            this.credbut.TabIndex = 41;
            this.credbut.Text = "&Credits";
            this.credbut.Click += new System.EventHandler(this.credbut_Click);
            // 
            // startbut
            // 
            this.startbut.BackColor = System.Drawing.Color.GreenYellow;
            this.startbut.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.startbut.Location = new System.Drawing.Point(319, 562);
            this.startbut.Name = "startbut";
            this.startbut.Size = new System.Drawing.Size(144, 48);
            this.startbut.TabIndex = 42;
            this.startbut.Text = "&Start";
            this.startbut.Click += new System.EventHandler(this.startbut_Click);
            // 
            // nplayer1
            // 
            this.nplayer1.BackColor = System.Drawing.Color.OliveDrab;
            this.nplayer1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.nplayer1.ForeColor = System.Drawing.Color.White;
            this.nplayer1.Location = new System.Drawing.Point(38, 209);
            this.nplayer1.Name = "nplayer1";
            this.nplayer1.Size = new System.Drawing.Size(95, 65);
            this.nplayer1.TabIndex = 44;
            this.nplayer1.Text = "1";
            this.nplayer1.Click += new System.EventHandler(this.nplayer1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(172, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 46;
            this.button1.Text = "&Score Board";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(480, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nplayer1);
            this.Controls.Add(this.startbut);
            this.Controls.Add(this.credbut);
            this.Controls.Add(this.tq4);
            this.Controls.Add(this.tq3);
            this.Controls.Add(this.tq2);
            this.Controls.Add(this.tq1);
            this.Controls.Add(this.nq4);
            this.Controls.Add(this.nq3);
            this.Controls.Add(this.nq2);
            this.Controls.Add(this.nq1);
            this.Controls.Add(this.nplayer4);
            this.Controls.Add(this.nplayer3);
            this.Controls.Add(this.nplayer2);
            this.Controls.Add(this.BackDrop);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 52);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Quizmine MathRacer";
            this.Closed += new System.EventHandler(this.MainForm_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.PictureBox BackDrop;
        private System.Windows.Forms.Button nplayer2;
        private System.Windows.Forms.Button nplayer3;
        private System.Windows.Forms.Button nplayer4;
        private System.Windows.Forms.Button nq1;
        private System.Windows.Forms.Button nq2;
        private System.Windows.Forms.Button nq3;
        private System.Windows.Forms.Button nq4;
        private System.Windows.Forms.Button tq1;
        private System.Windows.Forms.Button tq2;
        private System.Windows.Forms.Button tq3;
        private System.Windows.Forms.Button tq4;
        private System.Windows.Forms.Button credbut;
        private System.Windows.Forms.Button startbut;
        private System.Windows.Forms.Button nplayer1;
        private System.Windows.Forms.Button button1;
    }
}