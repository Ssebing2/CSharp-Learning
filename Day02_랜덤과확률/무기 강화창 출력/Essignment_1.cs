using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;





namespace _0707_서요셉.과제
{
    internal class Essignment_1
    {
        static int WeaponLevel = 0; // 강화수치
        static int AttackPower = 5;   // 공격력

        static void Main(string[] args)
        {
            menu();
            Weapon();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=======================================");
            Console.WriteLine("무기강화를 시작합니다!");
            Console.ResetColor();
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.ResetColor();
            Console.Clear();

            for (int i = 1; i < 6; i++) 
            {
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=======================================");
                Console.WriteLine("강화중...!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=======================================");
                Console.ResetColor();
                Console.WriteLine();

                Console.WriteLine("=======================================");
                Console.WriteLine($"[{i}]번째 강화시도...!");
                Console.WriteLine("=======================================");
                Enchant();
                Console.WriteLine($"나무막대기의 강화 수치 : {WeaponLevel} ");
                Console.WriteLine($"나무막대기의 공격 : {AttackPower} ");
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
            Console.WriteLine($"무기 : 나무막대기 {WeaponLevel}");
            Console.WriteLine($"공격력 : {AttackPower}");
            Console.WriteLine("===========================");
            Thread.Sleep(3000);

        }

        static void Enchant() // 무기 강화확률
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 101);

            if (randomNumber <= 10)
            {
                WeaponLevel++;
                AttackPower += 5;
                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("★★대성공★★");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }

            else if (randomNumber <= 60)
            {
                WeaponLevel ++;
                AttackPower ++;
                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("★성공★");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }

            else
            {
                if (WeaponLevel > 0)
                {
                    WeaponLevel--;
                    AttackPower--;
                }

                Thread.Sleep(3000);
                Console.WriteLine("=======================================");
                Console.WriteLine("실패...");
                Console.WriteLine("=======================================");
                Thread.Sleep(2000);
            }
                    
        }

        static void Weapon() // 무기 상태창
        {
             string weaponA = "나무막대기"; // 무기 이름
             int damage = 5;               // 데미지

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=======================================");
            Console.WriteLine("현재 무기 성능");
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine($"무기 : {weaponA}");
            Console.WriteLine($"공격력 : {damage}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Console.WriteLine();
            Thread.Sleep(2000);
            Console.Clear();
        }

        static void menu() // 시작 문구
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine("무기 강화 상점에 오신걸 환영합니다!");
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.ResetColor();
            Thread.Sleep(15000);
            Console.Clear();
        }

      
     








    }
}
