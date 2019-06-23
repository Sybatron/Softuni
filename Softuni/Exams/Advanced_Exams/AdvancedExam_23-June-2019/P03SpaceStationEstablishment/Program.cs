using System;

namespace P03SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = int.Parse(Console.ReadLine());
            var space = new char[side, side];

            int[] sCords = new int[2];
            for (int i = 0; i < side; i++)
            {
                var row = Console.ReadLine().ToCharArray();

                for (int j = 0; j < side; j++)
                {
                    space[i, j] = row[j];
                    if (row[j] == 'S')
                    {
                        sCords[0] = i;
                        sCords[1] = j;
                    }
                }
            }

            var starPower = 0;
            var command = Console.ReadLine();
            while (true)
            {
                try
                {
                    if (command == "up")
                    {
                        space[sCords[0], sCords[1]] = '-';
                        sCords[0]--;
                        NextPlaceActions(ref space, ref sCords, ref starPower);
                    }
                    else if (command == "down")
                    {
                        space[sCords[0], sCords[1]] = '-';
                        sCords[0]++;
                        NextPlaceActions(ref space, ref sCords, ref starPower);
                    }
                    else if (command == "left")
                    {
                        space[sCords[0], sCords[1]] = '-';
                        sCords[1]--;
                        NextPlaceActions(ref space, ref sCords, ref starPower);
                    }
                    else
                    {
                        space[sCords[0], sCords[1]] = '-';
                        sCords[1]++;
                        NextPlaceActions(ref space, ref sCords, ref starPower);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    PrintOutput(side, space, starPower);
                    return;
                }

                if (starPower >= 50)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            PrintOutput(side, space, starPower);
        }

        private static void PrintOutput(int side, char[,] space, int starPower)
        {
            Console.WriteLine($"Star power collected: {starPower}");
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(space[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static void NextPlaceActions(ref char[,] space, ref int[] sCords, ref int starPower)
        {
            if (char.IsDigit(space[sCords[0], sCords[1]]))
            {
                starPower += space[sCords[0], sCords[1]] - '0';
                space[sCords[0], sCords[1]] = 'S';
            }
            else if (space[sCords[0], sCords[1]] == 'O')
            {
                space[sCords[0], sCords[1]] = '-';
                FindBlackHole(sCords[0], sCords[1], ref sCords, space);
            }
        }

        public static void FindBlackHole(int currentX, int currentY, ref int[] blackHoleCords, char[,] space)
        {
            for (int i = 0; i < space.GetLength(0); i++)
            {
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    if (space[i, j] == 'O' &&
                        (i != currentX && j != currentY))
                    {
                        blackHoleCords[0] = i;
                        blackHoleCords[1] = j;
                        space[i, j] = 'S';
                        return;
                    }
                }
            }
        }
    }
}
