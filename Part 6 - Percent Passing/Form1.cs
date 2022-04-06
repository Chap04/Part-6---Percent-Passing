using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6___Percent_Passing
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }
        double passingCounter;
        double totalEntered;
        double overallPercentage;
        double tempGradeStore;
        double decimalPercentage;
        double gradesAverage;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtGrades.Text, out tempGradeStore))
            {
                if (tempGradeStore >= 71)
                {
                    passingCounter++;
                    totalEntered++;
                    overallPercentage = overallPercentage + tempGradeStore;
                    txtGrades.Text = ("");
                }
                else
                {
                    totalEntered++;
                    overallPercentage = overallPercentage + tempGradeStore;
                    txtGrades.Text = ("");
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            decimalPercentage = (passingCounter / totalEntered * 100);
            gradesAverage = (overallPercentage / totalEntered);
            lblOutput.Text = ($"You had {Math.Round(decimalPercentage, 2)}% of students passing, with an average grade of {gradesAverage}%");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            passingCounter = 0;
            totalEntered = 0;
            overallPercentage = 0;
            tempGradeStore = 0;
            decimalPercentage = 0;
            lblOutput.Text = ("");
        }
    }
}
