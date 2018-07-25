namespace Othello
{
    partial class TestBoardForm
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
            this.panelBoard = new System.Windows.Forms.Panel();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.Location = new System.Drawing.Point(12, 12);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(360, 360);
            this.panelBoard.TabIndex = 1;
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(388, 43);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(35, 13);
            this.lblCol.TabIndex = 2;
            this.lblCol.Text = "label1";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(388, 67);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(35, 13);
            this.lblRow.TabIndex = 3;
            this.lblRow.Text = "label2";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(388, 96);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(35, 13);
            this.lblVal.TabIndex = 4;
            this.lblVal.Text = "label3";
            // 
            // TestBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 404);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.panelBoard);
            this.Name = "TestBoardForm";
            this.Text = "TestBoardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblVal;
    }
}