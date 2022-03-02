using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeweyLibraryTrainer.NodeTree;

namespace DeweyLibraryTrainer
{
    public partial class FindingCallNumbersForm : Form
    {
        // Variables
        public static int trophies = IdentifyAreasForm.trophies;
        public static int totalScore = 0;

        private Tree<string> treeData = new Tree<string>();
        string questionCategory;

        List<string> questionList = new List<string>();
        List<string> questDataset = new List<string>();

        // Lists for each level question
        static List<string> firstLvlQuestions = new List<string>();
        static List<string> secondLvlQuestions = new List<string>();
        static List<string> thirdLvlQuestions = new List<string>();


        public FindingCallNumbersForm()
        {
            InitializeComponent();

            Random random = new Random();

            // Read Textfile
            TreeReaderClass treeReader = new TreeReaderClass(); 
            string[] lines = treeReader.ReadTree();
            ReadLineMethod(lines);

            treeData.TreeNodes.ForEach(n => Node(n, 0));
            QuestionsCategory();

            // Shuffle questions using Shuffle class
            questionList.Shuffle(); 
            questDataset = questionList.Take(1).ToList();

            int idx = random.Next(0, questDataset.Count);
            questionCategory = questDataset[idx];

            foreach (string selection in firstLvlQuestions)
            {
                lblQuestions.Text = selection;
            }
            lblQuestions.Text = questionCategory;
            lblQuestionHeading.Text = questionCategory.Split(';')[2].Split('+')[0];
            GetFirstLevelQuestions();

        }

        static void Node<T>(TreeNode<T> node, int questLevel)
        {
            if (questLevel == 0)
            {
                firstLvlQuestions.Add(node.Value.ToString());
            }
            if (questLevel == 1)
            {
                secondLvlQuestions.Add(node.Value.ToString());
            }
            if (questLevel == 2)
            {
                thirdLvlQuestions.Add(node.Value.ToString());
            }

            questLevel++;
            node.Children.ForEach(n => Node(n, questLevel));
        }

        private void ReadLineMethod(string[] lines)
        {
            foreach (string line in lines)
            {
                if (line.StartsWith("#")) // # - First level
                {
                    treeData.Begin(line.Split('#')[1].Split(';')[0] + line.Split('#')[1].Split(';')[1]);
                }

                if (line.StartsWith("*")) // * - Second level
                {
                    treeData.Begin(line.Split('*')[1].Split(';')[0] + line.Split('*')[1].Split(';')[1]);
                }

                if (line.StartsWith("~")) // ~ - Third level
                {
                    treeData.Add(line.Split('~')[1].Split(';')[0] + line.Split('~')[1].Split(';')[1]);
                }

                if (line.Contains("{BREAK}"))
                {
                    treeData.End();
                }
            }
        }

        private void QuestionsCategory()
        {
            foreach (string levelOne in firstLvlQuestions)
            {
                foreach (string levelTwo in secondLvlQuestions)
                {
                    if (levelOne.StartsWith("/" + levelTwo[2])) // in textfile
                    {
                        foreach (string levelThird in thirdLvlQuestions)
                        {
                            if (levelTwo.Contains("//" + levelThird[3] + levelThird[4]))
                            {
                                questionList.Add(levelOne.Replace("/", "") + ";" +
                                              levelTwo.Replace("/", "") + ";" +
                                              levelThird.Replace("/", ""));
                            }
                        }
                    }
                }
            }
        }


        private void GetFirstLevelQuestions()
        {

            firstLvlQuestions.Shuffle();

            List<string> firstLvlOutput = new List<string>();

            foreach (string item in firstLvlQuestions)
            {
                if (!item.Equals("#"))
                {
                    firstLvlOutput = firstLvlOutput.Take(3).ToList();
                    firstLvlOutput.Add(questionCategory.Split(';')[0].Split('+')[1]);
                    firstLvlOutput = questionList;
                }
            }

            radioBtn1.Text = (firstLvlOutput[0]);
            radioBtn2.Text = (firstLvlOutput[1]);
            radioBtn3.Text = (firstLvlOutput[2]);
            radioBtn4.Text = (firstLvlOutput[3]);

        }


        private void GetSecondLevelQuestions()
        {

            secondLvlQuestions.Shuffle();

            List<string> secondLvlOutput = new List<string>();

            foreach (string item in secondLvlQuestions)
            {
                if (!item.Equals("#"))
                {
                    secondLvlOutput = secondLvlOutput.Take(3).ToList();
                    secondLvlOutput.Add(questionCategory.Split(';')[1].Split('+')[1]);
                    secondLvlOutput = questionList;
                }
            }

            radioBtn1.Text = (secondLvlOutput[0]);
            radioBtn2.Text = (secondLvlOutput[1]);
            radioBtn3.Text = (secondLvlOutput[2]);
            radioBtn4.Text = (secondLvlOutput[3]);

        }

        private void GetThirdLevelQuestions()
        {

            thirdLvlQuestions.Shuffle();

            List<string> thirdLvlOutput = new List<string>();

            foreach (string item in thirdLvlQuestions)
            {
                if (!item.Equals("#"))
                {
                    thirdLvlOutput = thirdLvlOutput.Take(3).ToList();
                    thirdLvlOutput.Add(questionCategory.Split(';')[2].Split('+')[1]);
                    thirdLvlOutput = questionList;
                }
            }

            radioBtn1.Text = (thirdLvlOutput[0]);
            radioBtn2.Text = (thirdLvlOutput[1]);
            radioBtn3.Text = (thirdLvlOutput[2]);
            radioBtn4.Text = (thirdLvlOutput[3]);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string choice = null;
            int questionNum = 1;


            if (radioBtn1.Checked == true)
            {
                choice = radioBtn1.Checked.ToString();
            }
            if (radioBtn2.Checked == true)
            {
                choice = radioBtn2.Checked.ToString();
            }
            if (radioBtn3.Checked == true)
            {
                choice = radioBtn3.Checked.ToString();
            }
            if (radioBtn4.Checked == true)
            {
                choice = radioBtn4.Checked.ToString();
            }

            else if (questionNum == 1)
            {
                if (questionCategory.Split(';')[0].Split('+')[0].Equals(choice))
                { 
                    MessageBox.Show("Correct - Well done!");
                    questionNum++;
                    ResetRadioButtons();
                    GetSecondLevelQuestions();
                }
                else
                {
                    MessageBox.Show("Incorrect Answer!");
                }
            }

            if (questionNum == 2)
            {

                if (questionCategory.Split(';')[1].Split('+')[0] .Equals(choice))
                {
                    MessageBox.Show("Correct - Well done!");
                    questionNum++;
                    ResetRadioButtons();
                    GetThirdLevelQuestions();
                }
                else
                {
                    MessageBox.Show("Incorrect Answer!");
                }
            }
            if (questionNum == 3)
            {

                if (questionCategory.Split(';')[2].Split('+')[0].Equals(choice))
                {
                    MessageBox.Show("Correct - Well done!");
                    questionNum++;

                    trophies = trophies + 10;
                    totalScore = totalScore + 1;

                }
                else
                {
                    MessageBox.Show("Incorrect Answer!");
                }
            }

        }

    private void ResetRadioButtons()
    { 
        radioBtn1.Checked = false;
        radioBtn2.Checked = false;
        radioBtn3.Checked = false;
        radioBtn4.Checked = false;
    }

    private void btnViewScore_Click(object sender, EventArgs e)
    {
        CongratForm congratForm = new CongratForm();
        congratForm.Show();
        this.Hide();
    }
    }
}
