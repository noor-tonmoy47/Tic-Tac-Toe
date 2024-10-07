using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe
{
    internal class Players
    {


        internal List<int> occupiedPos = new List<int> {};
        private string _name { get; set; }

        public string Name { get { return _name; } set { _name = value; }  }

        public Players(string name)
        {
            Name = name;
        }

        private bool checkWithinRange(int pos)
        {
            if (pos < 0 && pos > 3) return false;
            else return true;
        }

        
        internal int Move(Game g, string name)
        {
            Console.Write($"{name}, Enter your move: ");

            Console.WriteLine();

            string playerInput = Console.ReadLine();

            Console.WriteLine();

            int position = Int32.Parse(playerInput);

            Console.WriteLine(position);

            if (checkWithinRange(position) && !g.isOccupied(position))
            {
                occupiedPos.Add(position);
                return position;
            }
            else
            {
                Console.WriteLine("Invalid Move\n");
                return -1;
            }
        }
    }
}
