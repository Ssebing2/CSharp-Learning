using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Character
{
    internal class Cone
    {
    
        public static void PrintCone(int startX, int startY)
        {
            // 번이 캐릭터 도트 배열
            string[] Cone =
            {
                "................................",
                "................................",
                "................................",
                "...............RR...............",
                ".............BBBBCC.............",
                "............BBBBBCCC............",
                "..........RBBBBBBBCCCC..........",
                ".........RBBBBBBBBBCCCC.........",
                ".........RRBRRRRRBBCCCC.........",
                ".........RRRRHHHHHHHCCC.........",
                "........RRHHHHSHHSHHHHH.........",
                ".........HHHSSSSHSSSHHH.........",
                "........HSSHSWKSSWKSGSS.........",
                "........HSSHSKKSSKKSHSS.........",
                ".........SSSSKKSSKKSSSS.........",
                "..........HSPSSKKSSPSH..........",
                "...........HSSSSSSSSH...........",
                ".............BBSSBB.............",
                "............BWWHHWWB............",
                "...........BBWHHHHWBB...........",
                "...........SSWGGGGWSS...........",
                "..........SSSWWHHWWSSS..........",
                "..........SSKWWWWWWKSS..........",
                "..........SSKBBBBBBKSS..........",
                ".............BBBBBB.............",
                ".............BBTTBB.............",
                ".............SSKKSS.............",
                ".............BWKKWB.............",
                "............RRRKKRRR............",
                "............WWWKKWWW............",
                "................................",
                "................................",
            };

            for (int y = 0; y < Cone.Length; y++)
            {

                for (int x = 0; x < Cone[y].Length; x++)
                {
                    char pixel = Cone[y][x];

                    if (pixel == '.')
                    {
                        continue;
                    }

                    switch (pixel)
                    {
                        // 투명 배경
                        case '.':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 검은색 외곽선
                        case 'K':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 파란색
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;

                        // 진한 파란색
                        case 'B':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;

                        // 피부색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 머리카락
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 녹색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 볼터치
                        case 'P':
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            break;

                        // 모자
                        case 'C':
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }

                    Console.SetCursorPosition(startX + x, startY + y);
                    Console.Write(" ");
                }

                Console.ResetColor();
                Console.WriteLine();






            }



        }


    }
}
