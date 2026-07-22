using BurgerDream.Resources.Character;
using OOP.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BurgerDream.Game
{
  
     class GameTool // 게임 전체 관리자
    {
        private int _x;
        private int _y;

        public GameTool(int x, int y)
        {
            _x = x;
            _y = y;
        }
        
        

        public static void ShowTitleA() // 게임 타이틀화면
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetCursorPosition(10, 1);
            int centerx = 10;
            int y = 1;

            void PrintCenter(string text, int yPos) // 가운데 정렬
            {
                int realLength = 0;

                foreach (char c in text)
                {
                    if (c >= '가' && c <= '힣')
                    {
                        realLength += 2;
                    }

                    else
                    {
                        realLength += 1;
                    }
                }
                Console.SetCursorPosition(centerx , yPos);
                Console.Write(text);
            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
                PrintCenter("███████████  █████  █████ ███████████     █████████  ██████████ ███████████", y);
                PrintCenter("░███░░░░░███░░███  ░░███ ░░███░░░░░███   ███░░░░░███░░███░░░░░█░░███░░░░░███", y + 1);
                PrintCenter("░███    ░███ ░███   ░███  ░███    ░███  ███     ░░░  ░███  █ ░  ░███    ░███", y + 2);
                PrintCenter("░██████████  ░███   ░███  ░██████████  ░███          ░██████    ░██████████", y + 3);
                PrintCenter("░███░░░░░███ ░███   ░███  ░███░░░░░███ ░███    █████ ░███░░█    ░███░░░░░███", y + 4);
                PrintCenter("░███    ░███ ░███   ░███  ░███    ░███ ░░███  ░░███  ░███ ░   █ ░███    ░███", y + 5);
                PrintCenter("███████████  ░░████████   █████   █████ ░░█████████  ██████████ █████   █████", y + 6);
                PrintCenter("░░░░░░░░░░░    ░░░░░░░░   ░░░░░   ░░░░░   ░░░░░░░░░  ░░░░░░░░░░ ░░░░░   ░░░░░", y + 7);
                Console.ResetColor();
            
        }

        public static void ShowTitleB() // 게임 타이틀화면
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetCursorPosition(45, 9);
            int centerx = 45;
            int y = 9;

            void PrintCenter(string text, int yPos) // 가운데 정렬
            {
                int realLength = 0;

                foreach (char c in text)
                {
                    if (c >= '가' && c <= '힣')
                    {
                        realLength += 2;
                    }

                    else
                    {
                        realLength += 1;
                    }
                }
                Console.SetCursorPosition(centerx , yPos);
                Console.Write(text);
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            PrintCenter("██████████   ███████████   ██████████   █████████   ██████   ██████", y);
            PrintCenter("░███░░░░███ ░░███░░░░░███ ░░███░░░░░█  ███░░░░░███ ░░██████ ██████", y + 1);
            PrintCenter("░███   ░░███ ░███    ░███  ░███  █ ░  ░███    ░███  ░███░█████░███", y + 2);
            PrintCenter("░███    ░███ ░██████████   ░██████    ░███████████  ░███░░███ ░███", y + 3);
            PrintCenter("░███    ░███ ░███░░░░░███  ░███░░█    ░███░░░░░███  ░███ ░░░  ░███", y + 4);
            PrintCenter("░███    ███  ░███    ░███  ░███ ░   █ ░███    ░███  ░███      ░███", y + 5);
            PrintCenter("██████████   █████   █████ ██████████ █████   █████ █████     █████", y + 6);
            PrintCenter("░░░░░░░░░░   ░░░░░   ░░░░░ ░░░░░░░░░░ ░░░░░   ░░░░░ ░░░░░     ░░░░░", y + 7);
            Console.ResetColor();
        }

        public static void ShowMainMenu(int select) // 게임 메인메뉴
        {
            Console.SetCursorPosition(60, 23);
            int centerx = 60;
            int y = 23;

            void PrintCenter(string text, int yPos) // 가운데 정렬
            {
                int realLength = 0;

                foreach (char c in text)
                {
                    if (c >= '가' && c <= '힣')
                    {
                        realLength += 2;
                    }

                    else
                    {
                        realLength += 1;
                    }
                }
                Console.SetCursorPosition(centerx - (realLength / 2), yPos);
                Console.Write(text);
            }

            if (select == 0)
            { 
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PrintCenter("▶ 게임 시작", y - 1);
                Console.ResetColor();
            }
            else
            {
                PrintCenter("  게임 시작", y - 1);
            }

            if (select == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PrintCenter("▶ 게임 설명", y);
                Console.ResetColor();
            }

            else
            {
                PrintCenter("  게임 설명", y);
            }

            if (select == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PrintCenter("▶ 게임 종료", y + 1);
                Console.ResetColor();

            }
            else
            {
                PrintCenter("  게임 종료", y + 1);
            }
        }

        public static void ShowBune()
        {
            SmallBun.PrintsmallBun(5, 8);
        }

        public static void Description()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("                     게임 설명");
            Console.WriteLine("==========================================================");
            Console.WriteLine();

            Console.WriteLine("Burger Dream에 오신 것을 환영합니다!");
            Console.WriteLine();

            Console.WriteLine("당신은 작은 햄버거 가게의 사장입니다.");
            Console.WriteLine("손님이 주문한 햄버거를 정확하게 만들어");
            Console.WriteLine("돈을 벌고 가게를 성장시켜 보세요!");
            Console.WriteLine();

            Console.WriteLine("[ 게임 진행 ]");
            Console.WriteLine();

            Console.WriteLine("1. 손님이 주문을 합니다.");
            Console.WriteLine("2. 주문한 재료를 순서대로 선택합니다.");
            Console.WriteLine("3. 햄버거를 완성하여 손님에게 제공합니다.");
            Console.WriteLine("4. 완성도에 따라 돈과 평판을 획득합니다.");
            Console.WriteLine("5. 하루가 끝나면 가게를 업그레이드할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("[ 평가 기준 ]");
            Console.WriteLine();

            Console.WriteLine("◎ 재료가 모두 맞으면 높은 점수!");
            Console.WriteLine("◎ 순서가 틀리면 감점!");
            Console.WriteLine("◎ 재료가 부족하거나 잘못 넣으면 큰 감점!");
            Console.WriteLine("◎ 점수가 높을수록 더 많은 수익을 얻습니다.");
            Console.WriteLine();

            Console.WriteLine("[ 승리 조건 ]");
            Console.WriteLine();

            Console.WriteLine("가게를 성장시키고 최고의 햄버거 맛집을");
            Console.WriteLine("만드는 것이 목표입니다!");
            Console.WriteLine();

            Console.WriteLine("==========================================================");
            Console.WriteLine("        ESC : 메인 메뉴로 돌아가기");
            Console.WriteLine("==========================================================");
            Console.ReadKey(true);
        }

        public static void Story() // 스토리 화면
        {
            
            Console.SetCursorPosition(60, 15);
            int centerx = 60;
            int y = 15;

            void PrintCenter(string text, int yPos) // 가운데 정렬
            {
                int realLength = 0;

                foreach(char c in text)
                {
                    if (c >= '가' && c <= '힣')
                    {
                        realLength += 2;
                    }

                    else
                    {
                        realLength += 1;
                    }
                }
                Console.SetCursorPosition(centerx - (realLength / 2), yPos);
                Console.Write(text);
            }

            PrintCenter("BURGER DREAM", y - 1);
            PrintCenter("Press Any Key...", y); 
            Console.ReadKey(true);
            Console.Clear();
            
            PrintCenter("5년 전...", y);
            Thread.Sleep(2000);
            Console.Clear();
           
            PrintCenter("오랫동안 햄버거를 만드는 것을 좋아했던 '번이'.", y);
            Thread.Sleep(2000);
            Console.Clear();

            PrintCenter("언젠가는 모두가 행복해지는 햄버거 가게를", y - 1);
            PrintCenter("운영하는 것이 그의 오랜 꿈이었습니다.", y);
            Thread.Sleep(2000);
            Console.Clear();

            PrintCenter("하지만 가진 돈은 얼마 없었고,", y - 1);
            PrintCenter("5년동안 쓰리잡을 하며 겨우 모은 돈으로", y);
            PrintCenter("작은 가게 하나를 겨우 열 수 있었습니다.", y + 1);
            Thread.Sleep(3000);
            Console.Clear();

            PrintCenter("첫 손님을 맞이하는 오늘.", y - 1);
            PrintCenter("이 작은 가게가 최고의 햄버거 가게가 될 수 있을까요?", y);
            Thread.Sleep(2000);
            Console.Clear();

            PrintCenter("손님의 주문을 정확하게 만들고", y - 1);
            PrintCenter("돈을 모아 가게를 성장시켜 보세요!", y);
            Thread.Sleep(2000);
            Console.Clear();

            PrintCenter("최고의 햄버거는 최고의 정성에서 시작됩니다.", y);
            Thread.Sleep(2000);
            Console.Clear();

            PrintCenter("Press Any Key...", y);
            Console.ReadKey(true);

            Console.Clear();


            PrintCenter( "Day 1", y - 1);
            PrintCenter ("첫 영업을 시작합니다.", y);
            Thread.Sleep(1500);
            Console.Clear();
        }

        public static void StorySkip()
        {
            bool watchStory = StorySelect();

            if (watchStory)
            {
                Console.Clear ();
                Story();
            }

            InteriorHall();

        }

        static bool StorySelect()
        {
            int select = 0;

            while (true)
            {
                Console.Clear ();

                Console.SetCursorPosition(45, 15);
                Console.WriteLine("스토리를 보시겠습니까?");

                string[] menu = { "스토리 보기", "스토리 스킵" };

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.SetCursorPosition(48, 18 + i * 2);

                    if (select == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("▶ " + menu[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  " + menu[i]);
                    }
                }
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        select--;

                        if (select < 0)
                        {
                            select = 1;
                        }
                        break;

                        case ConsoleKey.DownArrow:
                        select++;

                        if (select > 1)
                        {
                            select = 0;
                        }
                        break;

                    case ConsoleKey.Enter:
                        return select == 0;
                }
            }
        }



        public static void Play() // 게임 플레이
        {
            InteriorHall();

            InteriorOrder();
        }

        public static void InteriorHall() // 가게 홀
        {
            Console.CursorVisible = false;
            Console.Clear();

            OOP.Shop_Supplies.WallTile.DrawWall(5, 1);
            OOP.Shop_Supplies.Tile_check.DrawFloor(5, 15);
            OOP.Character.Bun.PrintBun(5, 3);
            OOP.Shop_Supplies.Table.PrintTable(60, 10);
            OOP.Shop_Supplies.Chair.PrintChair(35, 10);
            OOP.Shop_Supplies.Chair.PrintChair(85, 10);
            GoGame();


            Console.ResetColor();
            Console.ReadKey(true);
        }

        public static void GoGame()
        {
            bool GoGame = HallSelect();

            if (GoGame)
            {
                InteriorOrder();
            }

            GameManager.TitieCollection();

        }

        static bool HallSelect() // 손님 받기 선택
        {
            int select = 0;

            while (true)
            {     
                Console.SetCursorPosition(70, 18);           

                string[] menu = { "손님 받기", "장사 안하기" };

                for (int i = 0; i < menu.Length; i++)
                {
                    Console.SetCursorPosition(70, 18 + i * 2);

                    if (select == i)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("▶ " + menu[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("  " + menu[i]);
                    }
                }
                Console.ResetColor();

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        select--;

                        if (select < 0)
                        {
                            select = 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        select++;

                        if (select > 1)
                        {
                            select = 0;
                        }
                        break;

                    case ConsoleKey.Enter:
                        return select == 0;
                }
            }
        }

        public static void ShowText()
        {
            Console.SetCursorPosition(60, 15);
            int centerx = 60;
            int y = 15;

            void PrintCenter(string text, int yPos) // 가운데 정렬
            {
                int realLength = 0;

                foreach (char c in text)
                {
                    if (c >= '가' && c <= '힣')
                    {
                        realLength += 2;
                    }

                    else
                    {
                        realLength += 1;
                    }
                }
                Console.SetCursorPosition(centerx - (realLength / 2), yPos);
                Console.Write(text);
            }
            PrintCenter("어서오세요~ BURGER DREAM입니다!", y);
            PrintCenter("주문 하시겠어요?", y + 1);
            Thread.Sleep(3000);
            Console.Clear();
        }


        public static void InteriorOrder() // 가게 주문확인
        {
            Console.CursorVisible = false;
            Console.Clear();

            ShowText();

            OOP.Shop_Supplies.WallTile.DrawWall(5, 1);
            OOP.Shop_Supplies.Tile_check.DrawFloor(5, 15);
            OOP.Character.Cheese.PrintCheese(80, 0);
            OOP.Shop_Supplies.Counter.PrintCounter(70, 4);
            OOP.Shop_Supplies.Table.PrintTable(23, 0);
            OOP.Shop_Supplies.Chair.PrintChair(1, 0);
            OOP.Shop_Supplies.Chair.PrintChair(45, 0);

            Console.ResetColor();
            Console.ReadKey(true);
          
        }

        public void Nextday() // 시간 흐름
        {

        }

        public void GameOver() // 게임 엔딩
        {

        }
    }





}
