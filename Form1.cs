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
            // The order of checks has been altered here from the lesson to me maximally efficient
            if (chkStarTrek.Checked && chkStarWars.Checked) // Checks for both being checked. 
            {
                lblResults.Text = "You are truly a person of culture.";
                
            }
            else if (chkStarWars.Checked)   // Since we already checked for both CheckBoxes being checked in the previous if statement,
            {                               // we know that chkStarTrek is not checked at this point.
                lblResults.Text = "You like only Star Wars!";
            }
            else if (chkStarTrek.Checked)   // Since we already checked for both CheckBoxes being checked in the first if statement,
            {                               // we know that chkStarWars is not checked at this point.
                lblResults.Text = "You like only Star Trek!";
            }
            else                            // No other possibilities remain.
            {
                lblResults.Text = "You have much to learn.";
            }
        }

       
    }
}
