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

        public XOceptionGameMain(XOCeptionForm form) {
            board = new MainBoard();
            currentPlayer = Seed.X;
            currentState = State.PLAYING;
            this.form = form;
        }

        public void playerMove(Button btn) {
            int row = Int32.Parse(btn.Name.ToCharArray()[4].ToString()); //btn_11
            int col = Int32.Parse(btn.Name.ToCharArray()[5].ToString());
            board.playerMove(row, col);
            DisableInactive(row, col);
            currentPlayer = currentPlayer == Seed.X ? Seed.O : Seed.X;
            //XOCeptionForm.debu("Game status:" + board.boardState);
        }

        public void DisableInactive(int row, int col) {
            int rowA, colA;
            if (board.boards[row%3][col%3].boardState == State.PLAYING) {
                rowA = row%3;
                colA = col%3;
            } else {
                rowA = -1;
                colA = -1;
            }
            foreach (var control in form.Controls) {
                var btn = control as Button;
                if (btn != null && System.Text.RegularExpressions.Regex.IsMatch(btn.Name, "^btn_\\d{2}")) {
                    int currRow = Int32.Parse(btn.Name.ToCharArray()[4].ToString())/3;
                    int currCol = Int32.Parse(btn.Name.ToCharArray()[5].ToString())/3;
                    if ((currRow == rowA && currCol == colA) || rowA==-1) {
                        if (board.boards[currRow][currCol].boardState == State.PLAYING)
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
