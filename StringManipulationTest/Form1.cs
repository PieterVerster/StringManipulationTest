using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManipulationTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            string smallText = "";
            string bigText = "";
            int spaces = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 97 && text[i] <= 109)        //if letter is between a and m (1 to 13)
                {
                    smallText += Convert.ToString(Convert.ToChar(text[i] + 13));     //Apply ROT13
                }
                else if (text[i] >= 110 && text[i] <= 122)      //if letter is between n and z (14 to 26)
                {
                    smallText += Convert.ToString(Convert.ToChar(text[i] - 13));     //Apply ROT13
                }
                else if (text[i] >= 65 && text[i] <= 77)        //if letter is between A and M (1 to 13)
                {
                    smallText += Convert.ToString(Convert.ToChar(text[i] + 13));     //Apply ROT13
                }
                else if (text[i] >= 78 && text[i] <= 90)      //if letter is between N and Z (14 to 26)
                {
                    smallText += Convert.ToString(Convert.ToChar(text[i] - 13));     //Apply ROT13
                }
                else if (text[i] == 45)      //if letter is -
                {
                    smallText += "-";
                }

                    if (text[i] == ' ')
                {
                    smallText += " ";
                }
            }

            MessageBox.Show(smallText);

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    spaces++;
                    bigText += " ";
                }
                else
                {
                    smallText = Convert.ToString(text[i]);
                    bigText += smallText;
                }
            }

            MessageBox.Show(bigText + "... Spaces counter: " + spaces);
        }
    }
}


/*
 * Check through all the text
 * If there is a space, store die previous values in one string
 * Carry on and check if more spaces, and repeat
*/