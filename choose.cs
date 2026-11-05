using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {

            Bicycle b = new Bicycle();
            b.Show();
            this.Hide();

        }

        private void btxMushroom_Click(object sender, EventArgs e)
        {
            Mushroom m = new Mushroom();
            m.Show();
            this.Hide();
        }
    }
}
