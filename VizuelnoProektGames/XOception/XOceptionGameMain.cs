using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.XOception {
    public class XOceptionGameMain {
        static public MainBoard board { get; set; }
        static public State currentState { get; set; }
        static public Seed currentPlayer { get; set; }
        public XOCeptionForm form { get; set; }
        static public bool DebugMode { get; set; }

        public XOceptionGameMain(XOCeptionForm form) {
            board = new MainBoard();
            currentPlayer = Seed.X;
            currentState = State.PLAYING;
            this.form = form;
        }

        public void playerMove(Button btn) {
            int row = Int32.Parse(btn.Name.ToCharArray()[4].ToString()); //btn_11
            int col = Int32.Parse(btn.Name.ToCharArray()[5].ToString());
            State miniBoardState = board.playerMove(row, col);
            if (miniBoardState == State.DRAW)
                resetDrawBoard(row / 3, col / 3);
            else if (miniBoardState != State.PLAYING)
                showWinLabel(row / 3, col / 3);
            DisableInactive(row, col);
            currentPlayer = currentPlayer == Seed.X ? Seed.O : Seed.X;
        }

        public void showWinLabel(int row, int col) {

            foreach (var control in form.Controls) {
                var lbl = control as Label;
                if (lbl != null && System.Text.RegularExpressions.Regex.IsMatch(lbl.Name, "^lbl_\\d{2}")) {
                    int currRow = Int32.Parse(lbl.Name.ToCharArray()[4].ToString()); // selected button row
                    int currCol = Int32.Parse(lbl.Name.ToCharArray()[5].ToString()); // selected button col
                    if (row == currRow && col == currCol) {
                        lbl.Text = currentPlayer == Seed.X ? "X" : "O";
                        lbl.Visible = true;
                    }
                }
            }
        }

        public void resetDrawBoard(int row, int col) {
            foreach (var control in form.Controls) {
                var btn = control as Button;
                if (btn != null && System.Text.RegularExpressions.Regex.IsMatch(btn.Name, "^btn_\\d{2}")) {
                    int currRow = Int32.Parse(btn.Name.ToCharArray()[4].ToString()) / 3; // selected button row
                    int currCol = Int32.Parse(btn.Name.ToCharArray()[5].ToString()) / 3; // selected button col
                    if(row==currRow && col==currCol)
                        btn.BackgroundImage = null;
                }
            }
        }



        public void DisableInactive(int row, int col) {
            int rowA, colA; // cell that has been played
            if (board.boards[row%3][col%3].boardState == State.PLAYING) {
                rowA = row%3;
                colA = col%3;
            } else {
                rowA = -1;
                colA = -1;
            }
            foreach (var control in form.Controls) {
                var btn = control as Button;
                if (btn != null && System.Text.RegularExpressions.Regex.IsMatch(btn.Name, "^btn_\\d{2}")) { // ckeck if the button is game button
                    int currRow = Int32.Parse(btn.Name.ToCharArray()[4].ToString())/3; // mini board to be activated
                    int currCol = Int32.Parse(btn.Name.ToCharArray()[5].ToString())/3; // mini board to be activated
                    if (((currRow == rowA && currCol == colA) || rowA==-1 || DebugMode) && board.boardState==State.PLAYING) {
                        if (board.boards[currRow][currCol].boardState == State.PLAYING && btn.BackgroundImage==null)
                            btn.Enabled = true;
                        else
                            btn.Enabled = false;
                    } else {
                        btn.Enabled = false;
                    }
                }
            }
           // MessageBox.Show(board.boards[row / 3][col / 3].boardState.ToString());
        }

    }
}
