using System;
using System.Collections;
using System.Collections.Generic;

namespace _0706_서요셉_3_
{
    internal class Program
    {
        int numA; // 1번 정수
        int numB; // 2번 정수

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=======================================");
            Console.WriteLine("과제2-3: 몫과 나머지 출력");
            Console.WriteLine("=======================================");
            Console.ResetColor();

            Console.Write("첫번째 숫자를 입력하세요: ");
            int numA = int.Parse(Console.ReadLine()!);

            Console.Write("두번째 숫자를 입력하세요: ");
            int numB = int.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========연산결과========");
            Console.ResetColor();

            Console.WriteLine($" 몫 : {(numA/numB)}");
            Console.WriteLine($" 나머지 : {(numA % numB)}");
        }
    }
}
