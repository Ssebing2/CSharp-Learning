using System;
using System.Xml.Linq;
using System.Threading;


namespace _0714_서요셉
{
    public struct GameData // 구조체 뼈대
    {
        public string name;                                    // 이름
        public AgeRating ageRating;                            // 이용등급
        public int price;                                      // 가격
        public float rating;                                   // 평점
        public (bool HasIssue, string comment) Remarks;        // 특이사항
        public string toSumUp;                                 // 한마디
    }

    public enum AgeRating // 이용등급
    {
        ALL,        // 전체이용가
        TEEN,       // 19세 미만
        ADULT       // 19세 이상
    }

    

 

    internal class Program
    {
        static void Main(string[] args)
        {
            GameData[] game = new GameData[4]; // 배열로 게임 4개 초기화

            game[0].name = "Minecraft";
            game[0].ageRating = AgeRating.ALL;
            game[0].price = 30000;
            game[0].rating = 4.8f;
            game[0].Remarks = (true, "힐링게임");
            game[0].toSumUp = "즐겨봅니다.";

            game[1].name = "SuddenAttack";
            game[1].ageRating = AgeRating.ADULT;
            game[1].price = 0;
            game[1].rating = 3.0f;
            game[1].Remarks = (true, "망하기 직전");
            game[1].toSumUp = "저도 곧 총 다 팔 예정입니다.";

            game[2].name = "League of Legends";
            game[2].ageRating = AgeRating.ALL;
            game[2].price = 0;
            game[2].rating = 4.6f;
            game[2].Remarks = (false, "없음");
            game[2].toSumUp = "페이커... 그는 신...";

            game[3].name = "PUBG: BATTLEGROUNDS";
            game[3].ageRating = AgeRating.TEEN;
            game[3].price = 20000;
            game[3].rating = 4.0f;
            game[3].Remarks = (false, "없음");
            game[3].toSumUp = "움직이는 4렙 가방..";


            while (true)
            {
                Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩                                                  ▩▩▩▩▩");
                Console.WriteLine("▩▩▩    HI-SCORE                           ♥ ♥ ♥ ♥ ♥      ▩▩▩");
                Console.WriteLine("▩▩▩    123000                                            ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩                      S T A R T                       ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩                    ARE YOU READY?                    ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩                     YES◀   NO                        ▩▩▩");
                Console.WriteLine("▩▩▩                                                      ▩▩▩");
                Console.WriteLine("▩▩▩▩                                             ?      ▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩                                                  ▩▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                Console.WriteLine("모든 게임 정보 확인(1) / 특정 조건의 게임 확인(2) / 게임 종료(3)");
                Console.Write(">> 번호를 입력하세요.");
                int input = int.Parse(Console.ReadLine()!);
                Console.WriteLine();
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                        Console.WriteLine("▩           모든 게임 정보 확인          ▩");
                        Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");

                        for (int i = 0; i < game.Length; i++)
                        {
                            Console.WriteLine($"게임이름: {game[i].name}");
                            Console.WriteLine($"이용등급: {game[i].ageRating}");
                            Console.WriteLine($"가 격: {game[i].price}");
                            Console.WriteLine($"평 점: {game[i].rating}");
                            Console.WriteLine($"특이사항: {game[i].Remarks.HasIssue}");
                            Console.WriteLine($"설 명: {game[i].Remarks.comment}");
                            Console.WriteLine($"한마디: {game[i].toSumUp}");
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine();
                            Thread.Sleep(2000);

                            
                        }
                        Console.WriteLine("아무 키나 누르면 메인 메뉴로 돌아갑니다.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                        Console.WriteLine("▩           특정 조건 게임 확인          ▩");
                        Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                        Console.WriteLine("▩          (1) 평점 4.5 이상 게임        ▩");
                        Console.WriteLine("▩          (2) Adult 등급 게임           ▩");
                        Console.WriteLine("▩          (3) 특이사항이 있는 게임      ▩");
                        Console.WriteLine("▩          (4) 가격이 무료인 게임        ▩");
                        Console.WriteLine("▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩▩");
                        Console.WriteLine();
                        Console.Write(">> 원하는 필터의 번호를 입력하세요.");
                        int inputB = int.Parse(Console.ReadLine()!);
                        Console.WriteLine();                       
                        
                            switch (inputB)
                            {
                                case 1:
                                    for (int i = 0; i < game.Length; i++)
                                    {
                                        if (game[i].rating >= 4.5)
                                        {
                                            Console.WriteLine($"게임이름: {game[i].name}");
                                            Console.WriteLine($"이용등급: {game[i].ageRating}");
                                            Console.WriteLine($"가 격: {game[i].price}");
                                            Console.WriteLine($"평 점: {game[i].rating}");
                                            Console.WriteLine($"특이사항: {game[i].Remarks.HasIssue}");
                                            Console.WriteLine($"설 명: {game[i].Remarks.comment}");
                                            Console.WriteLine($"한마디: {game[i].toSumUp}");
                                            Console.WriteLine("---------------------------------------");
                                            Console.WriteLine();

                                            
                                        }

                                    }
                                    Console.WriteLine("아무 키나 누르면 메인 메뉴로 돌아갑니다.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    for (int i = 0; i < game.Length; i++)
                                    {
                                        if (game[i].ageRating == AgeRating.TEEN)
                                        {
                                            Console.WriteLine($"게임이름: {game[i].name}");
                                            Console.WriteLine($"이용등급: {game[i].ageRating}");
                                            Console.WriteLine($"가 격: {game[i].price}");
                                            Console.WriteLine($"평 점: {game[i].rating}");
                                            Console.WriteLine($"특이사항: {game[i].Remarks.HasIssue}");
                                            Console.WriteLine($"설 명: {game[i].Remarks.comment}");
                                            Console.WriteLine($"한마디: {game[i].toSumUp}");
                                            Console.WriteLine("---------------------------------------");
                                            Console.WriteLine();

                                            
                                        }

                                    }
                                    Console.WriteLine("아무 키나 누르면 메인 메뉴로 돌아갑니다.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    for (int i = 0; i < game.Length; i++)
                                    {
                                        if (game[i].Remarks.HasIssue == true)
                                        {
                                            Console.WriteLine($"게임이름: {game[i].name}");
                                            Console.WriteLine($"이용등급: {game[i].ageRating}");
                                            Console.WriteLine($"가 격: {game[i].price}");
                                            Console.WriteLine($"평 점: {game[i].rating}");
                                            Console.WriteLine($"특이사항: {game[i].Remarks.HasIssue}");
                                            Console.WriteLine($"설 명: {game[i].Remarks.comment}");
                                            Console.WriteLine($"한마디: {game[i].toSumUp}");
                                            Console.WriteLine("---------------------------------------");
                                            Console.WriteLine();

                                            
                                        }

                                    }
                                    Console.WriteLine("아무 키나 누르면 메인 메뉴로 돌아갑니다.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 4:
                                    for (int i = 0; i < game.Length; i++)
                                    {
                                        if (game[i].price == 0)
                                        {
                                            Console.WriteLine($"게임이름: {game[i].name}");
                                            Console.WriteLine($"이용등급: {game[i].ageRating}");
                                            Console.WriteLine($"가 격: {game[i].price}");
                                            Console.WriteLine($"평 점: {game[i].rating}");
                                            Console.WriteLine($"특이사항: {game[i].Remarks.HasIssue}");
                                            Console.WriteLine($"설 명: {game[i].Remarks.comment}");
                                            Console.WriteLine($"한마디: {game[i].toSumUp}");
                                            Console.WriteLine("---------------------------------------");
                                            Console.WriteLine();

                                          
                                        }

                                    }
                                    Console.WriteLine("아무 키나 누르면 메인 메뉴로 돌아갑니다.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                default:
                                    Console.WriteLine("====메인화면으로 돌아갑니다...===");
                                    Thread.Sleep(2000);

                                    break;
                            }
                       
                        break;

                    case 3:
                        Console.WriteLine("====프로그램을 종료합니다...===");
                        Thread.Sleep(2000);

                        return;

                }

            }

        }
    }

 












}
