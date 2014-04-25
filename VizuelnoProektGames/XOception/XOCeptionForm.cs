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
            game = new XOceptionGameMain(this);
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Abort;
        }

        private void button1_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            //lblDebug.Text = btn.Name;
            game.playerMove(btn);
            if (cbCheatMode.Checked) {
                if (XOceptionGameMain.currentPlayer == Seed.O)
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.tomche;
                else
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.dejan;
            } else {
                if (XOceptionGameMain.currentPlayer == Seed.O)
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.X;
                else
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.O;
            }
            btn.Enabled = false;
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
            XOceptionGameMain.DebugMode = cbCheatMode.Checked;
            MessageBox.Show("DebugMode Acticated!\nTomche=X\nDejan=O");
        }
    }
}
