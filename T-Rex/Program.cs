using System;
using System.Threading;
//using System.Text;
namespace T_Rex
{
    class Program
    {
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
            Console.Write(" ");

            Console.SetCursorPosition(2, Console.WindowHeight - 5);
            Console.Write("/ \\");
            Console.SetCursorPosition(2, Console.WindowHeight - 6);
            Console.Write("/╥\\");
            Console.SetCursorPosition(3, Console.WindowHeight - 7);
            Console.Write("σ");
            //Console.SetCursorPosition(3, Console.WindowHeight - 5);
            Console.MoveBufferArea(0, 0, Console.BufferWidth, Console.BufferHeight, 20, 20);
        }
            
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetWindowSize(180, 40);
            Console.CursorLeft = Console.WindowWidth / 2 - 10;
            //string odgovor = Console.ReadLine();
            //Console.Clear();
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
            Console.SetCursorPosition(1, Console.WindowHeight - 5);
            for(int i = 0; i < Console.WindowWidth-2; i++)
            {
                Console.Write("_");
            }
            //Console.SetCursorPosition(3, Console.WindowHeight - 5);
            //Console.WriteLine("\u2745");
            Console.SetCursorPosition(2, Console.WindowHeight - 5);
            Console.Write("/ \\");
            Console.SetCursorPosition(2, Console.WindowHeight - 6);
            Console.Write("/╥\\");
            Console.SetCursorPosition(3, Console.WindowHeight - 7);
            Console.Write("σ");
            //Console.SetCursorPosition(3, Console.WindowHeight - 5);

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

            Console.SetCursorPosition(Console.WindowWidth - 15, (Console.WindowHeight / 2) - 11);
            Console.WriteLine("  ≈≈≈≈  ");
            Console.SetCursorPosition(Console.WindowWidth - 15, (Console.WindowHeight / 2) - 10);
            Console.WriteLine(" ≈≈≈≈≈≈≈≈≈≈");
            Console.SetCursorPosition(Console.WindowWidth - 15, (Console.WindowHeight / 2) - 9);
            Console.WriteLine("≈≈≈≈≈≈≈≈≈≈≈≈");

            while (true)
            {
                var ch = Console.ReadKey(false).Key;
                if (ch == ConsoleKey.UpArrow)
                {
                    Jump();
                }
                
            }


            while (true) { };
        }
    }
}
