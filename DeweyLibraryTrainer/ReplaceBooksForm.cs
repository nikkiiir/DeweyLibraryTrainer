using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeweyLibraryTrainer
{
    public partial class ReplaceBooksForm : Form
    {
        // Variables
        public static int trophies;
        public static int totalScore = 0;

        // Random call number list for users to choose the call number
        public static List<string> callNumberList = new List<string>();

        // Users chosen answers list of the call numbers
        public static List<string> answerList = new List<string>();

        // Sorted list of the random call numbers
        public static List<string> sortedBookList = new List<string>(); 


        public ReplaceBooksForm()
        {
            InitializeComponent();
        }

      

        private void ReplaceBooksForm_Load(object sender, EventArgs e)
        {
            // Variable
            double randomNum;
            String authorsSurname;
            String callNumber;
            String bookTopicNumber;

            callNumberList.Clear();
            answerList.Clear();
            sortedBookList.Clear();

            // Randomly generate call numbers using the dewey decimal system
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {

                // Randomly displays 3 letters of the alphabetswhich stands for the authors name
                // Concatenate letters
                authorsSurname = (Convert.ToChar(random.Next('A', 'Z'))).ToString() + (Convert.ToChar(random.Next('A', 'Z'))).ToString() + (Convert.ToChar(random.Next('A', 'Z'))).ToString();


                // Randomly displays values between 000 and 999
                randomNum = random.NextDouble() + random.Next(000, 999);
                bookTopicNumber = (Math.Round(randomNum, 3)).ToString();

                // Concatenate call number 
                callNumber = bookTopicNumber + " " + authorsSurname;

                // Finally add randomly concatenated call number to the listboxes
                listBoxChoose.Items.Add(callNumber);
                callNumberList.Add(callNumber);
                sortedBookList.Add(callNumber);
            }

            listBoxBooks.DataSource = callNumberList;

            // Using Insertion sorting 
            for (int i = 0; i < sortedBookList.Count; i++)
            {
                IComparable value = sortedBookList[i];
                int j = i - 1;
                while ((j >= 0) && (sortedBookList[j].CompareTo(value) > 0))
                {
                    sortedBookList[j + 1] = sortedBookList[j];
                    j--;
                }
                sortedBookList[j + 1] = (string)value;

            }
        }


        private void btnChoose_Click(object sender, EventArgs e)
        {
            String value = listBoxChoose.Text;
            answerList.Add(value);


            // Once a call number is chosen from the listbox it should be removed
            listBoxChoose.Items.Remove(value);

            // Once the user has selected all ten call number display the hidden labels, listboxes and buttons
            if (answerList.Count == 10)
            {
                // Using stopwatch to get the time taken to complete the activity
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                Thread.Sleep(6000);

                listBoxBooks.DataSource = ReplaceBooksForm.sortedBookList;
                listBoxAnswers.DataSource = ReplaceBooksForm.answerList;
                listBoxAnswers.Visible = true;
                lblMyAnswers.Visible = true;
                lblCorrect.Visible = true;
                lblArrange.Visible = false;
                listBoxBooks.Visible = true;
                listBoxChoose.Visible = false;
                btnChoose.Visible = false;
                btnViewScore.Visible = true;

                for (int i = 0; i < 10; i++)
                {
                    // Compare the sorted list to the answers the user had chosen 
                    // Display the points and trophies accordingly
                    if (ReplaceBooksForm.sortedBookList[i] == ReplaceBooksForm.answerList[i])
                    {
                        trophies = trophies + 10;
                        totalScore++;
                    }
                }

                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;
                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
                lblTime.Text = "Time Taken " + elapsedTime;
            }
        }
            private void btnRegenerate_Click(object sender, EventArgs e)
            {
                ReplaceBooksForm replaceBooks = new ReplaceBooksForm();
                replaceBooks.Show();
                this.Hide();
            }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            answerList.Clear();
            listBoxChoose.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBoxChoose.Items.Add(callNumberList[i]);
            }
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            CongratForm congratForm = new CongratForm();
            congratForm.Show();
            this.Hide();

        }

        private void icBtnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }


    }
    }
