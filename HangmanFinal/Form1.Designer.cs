namespace HangmanFinal
{
    partial class frmMainWindow
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.pnlHangman = new System.Windows.Forms.Panel();
            this.gbWordBox = new System.Windows.Forms.GroupBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblLetterCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.entWordGuess = new System.Windows.Forms.TextBox();
            this.entLetterGuess = new System.Windows.Forms.TextBox();
            this.btnWordGuess = new System.Windows.Forms.Button();
            this.btnLetterGuess = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHangman
            // 
            this.pnlHangman.Location = new System.Drawing.Point(0, 0);
            this.pnlHangman.Name = "pnlHangman";
            this.pnlHangman.Size = new System.Drawing.Size(880, 630);
            this.pnlHangman.TabIndex = 0;
            // 
            // gbWordBox
            // 
            this.gbWordBox.Location = new System.Drawing.Point(1, 629);
            this.gbWordBox.Name = "gbWordBox";
            this.gbWordBox.Size = new System.Drawing.Size(879, 163);
            this.gbWordBox.TabIndex = 1;
            this.gbWordBox.TabStop = false;
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblGuessed.ForeColor = System.Drawing.Color.White;
            this.lblGuessed.Location = new System.Drawing.Point(4, 798);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(150, 36);
            this.lblGuessed.TabIndex = 1;
            this.lblGuessed.Text = "Guessed :";
            // 
            // lblLetterCount
            // 
            this.lblLetterCount.AutoSize = true;
            this.lblLetterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblLetterCount.ForeColor = System.Drawing.Color.White;
            this.lblLetterCount.Location = new System.Drawing.Point(631, 798);
            this.lblLetterCount.Name = "lblLetterCount";
            this.lblLetterCount.Size = new System.Drawing.Size(204, 36);
            this.lblLetterCount.TabIndex = 0;
            this.lblLetterCount.Text = "Word Length :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.entWordGuess);
            this.groupBox3.Controls.Add(this.entLetterGuess);
            this.groupBox3.Controls.Add(this.btnWordGuess);
            this.groupBox3.Controls.Add(this.btnLetterGuess);
            this.groupBox3.Location = new System.Drawing.Point(119, 832);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // entWordGuess
            // 
            this.entWordGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entWordGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.entWordGuess.Location = new System.Drawing.Point(227, 52);
            this.entWordGuess.MaxLength = 10;
            this.entWordGuess.Name = "entWordGuess";
            this.entWordGuess.Size = new System.Drawing.Size(267, 53);
            this.entWordGuess.TabIndex = 3;
            this.entWordGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // entLetterGuess
            // 
            this.entLetterGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.entLetterGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.entLetterGuess.Location = new System.Drawing.Point(138, 52);
            this.entLetterGuess.MaxLength = 1;
            this.entLetterGuess.Multiline = true;
            this.entLetterGuess.Name = "entLetterGuess";
            this.entLetterGuess.Size = new System.Drawing.Size(63, 53);
            this.entLetterGuess.TabIndex = 2;
            this.entLetterGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWordGuess
            // 
            this.btnWordGuess.Location = new System.Drawing.Point(500, 52);
            this.btnWordGuess.Name = "btnWordGuess";
            this.btnWordGuess.Size = new System.Drawing.Size(107, 53);
            this.btnWordGuess.TabIndex = 1;
            this.btnWordGuess.Text = "Word";
            this.btnWordGuess.UseVisualStyleBackColor = true;
            this.btnWordGuess.Click += new System.EventHandler(this.BtnWordGuess_Click);
            // 
            // btnLetterGuess
            // 
            this.btnLetterGuess.Location = new System.Drawing.Point(14, 52);
            this.btnLetterGuess.Name = "btnLetterGuess";
            this.btnLetterGuess.Size = new System.Drawing.Size(107, 53);
            this.btnLetterGuess.TabIndex = 0;
            this.btnLetterGuess.Text = "Letter";
            this.btnLetterGuess.UseVisualStyleBackColor = true;
            this.btnLetterGuess.Click += new System.EventHandler(this.BtnGuessLetter_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(882, 947);
            this.Controls.Add(this.pnlHangman);
            this.Controls.Add(this.lblLetterCount);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbWordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hang That Man!";
            this.Shown += new System.EventHandler(this.FrmMainWindow_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Panel pnlHangman;
        private System.Windows.Forms.GroupBox gbWordBox;
        private System.Windows.Forms.Label lblLetterCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox entWordGuess;
        private System.Windows.Forms.TextBox entLetterGuess;
        private System.Windows.Forms.Button btnWordGuess;
        private System.Windows.Forms.Button btnLetterGuess;
        private System.Windows.Forms.Label lblGuessed;
    }
}

