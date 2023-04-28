namespace Файтинг
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            this.playerImage = new System.Windows.Forms.PictureBox();
            this.AIImage = new System.Windows.Forms.PictureBox();
            this.imageCharacters = new System.Windows.Forms.ImageList(this.components);
            this.playerName = new System.Windows.Forms.Label();
            this.AIName = new System.Windows.Forms.Label();
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.AIHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeOfFight = new System.Windows.Forms.Label();
            this.headAttack = new System.Windows.Forms.Button();
            this.bodyAttack = new System.Windows.Forms.Button();
            this.feetAttack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerText = new System.Windows.Forms.Label();
            this.AIText = new System.Windows.Forms.Label();
            this.step = new System.Windows.Forms.Label();
            this.headBlock = new System.Windows.Forms.Button();
            this.bodyBlock = new System.Windows.Forms.Button();
            this.feetBlock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reGame = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.ListBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.startPicture = new System.Windows.Forms.PictureBox();
            this.rulesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerImage
            // 
            this.playerImage.BackColor = System.Drawing.Color.Transparent;
            this.playerImage.Location = new System.Drawing.Point(99, 90);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(256, 307);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 0;
            this.playerImage.TabStop = false;
            // 
            // AIImage
            // 
            this.AIImage.BackColor = System.Drawing.Color.Transparent;
            this.AIImage.Location = new System.Drawing.Point(769, 90);
            this.AIImage.Name = "AIImage";
            this.AIImage.Size = new System.Drawing.Size(256, 307);
            this.AIImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AIImage.TabIndex = 0;
            this.AIImage.TabStop = false;
            // 
            // imageCharacters
            // 
            this.imageCharacters.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageCharacters.ImageStream")));
            this.imageCharacters.TransparentColor = System.Drawing.Color.Transparent;
            this.imageCharacters.Images.SetKeyName(0, "baiken-character-artwork-guilty-gear-xrd-revelator-altar-of-gaming.png");
            this.imageCharacters.Images.SetKeyName(1, "dizzy-character-artwork-guilty-gear-xrd-revelator-altar-of-gaming.png");
            this.imageCharacters.Images.SetKeyName(2, "johnny-character-artwork-guilty-gear-xrd-revelator-altar-of-gaming-PhotoRoom.png-" +
        "PhotoRoom.png");
            this.imageCharacters.Images.SetKeyName(3, "kum-haehyun-character-artwork-guilty-gear-xrd-revelator-altar-of-gaming-PhotoRoom" +
        ".png-PhotoRoom.png");
            this.imageCharacters.Images.SetKeyName(4, "may-character-artwork-guilty-gear-xrd-revelator-altar-of-gaming-PhotoRoom.png-Pho" +
        "toRoom.png");
            this.imageCharacters.Images.SetKeyName(5, "ramlethal-character-artwork-guilty-gear-xrd-revelator-altar-of-gaming-PhotoRoom.p" +
        "ng-PhotoRoom.png");
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Black;
            this.playerName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerName.ForeColor = System.Drawing.Color.White;
            this.playerName.Location = new System.Drawing.Point(181, 9);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(0, 36);
            this.playerName.TabIndex = 1;
            this.playerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerName.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // AIName
            // 
            this.AIName.AutoSize = true;
            this.AIName.BackColor = System.Drawing.Color.Black;
            this.AIName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AIName.ForeColor = System.Drawing.Color.White;
            this.AIName.Location = new System.Drawing.Point(883, 9);
            this.AIName.Name = "AIName";
            this.AIName.Size = new System.Drawing.Size(44, 36);
            this.AIName.TabIndex = 1;
            this.AIName.Text = "AI";
            this.AIName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AIName.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(99, 50);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playerHealth.RightToLeftLayout = true;
            this.playerHealth.Size = new System.Drawing.Size(453, 36);
            this.playerHealth.TabIndex = 2;
            this.playerHealth.Value = 100;
            // 
            // AIHealth
            // 
            this.AIHealth.Location = new System.Drawing.Point(572, 50);
            this.AIHealth.Name = "AIHealth";
            this.AIHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AIHealth.RightToLeftLayout = true;
            this.AIHealth.Size = new System.Drawing.Size(453, 36);
            this.AIHealth.TabIndex = 2;
            this.AIHealth.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(523, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeOfFight
            // 
            this.timeOfFight.AutoSize = true;
            this.timeOfFight.BackColor = System.Drawing.Color.Black;
            this.timeOfFight.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeOfFight.ForeColor = System.Drawing.Color.White;
            this.timeOfFight.Location = new System.Drawing.Point(548, 135);
            this.timeOfFight.Name = "timeOfFight";
            this.timeOfFight.Size = new System.Drawing.Size(0, 36);
            this.timeOfFight.TabIndex = 1;
            this.timeOfFight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headAttack
            // 
            this.headAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headAttack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headAttack.Location = new System.Drawing.Point(100, 451);
            this.headAttack.Name = "headAttack";
            this.headAttack.Size = new System.Drawing.Size(110, 37);
            this.headAttack.TabIndex = 4;
            this.headAttack.Text = "Head";
            this.headAttack.UseVisualStyleBackColor = true;
            this.headAttack.Click += new System.EventHandler(this.PlayerAttack);
            // 
            // bodyAttack
            // 
            this.bodyAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bodyAttack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyAttack.Location = new System.Drawing.Point(99, 494);
            this.bodyAttack.Name = "bodyAttack";
            this.bodyAttack.Size = new System.Drawing.Size(110, 37);
            this.bodyAttack.TabIndex = 4;
            this.bodyAttack.Text = "Body";
            this.bodyAttack.UseVisualStyleBackColor = true;
            this.bodyAttack.Click += new System.EventHandler(this.PlayerAttack);
            // 
            // feetAttack
            // 
            this.feetAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feetAttack.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feetAttack.Location = new System.Drawing.Point(99, 536);
            this.feetAttack.Name = "feetAttack";
            this.feetAttack.Size = new System.Drawing.Size(110, 37);
            this.feetAttack.TabIndex = 4;
            this.feetAttack.Text = "Feet";
            this.feetAttack.UseVisualStyleBackColor = true;
            this.feetAttack.Click += new System.EventHandler(this.PlayerAttack);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Attack";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Block";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // playerText
            // 
            this.playerText.AutoSize = true;
            this.playerText.BackColor = System.Drawing.Color.Black;
            this.playerText.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerText.ForeColor = System.Drawing.Color.White;
            this.playerText.Location = new System.Drawing.Point(361, 95);
            this.playerText.Name = "playerText";
            this.playerText.Size = new System.Drawing.Size(73, 28);
            this.playerText.TabIndex = 1;
            this.playerText.Text = "Атака";
            this.playerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerText.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // AIText
            // 
            this.AIText.AutoSize = true;
            this.AIText.BackColor = System.Drawing.Color.Black;
            this.AIText.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AIText.ForeColor = System.Drawing.Color.White;
            this.AIText.Location = new System.Drawing.Point(707, 95);
            this.AIText.Name = "AIText";
            this.AIText.Size = new System.Drawing.Size(56, 28);
            this.AIText.TabIndex = 1;
            this.AIText.Text = "Блок";
            this.AIText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AIText.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.BackColor = System.Drawing.Color.Black;
            this.step.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step.ForeColor = System.Drawing.Color.White;
            this.step.Location = new System.Drawing.Point(572, 90);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(28, 36);
            this.step.TabIndex = 1;
            this.step.Text = "1";
            this.step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.step.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // headBlock
            // 
            this.headBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headBlock.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headBlock.Location = new System.Drawing.Point(252, 450);
            this.headBlock.Name = "headBlock";
            this.headBlock.Size = new System.Drawing.Size(103, 38);
            this.headBlock.TabIndex = 5;
            this.headBlock.Text = "Head";
            this.headBlock.UseVisualStyleBackColor = true;
            this.headBlock.Click += new System.EventHandler(this.PlayerBlock);
            // 
            // bodyBlock
            // 
            this.bodyBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bodyBlock.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyBlock.Location = new System.Drawing.Point(252, 494);
            this.bodyBlock.Name = "bodyBlock";
            this.bodyBlock.Size = new System.Drawing.Size(103, 38);
            this.bodyBlock.TabIndex = 5;
            this.bodyBlock.Text = "Body";
            this.bodyBlock.UseVisualStyleBackColor = true;
            this.bodyBlock.Click += new System.EventHandler(this.PlayerBlock);
            // 
            // feetBlock
            // 
            this.feetBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feetBlock.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feetBlock.Location = new System.Drawing.Point(252, 535);
            this.feetBlock.Name = "feetBlock";
            this.feetBlock.Size = new System.Drawing.Size(103, 38);
            this.feetBlock.TabIndex = 5;
            this.feetBlock.Text = "Feet";
            this.feetBlock.UseVisualStyleBackColor = true;
            this.feetBlock.Click += new System.EventHandler(this.PlayerBlock);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(493, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ход:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // reGame
            // 
            this.reGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reGame.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reGame.Location = new System.Drawing.Point(861, 528);
            this.reGame.Name = "reGame";
            this.reGame.Size = new System.Drawing.Size(102, 45);
            this.reGame.TabIndex = 6;
            this.reGame.Text = "Restart";
            this.reGame.UseVisualStyleBackColor = false;
            this.reGame.Click += new System.EventHandler(this.reGame_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.Black;
            this.history.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.FormattingEnabled = true;
            this.history.ItemHeight = 18;
            this.history.Location = new System.Drawing.Point(378, 187);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.history.Size = new System.Drawing.Size(364, 184);
            this.history.TabIndex = 7;
            this.history.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Black;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(982, 528);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(102, 45);
            this.menuButton.TabIndex = 6;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // startPicture
            // 
            this.startPicture.BackColor = System.Drawing.Color.Transparent;
            this.startPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startPicture.Image = ((System.Drawing.Image)(resources.GetObject("startPicture.Image")));
            this.startPicture.Location = new System.Drawing.Point(493, 402);
            this.startPicture.Name = "startPicture";
            this.startPicture.Size = new System.Drawing.Size(138, 86);
            this.startPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPicture.TabIndex = 8;
            this.startPicture.TabStop = false;
            this.startPicture.Click += new System.EventHandler(this.startButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rulesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rulesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rulesButton.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rulesButton.Location = new System.Drawing.Point(514, 494);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(102, 45);
            this.rulesButton.TabIndex = 6;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = false;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 588);
            this.Controls.Add(this.startPicture);
            this.Controls.Add(this.history);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.reGame);
            this.Controls.Add(this.feetBlock);
            this.Controls.Add(this.bodyBlock);
            this.Controls.Add(this.headBlock);
            this.Controls.Add(this.feetAttack);
            this.Controls.Add(this.bodyAttack);
            this.Controls.Add(this.headAttack);
            this.Controls.Add(this.AIHealth);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.timeOfFight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AIText);
            this.Controls.Add(this.playerText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.step);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AIName);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.AIImage);
            this.Controls.Add(this.playerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "God-killers III. The Hunt for Olympus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fight_FormClosing);
            this.Load += new System.EventHandler(this.Fight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox AIImage;
        private System.Windows.Forms.ImageList imageCharacters;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label AIName;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.ProgressBar AIHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeOfFight;
        private System.Windows.Forms.Button headAttack;
        private System.Windows.Forms.Button bodyAttack;
        private System.Windows.Forms.Button feetAttack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerText;
        private System.Windows.Forms.Label AIText;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.Button headBlock;
        private System.Windows.Forms.Button bodyBlock;
        private System.Windows.Forms.Button feetBlock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button reGame;
        private System.Windows.Forms.ListBox history;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox startPicture;
        private System.Windows.Forms.Button rulesButton;
    }
}