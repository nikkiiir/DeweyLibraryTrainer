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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void icBtnReplaceBooks_Click(object sender, EventArgs e)
        {
            ReplaceBooksForm replaceBooks = new ReplaceBooksForm();
            replaceBooks.Show();
            this.Hide();
        }


        private void icBtnIdentifyAreas_Click(object sender, EventArgs e)
        {
            IdentifyAreasForm identifyAreas = new IdentifyAreasForm();
            identifyAreas.Show();
            this.Hide();
        }

        private void icBtnCallNumbers_Click(object sender, EventArgs e)
        {
            FindingCallNumbersForm findingCallNumbers = new FindingCallNumbersForm();
            findingCallNumbers.Show();
            this.Hide();
        }
    }
}
