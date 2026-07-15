namespace _0708_서요셉.과제
{
    internal class essignment_1
    {
        static string[] item = { "캐릭터", "배경", "퀘스트", "아이템", "과금", "레이드" }; //항목 배열
        static int[] score = { 88, 56, 44, 61, 94, 95 }; // 점수 배열
        static int total = 0; // 점수 합계
        static void Main(string[] args)
        {
            Console.WriteLine("=========게임 테스트 결과=========");
            Console.WriteLine();

            for (int i = 0; i < 6;  i++)
            {
                
                total += score[i];
                Console.WriteLine($"{item[i]} : {score[i]}점");

            }
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine($"총합 : {total}");
            Console.WriteLine($"평균 : {total / 6}");
            Console.WriteLine();
            Console.Write("최종평가 : ");Final();
            Console.WriteLine("==================================");
        }

        static void Final()
        {
            int average = total / 6;

            if (average >= 70 )
            {
                Console.WriteLine("추천");
            }

            else if (average >= 50 )
            {
                Console.WriteLine("보통");
            }

            else if (average >= 30)
            {
                Console.WriteLine("비추천");
            }
        }
    }








}
