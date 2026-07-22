using OOP.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerDream.Resources.Character
{
    internal class SmallBun
    {
        public static void PrintsmallBun(int startX, int startY)
        {
            // 번이 캐릭터 도트 배열
            string[] smallbun =
            {
                "................................",
                "................................",
                "..........KKKKKKKKKKKK..........",
                "..........RRRRRRRRRRRR..........",
                "........KKKKKKKKKKKKKKKK........",
                "........RRRRRRYYYYRRRRRR........",
                ".......RRRRRRYYYYYYRRRRRR.......",
                ".......RRRRRRRGGGGRRRRRRR.......",
                ".......RRRRRRYYYYYYRRRRRR.......",
                "......RRRRRRRRRRRRRRRRRRRK......",
                "......RRRRRRRRRRRRRRRRRRRK......",
                ".....DDDHHHDDDDDDDDRRHHHRRK.....",
                ".....KKHHHKKKKKKKKKKKKHHHKK.....",
                ".......HHHSSSSSSSSSSSSHHH.......",
                ".......HHKSSSSSSSSSSSSKHH.......",
                ".......HHTSSWKSSSSWKSSTHH.......",
                ".......HHTSSKKSSSSKKSSTHH.......",
                ".......HHKPSSSSSSSSSSPKHH.......",
                ".......HHHSSSSSKKSSSSSHHH.......",
                "..........KKKKTTTTKKKK..........",
             
            };

            // 배열에서 한 줄씩 꺼내기
            for (int y = 0; y < smallbun.Length; y++)
            {

                for (int x = 0; x < smallbun[y].Length; x++)
                {
                    char pixel = smallbun[y][x];

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
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
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
                    
                    Console.SetCursorPosition(startX + x, startY + y);
                    Console.Write(" ");
                }

                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}

