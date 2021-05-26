using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* **********************************************************************************************************************************
    A C# program that allows the user to change the form background color by selecting two color radio buttons and "mixing" the two.
                                       (A programming problem from my Intro to C# course.)
************************************************************************************************************************************** */


namespace _4._4_Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void mixButton_Click(object sender, EventArgs e)
        {
            if (red1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Red; 
            }

            else if (red1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Purple;
            }

            else if (red1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Orange;
            }

            else if (blue1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Purple;
            }

            else if (blue1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Blue;
            }

            else if (blue1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }

            else if (yellow1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Orange;
            }

            else if (yellow1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }

            else if (yellow1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
