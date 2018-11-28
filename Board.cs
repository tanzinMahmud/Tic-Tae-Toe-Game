using System;

namespace TicTacToe
{
    class Board
    {
        private string[,] gameBoard;
        public Board()
        {
            gameBoard=new string[3 , 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = " ";
                }
            }
        }
        public void printBoard()
        {
            Console.WriteLine("   " + "A" + "  " + "B" + "  " + "C");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i+1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" |"+gameBoard[i, j]);
                }
                Console.Write(" |");
                Console.WriteLine();
            }
        }
        public bool submitMove(string move, char player)
        {
            if (move == "A1" && isMoveValid(move)==true)
            {
                gameBoard[0, 0] = player.ToString();
                return true;
            }
            else if (move == "A2" && isMoveValid(move) == true)
            {
                gameBoard[1, 0] = player.ToString();
                return true;
            }
            else if (move == "A3" && isMoveValid(move) == true)
            {
                gameBoard[2, 0] = player.ToString();
                return true;
            }
            else if (move == "B1" && isMoveValid(move) == true)
            {
                gameBoard[0, 1] = player.ToString();
                return true;
            }
            else if (move == "B2" && isMoveValid(move) == true)
            {
                gameBoard[1, 1] = player.ToString();
                return true;
            }
            else if (move == "B3" && isMoveValid(move) == true)
            {
                gameBoard[2, 1] = player.ToString();
                return true;
            }
            else if (move == "C1" && isMoveValid(move) == true)
            {
                gameBoard[0, 2] = player.ToString();
                return true;
            }
            else if (move == "C2" && isMoveValid(move) == true)
            {
                gameBoard[1, 2] = player.ToString();
                return true;
            }
            else if (move == "C3" && isMoveValid(move) == true)
            {
                gameBoard[2, 2] = player.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isWinner(char player)
        {
            if (gameBoard[0, 0] == player.ToString() && gameBoard[0, 1] == player.ToString() && gameBoard[0, 2] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[1, 0] == player.ToString() && gameBoard[1, 1] == player.ToString() && gameBoard[1, 2] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[2, 0] == player.ToString() && gameBoard[2, 1] == player.ToString() && gameBoard[2, 2] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[0, 0] == player.ToString() && gameBoard[1, 0] == player.ToString() && gameBoard[2, 0] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[0, 1] == player.ToString() && gameBoard[1, 1] == player.ToString() && gameBoard[2, 1] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[0, 2] == player.ToString() && gameBoard[1, 2] == player.ToString() && gameBoard[2, 2] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[0, 0] == player.ToString() && gameBoard[1, 1] == player.ToString() && gameBoard[2, 2] == player.ToString())
            {
                return true;
            }
            else if (gameBoard[0, 2] == player.ToString() && gameBoard[1, 1] == player.ToString() && gameBoard[2, 0] == player.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public bool isTie()
        {
 
        }*/
        public bool isMoveValid(string move)
        {
            if (gameBoard[0, 0] == " ")
            {
                return true;
            }
            else if (gameBoard[1, 0] == " ")
            {
                return true;
            }
            else if (gameBoard[2, 0] == " ")
            {
                return true;
            }
            else if (gameBoard[0, 1] == " ")
            {
                return true;
            }
            else if (gameBoard[1, 1] == " ")
            {
                return true;
            }
            else if (gameBoard[2, 1] == " ")
            {
                return true;
            }
            else if (gameBoard[0, 2] == " ")
            {
                return true;
            }
            else if (gameBoard[1, 2] == " ")
            {
                return true;
            }
            else if (gameBoard[2, 2] == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
