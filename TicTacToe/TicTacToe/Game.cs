using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    
    class Game
    {
        private Board board;
        private CurState curState;
        private Content curPlayer;

        public Game() {
            board = new Board();
        }

        public void start()
        {
            curState = CurState.IN_PROGRESS;
            curPlayer = Content.X;
            board.draw();
            do
            {
                board.draw();
                takeTurn();
                if (board.checkIfWin(curPlayer))
                    curState = curPlayer == Content.X ? CurState.X : CurState.O;
                else if (board.checkIfDraw())
                    curState = CurState.DRAW;
                curPlayer = curPlayer == Content.X ? Content.O : Content.X;
            } while (curState == CurState.IN_PROGRESS);
            board.draw();
            Console.WriteLine("Koniec gry");
            if (curState == CurState.DRAW)
                Console.WriteLine("Remis");
            else
                Console.WriteLine("Wygral zawodnik: " + curState);
        }

        private void takeTurn()
        {
            bool isValid = false;
            do {
            Console.WriteLine(curPlayer + ":  Wybierz lokalizacje [1-3] [1-3]: ");
            string local = Console.ReadLine();
            int line = Convert.ToInt32(local.Split(' ')[0]) - 1;
            int col = Convert.ToInt32(local.Split(' ')[1]) - 1;
            if (board.isCellValid(line, col))
            {
                board.setCell(line, col, curPlayer);
                isValid = true;
            }
            else
                Console.WriteLine("Zle wspolrzedne!!!");
            } while(!isValid);
        }
    }

    public enum CurState
    {
        IN_PROGRESS, X, O, DRAW
    }

    public enum Content
    {
        X, O, EMPTY
    }
}
