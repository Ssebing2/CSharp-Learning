using System;
using System.Collections;
using System.Collections.Generic;

namespace _0706_서요셉_2_
{
    internal class Program
    {
        int numA; // 1번 정수
        int numB; // 2번 정수
        int numC; // 3번 정수

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================");
            Console.WriteLine("과제2-2: 연산의 결과 출력");
            Console.WriteLine("==================================");
            Console.ResetColor();

            Console.Write("첫번째 숫자를 입력하세요: ");
            int numA = int.Parse(Console.ReadLine()!);

            Console.Write("두번째 숫자를 입력하세요: ");
            int numB = int.Parse(Console.ReadLine()!);

            Console.Write("세번째 숫자를 입력하세요: ");
            int numC = int.Parse(Console.ReadLine()!);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=========연산결과========");
            Console.ResetColor();
            Console.WriteLine($"({numA + numB}) * ({numC + numA}) % {numA} = {(numA + numB) * (numC + numA) % numA} ");
            Console.WriteLine($"({numC % numB}) + ({numA} * 2) = {(numC % numB) + (numA * 2)} ");
            Console.WriteLine($"({numA + numB + numC}) % ({numC} + 1) = {(numA + numB + numC) % (numC + 1)} ");

        }
    }
}
