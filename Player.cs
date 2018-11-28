using System;

namespace TicTacToe
{
    class Player
    {
        private char marker;
        private bool isHuman;
        public Player()
        {
            marker = 'X';
            isHuman = true;
        }
        public Player(bool inIsHuman)
        {
            isHuman = inIsHuman;
            if (inIsHuman == true)
            {
                marker = 'X';
            }
            else
            {
                marker = 'O';
            }
        }
        public char getMarker()
        {
            return marker;
        }
        public bool getIsHuman()
        {
            if (isHuman == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getPlayerMove()
        {
            Console.Write("Player Move "+"("+marker+")"+":");
            string plaOneMove=Console.ReadLine();
            if(plaOneMove=="A1" || plaOneMove=="A2" || plaOneMove=="A3" || plaOneMove=="B1" ||plaOneMove=="B2" ||plaOneMove=="B3" || plaOneMove=="C1" || plaOneMove=="C2"||plaOneMove=="C3")
            {
                return plaOneMove;
            }  
            else
            {
                Console.WriteLine("Invalid Input: Please enter the column and then row of your move (Example: A1)");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Player Move "+"("+marker+")"+":");
                    string plaOneMove1=Console.ReadLine();
                    if (plaOneMove == "A1" || plaOneMove == "A2" || plaOneMove == "A3" || plaOneMove == "B1" || plaOneMove == "B2" || plaOneMove == "B3" || plaOneMove == "C1" || plaOneMove == "C2" || plaOneMove == "C3")
                    {
                        return plaOneMove1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input: Please enter the column and then row of your move (Example: A1)");
                        return " ";
                    }
                }
                return " ";
            }
        }
        public string getHumanMove()
        {
            Console.Write("Player Move " + marker + ":");
            string plaTwoMove = Console.ReadLine();
            return plaTwoMove;
        }
        /*public string generateComputerMove()
        {
 
        }*/
    }
}
