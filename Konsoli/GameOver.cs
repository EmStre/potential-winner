using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Konsoli
{
    public class GameOver
    {
        static void ConsoleDraw(IEnumerable<string> lines, int x, int y)
        {
            if (x > Console.WindowWidth) return;
            if (y > Console.WindowHeight) return;

            var trimLeft = x < 0 ? -x : 0;
            int index = y;

            x = x < 0 ? 0 : x;
            y = y < 0 ? 0 : y;

            var linesToPrint =
                from line in lines
                let currentIndex = index++
                where currentIndex > 0 && currentIndex < Console.WindowHeight
                select new
                {
                    Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x, line.Length - trimLeft)).ToArray()),
                    X = x,
                    Y = y++
                };

            Console.Clear();
            foreach (var line in linesToPrint)
            {
                Console.SetCursorPosition(line.X, line.Y);
                Console.Write(line.Text);
            }
        }
        public static void KutsuGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var arr1 = new[]
            {
                    @"  _______________________________________________________________  ",
                    @"  |                                                             |  ",
                    @"  | | ========================================================| |  ",
                    @"  | |                                                         | |  ",
                    @"  | |      00000        00        000        000   00000000   | |                                                 ",
                    @"  | |    00     00      00        00 000  000 00   00         | |                                                 ",
                    @"  | |    00     00     0000       00    00    00   00         | |  /$$$$$$$$  \ $$     $$$   /$$$$$$$$   /$$ $$$  ",
                    @"  | |    00           00  00      00    00    00   00         | | | $$___/$$   \ $$    $$   | $$___/$$  | $$$ $$$ ",
                    @"  | |    00   0000   00    00     00    00    00   000000     | | | $$  | $$    \ $$   $$   | $$ /$$$$  | $$      ",
                    @"  | |    00     00  0000000000    00    00    00   00         | | | $$  | $$     \ $$ $$    | $$|____/  | $$      ",
                    @"  | |     0000000  000      000   00    00    00   00000000   | | | $$$$$$$$      \ $$$     | $$$$$$$$  | $$      ",
                    @"  | |                                                         | | |________/       |__/     |________/  |__/      ",
                    @"  | | ========================================================| |  ",
                    @"  |_____________________________________________________________|  ",
                    @"",
                    @"",
                    @"         ",
                    @"    TYÖRYHMÄ : Emilia Streng, Emma Tuovinen, Otto Forsberg, Aino Rouvinen  ",

            };

            Console.WindowWidth = 160;
            Console.WriteLine("\n\n");
            var maxLength = arr1.Aggregate(0, (max, line) => Math.Max(max, line.Length));
            var x = Console.BufferWidth / 2 - maxLength / 2;
            for (int y = -arr1.Length; y < Console.WindowHeight + arr1.Length; y++)
            {
                ConsoleDraw(arr1, x, y);
                Thread.Sleep(100);
            }
            Console.ResetColor();
            Console.WriteLine("\tPaina enteriä!");
            Console.ReadKey();
        }
    }
    //Toimii mainissa tällä kutsulla
    //GameOver gOver = new gOver();
    //gOver.KutsuGameOver();
}
