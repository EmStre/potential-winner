using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Peliluokkia
{
    class Winner
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
            public void KutsuWinner()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                var arr1 = new[]
                {
                    @"         /$$           /$$   /$$                                                 ",
                    @"        | $$    /$$   | $$  |__/                                                 ",
                    @"        | $$   | $$   | $$   /$$   /$$ $$$$$   /$$ $$$$$   /$$$$$$$$   /$$ $$$   ",
                    @"        |  $$  | $$   | $$  | $$  | $$$__/$$  | $$$__/$$  | $$___/$$  | $$$ $$$  ",
                    @"         \  $$ | $$   |$$   | $$  | $$  | $$  | $$  | $$  | $$ /$$$$  | $$\___/  ",
                    @"          \  $$ $$$$  $$    | $$  | $$  | $$  | $$  | $$  | $$|____/  | $$       ",
                    @"           \  $$$\  $$$     | $$  | $$  | $$  | $$  | $$  | $$$$$$$$  | $$       ",
                    @"            \__/  \__/      |__/  |__/  |__/  |__/  |__/  |________/  |__/       ",
                    @"",
                    @"",
                    @"         /$$           /$$   /$$                                                 ",
                    @"        | $$    /$$   | $$  |__/                                                 ",
                    @"        | $$   | $$   | $$   /$$   /$$ $$$$$   /$$ $$$$$   /$$$$$$$$   /$$ $$$   ",
                    @"        |  $$  | $$   | $$  | $$  | $$$__/$$  | $$$__/$$  | $$___/$$  | $$$ $$$  ",
                    @"         \  $$ | $$   |$$   | $$  | $$  | $$  | $$  | $$  | $$ /$$$$  | $$\___/  ",
                    @"          \  $$ $$$$  $$    | $$  | $$  | $$  | $$  | $$  | $$|____/  | $$       ",
                    @"           \  $$$\  $$$     | $$  | $$  | $$  | $$  | $$  | $$$$$$$$  | $$       ",
                    @"            \__/  \__/      |__/  |__/  |__/  |__/  |__/  |________/  |__/       ",
                    @"",
                    @"",
                    @"",
                    @"",
                    @"         ",
                    @"          TYÖRYHMÄ : Emilia Streng, Emma Tuovinen, Otto Forsberg, Aino Rouvinen  ",

            };

                Console.WindowWidth = 160;
                Console.WriteLine("\n\n");
                var maxLength = arr1.Aggregate(0, (max, line) => Math.Max(max, line.Length));
                var x = Console.BufferWidth / 2 - maxLength / 2;
                for (int y = -arr1.Length; y < Console.WindowHeight + arr1.Length; y++)
                {
                    ConsoleDraw(arr1, x, y);
                    Thread.Sleep(70);
                }
                Console.ResetColor();

                Console.WriteLine("Paina enteriä!");
                Console.ReadKey();
            }
        
        //Toimii mainissa tällä kutsulla
        //Winner win = new Winner();
        //win.KutsuWinner();
    }

}
