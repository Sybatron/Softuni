using System;
using System.Linq;

namespace P06BombTheBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[size[0], size[1]];
            var target_bombImpact = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Top and Bottom in the impact of the bomb
            var top = new int[]
            {
                target_bombImpact[0] - target_bombImpact[2], target_bombImpact[1]
            };
            var bottom = new int[]
            {
                target_bombImpact[0] + target_bombImpact[2], target_bombImpact[1]
            };
            var currentLeft = target_bombImpact[1];
            var currentRight = target_bombImpact[1];

            //Exploding until the target
            for (int row = top[0]; row <= target_bombImpact[0]; row++)
            {
                for (int col = currentLeft; col <= currentRight; col++)
                {
                    try
                    {
                        matrix[row, col] = 1;
                        var currentRow = row;
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (matrix[i, col] == 0)
                            {
                                matrix[currentRow, col] = 0;
                                matrix[i, col] = 1;
                                currentRow--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                }

                currentLeft--;
                currentRight++;
            }

            //Explode after the target
            currentLeft += 2;
            currentRight -= 2;
            for (int row = target_bombImpact[0] + 1; row <= bottom[0]; row++)
            {
                for (int col = currentLeft; col <= currentRight; col++)
                {
                    try
                    {
                        matrix[row, col] = 1;
                        var currentRow = row;
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if (matrix[i, col] == 0)
                            {
                                matrix[currentRow, col] = 0;
                                matrix[i, col] = 1;
                                currentRow--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                }

                currentLeft++;
                currentRight--;
            }

            //Output
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }

        }
    }
}
