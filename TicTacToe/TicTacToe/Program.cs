using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    internal class Program
    {
        static bool player1Turn = true;
        static int counterPlayer1Win = 0;
        static int counterPlayer2Win = 0;

        static string[,] board =
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };

        static void Main(string[] args)
        {

            startMenu();
            
        }

        private static void boardDraw()
        {
            Console.Clear();
            Console.WriteLine("     |      |      ");
            Console.WriteLine($"  {board[0,0]}  |   {board[0,1]}  |   {board[0,2]}  ");
            Console.WriteLine("     |      |      ");
            Console.WriteLine("-------------------");
            Console.WriteLine("     |      |      ");
            Console.WriteLine($"  {board[1, 0]}  |   {board[1, 1]}  |   {board[1, 2]}  ");
            Console.WriteLine("     |      |      ");
            Console.WriteLine("-------------------");
            Console.WriteLine("     |      |      ");
            Console.WriteLine($"  {board[2, 0]}  |   {board[2, 1]}  |   {board[2, 2]}  ");
            Console.WriteLine("     |      |      ");

            Console.WriteLine($"Player 1 score : {counterPlayer1Win}  |  Player 2 score : {counterPlayer2Win}");

            startGame();
        }

        private static void startMenu()
        {
            Console.Clear();
            Console.WriteLine("|    Welcome to TicTacToe   |");
            Console.WriteLine("|  Press 1 to play the game |");
            Console.WriteLine("|      Press 2 to exit      |");

            Console.WriteLine(" -> Choose option : ");

            string? input = Console.ReadLine();

            if(input == "1")
            {
                boardDraw();
            }
            if(input == "2")
            {
                Environment.Exit(0);
            }

            if(input != "1" && input != "2")
            {
                Console.WriteLine("This option doesn't exist!");
                Thread.Sleep(1000);
                startMenu();
            }
 
        }

        private static void startGame()
        {
            if (IsBoardFull())
            {
                Console.Clear();
                Console.WriteLine("*** It's a tie! ***");
                Thread.Sleep(3000);

                Console.Clear();
                Console.WriteLine("-> Do you want to play again? y/n ");
                string? input2 = Console.ReadLine();

                switch (input2)
                {
                    case "y":
                        ResetBoard();
                        boardDraw();
                        break;
                    case "n":
                        counterPlayer1Win = 0;
                        counterPlayer2Win = 0;
                        ResetBoard();
                        startMenu();
                        break;
                }
            }

            if (checkWiner(board) == true)
            {
                Console.Clear();
                if(player1Turn == true)
                {
                    Console.WriteLine("*** Player 2 Win ! ***");
                    counterPlayer2Win++;
                }
                else
                {
                    Console.WriteLine("*** PLayer 1 Win ! ***");
                    counterPlayer1Win++;
                }

                Thread.Sleep(3000);

                Console.Clear();
                Console.WriteLine("-> You want to play again? y/n ");
                string? input2 = Console.ReadLine();

                switch (input2)
                {
                    case "y":
                        ResetBoard();
                        boardDraw(); 
                        break;
                    case "n":
                        counterPlayer1Win = 0;
                        counterPlayer2Win = 0;
                        ResetBoard();
                        startMenu();
                        break;
                }
            }

            string? input;
            string player1 = "X";
            string player2 = "O";

            if (player1Turn)
            {
                
                Console.WriteLine("-> Player 1 - Choose your field : ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        if (board[0, 0] == player1 || board[0, 0] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[0, 0] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "2":
                        if (board[0, 1] == player1 || board[0, 1] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[0, 1] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "3":
                        if (board[0, 2] == player1 || board[0, 2] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[0, 2] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "4":
                        if (board[1, 0] == player1 || board[1, 0] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[1, 0] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "5":
                        if (board[1, 1] == player1 || board[1, 1] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[1, 1] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "6":
                        if (board[1, 2] == player1 || board[1, 2] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[1, 2] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "7":
                        if (board[2, 0] == player1 || board[2, 0] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[2, 0] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "8":
                        if (board[2, 1] == player1 || board[2, 1] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[2, 1] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    case "9":
                        if (board[2, 2] == player1 || board[2, 2] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[2, 2] = player1;
                            player1Turn = false;
                            boardDraw();
                        }
                        break;
                    default:
                        Console.WriteLine($"{input} Is not a position!");
                        Console.WriteLine("Enter a position");
                        Thread.Sleep(1000);
                        boardDraw();
                        break;

                }
            }
            else
            {
                Console.WriteLine("-> Player 2 - Choose your field : ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        if (board[0, 0] == player1 || board[0, 0] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[0, 0] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "2":
                        if (board[0, 1] == player1 || board[0, 1] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[0, 1] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "3":
                        if (board[0, 2] == player1 || board[0, 2] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[0, 2] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "4":
                        if (board[1, 0] == player1 || board[1, 0] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[1, 0] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "5":
                        if (board[1, 1] == player1 || board[1, 1] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[1, 1] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "6":
                        if (board[1, 2] == player1 || board[1, 2] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[1, 2] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "7":
                        if (board[2, 0] == player1 || board[2, 0] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[2, 0] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "8":
                        if (board[2, 1] == player1 || board[2, 1] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[2, 1] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    case "9":
                        if (board[2, 2] == player1 || board[2, 2] == player2)
                        {
                            Console.WriteLine("This position is already taken!");
                            Thread.Sleep(1000);
                            boardDraw();
                        }
                        else
                        {
                            board[2, 2] = player2;
                            player1Turn = true;
                            boardDraw();
                        }
                        break;
                    default:
                        Console.WriteLine($"{input} Is not a position!");
                        Console.WriteLine("Enter a position");
                        Thread.Sleep(1000);
                        boardDraw();
                        break;

                }
            }


        }

        private static bool checkWiner(string[,] board)
        {
            for(int i = 0; i < 3; i++)
            {
                if (board[i,0] == board[i,1] && board[i,1] == board[i,2])
                {
                    return true;
                }
                if (board[0,i] == board[1,i] && board[1,i] == board[2,i])
                {
                    return true;
                }
            }

            if (board[0,0] == board[1,1] && board[1,1] == board[2,2])
            {
                return true;
            }

            if (board[0,2] == board[1,1] && board[1,1] == board[2,2])
            {
                return true;
            }

            return false;
        }

        private static void ResetBoard()
        {
           
            board = new string[,]
            {
                {"1","2","3"},
                {"4","5","6"},
                {"7","8","9"}
            };

            player1Turn = true;
        }
        private static bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != "X" && board[i, j] != "O")
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }
    }
}