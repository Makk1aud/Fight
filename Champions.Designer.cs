namespace Файтинг
{
    partial class Champions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Champions));
            this.imageCharacters = new System.Windows.Forms.ImageList(this.components);
            this.AIChampion = new System.Windows.Forms.PictureBox();
            this.playerChampion = new System.Windows.Forms.PictureBox();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.PlayerRadio = new System.Windows.Forms.RadioButton();
            this.AIRadio = new System.Windows.Forms.RadioButton();
            this.aboutPlayerCharacter = new System.Windows.Forms.TextBox();
            this.aboutAICharacter = new System.Windows.Forms.TextBox();
            this.PlayerCharacterName = new System.Windows.Forms.Label();
            this.AICharacterName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHeadDamage = new System.Windows.Forms.TextBox();
            this.playerBodyDamage = new System.Windows.Forms.TextBox();
            this.playerFeetDamage = new System.Windows.Forms.TextBox();
            this.playerCritDamage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AiHeadDamage = new System.Windows.Forms.TextBox();
            this.AiBodyDamage = new System.Windows.Forms.TextBox();
            this.AiFeetDamage = new System.Windows.Forms.TextBox();
            this.AiCritDamage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AIChampion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerChampion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // AIChampion
            // 
            this.AIChampion.BackColor = System.Drawing.Color.Transparent;
            this.AIChampion.Cursor = System.Windows.Forms.Cursors.Default;
            this.AIChampion.Image = ((System.Drawing.Image)(resources.GetObject("AIChampion.Image")));
            this.AIChampion.Location = new System.Drawing.Point(745, 82);
            this.AIChampion.Name = "AIChampion";
            this.AIChampion.Size = new System.Drawing.Size(242, 336);
            this.AIChampion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AIChampion.TabIndex = 1;
            this.AIChampion.TabStop = false;
            // 
            // playerChampion
            // 
            this.playerChampion.BackColor = System.Drawing.Color.Transparent;
            this.playerChampion.Cursor = System.Windows.Forms.Cursors.Default;
            this.playerChampion.Image = ((System.Drawing.Image)(resources.GetObject("playerChampion.Image")));
            this.playerChampion.Location = new System.Drawing.Point(24, 82);
            this.playerChampion.Name = "playerChampion";
            this.playerChampion.Size = new System.Drawing.Size(242, 336);
            this.playerChampion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerChampion.TabIndex = 1;
            this.playerChampion.TabStop = false;
            // 
            // Left
            // 
            this.Left.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Left.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Left.Location = new System.Drawing.Point(354, 422);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(99, 55);
            this.Left.TabIndex = 2;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.BackColor = System.Drawing.Color.Black;
            this.Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Right.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Right.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Right.Location = new System.Drawing.Point(561, 422);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(99, 55);
            this.Right.TabIndex = 2;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = false;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // PlayerRadio
            // 
            this.PlayerRadio.AutoSize = true;
            this.PlayerRadio.BackColor = System.Drawing.Color.Transparent;
            this.PlayerRadio.Checked = true;
            this.PlayerRadio.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerRadio.Location = new System.Drawing.Point(101, 16);
            this.PlayerRadio.Name = "PlayerRadio";
            this.PlayerRadio.Size = new System.Drawing.Size(77, 29);
            this.PlayerRadio.TabIndex = 3;
            this.PlayerRadio.TabStop = true;
            this.PlayerRadio.Text = "Player";
            this.PlayerRadio.UseVisualStyleBackColor = false;
            // 
            // AIRadio
            // 
            this.AIRadio.AutoSize = true;
            this.AIRadio.BackColor = System.Drawing.Color.Transparent;
            this.AIRadio.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AIRadio.Location = new System.Drawing.Point(849, 16);
            this.AIRadio.Name = "AIRadio";
            this.AIRadio.Size = new System.Drawing.Size(51, 29);
            this.AIRadio.TabIndex = 3;
            this.AIRadio.Text = "AI";
            this.AIRadio.UseVisualStyleBackColor = false;
            // 
            // aboutPlayerCharacter
            // 
            this.aboutPlayerCharacter.BackColor = System.Drawing.Color.Black;
            this.aboutPlayerCharacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutPlayerCharacter.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutPlayerCharacter.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutPlayerCharacter.ForeColor = System.Drawing.Color.White;
            this.aboutPlayerCharacter.Location = new System.Drawing.Point(286, 84);
            this.aboutPlayerCharacter.Multiline = true;
            this.aboutPlayerCharacter.Name = "aboutPlayerCharacter";
            this.aboutPlayerCharacter.ReadOnly = true;
            this.aboutPlayerCharacter.Size = new System.Drawing.Size(199, 334);
            this.aboutPlayerCharacter.TabIndex = 4;
            this.aboutPlayerCharacter.Text = resources.GetString("aboutPlayerCharacter.Text");
            this.aboutPlayerCharacter.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // aboutAICharacter
            // 
            this.aboutAICharacter.BackColor = System.Drawing.Color.Black;
            this.aboutAICharacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutAICharacter.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutAICharacter.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutAICharacter.ForeColor = System.Drawing.Color.White;
            this.aboutAICharacter.Location = new System.Drawing.Point(529, 82);
            this.aboutAICharacter.Multiline = true;
            this.aboutAICharacter.Name = "aboutAICharacter";
            this.aboutAICharacter.ReadOnly = true;
            this.aboutAICharacter.Size = new System.Drawing.Size(199, 334);
            this.aboutAICharacter.TabIndex = 4;
            this.aboutAICharacter.Text = resources.GetString("aboutAICharacter.Text");
            this.aboutAICharacter.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // PlayerCharacterName
            // 
            this.PlayerCharacterName.AutoSize = true;
            this.PlayerCharacterName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerCharacterName.ForeColor = System.Drawing.Color.White;
            this.PlayerCharacterName.Location = new System.Drawing.Point(18, 43);
            this.PlayerCharacterName.Name = "PlayerCharacterName";
            this.PlayerCharacterName.Size = new System.Drawing.Size(0, 36);
            this.PlayerCharacterName.TabIndex = 5;
            this.PlayerCharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AICharacterName
            // 
            this.AICharacterName.AutoSize = true;
            this.AICharacterName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AICharacterName.ForeColor = System.Drawing.Color.White;
            this.AICharacterName.Location = new System.Drawing.Point(749, 43);
            this.AICharacterName.Name = "AICharacterName";
            this.AICharacterName.Size = new System.Drawing.Size(0, 36);
            this.AICharacterName.TabIndex = 5;
            this.AICharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Атака в голову";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Атака в тело";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Атака в ноги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Критический урон";
            // 
            // playerHeadDamage
            // 
            this.playerHeadDamage.BackColor = System.Drawing.Color.Black;
            this.playerHeadDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHeadDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerHeadDamage.ForeColor = System.Drawing.Color.White;
            this.playerHeadDamage.Location = new System.Drawing.Point(140, 427);
            this.playerHeadDamage.Multiline = true;
            this.playerHeadDamage.Name = "playerHeadDamage";
            this.playerHeadDamage.ReadOnly = true;
            this.playerHeadDamage.Size = new System.Drawing.Size(54, 23);
            this.playerHeadDamage.TabIndex = 9;
            this.playerHeadDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // playerBodyDamage
            // 
            this.playerBodyDamage.BackColor = System.Drawing.Color.Black;
            this.playerBodyDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerBodyDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerBodyDamage.ForeColor = System.Drawing.Color.White;
            this.playerBodyDamage.Location = new System.Drawing.Point(140, 456);
            this.playerBodyDamage.Multiline = true;
            this.playerBodyDamage.Name = "playerBodyDamage";
            this.playerBodyDamage.ReadOnly = true;
            this.playerBodyDamage.Size = new System.Drawing.Size(54, 23);
            this.playerBodyDamage.TabIndex = 9;
            this.playerBodyDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // playerFeetDamage
            // 
            this.playerFeetDamage.BackColor = System.Drawing.Color.Black;
            this.playerFeetDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerFeetDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerFeetDamage.ForeColor = System.Drawing.Color.White;
            this.playerFeetDamage.Location = new System.Drawing.Point(140, 482);
            this.playerFeetDamage.Multiline = true;
            this.playerFeetDamage.Name = "playerFeetDamage";
            this.playerFeetDamage.ReadOnly = true;
            this.playerFeetDamage.Size = new System.Drawing.Size(54, 23);
            this.playerFeetDamage.TabIndex = 9;
            this.playerFeetDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // playerCritDamage
            // 
            this.playerCritDamage.BackColor = System.Drawing.Color.Black;
            this.playerCritDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCritDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerCritDamage.ForeColor = System.Drawing.Color.White;
            this.playerCritDamage.Location = new System.Drawing.Point(160, 510);
            this.playerCritDamage.Multiline = true;
            this.playerCritDamage.Name = "playerCritDamage";
            this.playerCritDamage.ReadOnly = true;
            this.playerCritDamage.Size = new System.Drawing.Size(59, 23);
            this.playerCritDamage.TabIndex = 9;
            this.playerCritDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(751, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Атака в голову";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(751, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Атака в тело";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(751, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Атака в ноги";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(751, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Критический урон";
            // 
            // AiHeadDamage
            // 
            this.AiHeadDamage.BackColor = System.Drawing.Color.Black;
            this.AiHeadDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AiHeadDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AiHeadDamage.ForeColor = System.Drawing.Color.White;
            this.AiHeadDamage.Location = new System.Drawing.Point(861, 427);
            this.AiHeadDamage.Multiline = true;
            this.AiHeadDamage.Name = "AiHeadDamage";
            this.AiHeadDamage.ReadOnly = true;
            this.AiHeadDamage.Size = new System.Drawing.Size(54, 23);
            this.AiHeadDamage.TabIndex = 9;
            this.AiHeadDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // AiBodyDamage
            // 
            this.AiBodyDamage.BackColor = System.Drawing.Color.Black;
            this.AiBodyDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AiBodyDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AiBodyDamage.ForeColor = System.Drawing.Color.White;
            this.AiBodyDamage.Location = new System.Drawing.Point(861, 456);
            this.AiBodyDamage.Multiline = true;
            this.AiBodyDamage.Name = "AiBodyDamage";
            this.AiBodyDamage.ReadOnly = true;
            this.AiBodyDamage.Size = new System.Drawing.Size(54, 23);
            this.AiBodyDamage.TabIndex = 9;
            this.AiBodyDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // AiFeetDamage
            // 
            this.AiFeetDamage.BackColor = System.Drawing.Color.Black;
            this.AiFeetDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AiFeetDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AiFeetDamage.ForeColor = System.Drawing.Color.White;
            this.AiFeetDamage.Location = new System.Drawing.Point(861, 482);
            this.AiFeetDamage.Multiline = true;
            this.AiFeetDamage.Name = "AiFeetDamage";
            this.AiFeetDamage.ReadOnly = true;
            this.AiFeetDamage.Size = new System.Drawing.Size(54, 23);
            this.AiFeetDamage.TabIndex = 9;
            this.AiFeetDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // AiCritDamage
            // 
            this.AiCritDamage.BackColor = System.Drawing.Color.Black;
            this.AiCritDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AiCritDamage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AiCritDamage.ForeColor = System.Drawing.Color.White;
            this.AiCritDamage.Location = new System.Drawing.Point(881, 510);
            this.AiCritDamage.Multiline = true;
            this.AiCritDamage.Name = "AiCritDamage";
            this.AiCritDamage.ReadOnly = true;
            this.AiCritDamage.Size = new System.Drawing.Size(59, 23);
            this.AiCritDamage.TabIndex = 9;
            this.AiCritDamage.Click += new System.EventHandler(this.ChangeFocus);
            // 
            // Champions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 541);
            this.Controls.Add(this.AiCritDamage);
            this.Controls.Add(this.playerCritDamage);
            this.Controls.Add(this.AiFeetDamage);
            this.Controls.Add(this.AiBodyDamage);
            this.Controls.Add(this.playerFeetDamage);
            this.Controls.Add(this.AiHeadDamage);
            this.Controls.Add(this.playerBodyDamage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.playerHeadDamage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AICharacterName);
            this.Controls.Add(this.PlayerCharacterName);
            this.Controls.Add(this.aboutAICharacter);
            this.Controls.Add(this.aboutPlayerCharacter);
            this.Controls.Add(this.AIRadio);
            this.Controls.Add(this.PlayerRadio);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.AIChampion);
            this.Controls.Add(this.playerChampion);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Champions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "God-killers III. The Hunt for Olympus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Champions_FormClosing);
            this.Load += new System.EventHandler(this.Champions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AIChampion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerChampion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageCharacters;
        private System.Windows.Forms.PictureBox AIChampion;
        private System.Windows.Forms.PictureBox playerChampion;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.RadioButton PlayerRadio;
        private System.Windows.Forms.RadioButton AIRadio;
        private System.Windows.Forms.TextBox aboutPlayerCharacter;
        private System.Windows.Forms.TextBox aboutAICharacter;
        private System.Windows.Forms.Label PlayerCharacterName;
        private System.Windows.Forms.Label AICharacterName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox playerHeadDamage;
        private System.Windows.Forms.TextBox playerBodyDamage;
        private System.Windows.Forms.TextBox playerFeetDamage;
        private System.Windows.Forms.TextBox playerCritDamage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AiHeadDamage;
        private System.Windows.Forms.TextBox AiBodyDamage;
        private System.Windows.Forms.TextBox AiFeetDamage;
        private System.Windows.Forms.TextBox AiCritDamage;
    }
}