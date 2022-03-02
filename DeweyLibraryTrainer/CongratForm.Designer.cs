
namespace DeweyLibraryTrainer
{
    partial class CongratForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongratForm));
            this.lblCongrat = new System.Windows.Forms.Label();
            this.lblTrophies = new System.Windows.Forms.Label();
            this.icBtnBack = new FontAwesome.Sharp.IconButton();
            this.pictureBoxBadge = new System.Windows.Forms.PictureBox();
            this.lblTrophiesTwo = new System.Windows.Forms.Label();
            this.lblTrophiesThree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBadge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCongrat
            // 
            this.lblCongrat.AutoSize = true;
            this.lblCongrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.lblCongrat.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrat.Location = new System.Drawing.Point(24, 12);
            this.lblCongrat.Name = "lblCongrat";
            this.lblCongrat.Size = new System.Drawing.Size(340, 51);
            this.lblCongrat.TabIndex = 0;
            this.lblCongrat.Text = "Congratulations!";
            // 
            // lblTrophies
            // 
            this.lblTrophies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.lblTrophies.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrophies.Location = new System.Drawing.Point(29, 74);
            this.lblTrophies.Name = "lblTrophies";
            this.lblTrophies.Size = new System.Drawing.Size(329, 100);
            this.lblTrophies.TabIndex = 2;
            this.lblTrophies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icBtnBack
            // 
            this.icBtnBack.BackColor = System.Drawing.Color.Transparent;
            this.icBtnBack.FlatAppearance.BorderSize = 0;
            this.icBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.icBtnBack.IconColor = System.Drawing.Color.Black;
            this.icBtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnBack.IconSize = 52;
            this.icBtnBack.Location = new System.Drawing.Point(-2, 422);
            this.icBtnBack.Name = "icBtnBack";
            this.icBtnBack.Size = new System.Drawing.Size(26, 42);
            this.icBtnBack.TabIndex = 9;
            this.icBtnBack.UseVisualStyleBackColor = false;
            this.icBtnBack.Click += new System.EventHandler(this.icBtnBack_Click);
            // 
            // pictureBoxBadge
            // 
            this.pictureBoxBadge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBadge.Image = global::DeweyLibraryTrainer.Properties.Resources.thumbs_up_badge;
            this.pictureBoxBadge.Location = new System.Drawing.Point(645, 12);
            this.pictureBoxBadge.Name = "pictureBoxBadge";
            this.pictureBoxBadge.Size = new System.Drawing.Size(94, 87);
            this.pictureBoxBadge.TabIndex = 10;
            this.pictureBoxBadge.TabStop = false;
            // 
            // lblTrophiesTwo
            // 
            this.lblTrophiesTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.lblTrophiesTwo.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrophiesTwo.Location = new System.Drawing.Point(28, 183);
            this.lblTrophiesTwo.Name = "lblTrophiesTwo";
            this.lblTrophiesTwo.Size = new System.Drawing.Size(329, 104);
            this.lblTrophiesTwo.TabIndex = 11;
            this.lblTrophiesTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrophiesThree
            // 
            this.lblTrophiesThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(138)))), ((int)(((byte)(120)))));
            this.lblTrophiesThree.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrophiesThree.Location = new System.Drawing.Point(28, 296);
            this.lblTrophiesThree.Name = "lblTrophiesThree";
            this.lblTrophiesThree.Size = new System.Drawing.Size(329, 104);
            this.lblTrophiesThree.TabIndex = 12;
            this.lblTrophiesThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CongratForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DeweyLibraryTrainer.Properties.Resources.WinnerBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(751, 458);
            this.Controls.Add(this.lblTrophiesThree);
            this.Controls.Add(this.lblTrophiesTwo);
            this.Controls.Add(this.pictureBoxBadge);
            this.Controls.Add(this.icBtnBack);
            this.Controls.Add(this.lblTrophies);
            this.Controls.Add(this.lblCongrat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CongratForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CongratForm";
            this.Load += new System.EventHandler(this.CongratForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBadge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongrat;
        private System.Windows.Forms.Label lblTrophies;
        private FontAwesome.Sharp.IconButton icBtnBack;
        private System.Windows.Forms.PictureBox pictureBoxBadge;
        private System.Windows.Forms.Label lblTrophiesTwo;
        private System.Windows.Forms.Label lblTrophiesThree;
    }
}