using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private const int LINES = 3;
        private const int COLS = 3;

        private Cell[,] cells;

        public Board()
        {
            cells = new Cell[LINES, COLS];
            for(int i = 0; i < LINES; i++)
                for(int j = 0; j < COLS; j++)
                    cells[i, j] = new Cell(Content.EMPTY);
        }

        public void draw()
        {
            Console.Clear();
            for (int i = 0; i < LINES; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    Console.Write(cells[i, j].getContentStr());
                    if (j != COLS - 1)
                        Console.Write("||");
                }
                Console.WriteLine();
                if (i != LINES - 1)
                {
                    for (int k = 0; k < 5 * COLS - 2; k++)
                        Console.Write("=");
                    Console.WriteLine();
                }
            }
        }

        public bool isCellValid(int line, int col)
        {
            // TODO - sprawdzanie zakresow
            if (line >= 0 && line < LINES && col >=0 && col < COLS && cells[line, col].Cont == Content.EMPTY)
                return true;
            else
                return false;
        }

        public void setCell(int line, int col, Content content)
        {
            
            cells[line, col].Cont = content;
        }

        public bool checkIfWin(Content curPlayer)
        {
            // TODO - ogolna wersja???
            return cells[0, 0].Cont == curPlayer && cells[0, 1].Cont == curPlayer && cells[0, 2].Cont == curPlayer
                || cells[1, 0].Cont == curPlayer && cells[1, 1].Cont == curPlayer && cells[1, 2].Cont == curPlayer
                || cells[2, 0].Cont == curPlayer && cells[2, 1].Cont == curPlayer && cells[2, 2].Cont == curPlayer

                || cells[0, 0].Cont == curPlayer && cells[1, 0].Cont == curPlayer && cells[2, 0].Cont == curPlayer
                || cells[0, 1].Cont == curPlayer && cells[1, 1].Cont == curPlayer && cells[2, 1].Cont == curPlayer
                || cells[0, 2].Cont == curPlayer && cells[1, 2].Cont == curPlayer && cells[2, 2].Cont == curPlayer

                || cells[0, 0].Cont == curPlayer && cells[1, 1].Cont == curPlayer && cells[2, 2].Cont == curPlayer

                || cells[0, 2].Cont == curPlayer && cells[1, 1].Cont == curPlayer && cells[2, 0].Cont == curPlayer;
        }

        public bool checkIfDraw()
        {
            for (int i = 0; i < LINES; i++)
                for (int j = 0; j < COLS; j++)
                    if (cells[i, j].Cont == Content.EMPTY)
                        return false;
            return true;
        }
    }
}
