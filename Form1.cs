using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxes
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chkStarTrek.Checked && !chkStarWars.Checked)
            {
                lblResults.Text = "You like only Star Trek!";
            }
            else if (chkStarWars.Checked && !chkStarTrek.Checked)
            {
                lblResults.Text = "You like only Star Wars!";
            }
            else if (chkStarTrek.Checked && chkStarWars.Checked)
            {
                lblResults.Text = "You are truly a person of culture.";
            }
            else
            {
                lblResults.Text = "You have much to learn.";
            }
        }

       
    }
}
