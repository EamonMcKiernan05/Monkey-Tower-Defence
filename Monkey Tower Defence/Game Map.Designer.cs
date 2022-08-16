namespace Monkey_Tower_Defence
{
    partial class Game_Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Map));
            this.lblCoins = new System.Windows.Forms.Label();
            this.scoretimer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnCannon = new System.Windows.Forms.Button();
            this.btnXbow = new System.Windows.Forms.Button();
            this.lblADCount = new System.Windows.Forms.Label();
            this.lblXBowCount = new System.Windows.Forms.Label();
            this.lblCannonCount = new System.Windows.Forms.Label();
            this.imgTower = new System.Windows.Forms.PictureBox();
            this.imgBloon = new System.Windows.Forms.PictureBox();
            this.BloonTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBloon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCoins.Location = new System.Drawing.Point(12, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(106, 24);
            this.lblCoins.TabIndex = 1;
            this.lblCoins.Text = "Coins: 0";
            this.lblCoins.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoretimer
            // 
            this.scoretimer.Enabled = true;
            this.scoretimer.Interval = 90;
            this.scoretimer.Tick += new System.EventHandler(this.scoretimer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1096, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAD
            // 
            this.btnAD.BackColor = System.Drawing.Color.Lime;
            this.btnAD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAD.BackgroundImage")));
            this.btnAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAD.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAD.ForeColor = System.Drawing.Color.White;
            this.btnAD.Location = new System.Drawing.Point(235, 5);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(83, 55);
            this.btnAD.TabIndex = 5;
            this.btnAD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAD.UseVisualStyleBackColor = false;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnCannon
            // 
            this.btnCannon.BackColor = System.Drawing.Color.Blue;
            this.btnCannon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCannon.BackgroundImage")));
            this.btnCannon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCannon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCannon.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCannon.ForeColor = System.Drawing.Color.White;
            this.btnCannon.Location = new System.Drawing.Point(501, 5);
            this.btnCannon.Name = "btnCannon";
            this.btnCannon.Size = new System.Drawing.Size(83, 55);
            this.btnCannon.TabIndex = 6;
            this.btnCannon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCannon.UseVisualStyleBackColor = false;
            this.btnCannon.Click += new System.EventHandler(this.btnCannon_Click);
            // 
            // btnXbow
            // 
            this.btnXbow.BackColor = System.Drawing.Color.Red;
            this.btnXbow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXbow.BackgroundImage")));
            this.btnXbow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXbow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXbow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXbow.ForeColor = System.Drawing.Color.White;
            this.btnXbow.Location = new System.Drawing.Point(767, 5);
            this.btnXbow.Name = "btnXbow";
            this.btnXbow.Size = new System.Drawing.Size(83, 55);
            this.btnXbow.TabIndex = 7;
            this.btnXbow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnXbow.UseVisualStyleBackColor = false;
            this.btnXbow.Click += new System.EventHandler(this.btnXbow_Click);
            // 
            // lblADCount
            // 
            this.lblADCount.AutoSize = true;
            this.lblADCount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblADCount.Location = new System.Drawing.Point(209, 21);
            this.lblADCount.Name = "lblADCount";
            this.lblADCount.Size = new System.Drawing.Size(20, 22);
            this.lblADCount.TabIndex = 8;
            this.lblADCount.Text = "0";
            // 
            // lblXBowCount
            // 
            this.lblXBowCount.AutoSize = true;
            this.lblXBowCount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXBowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblXBowCount.Location = new System.Drawing.Point(741, 21);
            this.lblXBowCount.Name = "lblXBowCount";
            this.lblXBowCount.Size = new System.Drawing.Size(20, 22);
            this.lblXBowCount.TabIndex = 9;
            this.lblXBowCount.Text = "0";
            // 
            // lblCannonCount
            // 
            this.lblCannonCount.AutoSize = true;
            this.lblCannonCount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCannonCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCannonCount.Location = new System.Drawing.Point(475, 21);
            this.lblCannonCount.Name = "lblCannonCount";
            this.lblCannonCount.Size = new System.Drawing.Size(20, 22);
            this.lblCannonCount.TabIndex = 10;
            this.lblCannonCount.Text = "0";
            // 
            // imgTower
            // 
            this.imgTower.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgTower.BackgroundImage")));
            this.imgTower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTower.Location = new System.Drawing.Point(990, 497);
            this.imgTower.Name = "imgTower";
            this.imgTower.Size = new System.Drawing.Size(189, 152);
            this.imgTower.TabIndex = 11;
            this.imgTower.TabStop = false;
            this.imgTower.Click += new System.EventHandler(this.imgTower_Click);
            // 
            // imgBloon
            // 
            this.imgBloon.BackColor = System.Drawing.Color.Transparent;
            this.imgBloon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgBloon.BackgroundImage")));
            this.imgBloon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgBloon.Location = new System.Drawing.Point(12, 136);
            this.imgBloon.Name = "imgBloon";
            this.imgBloon.Size = new System.Drawing.Size(42, 31);
            this.imgBloon.TabIndex = 12;
            this.imgBloon.TabStop = false;
            // 
            // BloonTimer
            // 
            this.BloonTimer.Enabled = true;
            this.BloonTimer.Interval = 50;
            this.BloonTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(16, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 21);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(16, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1021, 21);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(16, 362);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1021, 21);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(16, 470);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1021, 21);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(1016, 146);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 129);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Location = new System.Drawing.Point(16, 254);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 129);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Location = new System.Drawing.Point(1016, 362);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(21, 129);
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox8.Location = new System.Drawing.Point(16, 470);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(21, 129);
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox9.Location = new System.Drawing.Point(16, 578);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1007, 21);
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // Game_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 717);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.imgBloon);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgTower);
            this.Controls.Add(this.lblCannonCount);
            this.Controls.Add(this.lblXBowCount);
            this.Controls.Add(this.lblADCount);
            this.Controls.Add(this.btnXbow);
            this.Controls.Add(this.btnCannon);
            this.Controls.Add(this.btnAD);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCoins);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_Map";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Game_Map";
            ((System.ComponentModel.ISupportInitialize)(this.imgTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBloon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Timer scoretimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnCannon;
        private System.Windows.Forms.Button btnXbow;
        private System.Windows.Forms.Label lblADCount;
        private System.Windows.Forms.Label lblXBowCount;
        private System.Windows.Forms.Label lblCannonCount;
        private System.Windows.Forms.PictureBox imgTower;
        private System.Windows.Forms.PictureBox imgBloon;
        private System.Windows.Forms.Timer BloonTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}