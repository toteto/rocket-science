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
        int timeLeft;
        int totalTimeLeft;
        float points = 50;
        int matchedIcons = 0;
        List<string> icons = new List<string>();
        int iconsNum = 0;

        Label firstClicked = null;
        Label secondClicked = null;

        public MemoryGameForm()
        {
            InitializeComponent();
        }

        public MemoryGameForm(string level)
        {
            InitializeComponent();
            if (level == "easy")
            {
                timeLeft = 35;
                easyGame();
            }
            else if (level == "normal")
            {
                timeLeft = 55;
                normalGame();
            }
            else if (level == "hard")
            {
                timeLeft = 80;
                hardGame();
            }

            this.pbTimeLeft.Maximum = timeLeft;
            this.pbTimeLeft.Value = timeLeft;
            totalTimeLeft = timeLeft;

            generateIcons();
            inicializeIcons();
            splitContainer1.IsSplitterFixed = true;
            points -= (float)50 / totalTimeLeft;
        }

        public void inicializeIcons()
        {
            Random random = new Random();

            foreach (Control control in tblPanel.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void easyGame()
        {
            tblPanel.RowCount = 4;
            tblPanel.ColumnCount = 4;
            tblPanel.Controls.Clear();
            tblPanel.RowStyles.Clear();
            tblPanel.ColumnStyles.Clear();

            for (int i = 0; i < tblPanel.ColumnCount; i++)
            {
                tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / tblPanel.ColumnCount)));
                tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));

                for (int j = 0; j < tblPanel.RowCount; j++)
                {
                    Label label = new Label();


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
                                matchedIcons++;
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

                    
                    label.AutoSize = false;
                    label.BackColor = Color.CornflowerBlue;
                    label.Dock = DockStyle.Fill;
                    label.Font = new Font("Webdings", 72F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
                    label.ForeColor = Color.Black;
                    label.Name = "label" + i + j;
                    label.Text = "c";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    tblPanel.Controls.Add(label, j, i);
                }
            }
        }

        private void normalGame()
        {
            tblPanel.RowCount = 6;
            tblPanel.ColumnCount = 4;
            tblPanel.Controls.Clear();
            tblPanel.RowStyles.Clear();
            tblPanel.ColumnStyles.Clear();

            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));

            for (int i = 0; i < tblPanel.ColumnCount; i++)
            {
                tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / tblPanel.ColumnCount)));
                tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));

                for (int j = 0; j < tblPanel.RowCount; j++)
                {
                    Label label = new Label();


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
                            // an icon that's already been revealed -- 
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

                            // If the player clicked two matching icons, keep them  
                            // black and reset firstClicked and secondClicked  
                            // so the player can click another icon 
                            if (firstClicked.Text == secondClicked.Text)
                            {
                                firstClicked = null;
                                secondClicked = null;
                                matchedIcons++;

                                // Check to see if the player won
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

                    label.AutoSize = false;
                    label.BackColor = Color.CornflowerBlue;
                    label.Dock = DockStyle.Fill;
                    label.Font = new Font("Webdings", 72F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
                    label.ForeColor = Color.Black;
                    label.Name = "label" + i + j;
                    label.Text = "c";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    tblPanel.Controls.Add(label, j, i);
                }
            }
        }

        private void hardGame()
        {
            tblPanel.RowCount = 6;
            tblPanel.ColumnCount = 6;
            tblPanel.Controls.Clear();
            tblPanel.RowStyles.Clear();
            tblPanel.ColumnStyles.Clear();

            for (int i = 0; i < tblPanel.ColumnCount; i++)
            {
                tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / tblPanel.ColumnCount)));
                tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / tblPanel.RowCount)));

                for (int j = 0; j < tblPanel.RowCount; j++)
                {
                    Label label = new Label();


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
                            // an icon that's already been revealed -- 
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

                            // If the player clicked two matching icons, keep them  
                            // black and reset firstClicked and secondClicked  
                            // so the player can click another icon 
                            if (firstClicked.Text == secondClicked.Text)
                            {
                                firstClicked = null;
                                secondClicked = null;
                                matchedIcons++;

                                // Check to see if the player won
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



                    label.AutoSize = false;
                    label.BackColor = Color.CornflowerBlue;
                    label.Dock = DockStyle.Fill;
                    label.Font = new Font("Webdings", 72F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
                    label.ForeColor = Color.CornflowerBlue;
                    label.Name = "label" + i + j;
                    label.Text = "c";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    tblPanel.Controls.Add(label, j, i);
                }
            }
        }

        private void generateIcons()
        {
            Random random = new Random();
            while (icons.Count != tblPanel.ColumnCount * tblPanel.RowCount)
            {
                char c = (char)random.Next(48, 122);
                if (!icons.Contains(Char.ToString(c)))
                {
                    icons.Add(Char.ToString(c));
                    icons.Add(Char.ToString(c));
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

        private void CheckForWinner()
        {
            if (timeLeft > 0)
            {
                if ((matchedIcons * 2) == tblPanel.RowCount * tblPanel.ColumnCount)
                {
                    timer2.Stop();
                    points = (int)(points + (50 / ((float)tblPanel.ColumnCount * tblPanel.RowCount)) * (matchedIcons * 2));
                    DialogResult dialogResult = MessageBox.Show("Congratulations! You matched all the icons!\nYour points: " +
                        points + "\nPlay again?", "Game over", MessageBoxButtons.YesNo);

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

                return;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft > 0)
            {
               lblTimeLeft.Text = "Time left: " + (timeLeft / 60) + " min " + (timeLeft % 60) + " sec";
               pbTimeLeft.Value = timeLeft;
               points -= (float)50 / totalTimeLeft;
            }
            else
            {
                timer2.Stop();
                points = (int)(points + (50 / ((float)tblPanel.ColumnCount * tblPanel.RowCount)) * (matchedIcons * 2));
                DialogResult dialogResult = MessageBox.Show("Game over, your points: " + 
                    points + "\nPlay again?", "Game over", MessageBoxButtons.YesNo);
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
}
