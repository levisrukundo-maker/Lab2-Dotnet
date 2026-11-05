using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStart.Text, out int startTime) || startTime < 0 || startTime > 23)
            {
                MessageBox.Show("Enter a valid starting hour between 0 and 23.", "Bicycle");
                return;
            }

            if (!int.TryParse(txtEnd.Text, out int endTime) || endTime < 1 || endTime > 24)
            {
                MessageBox.Show("Enter a valid ending hour between 1 and 24.", "Bicycle");
                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show("Ending hour must be greater than the starting hour.", "Bicycle");
                return;
            }

            int totalCost = 0;

            for (int hour = startTime; hour < endTime; hour++)
            {
                int rate;

                if ((hour >= 0 && hour < 7) || (hour >= 21 && hour < 24))
                    rate = 500;
                else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                    rate = 1000;
                else
                    rate = 1500;

                totalCost += rate;
            }

            txtTotal.Text = totalCost + " RWF";
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
