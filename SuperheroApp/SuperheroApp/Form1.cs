using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperheroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHeroId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtSuperpower.Text) ||
                string.IsNullOrWhiteSpace(txtExamScore.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Missing Information",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
