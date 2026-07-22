using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Character
{
    internal class Cheese
    {
       
        public static void PrintCheese(int startX, int startY)
        {
            // 번이 캐릭터 도트 배열
            string[] cheese =
            {
                
                ".............RRRRRR.............",
                "............RRYYYYRR............",
                "...........RRYYYYYYRR...........",
                "..........RRRRGGGGRRRR..........",
                "..........RRRYYYYYYRRR..........",
                ".........RRRRRRRRRRRRRR.........",
                ".........RRRDDDDDDDDRRR.........",
                "..........HDRRHHHHHHDH..........",
                "..........HHHSSSSSHHHH..........",
                "..........HHSWKSSWKSHHH.........",
                ".........HSHSKKSSKKSHSHH........",
                ".........HSHPKKSSKKPHSHH........",
                ".........HHHPSSKKSSPHHH.........",
                "..........HHSSSSSSSSHH..........",
                "............RHRWWRHR............",
                "..........RRRSRRRRSRRR..........",
                "..........RRRSSSSSSRRR..........",
                "..........SSRSSSSSSRSS..........",
                "..........SSKSHHHHSKSS..........",
                "..........SSKSHHHHSKSS..........",
                "............SSSSSSSS............",
                ".............BBKKBB.............",
                ".............BBKKBB.............",
                ".............WWKKWW.............",
                "............WWWKKWWW............",               
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
            };

            for (int y = 0; y < cheese.Length; y++)
            {
                for (int x = 0; x < cheese[y].Length; x++)
                {
                    char pixel = cheese[y][x];

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

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        // 어두운 빨간색
                        case 'D':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;

                        // 노란색
                        case 'Y':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 주황색
                        case 'O':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        // 피부색
                        case 'S':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        // 피부 그림자
                        case 'T':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;

                        // 머리카락
                        case 'H':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;

                        // 바지
                        case 'B':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            break;

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 초록색
                        case 'G':
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;

                        // 볼터치
                        case 'P':
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            break;

                        default:
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }

                    // 가로 비율을 맞추기 위해 공백 두 칸 출력
                    Console.SetCursorPosition(startX + x, startY + y);
                    Console.Write(" "); ;
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }

}


    

   