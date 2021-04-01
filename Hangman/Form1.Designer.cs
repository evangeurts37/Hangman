namespace Hangman
{
    partial class frmHangman
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnGeuss = new System.Windows.Forms.Button();
            this.imgHangingMan = new System.Windows.Forms.PictureBox();
            this.txtGeuss = new System.Windows.Forms.TextBox();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblLivesWord = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstGuessed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(8, 36);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(406, 18);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Geuss Letters to fill in the blanks befor the man dies.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hangman";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(91, 311);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(132, 25);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "_ _ _ _ _ _ _";
            // 
            // btnGeuss
            // 
            this.btnGeuss.Location = new System.Drawing.Point(390, 244);
            this.btnGeuss.Name = "btnGeuss";
            this.btnGeuss.Size = new System.Drawing.Size(75, 23);
            this.btnGeuss.TabIndex = 3;
            this.btnGeuss.Text = "Geuss";
            this.btnGeuss.UseVisualStyleBackColor = true;
            this.btnGeuss.Click += new System.EventHandler(this.btnGeuss_Click);
            // 
            // imgHangingMan
            // 
            this.imgHangingMan.Image = global::Hangman.Properties.Resources.Start;
            this.imgHangingMan.Location = new System.Drawing.Point(79, 82);
            this.imgHangingMan.Name = "imgHangingMan";
            this.imgHangingMan.Size = new System.Drawing.Size(161, 216);
            this.imgHangingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangingMan.TabIndex = 4;
            this.imgHangingMan.TabStop = false;
            // 
            // txtGeuss
            // 
            this.txtGeuss.Location = new System.Drawing.Point(264, 246);
            this.txtGeuss.MaxLength = 1;
            this.txtGeuss.Name = "txtGeuss";
            this.txtGeuss.Size = new System.Drawing.Size(100, 20);
            this.txtGeuss.TabIndex = 5;
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(260, 108);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(127, 19);
            this.lblInstruction2.TabIndex = 7;
            this.lblInstruction2.Text = "Geussed Letters";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(409, 4);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(75, 23);
            this.btnInstructions.TabIndex = 8;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.Location = new System.Drawing.Point(52, 91);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(19, 21);
            this.lblLives.TabIndex = 9;
            this.lblLives.Text = "6";
            // 
            // lblLivesWord
            // 
            this.lblLivesWord.AutoSize = true;
            this.lblLivesWord.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivesWord.Location = new System.Drawing.Point(6, 91);
            this.lblLivesWord.Name = "lblLivesWord";
            this.lblLivesWord.Size = new System.Drawing.Size(52, 21);
            this.lblLivesWord.TabIndex = 11;
            this.lblLivesWord.Text = "Lives:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(386, 244);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 24);
            this.lblResult.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // lstGuessed
            // 
            this.lstGuessed.FormattingEnabled = true;
            this.lstGuessed.Location = new System.Drawing.Point(264, 130);
            this.lstGuessed.Name = "lstGuessed";
            this.lstGuessed.Size = new System.Drawing.Size(120, 95);
            this.lstGuessed.TabIndex = 15;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.lstGuessed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLivesWord);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.txtGeuss);
            this.Controls.Add(this.imgHangingMan);
            this.Controls.Add(this.btnGeuss);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstruction);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHangingMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnGeuss;
        private System.Windows.Forms.PictureBox imgHangingMan;
        private System.Windows.Forms.TextBox txtGeuss;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblLivesWord;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstGuessed;
    }
}

