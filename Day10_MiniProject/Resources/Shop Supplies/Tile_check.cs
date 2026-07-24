using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP.Shop_Supplies
{
    public static class Tile_check
    {
            static void PrintTile_check(int startX, int startY)
            {
                // 타일 도트 배열
                string[] Tile_check =
                {
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "SSSSSSSSGGGGGGGG",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
                "GGGGGGGGSSSSSSSS",
            };

                // 배열에서 한 줄씩 꺼내기
                for (int y = 0; y < Tile_check.Length; y++)
                {
                    for (int x = 0; x < Tile_check[y].Length; x++)
                    {
                        char pixel = Tile_check[y][x];

                        if (pixel == '.') // 투명 배경
                        {
                            continue;
                        }
                        switch (pixel)
                        {    

                            // 노란색
                            case 'S':
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;

                            // 회색
                            case 'G':
                                Console.BackgroundColor = ConsoleColor.Gray;
                                break;


                            default:
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                        }

                        // 가로 비율을 맞추기 위해 공백 두 칸 출력
                        Console.SetCursorPosition(startX + x , startY + y);
                        Console.Write(" ");
                    }

                    Console.ResetColor();
                }
            }
            public static void DrawFloor(int startX, int startY)
            {
                int tileWidth = 16;
               

                // 가로로 타일 3개 배치
                for (int x = 0; x < 7; x++)
                {
                    PrintTile_check(startX + x * tileWidth, startY );
                }
            }

        
    }
}

