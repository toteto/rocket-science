using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.XOception {
    public partial class XOCeptionForm : Form {
        public XOceptionGameMain game { get; set; }
        public XOCeptionForm() {
            InitializeComponent();

            game = new XOceptionGameMain(this);
            XOceptionGameMain.currentPlayer = Seed.X;
            updateCurrentPlayer();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Abort;
        }
        private void updateCurrentPlayer() {
            if (cbCheatMode.Checked)
                lblCurrPlayer.Text = "Current player: " + (XOceptionGameMain.currentPlayer == Seed.X ? "Dejan" : "Tomche");
            else
                lblCurrPlayer.Text = "Current player: " + (XOceptionGameMain.currentPlayer == Seed.X ? "X" : "O");
        }

        private void button1_Click(object sender, EventArgs e) {
            updateCurrentPlayer();
            Button btn = (Button)sender;
            if (cbCheatMode.Checked) {
                if (XOceptionGameMain.currentPlayer == Seed.O)
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.tomche;
                else
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.dejan;
            } else {
                if (XOceptionGameMain.currentPlayer == Seed.O)
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.O;
                else
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.X;
            }
            btn.Enabled = false;
            game.playerMove(btn);
            // lblDebug.Text = "Button: " + System.Text.RegularExpressions.Regex.IsMatch(btn.Name, "^btn_\\d{2}");

            if (XOceptionGameMain.board.boardState == State.X_WON)
                MessageBox.Show("Congratulations, X player won!");
            else if (XOceptionGameMain.board.boardState == State.O_WON)
                MessageBox.Show("Congratulations, O player won!");
            else if (XOceptionGameMain.board.boardState == State.DRAW)
                MessageBox.Show("You both lose!");
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            MessageBox.Show(Properties.Resources.XOCeption_rules);
        }

        private void cbCheatMode_CheckedChanged(object sender, EventArgs e) {
            //updateCurrentPlayer();
            //updateBtnDebug();
            XOceptionGameMain.DebugMode = cbCheatMode.Checked;
            MessageBox.Show("DebugMode Acticated!\nDejan=O\nTomche=X");
        }

        private void updateBtnDebug() {
            foreach (var control in this.Controls) {
                var btn = control as Button;
                if (btn != null) {
                    if (cbCheatMode.Checked && btn.BackgroundImage!=null) {
                        if (btn.BackgroundImage == Properties.Resources.X){
                            btn.BackgroundImage = Properties.Resources.tomche;
                        }
                        else if (btn.BackgroundImage == (System.Drawing.Image)Properties.Resources.O)
                            btn.BackgroundImage = Properties.Resources.dejan;
                    } else {
                        if (btn.BackgroundImage == Properties.Resources.tomche)
                            btn.BackgroundImage = Properties.Resources.X;
                        else if (btn.BackgroundImage == Properties.Resources.dejan)
                            btn.BackgroundImage = Properties.Resources.O;
                    }
                }
            }
        }

        private void XOCeptionForm_Load(object sender, EventArgs e) {
            
        }
    }
}
