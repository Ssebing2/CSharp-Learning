using System;

namespace _0710_서요셉
{
    internal class Program
    {
        // 컴퓨터가 숫자를 뽑을 배열
        static int[] ComArrayA = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int[] ComArrayB = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int[] ComArrayC = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 컴퓨터가 선택한 숫자
        static int computerA;
        static int computerB;
        static int computerC;

        // 사용자가 입력한 숫자
        static int user1;
        static int user2;
        static int user3;

        // 시도 횟수
        static int tryCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("       숫자 합 UP & DOWN");
            Console.WriteLine("============================");
            Console.WriteLine();
            Console.WriteLine("1~10 사이의 서로 다른 숫자 3개를 입력하세요.");
            Console.WriteLine("컴퓨터 숫자를 보려면 '치트'를 입력하세요.");
            Console.WriteLine();

            // 컴퓨터 숫자 생성
            ComPlay();

            while (true)
            {
                // 사용자 숫자 입력
                User();

                // 시도 횟수 증가
                tryCount++;

                // 컴퓨터 숫자의 합
                int computerSum = computerA + computerB + computerC;

                // 사용자 숫자의 합
                int userSum = user1 + user2 + user3;

                Console.WriteLine();
                Console.WriteLine($"입력한 숫자 : {user1}, {user2}, {user3}");
                Console.WriteLine($"사용자 숫자의 합 : {userSum}");
                Console.WriteLine();

                // 합 비교
                if (userSum < computerSum)
                {
                    Console.WriteLine("결과 : UP!");
                    Console.WriteLine("컴퓨터 숫자의 합이 더 큽니다.");
                }
                else if (userSum > computerSum)
                {
                    Console.WriteLine("결과 : DOWN!");
                    Console.WriteLine("컴퓨터 숫자의 합이 더 작습니다.");
                }
                else
                {
                    Console.WriteLine("============================");
                    Console.WriteLine("         정답입니다!");
                    Console.WriteLine("============================");
                    Console.WriteLine();

                    Console.WriteLine(
                        $"컴퓨터 숫자 : {computerA}, {computerB}, {computerC}"
                    );

                    Console.WriteLine($"컴퓨터 숫자의 합 : {computerSum}");
                    Console.WriteLine($"총 시도 횟수 : {tryCount}회");

                    break;
                }

                Console.WriteLine($"현재 시도 횟수 : {tryCount}회");
                Console.WriteLine();
            }
        }

        // 컴퓨터 숫자 생성
        static void ComPlay()
        {
            Random random = new Random();

            // A 배열에서 숫자 1개 선택
            computerA =
                ComArrayA[random.Next(ComArrayA.Length)];

            // B 배열에서 숫자 1개 선택
            computerB =
                ComArrayB[random.Next(ComArrayB.Length)];

            // A와 B가 중복되면 B를 다시 선택
            while (computerA == computerB)
            {
                computerB =
                    ComArrayB[random.Next(ComArrayB.Length)];
            }

            // C 배열에서 숫자 1개 선택
            computerC =
                ComArrayC[random.Next(ComArrayC.Length)];

            // C가 A 또는 B와 중복되면 C를 다시 선택
            while (computerC == computerA ||
                   computerC == computerB)
            {
                computerC =
                    ComArrayC[random.Next(ComArrayC.Length)];
            }
        }

        // 사용자 숫자 입력
        static void User()
        {
            int number;

            // 첫 번째 숫자 입력
            while (true)
            {
                Console.Write("첫 번째 숫자 : ");
                string input = Console.ReadLine()!;

                // 치트 입력 확인
                if (input == "치트")
                {
                    ShowCheat();
                    continue;
                }

                // 숫자인지 확인
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("숫자만 입력해주세요.");
                    continue;
                }

                // 숫자 범위 확인
                if (number < 1 || number > 10)
                {
                    Console.WriteLine(
                        "1~10 사이의 숫자만 입력 가능합니다."
                    );

                    continue;
                }

                user1 = number;
                break;
            }

            // 두 번째 숫자 입력
            while (true)
            {
                Console.Write("두 번째 숫자 : ");
                string input = Console.ReadLine()!;

                // 치트 입력 확인
                if (input == "치트")
                {
                    ShowCheat();
                    continue;
                }

                // 숫자인지 확인
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("숫자만 입력해주세요.");
                    continue;
                }

                // 숫자 범위 확인
                if (number < 1 || number > 10)
                {
                    Console.WriteLine(
                        "1~10 사이의 숫자만 입력 가능합니다."
                    );

                    continue;
                }

                // 첫 번째 숫자와 중복 확인
                if (number == user1)
                {
                    Console.WriteLine(
                        "중복된 숫자는 입력할 수 없습니다."
                    );

                    continue;
                }

                user2 = number;
                break;
            }

            // 세 번째 숫자 입력
            while (true)
            {
                Console.Write("세 번째 숫자 : ");
                string input = Console.ReadLine()!;

                // 치트 입력 확인
                if (input == "치트")
                {
                    ShowCheat();
                    continue;
                }

                // 숫자인지 확인
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("숫자만 입력해주세요.");
                    continue;
                }

                // 숫자 범위 확인
                if (number < 1 || number > 10)
                {
                    Console.WriteLine(
                        "1~10 사이의 숫자만 입력 가능합니다."
                    );

                    continue;
                }

                // 첫 번째, 두 번째 숫자와 중복 확인
                if (number == user1 || number == user2)
                {
                    Console.WriteLine(
                        "중복된 숫자는 입력할 수 없습니다."
                    );

                    continue;
                }

                user3 = number;
                break;
            }
        }

        // 치트 출력
        static void ShowCheat()
        {
            int computerSum =
                computerA + computerB + computerC;

            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("            치트");
            Console.WriteLine("============================");

            Console.WriteLine(
                $"컴퓨터 숫자 : {computerA}, {computerB}, {computerC}"
            );

            Console.WriteLine($"컴퓨터 숫자의 합 : {computerSum}");
            Console.WriteLine();
        }
    }
}