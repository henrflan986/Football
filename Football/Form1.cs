using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Football
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random randGen = new Random();
        SoundPlayer sPlayer = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            DisplayPage();
        }

        private void option5Button_Click(object sender, EventArgs e)
        {
          

            if (page == 1)
            {
                int chance = randGen.Next(1, 101);

                if (chance > 50)
                {
                    page = 3;
                }
                else
                {
                    page = 2;
                }
            }
            else if (page == 5)
            {
                page = 6;
            }
           
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 15;
            }
            else if (page == 12)
            {
                page = 15;
            }
            else if (page == 13)
            {
                page = 3;
            }
            else if (page == 14)
            {
                page = 3;
            }
            else if (page == 15)
            {
                page = 3;

            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 2)
            {
                page = 1;
            }
            DisplayPage();
        }

        private void DisplayPage()
        {
            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    outputLabel.Text = "Start drive";
                    option2Output.Text = "Run";
                    option3Output.Text = "Pass";
                    option4Output.Text = "";
                   sPlayer = new SoundPlayer(Properties.Resources.startUpSound);
                   sPlayer.Play();
                    storyImageBox.Image = Properties.Resources.football_field;
                    break;
                case 2:
                    outputLabel.Text = "Your Qb threw an interception, play again?";
                    option2Output.Text = "Yes";
                    option3Output.Text = "No";
                    option4Output.Text = "";
                    sPlayer = new SoundPlayer(Properties.Resources.lostSound);
                    sPlayer.Play();
                    storyImageBox.Image = Properties.Resources.qbInterseption;
                    break;
                case 3:
                    outputLabel.Text = "You got a touchdown, you win, play again?";
                    option2Output.Text = "Yes";
                    option3Output.Text = "No";
                    option4Output.Text = "";
                    sPlayer = new SoundPlayer(Properties.Resources.winningSound);
                    sPlayer.Play();
                    storyImageBox.Image = Properties.Resources.touchdownScore;
                    break;
                case 4:
                    outputLabel.Text = "Your running back fumbled, play again?";
                   option2Output.Text = "Yes";
                  option3Output.Text = "No";
                    option4Output.Text = "";
                    sPlayer = new SoundPlayer(Properties.Resources.lostSound);
                  sPlayer.Play();
                    storyImageBox.Image = Properties.Resources.rbFumble;
                    break;
                case 5:
                    outputLabel.Text = "You gained 5 yards, would you like to pass or rush?";
                    option2Output.Text = "Pass";
                   option3Output.Text = "Rush";
                    break;
                case 6:
                    outputLabel.Text = "You are going for a passing play, would you like to go for a deep pass, short pass or screen pass?";
                   option2Output.Text = "Deep pass";
                  option3Output.Text = "short pass";
                   option4Output.Text = "screen pass";
                    break;
                case 7:
                    outputLabel.Text = "You are going for a rushing play, would you like to go for an imside or outside rush?";
                    option2Output.Text = "Inside run";
                    option3Output.Text = "outside run";
                    option4Output.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You are going for a deep pass play, would you like to throw to Wr1, Wr2, Wr3?";
                    option2Output.Text = "Wr1";
                   option3Output.Text = "Wr2";
                    option4Output.Text = "Wr3";
                    break;
                case 9:
                    outputLabel.Text = "You are going for a screen pass, would you like to throw to Wr1. Wr2, or Rb?";
                    option2Output.Text = "Wr1";
                   option3Output.Text = "Wr2";
                    option4Output.Text = "Rb";
                    break;
                case 10:
                    outputLabel.Text = "You are going for a short pass, would you like to throw to Wr1. Wr2, or Te?";
                    option2Output.Text = "Wr1";
                   option3Output.Text = "Wr2";
                    option4Output.Text = "Te";
                    break;
                case 11:
                    outputLabel.Text = "You are going for a outside rush, would you like to rush with Rb1, Rb2, or Qb?";
                    option2Output.Text = "Wr1";
                   option3Output.Text = "Wr2";
                    option4Output.Text = "Qb";
                    break;
                case 12:
                    outputLabel.Text = "You are going for a inside rush, would you like to rush with Rb1, Rb2, or Qb?";
                    option2Output.Text = "Wr1";
                   option3Output.Text = "Wr2";
                    option4Output.Text = "Qb";
                    break;
                case 13:
                    outputLabel.Text = "You gained 20 yards, would you like to pass or rush?";
                    option2Output.Text = "Rush";
                   option3Output.Text = "Pass";
                    break;
                case 14:
                    outputLabel.Text = "You gained 10 yard would you like to pass or rush?";
                    option2Output.Text = "rush";
                   option3Output.Text = "pass";
                    break;
                case 15:
                    outputLabel.Text = "gain 5 yards, would you like to pass or rush?";
                    option2Output.Text = "Rush";
                   option3Output.Text = "Pass";
                    break;


            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 5;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 7)
            {
                page = 15;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 2;
            }
            else if (page == 10)
            {
                page = 3;
            }
            else if (page == 8)
            {
                page = 3;
            }
            else if (page == 13)
            {
                page = 2;
            }
            else if (page == 14)
            {
                page = 4;
            }
            else if (page == 11)
            {
                page = 4;
            }
            else if (page == 12)
            {
                page = 3;
            }
            else if (page == 15)
            {
                page = 4;
            }
            DisplayPage();
        }

        private void optionButton4_Click(object sender, EventArgs e)
        {
            if (page == 6)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 2;
            }
            else if (page == 10)
            {
                page = 14;
            }
            else if (page == 11)
            {
                page = 3;
            }
            else if (page == 10)
            {
                page = 4;
            }
            DisplayPage();
        }

      
    }
}
