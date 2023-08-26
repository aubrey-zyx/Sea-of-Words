namespace the_Sea_of_Words
{
    partial class maininterface
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
            System.Windows.Forms.PictureBox player;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maininterface));
            this.gamebegin = new System.Windows.Forms.Button();
            this.XPlabel = new System.Windows.Forms.Label();
            this.LEVELlabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.NEXTlabel = new System.Windows.Forms.Label();
            this.Progresslabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.qutigame = new System.Windows.Forms.Button();
            this.musicopen = new System.Windows.Forms.Button();
            this.musicclose = new System.Windows.Forms.Button();
            this.playeraircraft = new System.Windows.Forms.PictureBox();
            this.PLANlabel = new System.Windows.Forms.Label();
            this.DIClabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aircaftNamelabel = new System.Windows.Forms.Label();
            player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playeraircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            player.BackColor = System.Drawing.Color.Transparent;
            player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            player.InitialImage = null;
            player.Location = new System.Drawing.Point(12, 12);
            player.Name = "player";
            player.Size = new System.Drawing.Size(359, 410);
            player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            player.TabIndex = 6;
            player.TabStop = false;
            // 
            // gamebegin
            // 
            this.gamebegin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gamebegin.BackColor = System.Drawing.Color.White;
            this.gamebegin.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gamebegin.ForeColor = System.Drawing.Color.HotPink;
            this.gamebegin.Location = new System.Drawing.Point(365, 459);
            this.gamebegin.Name = "gamebegin";
            this.gamebegin.Size = new System.Drawing.Size(374, 92);
            this.gamebegin.TabIndex = 0;
            this.gamebegin.Text = "开始游戏";
            this.gamebegin.UseVisualStyleBackColor = false;
            this.gamebegin.Click += new System.EventHandler(this.button1_Click);
            // 
            // XPlabel
            // 
            this.XPlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.XPlabel.AutoSize = true;
            this.XPlabel.BackColor = System.Drawing.Color.Transparent;
            this.XPlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.XPlabel.ForeColor = System.Drawing.Color.HotPink;
            this.XPlabel.Location = new System.Drawing.Point(400, 390);
            this.XPlabel.Name = "XPlabel";
            this.XPlabel.Size = new System.Drawing.Size(132, 27);
            this.XPlabel.TabIndex = 1;
            this.XPlabel.Text = "您的经验值：";
            // 
            // LEVELlabel
            // 
            this.LEVELlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LEVELlabel.AutoSize = true;
            this.LEVELlabel.BackColor = System.Drawing.Color.Transparent;
            this.LEVELlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LEVELlabel.ForeColor = System.Drawing.Color.HotPink;
            this.LEVELlabel.Location = new System.Drawing.Point(400, 138);
            this.LEVELlabel.Name = "LEVELlabel";
            this.LEVELlabel.Size = new System.Drawing.Size(52, 27);
            this.LEVELlabel.TabIndex = 2;
            this.LEVELlabel.Text = "等级";
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ID.ForeColor = System.Drawing.Color.HotPink;
            this.ID.Location = new System.Drawing.Point(400, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(35, 27);
            this.ID.TabIndex = 3;
            this.ID.Text = "ID";
            // 
            // NEXTlabel
            // 
            this.NEXTlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NEXTlabel.AutoSize = true;
            this.NEXTlabel.BackColor = System.Drawing.Color.Transparent;
            this.NEXTlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NEXTlabel.ForeColor = System.Drawing.Color.HotPink;
            this.NEXTlabel.Location = new System.Drawing.Point(400, 201);
            this.NEXTlabel.Name = "NEXTlabel";
            this.NEXTlabel.Size = new System.Drawing.Size(72, 27);
            this.NEXTlabel.TabIndex = 4;
            this.NEXTlabel.Text = "下一关";
            // 
            // Progresslabel
            // 
            this.Progresslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Progresslabel.AutoSize = true;
            this.Progresslabel.BackColor = System.Drawing.Color.Transparent;
            this.Progresslabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Progresslabel.ForeColor = System.Drawing.Color.HotPink;
            this.Progresslabel.Location = new System.Drawing.Point(400, 264);
            this.Progresslabel.Name = "Progresslabel";
            this.Progresslabel.Size = new System.Drawing.Size(52, 27);
            this.Progresslabel.TabIndex = 5;
            this.Progresslabel.Text = "进度";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(609, 371);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox3.Location = new System.Drawing.Point(614, 375);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(328, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // qutigame
            // 
            this.qutigame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qutigame.BackColor = System.Drawing.Color.White;
            this.qutigame.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qutigame.ForeColor = System.Drawing.Color.HotPink;
            this.qutigame.Location = new System.Drawing.Point(953, 495);
            this.qutigame.Name = "qutigame";
            this.qutigame.Size = new System.Drawing.Size(151, 44);
            this.qutigame.TabIndex = 9;
            this.qutigame.Text = "退出游戏";
            this.qutigame.UseVisualStyleBackColor = false;
            this.qutigame.Click += new System.EventHandler(this.qutigame_Click);
            // 
            // musicopen
            // 
            this.musicopen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.musicopen.BackColor = System.Drawing.Color.White;
            this.musicopen.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.musicopen.ForeColor = System.Drawing.Color.HotPink;
            this.musicopen.Location = new System.Drawing.Point(24, 495);
            this.musicopen.Name = "musicopen";
            this.musicopen.Size = new System.Drawing.Size(151, 44);
            this.musicopen.TabIndex = 10;
            this.musicopen.Text = "开启音乐";
            this.musicopen.UseVisualStyleBackColor = false;
            this.musicopen.Click += new System.EventHandler(this.music_Click);
            // 
            // musicclose
            // 
            this.musicclose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.musicclose.BackColor = System.Drawing.Color.White;
            this.musicclose.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.musicclose.ForeColor = System.Drawing.Color.HotPink;
            this.musicclose.Location = new System.Drawing.Point(185, 495);
            this.musicclose.Name = "musicclose";
            this.musicclose.Size = new System.Drawing.Size(151, 44);
            this.musicclose.TabIndex = 11;
            this.musicclose.Text = "关闭音乐";
            this.musicclose.UseVisualStyleBackColor = false;
            this.musicclose.Click += new System.EventHandler(this.musicclose_Click);
            // 
            // playeraircraft
            // 
            this.playeraircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.playeraircraft.BackColor = System.Drawing.Color.Transparent;
            this.playeraircraft.Location = new System.Drawing.Point(678, 54);
            this.playeraircraft.Name = "playeraircraft";
            this.playeraircraft.Size = new System.Drawing.Size(404, 296);
            this.playeraircraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playeraircraft.TabIndex = 12;
            this.playeraircraft.TabStop = false;
            // 
            // PLANlabel
            // 
            this.PLANlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PLANlabel.AutoSize = true;
            this.PLANlabel.BackColor = System.Drawing.Color.Transparent;
            this.PLANlabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PLANlabel.ForeColor = System.Drawing.Color.HotPink;
            this.PLANlabel.Location = new System.Drawing.Point(400, 327);
            this.PLANlabel.Name = "PLANlabel";
            this.PLANlabel.Size = new System.Drawing.Size(52, 27);
            this.PLANlabel.TabIndex = 13;
            this.PLANlabel.Text = "计划";
            // 
            // DIClabel
            // 
            this.DIClabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DIClabel.AutoSize = true;
            this.DIClabel.BackColor = System.Drawing.Color.Transparent;
            this.DIClabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DIClabel.ForeColor = System.Drawing.Color.HotPink;
            this.DIClabel.Location = new System.Drawing.Point(400, 75);
            this.DIClabel.Name = "DIClabel";
            this.DIClabel.Size = new System.Drawing.Size(52, 27);
            this.DIClabel.TabIndex = 14;
            this.DIClabel.Text = "词库";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.HotPink;
            this.button1.Location = new System.Drawing.Point(767, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "词库/计划";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aircaftNamelabel
            // 
            this.aircaftNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.aircaftNamelabel.AutoSize = true;
            this.aircaftNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.aircaftNamelabel.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aircaftNamelabel.ForeColor = System.Drawing.Color.HotPink;
            this.aircaftNamelabel.Location = new System.Drawing.Point(796, 2);
            this.aircaftNamelabel.Name = "aircaftNamelabel";
            this.aircaftNamelabel.Size = new System.Drawing.Size(177, 37);
            this.aircaftNamelabel.TabIndex = 16;
            this.aircaftNamelabel.Text = "您  的  战  机";
            // 
            // maininterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 576);
            this.Controls.Add(this.aircaftNamelabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DIClabel);
            this.Controls.Add(this.PLANlabel);
            this.Controls.Add(this.playeraircraft);
            this.Controls.Add(this.musicclose);
            this.Controls.Add(this.musicopen);
            this.Controls.Add(this.qutigame);
            this.Controls.Add(player);
            this.Controls.Add(this.Progresslabel);
            this.Controls.Add(this.NEXTlabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.LEVELlabel);
            this.Controls.Add(this.XPlabel);
            this.Controls.Add(this.gamebegin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "maininterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "词海迷航";
            this.Load += new System.EventHandler(this.maininterface_Load);
            ((System.ComponentModel.ISupportInitialize)(player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playeraircraft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gamebegin;
        private System.Windows.Forms.Label XPlabel;
        private System.Windows.Forms.Label LEVELlabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NEXTlabel;
        private System.Windows.Forms.Label Progresslabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button qutigame;
        private System.Windows.Forms.Button musicopen;
        private System.Windows.Forms.Button musicclose;
        private System.Windows.Forms.PictureBox playeraircraft;
        private System.Windows.Forms.Label PLANlabel;
        private System.Windows.Forms.Label DIClabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label aircaftNamelabel;
    }
}