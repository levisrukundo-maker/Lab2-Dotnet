using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Mushroom : Form
    {
        public Mushroom()
        {
            InitializeComponent();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            string result;

            bool inForest = AskYesNo("Does your mushroom grow in a forest?");
            bool hasConvex = AskYesNo("Does your mushroom have a convex cup?");

            if (!inForest)
            {
                result = hasConvex ? "Agaric jaunissant" : "Coprin chevelu";
            }
            else if (hasConvex)
            {
                bool hasRing = AskYesNo("Does your mushroom have a ring?");
                result = hasRing ? "Amanite tue-mouche" : "Pied bleu";
            }
            else
            {
                bool hasGills = AskYesNo("Does your mushroom have gills?");
                result = hasGills ? "Girolle" : "Cepe de bordeaux";
            }

            MessageBox.Show("Your mushroom is: " + result, "Result");
        }

        private bool AskYesNo(string question)
        {
            DialogResult answer = MessageBox.Show(question, "Mushroom", MessageBoxButtons.YesNo);
            return answer == DialogResult.Yes;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            choose c = new choose();
            c.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
