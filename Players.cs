using System;
using System.Collections.Generic;
using System.Xml.Linq;

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


        private int getInput(string name)
        {
            Console.Write($"{name}, Enter your move: ");

            Console.WriteLine();

            string playerInput = Console.ReadLine();

            int position = -1;

                //int position = Int32.Parse(playerInput);
            try
            {

                position = Int32.Parse(playerInput);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("Please Input a number between (1-9)");
            }
            Console.WriteLine();
            return position;
        }
        
        internal int Move(Game g, string name)
        {

            int position = getInput(name);

            if (position < 0) {
                Console.WriteLine("Invalid Move\n");
                return -1;
            }
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
