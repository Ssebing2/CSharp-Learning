using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shop_Supplies
{
    internal class WallTile
    {

        private static void PrintWallTile(int startX, int startY)
        {
            string[] wallTile =
            {
                    "LLLLLLLLLLLLLLLL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "LSSSSSSSSSSSSSSL",
                    "HHHHHHHHHHHHHHHH",
                    "HHHHHHHHHHHHHHHH",
                    "KKKKKKKKKKKKKKKK",
                    "KKKKKKKKKKKKKKKK"
            };

            for (int y = 0; y < wallTile.Length; y++)
            {
                for (int x = 0; x < wallTile[y].Length; x++)
                {
                    char pixel = wallTile[y][x];

                    switch (pixel)
                    {
                        case 'L':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;

                        case 'S':
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;

                        case 'H':
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            break;

                        case 'K':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }

                    Console.SetCursorPosition(startX + x, startY + y);
                    Console.Write(" ");
                }
            }

            Console.ResetColor();
        }
        public static void DrawWall(int startX, int startY)
        {
            int wallWidth = 16;

            for (int x = 0; x < 7; x++)
            {
                PrintWallTile(startX + x * wallWidth, startY);
            }
        }




    }

    
    }
    
