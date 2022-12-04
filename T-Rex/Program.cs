using System;
using System.Threading;
//using System.Text;
namespace T_Rex
{
    class Program
    {
        static string[] cloudArray = { "   ≈≈≈≈                      ≈≈≈≈≈≈≈    ≈≈≈≈                              ≈≈≈≈≈      ",
                                       "  ≈≈≈≈≈≈≈≈≈≈             ≈≈ ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈          ≈≈≈           ≈≈≈≈≈≈≈≈≈≈≈  ",
                                       "≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈       ≈≈≈≈≈≈≈≈≈  ≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈       ≈≈≈≈≈≈≈≈                    " };
        static int backgroundY = Console.WindowHeight / 2 - 11;

        static void DrawCloudColumn(int col)
        {
            int x = Console.WindowWidth - 2;
            int y = backgroundY;
            for(int i = 0; i < cloudArray.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(cloudArray[i][col]);
            }
        }
        
        static void Jump()
        {
            Console.SetCursorPosition(2, Console.WindowHeight - 5);
            Console.Write("    ");
            Console.SetCursorPosition(2, Console.WindowHeight - 6);
            Console.Write("    ");
            Console.SetCursorPosition(3, Console.WindowHeight - 7);
            Console.Write(" ");

            Console.SetCursorPosition(2, Console.WindowHeight - 6);
            Console.Write("| |");
            Console.SetCursorPosition(2, Console.WindowHeight - 7);
            Console.Write("/╥\\");
            Console.SetCursorPosition(3, Console.WindowHeight - 8);
            Console.Write("σ");

            Thread.Sleep(200);

            Console.SetCursorPosition(2, Console.WindowHeight - 6);
            Console.Write("    ");
            Console.SetCursorPosition(2, Console.WindowHeight - 7);
            Console.Write("    ");
            Console.SetCursorPosition(3, Console.WindowHeight - 8);
            Console.Write("  ");

            Console.SetCursorPosition(2, Console.WindowHeight - 5);
            Console.Write("/ \\");
            Console.SetCursorPosition(2, Console.WindowHeight - 6);
            Console.Write("/╥\\");
            Console.SetCursorPosition(3, Console.WindowHeight - 7);
            Console.Write("σ");
        }

        static void MoveBackground()
        {
            Console.MoveBufferArea(2, backgroundY, Console.WindowWidth - 3, cloudArray.Length, 1, backgroundY);
        }
            
        static void Main(string[] args)
        { 
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetWindowSize(180, 40);
            Console.CursorLeft = Console.WindowWidth / 2 - 10;
            DrawFrame();
            Console.SetCursorPosition(Console.WindowWidth-10, 1);
            Console.Write("score:000");
            //line
            Console.SetCursorPosition(1, Console.WindowHeight - 5);
            for (int i = 0; i < Console.WindowWidth - 2; i++)
            {
                Console.Write("_");
            }
            //sprite
            int spriteStartX = 2;
            int spriteStartY = Console.WindowHeight - 5;
            Console.SetCursorPosition(spriteStartX, spriteStartY);
            //Console.Write(" Ω ");
            //Console.Write("/ \\");
            Console.SetCursorPosition(spriteStartX, spriteStartY-1);
            Console.Write("/╥\\");
            Console.SetCursorPosition(spriteStartX, spriteStartY-2);
            Console.Write(" σ  ");

                

            //Console.SetCursorPosition(15, Console.WindowHeight/2);
            //Console.WriteLine("           ████████ ");
            //Console.WriteLine("          ███▄███████");
            //Console.WriteLine("          ███████████");
            //Console.WriteLine("          ███████████");
            //Console.WriteLine("          ██████ ");
            //Console.WriteLine("          █████████ ");
            //Console.WriteLine("█        ███████ ");
            //Console.WriteLine("██    ████████████ ");
            //Console.WriteLine("███   ██████████ █ ");
            //Console.WriteLine("███████████████  ");
            //Console.WriteLine("███████████████ ");
            //Console.WriteLine(" █████████████ ");
            //Console.WriteLine("  ███████████ ");
            //Console.WriteLine("    ████████ ");
            //Console.WriteLine("     ███  ██ ");
            //Console.WriteLine("     ██   █");
            //Console.WriteLine("     █    █");
            //Console.WriteLine("     ██   ██");

            // initialize cloud column
            int col = 0;
            

            while (true)
            {
                //var ch = Console.ReadKey(false).Key;
                //if (ch == ConsoleKey.UpArrow)
                //{
                //    Jump();
                //}

                //Clouds animation
                //iterate cloud column
                col++;
                col = col % cloudArray[0].Length;
                // draw cloud column
                DrawCloudColumn(col);
                // Move background
                MoveBackground();

                if (col % 2 == 0)
                {
                    Console.SetCursorPosition(spriteStartX, spriteStartY);
                    Console.Write(" ┘\\ ");
                    

                }
                else
                {
                    Console.SetCursorPosition(spriteStartX, spriteStartY);
                    Console.Write(" /┘ ");
                    

                }
                Thread.Sleep(300);
            }

        }

        private static void DrawFrame()
        {
            //frame
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.Write("╔");
            for (int i = 1; i < Console.WindowWidth - 1; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╗");
            Console.CursorLeft = 0;
            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                Console.Write("║");
                Console.CursorLeft = Console.WindowWidth - 1;
                Console.WriteLine("║");
                Console.CursorLeft = 0;
            }
            Console.Write("╚");
            for (int i = 1; i < Console.WindowWidth - 1; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
        }
    }
}
