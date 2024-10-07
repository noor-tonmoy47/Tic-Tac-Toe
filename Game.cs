using System;
namespace Tic_Tac_Toe
{
    internal class Game
    {

        private char[,] gameBoard;


        internal Game()
        {
            this.gameBoard = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        }


        private void insertOnBoard(int pos, char c)
        {
            switch (pos)
            {
                case 1:
                    gameBoard[0, 0] = c;
                    break;
                case 2:
                    gameBoard[0, 1] = c;
                    break;
                case 3:
                    gameBoard[0, 2] = c;
                    break;
                case 4:
                    gameBoard[1, 0] = c;
                    break;
                case 5:
                    gameBoard[1, 1] = c;
                    break;
                case 6:
                    gameBoard[1, 2] = c;
                    break;
                case 7:
                    gameBoard[2, 0] = c;
                    break;
                case 8:
                    gameBoard[2, 1] = c;
                    break;
                case 9:
                    gameBoard[2, 2] = c;
                    break;

            }
        }
        internal void UpdateBoard(int move, Players pl)
        {            // 

            if (pl.Name.Equals("Player1"))
            {
                insertOnBoard(move, 'O');
            }
            else
            {
                insertOnBoard(move, 'X');
            }

        }

        internal void printBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {gameBoard[i, j]} ");

                    // Print a vertical divider between columns except for the last column
                    if (j < 2)
                    {
                        Console.Write("|");
                    }
                }

                Console.WriteLine();

                // Print a horizontal divider between rows except for the last row
                if (i < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }

        internal bool isOccupied(int pos)
        {
            switch (pos)
            {
                case 1:
                    if (gameBoard[0, 0] == ' ') return false;
                    else return true;

                case 2:
                    if (gameBoard[0, 1] == ' ') return false;
                    else return true;
                case 3:
                    if (gameBoard[0, 2] == ' ') return false;
                    else return true;
                case 4:
                    if (gameBoard[1, 0] == ' ') return false;
                    else return true;
                case 5:
                    if (gameBoard[1, 1] == ' ') return false;
                    else return true;
                case 6:
                    if (gameBoard[1, 2] == ' ') return false;
                    else return true;
                case 7:
                    if (gameBoard[2, 0] == ' ') return false;
                    else return true;
                case 8:
                    if (gameBoard[2, 1] == ' ') return false;
                    else return true;
                case 9:
                    if (gameBoard[2, 2] == ' ') return false;
                    else return true;

            }
            return true;
        }

        public bool IsGameOver(Players p1, Players p2)
        {


            if(p1.occupiedPos.Count == 0 || p2.occupiedPos.Count == 0) return false;
            //horizontal Search

            if ((p1.occupiedPos.Contains(1) && p1.occupiedPos.Contains(2) && p1.occupiedPos.Contains(3)) ||

                (p1.occupiedPos.Contains(4) && p1.occupiedPos.Contains(5) && p1.occupiedPos.Contains(6)) ||

                (p1.occupiedPos.Contains(7) && p1.occupiedPos.Contains(8) && p1.occupiedPos.Contains(9)) ||

                (p1.occupiedPos.Contains(1) && p1.occupiedPos.Contains(4) && p1.occupiedPos.Contains(7)) ||

                (p1.occupiedPos.Contains(2) && p1.occupiedPos.Contains(5) && p1.occupiedPos.Contains(8)) ||

                (p1.occupiedPos.Contains(3) && p1.occupiedPos.Contains(6) && p1.occupiedPos.Contains(9)) ||

                (p1.occupiedPos.Contains(7) && p1.occupiedPos.Contains(8) && p1.occupiedPos.Contains(9)) ||

                (p1.occupiedPos.Contains(1) && p1.occupiedPos.Contains(5) && p1.occupiedPos.Contains(9)) ||

                (p1.occupiedPos.Contains(3) && p1.occupiedPos.Contains(5) && p1.occupiedPos.Contains(7))

                )
            {
                Console.WriteLine("Player 1 has won!!!");
                return true;
            }
            else if ((p2.occupiedPos.Contains(1) && p2.occupiedPos.Contains(2) && p2.occupiedPos.Contains(3)) ||

                (p2.occupiedPos.Contains(4) && p2.occupiedPos.Contains(5) && p2.occupiedPos.Contains(6)) ||

                (p2.occupiedPos.Contains(7) && p2.occupiedPos.Contains(8) && p2.occupiedPos.Contains(9)) ||

                (p2.occupiedPos.Contains(1) && p2.occupiedPos.Contains(4) && p2.occupiedPos.Contains(7)) ||

                (p2.occupiedPos.Contains(2) && p2.occupiedPos.Contains(5) && p2.occupiedPos.Contains(8)) ||

                (p2.occupiedPos.Contains(3) && p2.occupiedPos.Contains(6) && p2.occupiedPos.Contains(9)) ||

                (p2.occupiedPos.Contains(7) && p2.occupiedPos.Contains(8) && p2.occupiedPos.Contains(9)) ||

                (p2.occupiedPos.Contains(1) && p2.occupiedPos.Contains(5) && p2.occupiedPos.Contains(9)) ||

                (p2.occupiedPos.Contains(3) && p2.occupiedPos.Contains(5) && p2.occupiedPos.Contains(7))

                )
            {
                Console.WriteLine("Player 2 has won !!!");
                return true;
            }
            else if (IsFull())
            {
                Console.WriteLine("Draw :)"); return true;
            }


            return false;
        }


        private bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameBoard[i, j] == ' ') return false;
                }
            }

            return true;

        }
    }
}
