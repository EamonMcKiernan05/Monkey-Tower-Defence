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
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(719, -3);
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
            this.btnAD.Location = new System.Drawing.Point(717, 39);
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
            this.btnCannon.Location = new System.Drawing.Point(719, 100);
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
            this.btnXbow.Location = new System.Drawing.Point(719, 161);
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
            this.lblADCount.Location = new System.Drawing.Point(684, 61);
            this.lblADCount.Name = "lblADCount";
            this.lblADCount.Size = new System.Drawing.Size(13, 13);
            this.lblADCount.TabIndex = 8;
            this.lblADCount.Text = "0";
            // 
            // lblXBowCount
            // 
            this.lblXBowCount.AutoSize = true;
            this.lblXBowCount.Location = new System.Drawing.Point(684, 183);
            this.lblXBowCount.Name = "lblXBowCount";
            this.lblXBowCount.Size = new System.Drawing.Size(13, 13);
            this.lblXBowCount.TabIndex = 9;
            this.lblXBowCount.Text = "0";
            // 
            // lblCannonCount
            // 
            this.lblCannonCount.AutoSize = true;
            this.lblCannonCount.Location = new System.Drawing.Point(684, 122);
            this.lblCannonCount.Name = "lblCannonCount";
            this.lblCannonCount.Size = new System.Drawing.Size(13, 13);
            this.lblCannonCount.TabIndex = 10;
            this.lblCannonCount.Text = "0";
            // 
            // Game_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
    }
}