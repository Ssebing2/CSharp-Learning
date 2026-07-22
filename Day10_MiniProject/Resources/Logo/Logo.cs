using OOP.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Logo
{
    internal class Logo
    {
       

        public static void PrintLogo(int startX, int startY)
        {
            string[] Logo =
            {
                "................................",
                "................................",
                "................................",
                ".............RRRRRR.............",
                "...........RRHSHSHHRR...........",
                ".........RRRHHHHHHSHRRR.........",
                ".........RRHHSHSHSHHHRRR........",
                ".......RRRGTHHHHHHHHTGRRR.......",
                ".......RRHGGGGGGGGGGGGHRRR......",
                "......RRHWRRRGGGGGGRRRWHRRR.....",
                ".....RRHHWHHHRRRRRRHHHWHHRR.....",
                ".....RRHWWWHHHHHHHHHHWWWHRR.....",
                ".....RRHWWWWWWWWWWWWWWWWHRR.....",
                ".....RHWWWHHHHHHHHHHHWWWWHR.....",
                ".....RHWWWHRRRRRRRRRHWWWWHR.....",
                ".....RHRRWHHRRHHHHRRHWRRWHR.....",
                ".....RHWWWWHRRHWWHRRHWWWWHR.....",
                ".....RHRWWWHRRRRRRRHHWWRWHR.....",
                ".....RHWWWWHRRHWWHRRHWWWHHR.....",
                "..HHHRRHWWHHRRHHHHRRHWWWHRRHHH..",
                "..HRRHHHHWRRRRRRRRRRHWWHHHHRRH..",
                "....RRRHHHHHHHHHHHHHHHHHRRRR....",
                "...RHHRRRRRRRRRRRRRRRRRRHRHRR...",
                "..HRHRHRRHHRRHHRRHHRRHRRHHHRRH..",
                "..HRHHRRRHRHRHRHRHRRHRHRHRHRRH..",
                "...RHRHRRHRHRHHRRHHRHRHRHRHRR...",
                "..HRHHRRRHRHRHRHRHRRHHHRHRHRH...",
                "....RRRHRHHRRHRHRHHRHRHRRRR.....",
                "....HHHRRRRRRRRRRRRRRRRRKHH.....",
                "..........HHHHHHHHHHH...........",
                "............RRRRRRR.............",
                "................................",
     
            };

            for (int y = 0; y < Logo.Length; y++)
            {

                for (int x = 0; x < Logo[y].Length; x++)
                {
                    char pixel = Logo[y][x];

                    if (pixel == '.')
                    {
                        continue;
                    }
                    switch (pixel)
                    {

                        // 검은색 외곽선
                        case 'K':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 노란색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 진한노랑
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 녹색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;

                        // 진한 녹색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }

                    Console.SetCursorPosition(startX + x, startY + y);
                    Console.Write(" ");
                }

                Console.ResetColor();






            }
        }

    }
}
    
