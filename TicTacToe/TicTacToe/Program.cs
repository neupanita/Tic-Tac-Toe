using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            ticTacToe();
        }

        public static void ticTacToe()
        {
            //1 input
            Console.Write("Enter the boardsize from 2 to 10 to play tic-tac-toe ");
            int dimension = int.Parse(Console.ReadLine());

            if (!(dimension >= 2 && dimension <= 10))
            {
                Console.WriteLine("Enter the boardsize from 2 to 10 to play tic-tac-toe");
                dimension = int.Parse(Console.ReadLine());
            }

            //2 select player randomly
            Random rnd = new Random();
            int player = rnd.Next(0, 2);

            //3 play randomly
            int[][] board = new int[dimension][];
            for (int i = 0; i < dimension; i++)
            {
                board[i] = new int[dimension];
            }
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    board[i][j] = -1;
                }
            }

            int totalOptions = dimension * dimension;

            //is board filled check counter 
            int counter = 0;
            while (counter < totalOptions)
            {
                int play = rnd.Next(0, totalOptions + 1);
                int[] pos = mapOnTheBoard(play, dimension);
                int x = pos[0];
                int y = pos[1];
                if (board[x][y] == -1)
                {
                    counter++;
                    board[x][y] = player;
                    ////Console.WriteLine("placing " + player + " at " + x + ", " + y);
                    if (isWinner(board) == 0 || isWinner(board) == 1) break;
                    if (player == 1)
                    {
                        player = 0;
                    }
                    else
                    {
                        player = 1;
                    }
                }
            }

            //Dispaly Winner
            int winner = isWinner(board);
            if (winner == 1)
            {
                Console.WriteLine("Winner is X");
            }
            else if (winner == 0)
            {
                Console.WriteLine("Winner is O");
            }
            else
            {
                Console.WriteLine("Draw");
            }

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (board[i][j] == 0)
                    {
                        Console.Write("O\t");
                    }
                    else if (board[i][j] == 1)
                    {
                        Console.Write("X\t");
                    }
                    else
                    {
                        Console.Write("#\t");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static int[] mapOnTheBoard(int play, int dimension)
        {
            int value = 0;
            int[] pos = new int[2];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (value == play)
                    {
                        pos[0] = i;
                        pos[1] = j;
                    }
                    value++;
                }
            }
            return pos;
        }

        static int isWinner(int[][] board)
        {
            //horizontal check
            for (int i = 0; i < board.Length; i++)
            {
                Boolean checkHorizontal = true;
                for (int j = 0; j < board.Length - 1; j++)
                {
                    if (!(board[i][j] == board[i][j + 1]))
                    {
                        checkHorizontal = false;
                        break;
                    }
                }
                if (checkHorizontal == true)
                {
                    return board[i][0];
                }
            }

            //vertical check

            for (int i = 0; i < board.Length; i++)
            {
                Boolean checkVertical = true;
                for (int j = 0; j < board.Length - 1; j++)
                {
                    if (board[j][i] != board[j + 1][i])
                    {
                        checkVertical = false;
                        break;
                    }
                }
                if (checkVertical == true)
                {
                    return board[0][i];
                }
            }

            //diagonal check

            Boolean check = true;
            for (int i = 0; i < board.Length - 1; i++)
            {
                if (board[i][i] != board[i + 1][i + 1])
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                return board[0][0];

            }

            for (int i = 0; i < board.Length - 1; i++)
            {
                Boolean checkDiagonal = true;
                for (int j = board.Length - 1; j > 0; j--)
                {
                    if (board[i][j] != board[i + 1][j - 1])
                    {
                        checkDiagonal = false;
                        break;
                    }
                }
                if (checkDiagonal == true)
                {
                    return board[0][board.Length - 1];

                }
            }
            return -1;
        }
    }
}
