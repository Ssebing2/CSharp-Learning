using OOP.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shop_Supplies
{
    internal class Chair
    {
     

        public static void PrintChair(int startX, int startY)
        {
            // 번이 캐릭터 도트 배열
            string[] Chair =
            {
                "................................",
                "................................",
                "................................",
                ".........HHKKKKKKKKKKHH.........",
                "........HSSHKDDDDDDKHSSH........",
                "........HSSDDRRRRRRDDSWH........",
                "........HSSDRDDDDDDRDSWH........",
                "........HSSDDDDDDDDDDSWH........",
                "........HWSDDRDDDDRDDSSH........",
                "........HWSDDDRRRRDDDSSH........",
                "........HSSHKKKKKKKKHSSH........",
                "........DDDDDDDDDDDDDDDD........",
                ".......DDRDDDDDDDDDDDDRD........",
                "......DDDRDDWDDDDDWWDDRDD.......",
                "......DDRDDDWDDDDDDDWWDRDD......",
                ".....DDRDDDDDDDDDDDDDDDDRD......",
                ".....DDRRRRRRRRRRRRRRRRRDD......",
                ".....DDDDDDDDDDDDDDDDDDDDD......",
                ".....DDDDDDDDDDDDDDDDDDDDD......",
                ".....HWSHKKKKKKKKKKKKKHSSH......",
                ".....HWSHHHHHHHHHHHHHHHSWH......",
                ".....HSSSSSSSSSSSSSSSSSSWH......",
                ".....HSSHHHHHHHHHHHHHHHSSH......",
                ".....HSWHKKKKKKKKKKKKKHWSH......",
                ".....HSSHKKKKKKKKKKKKKHSSH......",
                "......HH...............HH.......",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",
                "................................",


            };

            for (int y = 0; y < Chair.Length; y++)
            {

                for (int x = 0; x < Chair[y].Length; x++)
                {
                    char pixel = Chair[y][x];

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

                        // 흰색
                        case 'W':
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                        // 빨간색
                        case 'R':
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;

                        // 진한빨간색
                        case 'D':
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
    
