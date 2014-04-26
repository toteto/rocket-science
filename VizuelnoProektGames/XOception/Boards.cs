using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoProektGames.XOception {
   public  class MiniBoard {
        public State boardState { get; set; }
        public Seed[][] cells { get; set; }

        public MiniBoard() {
            boardState = State.PLAYING;
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
            this.boardState = State.DRAW;
            return true;
        }

        public bool CheckWin(int currentRow, int currentCol) {
            // state check got from http://www3.ntu.edu.sg/home/ehchua/programming/java/JavaGame_TicTacToe.html#zz-2
            Seed currentPlayer = XOceptionGameMain.currentPlayer;
            return (cells[currentRow][0] == currentPlayer         // 3-in-the-row
                   && cells[currentRow][1] == currentPlayer
                   && cells[currentRow][2] == currentPlayer
              || cells[0][currentCol] == currentPlayer      // 3-in-the-column
                   && cells[1][currentCol] == currentPlayer
                   && cells[2][currentCol] == currentPlayer
              || currentRow == currentCol            // 3-in-the-diagonal
                   && cells[0][0] == currentPlayer
                   && cells[1][1] == currentPlayer
                   && cells[2][2] == currentPlayer
              || currentRow + currentCol == 2    // 3-in-the-opposite-diagonal
                   && cells[0][2] == currentPlayer
                   && cells[1][1] == currentPlayer
                   && cells[2][0] == currentPlayer);
        }

        public State playerMove(int row, int col) {
            cells[row][col] = XOceptionGameMain.currentPlayer;
            return updateState(row, col);
        }

        private State updateState(int row, int col) {
            if (CheckWin(row, col)) {
                boardState = XOceptionGameMain.currentPlayer == Seed.X ? State.X_WON : State.O_WON;
            } else if (CheckDraw()) {
                boardState = State.DRAW;
            }
            return boardState;
        }
    }


    public class MainBoard {
        public State boardState { get; set; }

        public MiniBoard[][] boards { get; set; }

        public MainBoard() {
            boardState = State.PLAYING;
            boards = new MiniBoard[3][];
            for (int i = 0; i < 3; i++) {
                boards[i] = new MiniBoard[3];
                for (int j = 0; j < 3; j++) 
                    boards[i][j] = new MiniBoard();
            }
        }

        public State playerMove(int row, int col) {
            System.Diagnostics.Debug.Write(row + ":" + col);
            State miniBoardState = boards[row / 3][col / 3].playerMove(row % 3, col % 3);
            if (miniBoardState==State.DRAW) {
                boards[row / 3][col / 3] = new MiniBoard();
            } else
                updateState(row / 3, col / 3);
            return miniBoardState;
        }
        private void updateState(int row, int col) {
            if (CheckWin(row, col)) {
                boardState = XOceptionGameMain.currentPlayer == Seed.X ? State.X_WON : State.O_WON;
            } else if (CheckDraw()) {
                boardState = State.DRAW;
            }
        }

        public bool CheckDraw() {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (boards[i][j].boardState == State.PLAYING)
                        return false;
            this.boardState = State.DRAW;
            return true;
        }

        public bool CheckWin(int currentRow, int currentCol) {
            // state check got from http://www3.ntu.edu.sg/home/ehchua/programming/java/JavaGame_TicTacToe.html#zz-2
            State currentPlayer = XOceptionGameMain.currentPlayer == Seed.X ? State.X_WON : State.O_WON;
            return (boards[currentRow][0].boardState == currentPlayer         // 3-in-the-row
                   && boards[currentRow][1].boardState == currentPlayer
                   && boards[currentRow][2].boardState == currentPlayer
              || boards[0][currentCol].boardState == currentPlayer      // 3-in-the-column
                   && boards[1][currentCol].boardState == currentPlayer
                   && boards[2][currentCol].boardState == currentPlayer
              || currentRow == currentCol            // 3-in-the-diagonal
                   && boards[0][0].boardState == currentPlayer
                   && boards[1][1].boardState == currentPlayer
                   && boards[2][2].boardState == currentPlayer
              || currentRow + currentCol == 2    // 3-in-the-opposite-diagonal
                   && boards[0][2].boardState == currentPlayer
                   && boards[1][1].boardState == currentPlayer
                   && boards[2][0].boardState == currentPlayer);
        }
    }

    
}
