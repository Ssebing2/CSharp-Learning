using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;

namespace _0707_서요셉.과제
{
    internal class Essignment_2
    {
        // 캐릭터 성능
        static string [] characterA = { "[일반]", "베드로", "43", "51" };
        static string [] characterB = { "[고급]", "다윗", "121", "115" };
        static string [] characterC = { "[희긔]", "엘리야", "517", "485" };
        static string [] characterD = { "[전설]", "가브리엘", "1004", "1004" };

        static int normalCount = 0;
        static int highCount = 0;
        static int rareCount = 0;
        static int legendaryCount = 0;



        static void Main(string[] args)
        {
            menu();
            character();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine("캐릭터 뽑기를 시작합니다!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.Clear();

            for (int i = 1; i < 6; i++)
            {

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("=======================================");
                Console.WriteLine("뽑는중...!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("=======================================");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("=======================================");
                Console.WriteLine($"[{i}]번째 상자깡...!");
                Console.WriteLine("=======================================");
                Lootbox();
                Console.WriteLine("=======================================");
                Console.WriteLine("실시간 현황판");
                Console.WriteLine("=======================================");
                Console.WriteLine($"전설 : {legendaryCount}개");
                Console.WriteLine($"희긔 : {rareCount}개");
                Console.WriteLine($"고급 : {highCount}개");
                Console.WriteLine($"일반 : {normalCount}개");
                Console.WriteLine("=======================================");
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.Clear();

            }

            Console.WriteLine("======== 집계중... ========");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("======== 최종 결과 ========");
            Console.WriteLine($"전설 : {legendaryCount}개");
            Console.WriteLine($"희긔 : {rareCount}개");
            Console.WriteLine($"고급 : {highCount}개");
            Console.WriteLine($"일반 : {normalCount}개");
            Console.WriteLine("===========================");
            Thread.Sleep(3000);

        }

        static void Lootbox() // 캐릭터 뽑기확률
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            if (randomNumber <= 5)
            {
                legendaryCount++;
                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("★★★★★ 전설 획득");
                Console.WriteLine($"{characterD[0]}/ {characterD[1]}/ 공격력: {characterD[2]}/ 방어력: {characterD[3]}");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }

            else if (randomNumber <= 15)
            {
                rareCount++;
                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("★★★★☆ 희긔 획득");
                Console.WriteLine($"{characterC[0]}/ {characterC[1]}/ 공격력: {characterC[2]}/ 방어력: {characterC[3]}");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }

            else if (randomNumber <= 45)
            {
                highCount++;
                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("★★☆☆☆ 고급 획득");
                Console.WriteLine($"{characterB[0]}/ {characterB[1]}/ 공격력: {characterB[2]}/ 방어력: {characterB[3]}");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }

            else
            {
                normalCount++;
                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("★☆☆☆☆ 일반 획득");
                Console.WriteLine($"{characterA[0]}/ {characterA[1]}/ 공격력: {characterA[2]}/ 방어력: {characterA[3]}");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }

        }

        static void character() // 캐릭터 상세정보 창
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("===============================================");
            Console.WriteLine("※ 캐릭터 등급별 상세정보 알림 ※");
            Console.WriteLine("===============================================");
            Console.ResetColor();
            Console.WriteLine($"{characterA[0]}/ {characterA[1]}/ 공격력: {characterA[2]}/ 방어력: {characterA[3]}");
            Console.WriteLine($"{characterB[0]}/ {characterB[1]}/ 공격력: {characterB[2]}/ 방어력: {characterB[3]}");
            Console.WriteLine($"{characterC[0]}/ {characterC[1]}/ 공격력: {characterC[2]}/ 방어력: {characterC[3]}");
            Console.WriteLine($"{characterD[0]}/ {characterD[1]}/ 공격력: {characterD[2]}/ 방어력: {characterD[3]}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("===============================================");
            Console.WriteLine("===============================================");
            Console.WriteLine("===============================================");
            Console.ResetColor();
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.Clear();
        }

        static void menu() // 시작 문구
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            Console.WriteLine("◈ 캐릭터 뽑기 상점에 오신걸 환영합니다! ◈");
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            Console.ResetColor();
            Thread.Sleep(15000);
            Console.Clear();
        }

    }
}


