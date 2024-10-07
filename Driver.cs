using System;
namespace Tic_Tac_Toe
{   

    internal class Driver
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            g.printBoard();
            Console.WriteLine();
            Players p1 = new Players("Player1");
            Players p2 = new Players("Player2");


            Console.WriteLine("Tic-Tac-Toe\n");


            //Game Loop
            while (true)
            {

                int posP1 = -1, posP2 = -1;

                // Player 1 Moves

                while (true)
                { 
                    posP1 = p1.Move(g, p1.Name);
                    
                    if (posP1 != -1)
                    {
                        Console.WriteLine("Player 1 move was successful\n");
                        g.UpdateBoard(posP1, p1);
                        g.printBoard();
                        break;
                    }

                }

                // check win condition

                if (g.IsGameOver(p1, p2)) break;

                //Player 2 Moves
                while (true)
                {
                    posP2 = p2.Move(g, p2.Name);
                   
                    if(posP2 != -1)
                    {
                        Console.WriteLine("Player 2 move was successful\n");
                        g.UpdateBoard(posP2, p2);
                        g.printBoard();
                        break;
                    }
                }

                // check win condition
                if (g.IsGameOver(p1, p2)) break;

            }
        }
    }
}
