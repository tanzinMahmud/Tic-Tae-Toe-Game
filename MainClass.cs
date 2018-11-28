using System;

namespace TicTacToe
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Welcome to my Tic-Tac-Toe!");
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine("Please enter the column and then row of your move");
            Console.WriteLine();
            Board b = new Board();
            b.printBoard();
            Player p1 = new Player();
            Player p2 = new Player(false);
            while (b.isWinner(p1.getMarker()) == false && b.isWinner(p2.getMarker()) == false)
            {
                b.submitMove(p1.getPlayerMove(), p1.getMarker());
                b.printBoard();
                if (b.isWinner(p1.getMarker()) == true)
                {
                    Console.WriteLine("Winner is:" + p1.getMarker());
                }
                else
                {
                    b.submitMove(p2.getPlayerMove(), p2.getMarker());
                    b.printBoard();
                    if (b.isWinner(p2.getMarker()) == true)
                    {
                        Console.WriteLine("Winner is:" + p1.getMarker());
                    }
                }
            }
            while (true) ;
        }
    }
}
