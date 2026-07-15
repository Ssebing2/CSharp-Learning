using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _0708_서요셉.과제
{
    internal class essignment_2
    {
        static int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // 숫자 배열
        static int number1; // 컴퓨터 1번
        static int number2; // 컴퓨터 2번
        static int number3; // 컴퓨터 3번

        static int user1; // 사용자 1번
        static int user2; // 사용자 2번
        static int user3; // 사용자 3번

        static int strike; // 스트라이크 카운트
        static int ball;   // 볼 카운트
        static int outCount; // 아웃 카운트
        static int playCount = 0; // 판수


        static void Main()
        {
            ComNum();

            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine($"[치트] 정답 : {number1} {number2} {number3}");
                Console.WriteLine("=================================");

                playCount++;

                UserInput();

                CheckResult();
                Thread.Sleep(2000);
                Console.Clear();

                if (strike == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("★★★★ 정답입니다! ★★★★");
                    Console.WriteLine($"{playCount}번 만에 맞췄습니다!");
                    Thread.Sleep(3000);
                    break;
                }
            }
            
        }

        static void ComNum() // 컴퓨터 무작위 뽑기
        {
            Random random = new Random();

             number1 = random.Next(num.Length);

             number2 = random.Next(num.Length);

            while (number1 == number2)
            {
                Console.WriteLine("number2가 중복입니다! 다시 뽑습니다.");
                number2 = random.Next(num.Length);
            }

             number3 = random.Next(num.Length);

            while (number3 == number1 || number3 == number2)
            {
                Console.WriteLine("number3가 중복입니다! 다시 뽑습니다.");
                number3 = random.Next(num.Length);
            }
        }

        static void UserInput() // 사용자 입력
        {
            int number;

            // 첫 번째 숫자
            while (true)
            {
                Console.Write("첫 번째 숫자 : ");
                string input = Console.ReadLine()!;

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("숫자만 입력해주세요.");
                    continue;
                }

                if (number < 0 || number > 9)
                {
                    Console.WriteLine("0~9 사이의 숫자만 입력 가능합니다.");
                    continue;
                }

                user1 = number;
                break;
            }

            // 두 번째 숫자
            while (true)
            {
                Console.Write("두 번째 숫자 : ");
                string input = Console.ReadLine()!;

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("숫자만 입력해주세요.");
                    continue;
                }

                if (number < 0 || number > 9)
                {
                    Console.WriteLine("0~9 사이의 숫자만 입력 가능합니다.");
                    continue;
                }

                if (number == user1)
                {
                    Console.WriteLine("중복된 숫자는 입력할 수 없습니다.");
                    continue;
                }

                user2 = number;
                break;
            }

            // 세 번째 숫자
            while (true)
            {
                Console.Write("세 번째 숫자 : ");
                string input = Console.ReadLine()!;

                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("숫자만 입력해주세요.");
                    continue;
                }

                if (number < 0 || number > 9)
                {
                    Console.WriteLine("0~9 사이의 숫자만 입력 가능합니다.");
                    continue;
                }

                if (number == user1 || number == user2)
                {
                    Console.WriteLine("중복된 숫자는 입력할 수 없습니다.");
                    continue;
                }

                user3 = number;
                break;
            }
        }

            static void CheckResult() // 스트라이크, 볼, 아웃
            {
                strike = 0;
                ball = 0;
                outCount = 0;

                // 첫 번째 숫자
                if (user1 == number1)
                {
                    strike++;
                }
                else if (user1 == number2 || user1 == number3)
                {
                    ball++;
                }
                else
                {
                    outCount++;
                }

                // 두 번째 숫자
                if (user2 == number2)
                {
                    strike++;
                }
                else if (user2 == number1 || user2 == number3)
                {
                    ball++;
                }
                else
                {
                    outCount++;
                }

                // 세 번째 숫자
                if (user3 == number3)
                {
                    strike++;
                }
                else if (user3 == number1 || user3 == number2)
                {
                    ball++;
                }
                else
                {
                    outCount++;
                }

                Console.WriteLine();
                Console.WriteLine("=======================");
                Console.WriteLine($"{strike} Strike");
                Console.WriteLine($"{ball} Ball");
                Console.WriteLine($"{outCount} Out");
                Console.WriteLine("=======================");
            }

        
    }
}
