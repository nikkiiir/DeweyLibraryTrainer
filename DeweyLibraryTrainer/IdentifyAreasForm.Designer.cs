
namespace DeweyLibraryTrainer
{
    partial class IdentifyAreasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyAreasForm));
            this.listBoxCallNum = new System.Windows.Forms.ListBox();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.listBoxAnswers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseOption = new System.Windows.Forms.Button();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.icBtnBack = new FontAwesome.Sharp.IconButton();
            this.btnViewScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCallNum
            // 
            this.listBoxCallNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.listBoxCallNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCallNum.FormattingEnabled = true;
            this.listBoxCallNum.ItemHeight = 24;
            this.listBoxCallNum.Location = new System.Drawing.Point(67, 113);
            this.listBoxCallNum.Name = "listBoxCallNum";
            this.listBoxCallNum.Size = new System.Drawing.Size(70, 292);
            this.listBoxCallNum.TabIndex = 0;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.listBoxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 24;
            this.listBoxQuestions.Location = new System.Drawing.Point(158, 113);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(465, 292);
            this.listBoxQuestions.TabIndex = 1;
            // 
            // listBoxAnswers
            // 
            this.listBoxAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.listBoxAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAnswers.ForeColor = System.Drawing.Color.Black;
            this.listBoxAnswers.FormattingEnabled = true;
            this.listBoxAnswers.ItemHeight = 24;
            this.listBoxAnswers.Location = new System.Drawing.Point(158, 113);
            this.listBoxAnswers.Name = "listBoxAnswers";
            this.listBoxAnswers.Size = new System.Drawing.Size(452, 292);
            this.listBoxAnswers.TabIndex = 2;
            this.listBoxAnswers.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Match the columns below by their call numbers";
            // 
            // btnChooseOption
            // 
            this.btnChooseOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(144)))));
            this.btnChooseOption.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnChooseOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnChooseOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseOption.Location = new System.Drawing.Point(370, 416);
            this.btnChooseOption.Name = "btnChooseOption";
            this.btnChooseOption.Size = new System.Drawing.Size(75, 30);
            this.btnChooseOption.TabIndex = 4;
            this.btnChooseOption.Text = "Choose";
            this.btnChooseOption.UseVisualStyleBackColor = false;
            this.btnChooseOption.Click += new System.EventHandler(this.btnChooseOption_Click);
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswers.Location = new System.Drawing.Point(262, 77);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(255, 33);
            this.lblAnswers.TabIndex = 5;
            this.lblAnswers.Text = "Correct Answers:";
            this.lblAnswers.Visible = false;
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
            this.icBtnBack.Location = new System.Drawing.Point(0, 416);
            this.icBtnBack.Name = "icBtnBack";
            this.icBtnBack.Size = new System.Drawing.Size(26, 42);
            this.icBtnBack.TabIndex = 9;
            this.icBtnBack.UseVisualStyleBackColor = false;
            this.icBtnBack.Click += new System.EventHandler(this.icBtnBack_Click);
            // 
            // btnViewScore
            // 
            this.btnViewScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(173)))), ((int)(((byte)(144)))));
            this.btnViewScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnViewScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.btnViewScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScore.Location = new System.Drawing.Point(653, 397);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.Size = new System.Drawing.Size(86, 49);
            this.btnViewScore.TabIndex = 10;
            this.btnViewScore.Text = "View Score";
            this.btnViewScore.UseVisualStyleBackColor = false;
            this.btnViewScore.Visible = false;
            this.btnViewScore.Click += new System.EventHandler(this.btnViewScore_Click);
            // 
            // IdentifyAreasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeweyLibraryTrainer.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(751, 458);
            this.Controls.Add(this.btnViewScore);
            this.Controls.Add(this.icBtnBack);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.btnChooseOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAnswers);
            this.Controls.Add(this.listBoxQuestions);
            this.Controls.Add(this.listBoxCallNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IdentifyAreasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdentifyAreasForm";
            this.Load += new System.EventHandler(this.IdentifyAreasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCallNum;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.ListBox listBoxAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseOption;
        private System.Windows.Forms.Label lblAnswers;
        private FontAwesome.Sharp.IconButton icBtnBack;
        private System.Windows.Forms.Button btnViewScore;
    }
}