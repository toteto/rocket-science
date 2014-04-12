using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoProektGames.XOception {
    public class XOceptionGameMain {
        public MainBoard board { get; set; }
        public State currentState { get; set; }
        public Seed currentPlayer { get; set; }

        public XOceptionGameMain() {
            board = new MainBoard();
            currentPlayer = Seed.X;
            currentState = State.PLAYING;
        }

        public void playerMove(int row, int col) {

        }
    }
}
