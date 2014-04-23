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

        public XOceptionGameMain(XOCeptionForm form) {
            board = new MainBoard();
            currentPlayer = Seed.X;
            currentState = State.PLAYING;
        }

        public void playerMove(Button btn) {
            int row = Int32.Parse(btn.Name.ToCharArray()[4].ToString()); //btn_11
            int col = Int32.Parse(btn.Name.ToCharArray()[5].ToString());
            board.playerMove(row, col);

            currentPlayer = currentPlayer == Seed.X ? Seed.O : Seed.X;
            //XOCeptionForm.debu("Game status:" + board.boardState);
        }
    }
}
