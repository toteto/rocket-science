using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.Memory
{
    public partial class MemoryGameForm : Form
    {
        Label firstClicked;
        Label secondClicked;
        NewGame game;
        public string level;

        public MemoryGameForm(string level)
        {
            InitializeComponent();
            firstClicked = null;
            secondClicked = null;
            this.level = level;
            game = createNewGame();
            this.pbTimeLeft.Maximum = game.timeLeft;
            this.pbTimeLeft.Value = game.timeLeft;

            splitContainer1.IsSplitterFixed = true;
            inicializePanel();
            addIcons();
        }

        private NewGame createNewGame()
        {
            if (level == "easy")
            {
                return new EasyGame();
            }
            else if (level == "normal")
            {
                return new NormalGame();
            }
            else if (level == "hard")
            {
                return new HardGame();
            }
            else return null;
        }

        public void inicializePanel()
        {
            tblPanel.RowCount = game.RowCount;
            tblPanel.ColumnCount = game.ColumnCount;
            tblPanel.Controls.Clear();
            tblPanel.RowStyles.Clear();
            tblPanel.ColumnStyles.Clear();

            if (level == "normal")
            {
                tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));
                tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));
            }

            for (int i = 0; i < tblPanel.ColumnCount; i++)
            {
                tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / tblPanel.ColumnCount)));
                tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));
            }
        }

        private void inicializeLabel(ref Label label)
        {
            addClickEventToLabel(ref label);
            inicializeLabelProperty(ref label);
            label.Text = game.icons[0];
            game.icons.RemoveAt(0);
        }

        private void addClickEventToLabel(ref Label label)
        {
            label.Click += (sender, e) =>
            {
                // The timer is only on after two non-matching  
                // icons have been shown to the player,  
                // so ignore any clicks if the timer is running
                if (timer1.Enabled == true)
                    return;

                Label clickedLabel = sender as Label;

                if (clickedLabel != null)
                {
                    // If the clicked label is black, the player clicked 
                    // an icon that's already been revealed
                    // ignore the click 
                    if (clickedLabel.ForeColor == Color.Black)
                        return;

                    // If firstClicked is null, this is the first icon 
                    // in the pair that the player clicked,  
                    // so set firstClicked to the label that the player  
                    // clicked, change its color to black, and return 
                    if (firstClicked == null)
                    {
                        firstClicked = clickedLabel;
                        firstClicked.ForeColor = Color.Black;
                        return;
                    }

                    // If the player gets this far, the timer isn't 
                    // running and firstClicked isn't null, 
                    // so this must be the second icon the player clicked 
                    // Set its color to black
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;

                    // Check to see if the player won

                    // If the player clicked two matching icons, keep them  
                    // black and reset firstClicked and secondClicked  
                    // so the player can click another icon 
                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        game.matchedIcons++;
                        CheckForWinner();
                        return;
                    }

                    // If the player gets this far, the player  
                    // clicked two different icons, so start the  
                    // timer (which will wait three quarters of  
                    // a second, and then hide the icons)
                    timer1.Start();
                }
            };
        }

        public void inicializeLabelProperty(ref Label label)
        {
            label.AutoSize = false;
            label.BackColor = Color.CornflowerBlue;
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Webdings", 72F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
            //label.ForeColor = Color.Black;
            label.ForeColor = Color.CornflowerBlue;
            label.Text = "c";
            label.TextAlign = ContentAlignment.MiddleCenter;
        }


        private void addIcons()
        {
            for (int i = 0; i < game.ColumnCount; i++)
            {
                for (int j = 0; j < game.RowCount; j++)
                {
                    Label label = new Label();
                    inicializeLabel(ref label);
                    label.Name = "label" + i + j;
                    tblPanel.Controls.Add(label, j, i);
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked  
            // so the next time a label is 
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        private string gameOverMessage()
        {
            string message;
            if (game.matchedIcons < game.ColumnCount * game.RowCount)
            {
                message = "Game over, your points: " + game.points + "\nPlay again?";
            }
            else
            {
                message = "Congratulations! You matched all the icons!\nYour points: " +
                game.points + "\nPlay again?";
            }
            return message;
        }

        private void CheckForWinner()
        {
            if (game.timeLeft > 0)
            {
                if ((game.matchedIcons * 2) == tblPanel.RowCount * tblPanel.ColumnCount)
                {
                    gameOver();

                }
                else
                {
                    return;
                }

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            game.timeLeft--;

            if (game.timeLeft > 0)
            {
                lblTimeLeft.Text = "Time left: " + (game.timeLeft / 60) + " min " + (game.timeLeft % 60) + " sec";
                pbTimeLeft.Value = game.timeLeft;
                game.points -= (float)50 / game.totalTimeLeft;
            }
            else
            {
                gameOver();
            }
        }

        private void gameOver()
        {
            timer2.Stop();
            timer1.Stop();
            game.points = (int)(game.points + (50 / ((float)tblPanel.ColumnCount * tblPanel.RowCount)) * (game.matchedIcons * 2));
            DialogResult dialogResult = MessageBox.Show(gameOverMessage(), "Game over", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                MemoryMainForm mf = new MemoryMainForm();
                mf.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }


    }
}
