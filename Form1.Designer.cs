namespace Файтинг
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BGImage = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.board = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BGImage
            // 
            this.BGImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BGImage.ImageStream")));
            this.BGImage.TransparentColor = System.Drawing.Color.Transparent;
            this.BGImage.Images.SetKeyName(0, "maxresdefault.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "God-killers III\r\nThe Hunt for Olympus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DarkSlateGray;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(92, 224);
            this.name.MaxLength = 9;
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(231, 50);
            this.name.TabIndex = 2;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 43);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Black;
            this.board.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board.FlatAppearance.BorderSize = 0;
            this.board.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.board.Location = new System.Drawing.Point(105, 384);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(208, 40);
            this.board.TabIndex = 3;
            this.board.Text = "Таблица лидеров";
            this.board.UseVisualStyleBackColor = false;
            this.board.Click += new System.EventHandler(this.board_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(92, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 81);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "God-killers III. The Hunt for Olympus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList BGImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button board;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

