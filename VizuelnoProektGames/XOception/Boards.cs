using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoProektGames.XOception {
   public  class MiniBoard {
        public State boardSate { get; set; }
        public Seed[][] cells { get; set; }

        public MiniBoard() {
            boardSate = State.PLAYING;
            cells = new Seed[3][];
            for (int i = 0; i < 3; i++) {
                cells[i] = new Seed[3];
                for (int j = 0; j < 3; j++) 
                    cells[i][j] = Seed.EMPTY;
            }
        }

        public bool CheckDraw() {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (cells[i][j] == Seed.EMPTY)
                        return false;
            this.boardSate = State.DRAW;
            return true;
        }

        public bool CheckSeedWin(Seed theSeed, int currentRow, int currentCol) {
            // state check got from http://www3.ntu.edu.sg/home/ehchua/programming/java/JavaGame_TicTacToe.html#zz-2
            return (cells[currentRow][0] == theSeed         // 3-in-the-row
                   && cells[currentRow][1] == theSeed
                   && cells[currentRow][2] == theSeed
              || cells[0][currentCol] == theSeed      // 3-in-the-column
                   && cells[1][currentCol] == theSeed
                   && cells[2][currentCol] == theSeed
              || currentRow == currentCol            // 3-in-the-diagonal
                   && cells[0][0] == theSeed
                   && cells[1][1] == theSeed
                   && cells[2][2] == theSeed
              || currentRow + currentCol == 2    // 3-in-the-opposite-diagonal
                   && cells[0][2] == theSeed
                   && cells[1][1] == theSeed
                   && cells[2][0] == theSeed);
        }

    }
    public class MainBoard {
        public State boardSate { get; set; }

        public MiniBoard[][] boards { get; set; }

        public MainBoard() {
            boardSate = State.PLAYING;
            boards = new MiniBoard[3][];
            for (int i = 0; i < 3; i++) {
                boards[i] = new MiniBoard[3];
                for (int j = 0; j < 3; j++) 
                    boards[i][j] = new MiniBoard();
            }
        }
        public bool CheckDraw() {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (boards[i][j].boardSate == State.PLAYING)
                        return false;
            this.boardSate = State.DRAW;
            return true;
        }

        public bool CheckSeedWin(Seed seed, int currentRow, int currentCol) {
            // state check got from http://www3.ntu.edu.sg/home/ehchua/programming/java/JavaGame_TicTacToe.html#zz-2
            State theSeed = seed == Seed.X ? State.X_WON : State.O_WON;
            return (boards[currentRow][0].boardSate == theSeed         // 3-in-the-row
                   && boards[currentRow][1].boardSate == theSeed
                   && boards[currentRow][2].boardSate == theSeed
              || boards[0][currentCol].boardSate == theSeed      // 3-in-the-column
                   && boards[1][currentCol].boardSate == theSeed
                   && boards[2][currentCol].boardSate == theSeed
              || currentRow == currentCol            // 3-in-the-diagonal
                   && boards[0][0].boardSate == theSeed
                   && boards[1][1].boardSate == theSeed
                   && boards[2][2].boardSate == theSeed
              || currentRow + currentCol == 2    // 3-in-the-opposite-diagonal
                   && boards[0][2].boardSate == theSeed
                   && boards[1][1].boardSate == theSeed
                   && boards[2][0].boardSate == theSeed);
        }
    }

    
}
