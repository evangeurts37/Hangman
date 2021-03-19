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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHangingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(95, 43);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(252, 13);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Geuss Letters to fill in the blanks befor the man dies.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(86, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hangman";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(131, 318);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(103, 13);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "_ _ _ _ _ _ _ _ _ _ _";
            // 
            // btnGeuss
            // 
            this.btnGeuss.Location = new System.Drawing.Point(521, 357);
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
            this.imgHangingMan.Location = new System.Drawing.Point(113, 82);
            this.imgHangingMan.Name = "imgHangingMan";
            this.imgHangingMan.Size = new System.Drawing.Size(161, 216);
            this.imgHangingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHangingMan.TabIndex = 4;
            this.imgHangingMan.TabStop = false;
            // 
            // txtGeuss
            // 
            this.txtGeuss.Location = new System.Drawing.Point(403, 359);
            this.txtGeuss.Name = "txtGeuss";
            this.txtGeuss.Size = new System.Drawing.Size(100, 20);
            this.txtGeuss.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(438, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 6;
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Location = new System.Drawing.Point(456, 178);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(84, 13);
            this.lblInstruction2.TabIndex = 7;
            this.lblInstruction2.Text = "Geussed Letters";
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblInstruction2;
    }
}

