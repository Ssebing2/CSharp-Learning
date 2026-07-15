using System;
using System.Collections;
using System.Collections.Generic;

namespace _0706_서요셉
{
    internal class Program
    {
        int numA; // 1번 정수
        int numB; // 2번 정수
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=======================================");
            Console.WriteLine("과제2-1: 사칙연산 + 나머지 출력");
            Console.WriteLine("=======================================");
            Console.ResetColor();

            Console.Write("첫번째 숫자를 입력하세요: ");
            int numA = int.Parse(Console.ReadLine()!);

            Console.Write("두번째 숫자를 입력하세요: ");
            int numB = int.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=========연산결과========");
            Console.ResetColor();

            Console.WriteLine($"덧셈 : {numA + numB}");
            Console.WriteLine($"뺄셈 : {numA - numB}");
            Console.WriteLine($"곱셈 : {numA * numB}");
            Console.WriteLine($"나눗셈 : {numA / numB}");
            Console.WriteLine($"나머지 : {numA % numB}");

            if (numA != 0)
            {
                Console.WriteLine("※ 0은 사용할 수 없습니다. ※");
            }

            else if (numB != 0)
            {
                Console.WriteLine("※ 0은 사용할 수 없습니다. ※");
            }

            



        }
    }
}
