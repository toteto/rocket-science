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
        Graphics graphics;
        Pen pen;
        public XOceptionGameMain game { get; set; }
        public XOCeptionForm() {
            InitializeComponent();
            game = new XOceptionGameMain(this);
            updateCurrentPlayer();
        }

        /*
         * Drawing the lines between the mini boards
         */
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            graphics = this.CreateGraphics();
            pen = new Pen(Color.Black, 3);
            graphics.DrawLine(pen, 159, 27, 159, 457);
            graphics.DrawLine(pen, 304, 27, 304, 457);
            graphics.DrawLine(pen, 10, 172, 450, 172);
            graphics.DrawLine(pen, 10, 313, 450, 313);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Abort;
        }

        /*
         * Updating the label that shows who is the current player
         */
        private void updateCurrentPlayer() {
            if (cbCheatMode.Checked)
                lblCurrPlayer.Text = "Current player: " + (game.currentPlayer == Seed.X ? "Dejan" : "Tomche");
            else
                lblCurrPlayer.Text = "Current player: " + (game.currentPlayer == Seed.X ? "X" : "O");
        }

        private void button1_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            if (cbCheatMode.Checked) {
                if (game.currentPlayer == Seed.O)
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.tomche;
                else
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.dejan;
            } else {
                if (game.currentPlayer == Seed.O)
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.O;
                else
                    btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.X;
            }
            btn.Enabled = false;
            game.playerMove(btn);
            updateCurrentPlayer();

            if (XOceptionGameMain.board.boardState == State.X_WON)
                MessageBox.Show("Congratulations, X player won!");
            else if (XOceptionGameMain.board.boardState == State.O_WON)
                MessageBox.Show("Congratulations, O player won!");
            else if (XOceptionGameMain.board.boardState == State.DRAW)
                MessageBox.Show("You both lose!");
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            MessageBox.Show(Properties.Resources.XOCeption_rules_en);
        }

        private void cbCheatMode_CheckedChanged(object sender, EventArgs e) {
            //updateCurrentPlayer();
            XOceptionGameMain.DebugMode = cbCheatMode.Checked;
            MessageBox.Show("DebugMode Acticated!");
        }

       

        private void XOCeptionForm_Load(object sender, EventArgs e) {
            
        }

        private void lbl_00_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            MessageBox.Show(Properties.Resources.XOception_rules_mk);

        }
    }
}
