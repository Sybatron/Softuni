using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        // Setting
        static int TetrisRows = 20;
        static int TetrisCols = 10;
        static int InfoCols = 10;
        static int ConsoleRows = 1 + TetrisRows + 1;
        static int ConsoleCols = 1 + TetrisCols + 1 + InfoCols + 1;

        // State
        static int score = 0;
        static void Main(string[] args)
        {
            Console.Title = "Tetris v1.0";
            Console.SetWindowSize(ConsoleCols, ConsoleRows);
            Console.SetBufferSize(ConsoleCols, ConsoleRows);
            Console.CursorVisible = false;
            //write("world", 10, 10, consolecolor.yellow);
            //write("niki", 2, 20, consolecolor.darkgreen);
            //write("students", 20, 1, consolecolor.cyan);
            bool result = CheckIfFirstIsgREATER(10, 5);

            while (true)
            {
                score++;

                if (Console.KeyAvailable)
                {

                    var key=Console.ReadKey();
                    if(key.Key==ConsoleKey.Escape)
                    {
                        return;
                    }
                }
                //user input
                //change state

                //Redraw UI
                DrawBorder();
                DrawInfo();
                Thread.Sleep(40);
            }
        }

        static void DrawBorder()
        {
            string line = "╔";
            //for (int i = 0; i < TetrisCols; i++)
            //{
            //    line += "═";
            //}
            line += new string('═', TetrisCols);
            line += "╦";
            //for (int i = 0; i < InfoCols; i++)
            //{
            //    line += "═";
            //}
            line += new string('═', InfoCols);
            line += "╗";
            Console.Write(line);

            for (int i = 0; i < TetrisRows; i++)
            {
                string middleLine = "║";
                middleLine += new string(' ', TetrisCols);
                middleLine += "║";
                middleLine += new string(' ', InfoCols);
                middleLine += "║";
                Console.Write(middleLine);
            }
            string endline = "╚";
            endline += new string('═', TetrisCols);
            endline += "╩";
            endline += new string('═', InfoCols);
            endline += "╝";
            Console.Write(endline);
        }

        static void DrawInfo()
        {
            //Write("Score:", 1, 3 + TetrisCols);
            //Write($"{score}", 2, 3 + TetrisCols);
        }

        static bool CheckIfFirstIsgREATER(int a, int b)
        {
            bool isGreater = a > b;
            return isGreater;
        }

        static void Write(string text, int row, int col, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
