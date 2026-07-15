using System;
using System.Threading;
using Monsters;


namespace _0715_서요셉
{
    internal class Final
    {
        class Monster
        {
            // 필드 작성
            private string _name; // 이름
            private string _SpawnArea; // 출몰 지역
            private string _risk; // 위험도
            private string _Characteristic; // 한줄 소개
            private int _x; // x 위치
            private int _y; // y 위치
            private Action _PrintCharacter; // 도트 캐릭터

            // 생성자
            public Monster(string name, string spawnArea, string risk, string characteristic, Action printCharacter)
            {
                _name = name;
                _x = 0;
                _y = 0;
                _SpawnArea = spawnArea;
                _risk = risk;
                _Characteristic = characteristic;
                _PrintCharacter = printCharacter; 
            }


            // 몬스터 상태 출력
            public void PrintStatus(int i)
            {
                SetPosition((i * 30), 2);
                Console.WriteLine($"이름: {_name}");
                SetPosition((i * 30), 3);
                Console.WriteLine($"출몰 지역: {_SpawnArea}");
                SetPosition((i * 30), 4);
                Console.WriteLine($"위험도: {_risk}");
                SetPosition((i * 30), 5);
                Console.WriteLine($"한줄 소개: {_Characteristic}");
            }

            // 도트 출력 함수
            public void PrintCharacter()
            {
                _PrintCharacter();
            }

            // 몬스터 위치
            public void SetPosition(int x, int y)
            {
                this._x = x;
                this._y = y;
            }

            static void Main(string[] args)
            {
                ConsolePrint.Title();
                Console.ReadKey();
                Console.Clear();

                Monster[] monsters = new Monster[]
                {
                new Monster("BunE", "햄버거빌딩", "★★★★★", "햄버거가게 사장으로 돈을 날리며 공격", Monsters.Monsters.PrintBun),
                new Monster("Patty", "햄버거가게", "☆☆★★★", "햄버거가게 요리사로 패티를 던지며 공격",Monsters.Monsters.PrintPatty),
                new Monster("ConE", "햄버거가게근처 서성임", "☆☆☆★★", "햄버거가게 단골 꼬마손님으로 울음 데시벨공격",Monsters.Monsters.PrintCone)

                };

                for (int i = 0; i < monsters.Length; i++)
                {
                    monsters[i].PrintCharacter();
                    monsters[i].PrintStatus(i);
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                
            }
        }
    }
}
