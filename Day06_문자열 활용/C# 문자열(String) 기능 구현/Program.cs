using System;

namespace _0713_서요셉
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("문자열 역순 출력");
            Console.WriteLine("==============================");
            Hello();
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.WriteLine("짝수열 문자만 뒤집어 출력");
            Console.WriteLine("==============================");
            EvenNumber();
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.WriteLine("문자 갯수 확인 출력");
            Console.WriteLine("==============================");
            CountNumber();
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.WriteLine("문자열에서 숫자만 출력");
            Console.WriteLine("==============================");
            TextNumber();
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.WriteLine("문자열에서 문자제거 결과출력");
            Console.WriteLine("==============================");
            TextOutput();
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.WriteLine("주민번호 '-' 제거");
            Console.WriteLine("==============================");
            ResidentNumber();
            Console.WriteLine();

            Console.WriteLine("==============================");
            Console.WriteLine("부분 문자열 직접 찾기");
            Console.WriteLine("==============================");
            FindText();
            Console.WriteLine();

        }

        static void Hello() // 문자열 역순 출력
        {
            Console.Write("문자열 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();

            char[] charArray = Text.ToCharArray(); // 문자 배열화

            Array.Reverse(charArray); // 문자 뒤집기

            Console.WriteLine(charArray);
        }

        static void EvenNumber() // 짝수열 문자만 뒤집어 출력
        {
            Console.Write("문자열 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();

            char[] charArray = Text.ToCharArray(); // 문자 배열화

            int count = charArray.Length / 2; // 짝수 위치 및 짝수 갯수

            char[] even = new char[count]; // 짝수 위치저장

            int index = 0;

            for (int i = 1; i < charArray.Length; i += 2) //짝수 위치 추출
            {
                even[index] = charArray[i];
                index++;
            }

            Array.Reverse(even); // 문자 뒤집기

            index = 0; //초기화

            for (int i = 1; i < charArray.Length; i += 2)  //짝수 추출한거 짝수위치에 넣어주기
            {
                charArray[i] = even[index];
                index++;
            }
            Console.WriteLine(charArray);

        }
        
        static void CountNumber() // 문자 갯수 확인 출력
        {
            Console.Write("문자열 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();

            Console.Write("문자 한개 입력 : ");
            string Message = Console.ReadLine()!; // 문자 한개 입력
            Console.WriteLine();

            string input = Text; // input에 저장
            int count = 0; // 숫자 갯수 변수선언
            foreach(char c in input)
            {
                if (c == Message[0]) // char c에 문자 저장
                {
                    count++; // 해당 문자 카운트
                }
            }
            Console.WriteLine($"문자열: {Text} → 문자: {Message}, 숫자: {count}개");            
        }

        static void TextNumber() // 문자열 입력 후 숫자만 출력
        {
            Console.Write("문자열 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();

            Console.Write("숫자만 출력: ");

            for (int i = 0; i < Text.Length; i++) 
            {
                if (Text[i] >= '0' && Text[i] <= '9') // 1 ~ 9까지의 문자만 출력
                {
                    Console.Write(Text[i]);
                }
            }

            Console.WriteLine();

        }

        static void TextOutput() // 문자열 제거 후 제거한 결과출력
        {
            Console.Write("문자열 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();

            Console.Write("제거 문자 입력(문자 한개 입력) : ");
            string Message = Console.ReadLine()!; // 제거문자 한개 입력
            Console.WriteLine();

            Console.Write("문자만 출력: ");

            foreach (char c in Text)
            {
                if (c != Message[0]) // char c에 문자 저장
                {
                    Console.Write(c); // 결과값 출력
                }
               
            }
            Console.WriteLine() ;
            Console.WriteLine($"문자열: {Text} → 제거문자: {Message}");
        }

        static void ResidentNumber() // 주민번호 '-' 제거
        {
            Console.Write("주민등록번호 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();


            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] != '-') // - 제거
                {
                    Console.Write(Text[i]);
                }
            }

            Console.WriteLine();
        }

        static void FindText() // 부분 문자열 직접 찾기
        {
            Console.Write("문자열 입력 : ");
            string Text = Console.ReadLine()!; // 문자열 입력
            Console.WriteLine();

            char[] charArray = Text.ToCharArray();

            Console.Write("찾을 문자 입력 : ");
            string Message = Console.ReadLine()!; // 찾을문자 입력
            Console.WriteLine();

            Console.Write("출력 결과 : ");

            
            for (int i = 0; i < Text.Length; i++)
            {
                if (  Text[i] == Message[0]) // 입력한 문자에 해당하는 문자만 출력
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            
        }








    }
}
