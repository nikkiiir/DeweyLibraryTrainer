
namespace DeweyLibraryTrainer
{
    partial class ReplaceBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBooksForm));
            this.lblArrange = new System.Windows.Forms.Label();
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.listBoxChoose = new System.Windows.Forms.ListBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.listBoxAnswers = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnViewScore = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.lblMyAnswers = new System.Windows.Forms.Label();
            this.icBtnBack = new FontAwesome.Sharp.IconButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArrange
            // 
            this.lblArrange.AutoSize = true;
            this.lblArrange.BackColor = System.Drawing.Color.Transparent;
            this.lblArrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArrange.Location = new System.Drawing.Point(22, 18);
            this.lblArrange.Name = "lblArrange";
            this.lblArrange.Size = new System.Drawing.Size(726, 33);
            this.lblArrange.TabIndex = 1;
            this.lblArrange.Text = "Arrange the books according to their call numbers: ";
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.listBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBooks.FormattingEnabled = true;
            this.listBoxBooks.IntegralHeight = false;
            this.listBoxBooks.ItemHeight = 25;
            this.listBoxBooks.Location = new System.Drawing.Point(129, 127);
            this.listBoxBooks.Name = "listBoxBooks";
            this.listBoxBooks.Size = new System.Drawing.Size(198, 279);
            this.listBoxBooks.TabIndex = 0;
            this.listBoxBooks.Visible = false;
            // 
            // listBoxChoose
            // 
            this.listBoxChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.listBoxChoose.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChoose.FormattingEnabled = true;
            this.listBoxChoose.ItemHeight = 25;
            this.listBoxChoose.Location = new System.Drawing.Point(304, 91);
            this.listBoxChoose.Name = "listBoxChoose";
            this.listBoxChoose.Size = new System.Drawing.Size(209, 329);
            this.listBoxChoose.TabIndex = 7;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorrect.Location = new System.Drawing.Point(115, 95);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(212, 29);
            this.lblCorrect.TabIndex = 11;
            this.lblCorrect.Text = "Correct Answers:";
            this.lblCorrect.Visible = false;
            // 
            // listBoxAnswers
            // 
            this.listBoxAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.listBoxAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnswers.FormattingEnabled = true;
            this.listBoxAnswers.ItemHeight = 25;
            this.listBoxAnswers.Location = new System.Drawing.Point(496, 127);
            this.listBoxAnswers.Name = "listBoxAnswers";
            this.listBoxAnswers.Size = new System.Drawing.Size(209, 279);
            this.listBoxAnswers.TabIndex = 9;
            this.listBoxAnswers.Visible = false;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(144)))));
            this.btnChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnChoose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(371, 376);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 30);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnViewScore
            // 
            this.btnViewScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(144)))));
            this.btnViewScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnViewScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnViewScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScore.Location = new System.Drawing.Point(360, 274);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.Size = new System.Drawing.Size(86, 49);
            this.btnViewScore.TabIndex = 4;
            this.btnViewScore.Text = "View Score";
            this.btnViewScore.UseVisualStyleBackColor = false;
            this.btnViewScore.Visible = false;
            this.btnViewScore.Click += new System.EventHandler(this.btnViewScore_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(144)))));
            this.btnRestart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(60, 411);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 30);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(144)))));
            this.btnRegenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnRegenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnRegenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegenerate.Location = new System.Drawing.Point(153, 411);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(102, 29);
            this.btnRegenerate.TabIndex = 3;
            this.btnRegenerate.Text = "Regenerate";
            this.btnRegenerate.UseVisualStyleBackColor = false;
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // 
            // lblMyAnswers
            // 
            this.lblMyAnswers.AutoSize = true;
            this.lblMyAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lblMyAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyAnswers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMyAnswers.Location = new System.Drawing.Point(519, 95);
            this.lblMyAnswers.Name = "lblMyAnswers";
            this.lblMyAnswers.Size = new System.Drawing.Size(159, 29);
            this.lblMyAnswers.TabIndex = 12;
            this.lblMyAnswers.Text = "My Answers:";
            this.lblMyAnswers.Visible = false;
            // 
            // icBtnBack
            // 
            this.icBtnBack.BackColor = System.Drawing.Color.Transparent;
            this.icBtnBack.FlatAppearance.BorderSize = 0;
            this.icBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.icBtnBack.IconColor = System.Drawing.Color.White;
            this.icBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnBack.IconSize = 52;
            this.icBtnBack.Location = new System.Drawing.Point(0, 422);
            this.icBtnBack.Name = "icBtnBack";
            this.icBtnBack.Size = new System.Drawing.Size(26, 42);
            this.icBtnBack.TabIndex = 8;
            this.icBtnBack.UseVisualStyleBackColor = false;
            this.icBtnBack.Click += new System.EventHandler(this.icBtnBack_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(113, 37);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 39);
            this.lblTime.TabIndex = 13;
            // 
            // ReplaceBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeweyLibraryTrainer.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(751, 458);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.icBtnBack);
            this.Controls.Add(this.lblMyAnswers);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnViewScore);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.listBoxAnswers);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.listBoxChoose);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.lblArrange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplaceBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplaceBooks";
            this.Load += new System.EventHandler(this.ReplaceBooksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrange;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.ListBox listBoxChoose;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ListBox listBoxAnswers;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnViewScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnRegenerate;
        private System.Windows.Forms.Label lblMyAnswers;
        private FontAwesome.Sharp.IconButton icBtnBack;
        private System.Windows.Forms.Label lblTime;
    }
}