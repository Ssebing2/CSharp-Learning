using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;


namespace _0706_서요셉_4_
{
    internal class Program
    {
        int numA; // 1번 정수
        int numB; // 2번 정수
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=======================================");
            Console.WriteLine("과제2-3: 원래 숫자 복원");
            Console.WriteLine("=======================================");
            Console.ResetColor();

            Console.Write("첫번째 숫자를 입력하세요: ");
            int numA = int.Parse(Console.ReadLine()!);

            Console.Write("두번째 숫자를 입력하세요: ");
            int numB = int.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("=========연산결과========");
            Console.ResetColor();

            Console.WriteLine($" 몫 : {(numA / numB)}");
            Console.WriteLine($" 나머지 : {(numA % numB)}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=========원래숫자복원========");
            Console.ResetColor();

            Console.WriteLine($" 복원숫자 : {numB * (numA / numB) + (numA % numB)}");
        }
    }
}
