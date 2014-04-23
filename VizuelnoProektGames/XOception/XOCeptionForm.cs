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
            if (XOceptionGameMain.currentPlayer==Seed.O){
                btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.tomche;
            } else {
                btn.BackgroundImage = (System.Drawing.Image)Properties.Resources.dejan;
            }
            btn.Enabled = false;
            lblDebug.Text = "Game state: " + XOceptionGameMain.board.boardState.ToString();
        }
    }
}
