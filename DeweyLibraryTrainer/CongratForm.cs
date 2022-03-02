using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyLibraryTrainer
{
    public partial class CongratForm : Form
    {
        public CongratForm()
        {
            InitializeComponent();
        }

        private void CongratForm_Load(object sender, EventArgs e)
        {
            // Ouput
            String numTrophies = (ReplaceBooksForm.trophies).ToString();
            String score = (ReplaceBooksForm.totalScore).ToString();


            String numTrophiesTwo = (IdentifyAreasForm.trophies).ToString();
            String scoreTwo = (IdentifyAreasForm.totalScore).ToString();

            String numTrophiesThree = (FindingCallNumbersForm.trophies).ToString();
            String scoreThree = (FindingCallNumbersForm.totalScore).ToString();

            // if the score is equal to 10 then display the thumbs up badge
            //if (msgScore.Length == 10)
            //{
            //    pictureBoxBadge.Visible = true;
            //}
            //else 
            //{
            //    pictureBoxBadge.Visible = false;
            //}

            pictureBoxBadge.SizeMode = PictureBoxSizeMode.StretchImage;

            lblTrophies.Text = "Game: Replace books" + "\n" + "You did an excellent job. You received "
                + numTrophies + " trophies after scoring " + score + " correct.";

            lblTrophiesTwo.Text = "Game: Identify Areas" + "\n" + "You did an excellent job. You received "
                + numTrophiesTwo + " trophies after scoring " + scoreTwo + " correct.";

            lblTrophiesThree.Text = "Game: Finding Call Numbers" + "\n" + "You did an excellent job. You received "
             + numTrophiesThree + " trophies after scoring " + scoreThree + " correct.";
        }

        private void icBtnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
            lblTrophies.Text = "";
            lblTrophiesTwo.Text = "";


        }
    }
}
