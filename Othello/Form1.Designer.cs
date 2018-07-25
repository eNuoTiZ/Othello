namespace Othello
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBoard = new System.Windows.Forms.Panel();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbScorePlayer1 = new System.Windows.Forms.TextBox();
            this.tbScorePlayer2 = new System.Windows.Forms.TextBox();
            this.cbDisplayAvailableMoves = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelPic = new System.Windows.Forms.PictureBox();
            this.loadingBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPastHistory2 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Location = new System.Drawing.Point(27, 47);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(360, 360);
            this.panelBoard.TabIndex = 0;
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.BackColor = System.Drawing.Color.Black;
            this.tbPlayer1.ForeColor = System.Drawing.Color.White;
            this.tbPlayer1.Location = new System.Drawing.Point(393, 47);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.ReadOnly = true;
            this.tbPlayer1.Size = new System.Drawing.Size(100, 23);
            this.tbPlayer1.TabIndex = 1;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(393, 76);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.ReadOnly = true;
            this.tbPlayer2.Size = new System.Drawing.Size(100, 23);
            this.tbPlayer2.TabIndex = 1;
            // 
            // tbScorePlayer1
            // 
            this.tbScorePlayer1.Location = new System.Drawing.Point(499, 47);
            this.tbScorePlayer1.Name = "tbScorePlayer1";
            this.tbScorePlayer1.ReadOnly = true;
            this.tbScorePlayer1.Size = new System.Drawing.Size(38, 23);
            this.tbScorePlayer1.TabIndex = 2;
            // 
            // tbScorePlayer2
            // 
            this.tbScorePlayer2.Location = new System.Drawing.Point(499, 76);
            this.tbScorePlayer2.Name = "tbScorePlayer2";
            this.tbScorePlayer2.ReadOnly = true;
            this.tbScorePlayer2.Size = new System.Drawing.Size(38, 23);
            this.tbScorePlayer2.TabIndex = 2;
            // 
            // cbDisplayAvailableMoves
            // 
            this.cbDisplayAvailableMoves.AutoSize = true;
            this.cbDisplayAvailableMoves.Location = new System.Drawing.Point(393, 388);
            this.cbDisplayAvailableMoves.Name = "cbDisplayAvailableMoves";
            this.cbDisplayAvailableMoves.Size = new System.Drawing.Size(106, 19);
            this.cbDisplayAvailableMoves.TabIndex = 4;
            this.cbDisplayAvailableMoves.Text = "Display moves";
            this.cbDisplayAvailableMoves.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLabel2
            // 
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(584, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newGameToolStripMenuItem.Text = "New game...";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // levelPic
            // 
            this.levelPic.Location = new System.Drawing.Point(542, 76);
            this.levelPic.Name = "levelPic";
            this.levelPic.Size = new System.Drawing.Size(25, 25);
            this.levelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.levelPic.TabIndex = 8;
            this.levelPic.TabStop = false;
            // 
            // loadingBox
            // 
            this.loadingBox.Location = new System.Drawing.Point(542, 375);
            this.loadingBox.Name = "loadingBox";
            this.loadingBox.Size = new System.Drawing.Size(32, 32);
            this.loadingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingBox.TabIndex = 7;
            this.loadingBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "A        B         C         D         E         F         G         H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "1";
            // 
            // lbPastHistory2
            // 
            this.lbPastHistory2.FormattingEnabled = true;
            this.lbPastHistory2.ItemHeight = 15;
            this.lbPastHistory2.Location = new System.Drawing.Point(393, 135);
            this.lbPastHistory2.Name = "lbPastHistory2";
            this.lbPastHistory2.Size = new System.Drawing.Size(100, 244);
            this.lbPastHistory2.TabIndex = 18;
            this.lbPastHistory2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Past history";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPastHistory2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelPic);
            this.Controls.Add(this.loadingBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.cbDisplayAvailableMoves);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.tbScorePlayer2);
            this.Controls.Add(this.tbScorePlayer1);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 480);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Othello";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbScorePlayer1;
        private System.Windows.Forms.TextBox tbScorePlayer2;
        private System.Windows.Forms.CheckBox cbDisplayAvailableMoves;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.PictureBox loadingBox;
        private System.Windows.Forms.PictureBox levelPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ListBox lbPastHistory;
        private System.Windows.Forms.ListBox lbPastHistory2;
    }
}

