using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;


namespace _0709_서요셉
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Menu();
                string input = Console.ReadLine()!;

                switch (input)
                {

                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("===== 반복문 복습 입장중... =====");
                        Thread.Sleep(3000);
                        Console.Clear();
                        LoopReviewMenup();

                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("===== 배열 + 반복문 입장중... =====");
                        Thread.Sleep(3000);
                        Console.Clear();
                        ArrayLoop();
                        break;

                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("===== 조건문 + 예외처리 입장중... =====");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Quiz();
                        break;

                    case "4":
                        Console.WriteLine();
                        Console.WriteLine("===== 문자열 Preview 입장중...=====");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Text();
                        break;

                    case "5":
                        Console.WriteLine();
                        Console.WriteLine("===== 프로그램을 종료합니다. =====");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("잘못된 입력입니다. 다시 입력하여주세요(1 ~ 5)");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                }
            }

        }



        static void Menu() // 시작화면
        {
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│ ███████████   ██████████ █████   █████ █████ ██████████ █████   ███   █████   │");
            Console.WriteLine("│ ░███░░░░░███ ░░███░░░░░█░░███   ░░███ ░░███ ░░███░░░░░█░░███   ░███  ░░███    │");
            Console.WriteLine("│ ░███    ░███  ░███  █ ░  ░███    ░███  ░███  ░███  █ ░  ░███   ░███   ░███    │");
            Console.WriteLine("│ ░██████████   ░██████    ░███    ░███  ░███  ░██████    ░███   ░███   ░███    │");
            Console.WriteLine("│ ░███░░░░░███  ░███░░█    ░░███   ███   ░███  ░███░░█    ░░███  █████  ███     │");
            Console.WriteLine("│ ░███    ░███  ░███ ░   █  ░░░█████░    ░███  ░███ ░   █  ░░░█████░█████░      │");
            Console.WriteLine("│ █████   █████ ██████████    ░░███      █████ ██████████    ░░███ ░░███        │");
            Console.WriteLine("│ ░░░░░   ░░░░░ ░░░░░░░░░░      ░░░      ░░░░░ ░░░░░░░░░░      ░░░   ░░░        │");
            Console.WriteLine("│                                                                               │");
            Console.WriteLine("│             ═══════════════════════════════════════════════════════           │");
            Console.WriteLine("│                                                                               │");
            Console.WriteLine("│               C# Console Review Program                                       │");
            Console.WriteLine("│               반복문 · 배열 · 조건문 · 예외처리 복습                          │");
            Console.WriteLine("│                                                                               │");
            Console.WriteLine("│             ═══════════════════════════════════════════════════════           │");
            Console.WriteLine("│                                                                               │");
            Console.WriteLine("│                           ▶ 1. 반복문  복습                                   │");
            Console.WriteLine("                            ▶ 2. 배열 + 반복문");
            Console.WriteLine("│                           ▶ 3. 조건문 + 예외처리                              │");
            Console.WriteLine("│                           ▶ 4. 문자열 Preview                                 │");
            Console.WriteLine("│                           ──────────────────────                              │");
            Console.WriteLine("                            ▶ 5. 종료");
            Console.WriteLine("│                                                                               │");
            Console.WriteLine("└───────────────────────────────────────────────────────────────────────────────┘");
        }

        static void LoopReviewMenup() // 반복문 메뉴창.
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================");
                Console.WriteLine("       반복문 복습");
                Console.WriteLine("========================");
                Console.WriteLine();
                Console.WriteLine("1. for문");
                Console.WriteLine("2. while문");
                Console.WriteLine("3. 메인메뉴");
                Console.WriteLine();

                string input = Console.ReadLine()!;
                Console.Clear();
                switch (input)
                {

                    case "1":

                        ForReview();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine();
                        WhileReview();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case "3":
                        return;
                }
            }
        }

        static void ForReview() // for문 복습내용
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("                          for문 복습");
            Console.WriteLine("==============================================================");
            Console.WriteLine();
            Console.WriteLine("for문은 똑같은 작업을 여러 번 반복할 때 사용하는 반복문입니다.");
            Console.WriteLine("반복 횟수가 명확할 때 주로 사용");
            Console.WriteLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");

                }
            }
            Console.Write("엔터를 누르면 메뉴로 돌아갑니다.");
            Console.ReadLine();
        }

        static void WhileReview() // while문 복습내용
        {

            Console.WriteLine("============================================================================================");
            Console.WriteLine("                          while문 복습");
            Console.WriteLine("============================================================================================");
            Console.WriteLine();
            Console.WriteLine("조건이 '참'(true)인 동안 특정 코드를 반복해서 실행하는 문법입니다. ");
            Console.WriteLine("정해진 횟수만큼 도는 for문과 달리, 주로 조건에 맞을 때까지 계속 반복해야 할 때 사용합니다");
            Console.WriteLine();
            Console.WriteLine("============================================================================================");
            Console.WriteLine();

            Console.WriteLine("숫자를 입력하세요.");
            int input = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            int CountSum = 0;
            int Number = input;


            while (input > 0)
            {
                CountSum += input;

                input--;

            }

            Console.WriteLine($"1부터 {Number}까지의 합은");
            Console.WriteLine();
            Console.WriteLine($"{CountSum}입니다.");

            Console.Write("엔터를 누르면 메뉴로 돌아갑니다.");
            Console.ReadLine();

        }

        static void ArrayLoop() // 배열 + 반복문
        {
            Console.WriteLine("=================================================================================");
            Console.WriteLine("                          배열 + 반복문 복습");
            Console.WriteLine("=================================================================================");
            Console.WriteLine();
            Console.WriteLine("배열: 배열은 여러 개의 데이터를 한 번에 담는 상자입니다. ");
            Console.WriteLine("반복문: 반복문은 이 상자 속 데이터를 하나씩 꺼내 똑같은 작업을 수행하는 명령어 ");
            Console.WriteLine();
            Console.WriteLine("=================================================================================");
            Console.WriteLine();

            int[] student = { 68, 73, 85, 91, 100 };

            int CountSum = 0;

            for (int i = 0; i < 5; i++)
            {
                CountSum += student[i];
                Console.WriteLine($"{i}번 학생 : [{student[i]}]점");

            }
            Console.WriteLine($"총 합: {CountSum}");
            Console.WriteLine($"평 균: {CountSum / 5}");
            Console.ReadLine();

            Console.Write("엔터를 누르면 메뉴로 돌아갑니다.");
            Console.ReadLine();
        }

        static void Quiz() // 조건문 + 예외처리
        {
            while (true)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("        복습 퀴즈");
                Console.WriteLine("===========================");
                Console.WriteLine();

                Console.WriteLine("Q. 반복문의 종류가 아닌 것은?");
                Console.WriteLine();
                Console.WriteLine("1. for문 ");
                Console.WriteLine("2. while문");
                Console.WriteLine("3. if~else문");
                Console.WriteLine("4. do-while문");
                Console.WriteLine();

                Console.Write("선택 >");
                int input = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                switch (input)
                {
                    case 1:
                    case 2:
                    case 4:
                        Console.WriteLine("땡 !!! 틀렸습니다 !!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("오 !!! 정답입니다 !!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("잘못된 입력입니다. 다시 입력하여주세요(1 ~ 4)");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                }
                
            }
            Console.Write("엔터를 누르면 메뉴로 돌아갑니다.");
            Console.ReadLine();
        }

        static void Text() // 문자열 예습
        {
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("                                                  ◈ 문자열의 뜻 ◈");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("C#에서 문자열(string)은 글자들의 모임입니다. 예를 들어\"안녕하세요!\", \"Hello\" 같은 문장이나 단어입니다. ");
            Console.WriteLine("C#에서는 string 키워드를 사용하여 문자열을 만들 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("문자열의 주요 특징은 다음과 같습니다");
            Console.WriteLine();
            Console.WriteLine("작성법: 큰따옴표(\" \") 안에 글자들을 넣어서 만듭니다.");
            Console.WriteLine("문자들의 모임: 문자열은 작은따옴표(' ')를 쓰는 문자(char) 여러 개가 기차처럼 이어진 형태입니다.");
            Console.WriteLine("변경 불가(불변성): 문자열은 한 번 만들면 내용을 바꿀 수 없습니다. 만약 문자열을 수정하려고 하면, 기존 것은 버리고 새로운 문자열을 만들어냅니다.");
            Console.WriteLine();
            Console.WriteLine("문자열은 다양한 기능(메서드)을 제공합니다. 자주 쓰는 기능은 아래와 같습니다");
            Console.WriteLine();
            Console.WriteLine("Length: 문자열의 글자 수를 알려줍니다..");
            Console.WriteLine("Substring(): 문자열의 일부분만 잘라냅니다.");
            Console.WriteLine(".Replace(): 원하는 단어를 다른 단어로 바꿉니다");
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("========================================================================================================================");

            Console.Write("엔터를 누르면 메뉴로 돌아갑니다.");
            Console.ReadLine();
        }





    }    

}

