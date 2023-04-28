namespace Файтинг
{
    partial class Board
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.table = new System.Windows.Forms.DataGridView();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.reserTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Position,
            this.NameOfPlayer,
            this.Points});
            this.table.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.table.Location = new System.Drawing.Point(100, 124);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(343, 260);
            this.table.TabIndex = 0;
            // 
            // Position
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Position.DefaultCellStyle = dataGridViewCellStyle2;
            this.Position.FillWeight = 150F;
            this.Position.HeaderText = "Место";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 64;
            // 
            // NameOfPlayer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOfPlayer.DefaultCellStyle = dataGridViewCellStyle3;
            this.NameOfPlayer.HeaderText = "Имя";
            this.NameOfPlayer.Name = "NameOfPlayer";
            this.NameOfPlayer.ReadOnly = true;
            this.NameOfPlayer.Width = 140;
            // 
            // Points
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Points.DefaultCellStyle = dataGridViewCellStyle4;
            this.Points.HeaderText = "Очки";
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица лидеров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(60, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(184, 67);
            this.search.MaxLength = 9;
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(178, 42);
            this.search.TabIndex = 2;
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(386, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 39);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reserTable
            // 
            this.reserTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reserTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reserTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reserTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reserTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserTable.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reserTable.ForeColor = System.Drawing.SystemColors.Control;
            this.reserTable.Location = new System.Drawing.Point(461, 351);
            this.reserTable.Name = "reserTable";
            this.reserTable.Size = new System.Drawing.Size(73, 39);
            this.reserTable.TabIndex = 3;
            this.reserTable.Text = "Сброс";
            this.reserTable.UseVisualStyleBackColor = false;
            this.reserTable.Click += new System.EventHandler(this.reserTable_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 402);
            this.Controls.Add(this.reserTable);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "God-killers III. The Hunt for Olympus";
            this.Load += new System.EventHandler(this.Board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button reserTable;
    }
}