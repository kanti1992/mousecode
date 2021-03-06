﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace mysz
{
    public partial class ColorsGameMenuWindow : GameMenuWindowBase
    {
        ColorsGameWindow ColorsWindow;
        string userName;
        int seconds = 5;

        public ColorsGameMenuWindow(string userName)
        {
            InitializeComponent();
            GameMenuWindowBase BaseWindow = new GameMenuWindowBase(helpLabel, titleLabel1, exitLabel, backLabel, settingsLabel,
            playButton, instructionTextBox);
            this.userName = userName;
            titleLabel1.Text = "Welcome \n" + userName +"!";
        }

        public void playButtonClick(object sender, EventArgs e)
        {
            ColorsWindow = new ColorsGameWindow(userName, seconds);
            ColorsWindow.FormClosed += new FormClosedEventHandler(ColorsWindow_FormClosed);
            ColorsWindow.Show();
            this.Hide();
        }

        void ColorsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        public void exitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void settingsClick(object sender, EventArgs e)
        {
            playButton.Visible = false;
            helpLabel.Visible = false;
            titleLabel1.Visible = false;
            exitLabel.Visible = false;
            backLabel.Visible = true;
            instructionTextBox.Visible = false;
            gameTimeLabel.Visible = true;
            secondsLabel.Visible = true;
            secondsTextbox.Visible = true;
            setTimeButton.Visible = true;
            playButton.Enabled = false;
            setTimeButton.BackColor = Color.LightGray;
        }

        public void helpClick(object sender, EventArgs e)
        {
            playButton.Visible = false;
            settingsLabel.Visible = false;
            titleLabel1.Visible = false;
            exitLabel.Visible = false;
            backLabel.Visible = true;
            instructionTextBox.Visible = true;
            backLabel.Location = new Point
            {
                X = 96,
                Y = 226
            };
            settingsComponents();
            playButton.Enabled = false;
        }

        public void backGameWindow(object sender, MouseEventArgs e)
        {
            playButton.Visible = true;
            if (helpLabel.Visible == true)
            {
                settingsLabel.Visible = true;
            }
            else
            {
                helpLabel.Visible = true;
            }
            titleLabel1.Visible = true;
            exitLabel.Visible = true;
            backLabel.Visible = false;
            settingsComponents();
            playButton.Enabled = true;
        }
        public new void highlightLabel(object sender, EventArgs e)
        {
            base.highlightLabel(sender, e);
        }

        public new void removeHighlightLabel(object sender, EventArgs e)
        {
            base.removeHighlightLabel(sender, e);
        }

        public new void buttonHighlight(object sender, EventArgs e)
        {
            base.buttonHighlight(sender, e);
        }

        public new void removeHighlightButton(object sender, EventArgs e)
        {
            base.removeHighlightButton(sender, e);
        }

        public void settingsComponents()
        {
            gameTimeLabel.Visible = false;
            secondsLabel.Visible = false;
            secondsTextbox.Visible = false;
            setTimeButton.Visible = false;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            
            if (System.Text.RegularExpressions.Regex.IsMatch(secondsTextbox.Text, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter only numbers.");
                secondsTextbox.Text = "";
            }
            if (secondsTextbox.Text.Length > 2)
            {
                MessageBox.Show("Please enter only two numbers.");
                secondsTextbox.Text = "";
            }

            base.textbox_TextChanged(sender, e, secondsTextbox, setTimeButton); 
        }

        private void setTimeButton_Click(object sender, EventArgs e)
        {
            string secondsS = "";
            int secondsValidator = 0;
            if (secondsTextbox.Text != "")
            {
                try
                {
                    secondsS = secondsTextbox.Text;
                    secondsValidator = Convert.ToInt32(secondsS);
                    secondsS = "0";
                }
                catch
                {
                    MessageBox.Show("Please enter seconds in valid format.");
                    secondsTextbox.Text = "";
                    secondsS = "1000";
                    //workaround
                }
            }
            if (!String.IsNullOrEmpty(secondsTextbox.Text) && (secondsValidator < 2 || secondsValidator > 10))
            {
                MessageBox.Show("Please enter seconds in range from 2 to 10.");
                secondsTextbox.Text = "";
            }

            else
            {
                int time = 0;
                if(secondsS !="1000")
                    time = base.setTimeButton_Click(sender, e, secondsTextbox.Text, setTimeButton);

                seconds = time;
            }
        }
    }

}
