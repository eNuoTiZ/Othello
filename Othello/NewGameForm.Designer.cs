namespace Othello
{
    partial class NewGameForm
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
            this.cbPlayerBlack = new System.Windows.Forms.ComboBox();
            this.cbPlayerWhite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLevelWhite = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlayerBlack
            // 
            this.cbPlayerBlack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerBlack.FormattingEnabled = true;
            this.cbPlayerBlack.Items.AddRange(new object[] {
            "Human",
            "Computer"});
            this.cbPlayerBlack.Location = new System.Drawing.Point(91, 25);
            this.cbPlayerBlack.Name = "cbPlayerBlack";
            this.cbPlayerBlack.Size = new System.Drawing.Size(140, 23);
            this.cbPlayerBlack.TabIndex = 1;
            this.cbPlayerBlack.SelectedIndexChanged += new System.EventHandler(this.cbPlayerBlack_SelectedIndexChanged);
            // 
            // cbPlayerWhite
            // 
            this.cbPlayerWhite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayerWhite.FormattingEnabled = true;
            this.cbPlayerWhite.Items.AddRange(new object[] {
            "Human",
            "Computer"});
            this.cbPlayerWhite.Location = new System.Drawing.Point(91, 56);
            this.cbPlayerWhite.Name = "cbPlayerWhite";
            this.cbPlayerWhite.Size = new System.Drawing.Size(140, 23);
            this.cbPlayerWhite.TabIndex = 2;
            this.cbPlayerWhite.SelectedIndexChanged += new System.EventHandler(this.cbPlayerBlack_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Black";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "White";
            // 
            // lblLevelWhite
            // 
            this.lblLevelWhite.AutoSize = true;
            this.lblLevelWhite.Location = new System.Drawing.Point(246, 44);
            this.lblLevelWhite.Name = "lblLevelWhite";
            this.lblLevelWhite.Size = new System.Drawing.Size(34, 15);
            this.lblLevelWhite.TabIndex = 2;
            this.lblLevelWhite.Text = "Level";
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbLevel.Location = new System.Drawing.Point(286, 41);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(98, 23);
            this.cbLevel.TabIndex = 3;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(314, 111);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 142);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.lblLevelWhite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlayerWhite);
            this.Controls.Add(this.cbPlayerBlack);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 180);
            this.MinimumSize = new System.Drawing.Size(412, 180);
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlayerBlack;
        private System.Windows.Forms.ComboBox cbPlayerWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLevelWhite;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}