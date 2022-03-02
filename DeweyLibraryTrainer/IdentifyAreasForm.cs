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
    public partial class IdentifyAreasForm : Form
    {
        // Variables
        public static int trophies = ReplaceBooksForm.trophies;
        public static int totalScore = 0;
        public static int option;
        int index;

        // Call numbers according to the dewey decimal system.
        Dictionary<int, string> callNumbers = new Dictionary<int, string>();

        // List for users to choose the questions according to the dewey decimal system
        Dictionary<int, string> catQuestions = new Dictionary<int, string>();

        // Displays a random call number list 
        public static List<string> randomCallNumList = new List<string>();

        // Displays a random number list 
        public static List<string> randomQuestionsList = new List<string>();

        // Users chosen answers list of the call numbers
        public static List<string> answerList = new List<string>();

        // Sorted list of the call numbers
        public static List<string> sortedCateCallNumList = new List<string>();



        public IdentifyAreasForm()
        {
            InitializeComponent();
        }

        private void IdentifyAreasForm_Load(object sender, EventArgs e)
        {
            // Add call numbers  
            // Adding key value to the dictionary
            callNumbers.Add(0, "000");
            callNumbers.Add(1, "100");
            callNumbers.Add(2, "200");
            callNumbers.Add(3, "300");
            callNumbers.Add(4, "400");
            callNumbers.Add(5, "500");
            callNumbers.Add(6, "600");
            callNumbers.Add(7, "700");
            callNumbers.Add(8, "800");
            callNumbers.Add(9, "900");

            // Add category questions  
            // Adding key value to the dictionary
            catQuestions.Add(0, "Who was Albert Einstein?");
            catQuestions.Add(1, "Where did Socrates live?");
            catQuestions.Add(2, "What was the first religion practised?");
            catQuestions.Add(3, "What regions are very hot & dry?");
            catQuestions.Add(4, "How many languages are spoken worldwide?");
            catQuestions.Add(5, "Which planet has the most moons?");
            catQuestions.Add(6, "Who founded Apple Computer?");
            catQuestions.Add(7, "Who painted The Scream in 1893? ");
            catQuestions.Add(8, "What is the 4th Harry Potter book?");
            catQuestions.Add(9, "What is the world's largest continent?");
          

            Random random = new Random();

            // Generates a random call numbers within the range
            option = random.Next(1, 3);
            // four randomly selected items in the first column, 
            // and seven possible answers(three of which are incorrect) in the second column
            if (option == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                  index = random.Next();

                    // check the randomized category questions list
                    // with the original category questions dictionary values
                    if (randomQuestionsList.Contains(catQuestions[index]) == false)
                    {
                        randomCallNumList.Add(callNumbers[index]);
                        randomQuestionsList.Add(catQuestions[index]);
                        sortedCateCallNumList.Add(callNumbers[index]);
                    }
                    else
                    {
                        i--;
                    }
                }

                listBoxCallNum.DataSource = randomQuestionsList;

                for (int i = 0; i < 3; i++)
                {
                    index = random.Next(0, 9);

                    // check the randomized call number list
                    // with the original call number dictionary values
                    if (randomCallNumList.Contains(callNumbers[index]) == false)
                    {
                        randomCallNumList.Add(callNumbers[index]);
                        sortedCateCallNumList.Add(callNumbers[index]);
                    }
                    else
                    {
                        i--;
                    }
                }

                RandomizeCallNumList();
            }

            if (option == 2)
            {
                for (int i = 0; i < 4; i++)
                {

                    index = random.Next(0, 9);

                    // check the randomized call number list
                    // with the original call number dictionary values
                    if (randomCallNumList.Contains(callNumbers[index]) == false)
                    {
                        randomCallNumList.Add(callNumbers[index]);
                        randomQuestionsList.Add(catQuestions[index]);
                        sortedCateCallNumList.Add(catQuestions[index]);
                    }
                    else
                    {
                        i--;
                    }
                }

                listBoxCallNum.DataSource = randomCallNumList;



                for (int i = 0; i < 3; i++)
                {
                    index = random.Next(0, 9);

                    // check the randomized call number list
                    // with the original call number dictionary values
                    if (randomQuestionsList.Contains(catQuestions[index]) == false)
                    {
                        randomQuestionsList.Add(catQuestions[index]);
                        sortedCateCallNumList.Add(catQuestions[index]);
                    }
                    else
                    {
                        i--;
                    }
                }
                
                RandomizeQuestionsList();

            }
        }

        private void btnChooseOption_Click(object sender, EventArgs e)
        {
            String userAnswer = listBoxQuestions.Text;
            answerList.Add(userAnswer);


            // Once a question is chosen from the listbox it should be removed
            // Only 4 questions will be removed
            listBoxQuestions.Items.Remove(userAnswer);

            if (answerList.Count == 4)
            {
                listBoxAnswers.Visible = true;
                listBoxQuestions.Visible = false;
                btnChooseOption.Visible = false;
                lblAnswers.Visible = true;
                btnViewScore.Visible = true;
              
                if (IdentifyAreasForm.option == 1)
                {
                    listBoxAnswers.DataSource = IdentifyAreasForm.sortedCateCallNumList;
                }
                if (IdentifyAreasForm.option == 2)
                {
                    listBoxAnswers.DataSource = IdentifyAreasForm.sortedCateCallNumList;
                }

                for (int i = 0; i < 4; i++)
                {
                    // Compare the sorted list to the answers the user had chosen 
                    // Display the points and trophies accordingly
                    if (sortedCateCallNumList[i] == answerList[i])
                    {
                        trophies = trophies + 10;
                        totalScore = totalScore + 1;
                    }
                }
            }
        }

        private void icBtnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Hide();
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            CongratForm congratForm = new CongratForm();
            congratForm.Show();
            this.Hide();
        }

        private void RandomizeCallNumList()
        {

            Random random = new Random();

            int j = randomCallNumList.Count;
            while (j > 1)
            {
                j--;
                int k = random.Next(j + 1);

                // Utilising selection sorting for call numbers
                String temp = randomCallNumList[k];
                randomCallNumList[k] = randomCallNumList[j];
                randomCallNumList[j] = temp;
            }
            for (int i = 0; i < randomCallNumList.Count; i++)
            {
                listBoxQuestions.Items.Add(randomCallNumList[i]);
            }
        }

        private void RandomizeQuestionsList()
        {
            Random random = new Random();
            int j = randomQuestionsList.Count;
            while (j > 1)
            {
                j--;
                int k = random.Next(j + 1);

                // Utilising selection sorting for category questions
                String temp = randomQuestionsList[k];
                randomQuestionsList[k] = randomQuestionsList[j];
                randomQuestionsList[j] = temp;
            }
            for (int i = 0; i < randomQuestionsList.Count; i++)
            {
                listBoxQuestions.Items.Add(randomQuestionsList[i]);
            }
        }


     
    }
        }






