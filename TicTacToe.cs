using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{

    class Program
    {
        static void Main(string[] args)
        {
            // n = 3;
            // check if it is outside the matrix and if there isn't X or O

            Console.WriteLine("Let's start our 'Tic Tac Toe' game!");
            Console.WriteLine("You can mark the place by its row and column");
            Console.WriteLine("Rows and columns must be integers between indexes 0 and 2");

            int n = 3;
            char[,] field = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = '-';
                }
            }
            Console.WriteLine();
            Console.WriteLine("Field:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int rowGame = 0;
            int colGame = 0;
            int count = 0;

            while (true)
            {
                if ((field[0, 0] != '-' && field[0, 1] != '-' && field[0, 2] != '-') && (field[1, 0] != '-' && field[1, 1] != '-' && field[1, 2] != '-') && (field[2, 0] != '-' && field[2, 1] != '-' && field[2, 2] != '-'))
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    Console.WriteLine("The FIRST player with 'X' char has a turn");
                    Console.Write("Enter row:");
                    rowGame = int.Parse(Console.ReadLine());
                    Console.Write("Enter col:");
                    colGame = int.Parse(Console.ReadLine());

                }
                if (count % 2 != 0)
                {
                    Console.WriteLine("The SECOND player with 'O' char has a turn");
                    Console.Write("Enter row:");
                    rowGame = int.Parse(Console.ReadLine());
                    Console.Write("Enter col:");
                    colGame = int.Parse(Console.ReadLine());

                }
                if ((rowGame >= 0 && rowGame < n) && (colGame >= 0 && colGame < n))
                {
                    switch (count)
                    {
                        case 0:
                            if (field[rowGame, colGame] != 'X' && field[rowGame, colGame] != 'O')
                            {
                                field[rowGame, colGame] = 'X';
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Field:");

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        Console.Write(field[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Invalid row or col!!!");
                                Console.WriteLine("Try again!");
                                Console.WriteLine();
                                continue;
                            }
                            break;


                        case 2:
                            if (field[rowGame, colGame] != 'X' && field[rowGame, colGame] != 'O')
                            {
                                field[rowGame, colGame] = 'X';
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Field:");

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        Console.Write(field[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();

                                Console.WriteLine("Invalid row or col!!!");
                                Console.WriteLine("Try again!");
                                Console.WriteLine();
                                continue;
                            }
                            break;


                        case 4:
                            if (field[rowGame, colGame] != 'X' && field[rowGame, colGame] != 'O')
                            {
                                field[rowGame, colGame] = 'X';
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Field:");

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        Console.Write(field[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();

                                Console.WriteLine("Invalid row or col!!!");
                                Console.WriteLine("Try again!");
                                Console.WriteLine();
                                continue;
                            }
                            break;


                        case 6:
                            if (field[rowGame, colGame] != 'X' && field[rowGame, colGame] != 'O')
                            {
                                field[rowGame, colGame] = 'X';
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Field:");

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        Console.Write(field[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();

                                Console.WriteLine("Invalid row or col!!!");
                                Console.WriteLine("Try again!");
                                Console.WriteLine();
                                continue;
                            }
                            break;


                        case 8:
                            if (field[rowGame, colGame] != 'X' && field[rowGame, colGame] != 'O')
                            {
                                field[rowGame, colGame] = 'X';
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Field:");

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        Console.Write(field[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();

                                Console.WriteLine("Invalid row or col!!!");
                                Console.WriteLine("Try again!");
                                Console.WriteLine();
                                continue;
                            }
                            break;


                        default:
                            if (field[rowGame, colGame] != 'X' && field[rowGame, colGame] != 'O')
                            {
                                field[rowGame, colGame] = 'O';
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Field:");

                                for (int i = 0; i < n; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        Console.Write(field[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();

                                Console.WriteLine("Invalid row or col!!!");
                                Console.WriteLine("Try again!");
                                Console.WriteLine();
                                continue;
                            }
                            break;


                    }


                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Invalid row or col!!!");
                    Console.WriteLine("Try again!");
                    Console.WriteLine();
                    continue;


                }

                if (field[0, 0] == 'X' && field[0, 1] == 'X' && field[0, 2] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[1, 0] == 'X' && field[1, 1] == 'X' && field[1, 2] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[2, 0] == 'X' && field[2, 1] == 'X' && field[2, 2] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 0] == 'X' && field[1, 0] == 'X' && field[2, 0] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 1] == 'X' && field[1, 1] == 'X' && field[2, 1] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 2] == 'X' && field[1, 2] == 'X' && field[2, 2] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 0] == 'X' && field[1, 1] == 'X' && field[2, 2] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 2] == 'X' && field[1, 1] == 'X' && field[2, 0] == 'X')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The first player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 0] == 'O' && field[0, 1] == 'O' && field[0, 2] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[1, 0] == 'O' && field[1, 1] == 'O' && field[1, 2] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[2, 0] == 'O' && field[2, 1] == 'O' && field[2, 2] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 0] == 'O' && field[1, 0] == 'O' && field[2, 0] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 1] == 'O' && field[1, 1] == 'O' && field[2, 1] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 2] == 'O' && field[1, 2] == 'O' && field[2, 2] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 0] == 'O' && field[1, 1] == 'O' && field[2, 2] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }
                else if (field[0, 2] == 'O' && field[1, 1] == 'O' && field[2, 0] == 'O')
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations!");
                    Console.WriteLine("The second player is the WINNER!");
                    Console.WriteLine();
                    Console.WriteLine("Field:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                }


                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(field[i, j] + " ");
                    }
                    Console.WriteLine();
                }


                count++;
            }

            if (count == 9)
            {
                Console.WriteLine();
                Console.WriteLine("It's a draw! Try again! ");
            }


        }
    }
}