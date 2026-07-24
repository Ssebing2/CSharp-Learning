using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerDream.Game
{

    internal class StackGame // 균형게임
    {
        public static void Main(string[] args)
        {
            Console.SetBufferSize(220, 60);
            Console.SetWindowSize(220, 60);

            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
                      
            Play play = new Play(20, 5, 10, 90, 1, new TopBun());

            play.StartGame();

        }

    }

    public interface IMoveable
    {
        void MoveIngredient();

    }

    public abstract class Ingredient
    {
        protected string Ingredientname;
        protected int MoveSpeed;
        protected int score;
        protected string[] image;
        protected ConsoleColor color;

        public string[] Image
        {
            get { return image;  }
        }

        public ConsoleColor Color
        { 
            get { return color; } 
        }

        public int MoveDelay
        {
            get { return MoveSpeed; }
        }

        public int Score
        {
            get { return score; }
        }

        public string Name
        {
            get { return Ingredientname; }
        }

        protected Ingredient(string ingredientname, int moveSpeed, int score, ConsoleColor color)
        {
            this.Ingredientname = ingredientname;
            this.MoveSpeed = moveSpeed;
            this.score = score;
            this.image = Array.Empty<string>();
            this.color = color;
        }
    }

    public class TopBun : Ingredient
    {

        public TopBun()
            : base("TopBun", 2, 200, ConsoleColor.DarkYellow)
        {
            image = new string[]
            {
              "████████████████████████",
              "████████████████████████",
              "████████████████████████"
            };

        }
    }

    public class BottomBun : Ingredient
    {

        public BottomBun()
            : base("BottomBun", 50, 50, ConsoleColor.DarkYellow)
        {
            image = new string[]
            {
              "████████████████████████",
              "████████████████████████",
              "████████████████████████"
            };

        }
    }

    public class Patty : Ingredient
    {

        public Patty()
            : base("Patty", 30, 70, ConsoleColor.Red)
        {
            image = new string[]
            {
              "█████████████████████",
              "█████████████████████",
              "█████████████████████"
            };

        }
    }

    public class Cheese : Ingredient
    {

        public Cheese()
            : base("Cheese", 10, 100, ConsoleColor.Yellow)
        {
            image = new string[]
            {
              "██████████████████████",
              "██████████████████████",
              "██████████████████████"
            };

        }
    }

    public class Lettuce : Ingredient
    {

        public Lettuce()
            : base("Lettuce", 8, 130, ConsoleColor.DarkGreen)
        {
            image = new string[]
            {
              "██████████████████████████",
              "██████████████████████████",
              "██████████████████████████"
            };

        }
    }

    public class Tomato : Ingredient
    {

        public Tomato()
            : base("Tomato", 6, 150, ConsoleColor.DarkRed)
        {
            image = new string[]
            {
              "██████████████████",
              "██████████████████",
              "██████████████████"
            };

        }
    }

    public class Pickle : Ingredient
    {

        public Pickle()
            : base("Pickle", 5, 180, ConsoleColor.Green)
        {
            image = new string[]
            {
              "███████████",
              "███████████",
              "███████████"
            };

        }
    }

    public class Play : IMoveable
    {
        int ingredientX;   // 시작 X 좌표
        int ingredientY;   // 움직일 Y 좌표
        int minX;          // 왼쪽 끝
        int maxX;          // 오른쪽 끝
        int direction;     // 1은 오른쪽, -1은 왼쪽  
        private Ingredient currentIngredient;
        int previousCenterX;              // 이전에 쌓인 재료의 중앙 X좌표
        bool hasPreviousIngredient = false; // 이전 재료가 있는지 확인
        int totalScore = 0; // 점수 저장
        int combo = 0; // 콤보
        int tilt = 0; // 기울기 값
        const int collapseLimit = 8; // 기울기 한계치
        int currentRound = 1; // 현재 라운드
        const int maxRound = 3; // 최대 라운드

        public Play (int ingredientX, int ingredientY, int minX, int maxX, int direction, Ingredient currentIngredient)
        {
            this.ingredientX = ingredientX;
            this.ingredientY = ingredientY;
            this.minX = minX;
            this.maxX = maxX;
            this.direction = direction;
            this.currentIngredient = currentIngredient;
        }

        public void StartGame()
        {
            for (int i = 1; i < 3 ; i++)
            {
                Console.SetCursorPosition(55, 2);
                Console.WriteLine($"{i}번째 주문 햄버거!");
                for (currentRound = 1; currentRound <= maxRound; currentRound++)
                {
                    ResetRound();
                    StartRound();
                    Console.Clear();
                }
            }
           
        }

        private void ResetRound() // 라운드 초기화
        {
            tilt = 0;
            combo = 0;

            previousCenterX = 0;
            hasPreviousIngredient = false;
        }

        public void StartRound()
        {
            Ingredient[] ingredients = GetRoundIngredients(currentRound);

            int stackY = 30;

            

            for (int i = 0; i < ingredients.Length; i++)
            {
                currentIngredient = ingredients[i];

                ingredientX = 20;
                ingredientY = 5;
                direction = 1;

                int landingY = stackY - currentIngredient.Image.Length;

                MoveIngredient();
                DropIngredient(landingY);

                int currentCenterX =
                ingredientX + currentIngredient.Image[0].Length / 2;


                if (hasPreviousIngredient == false)
                {
                    previousCenterX = currentCenterX;
                    hasPreviousIngredient = true;
                }
                else
                {
                    Result result = JudgePlacement(out int gap);
                    int addedScore = AddScore(result);


                    Console.SetCursorPosition(95, 8);
                    Console.Write($"재료 : {currentIngredient.Name}       ");
                    Console.SetCursorPosition(95, 10);
                    Console.Write($"기본 점수 : {currentIngredient.Score}      ");
                    Console.SetCursorPosition(95, 12);
                    Console.Write($"판정 : {result} + {addedScore}점         ");
                    Console.SetCursorPosition(95, 14);
                    Console.Write($"점수 : {totalScore}      ");
                    UpdateCombo(result);
                    UpdateTilt(result, gap);
                    Console.SetCursorPosition(20, 12);
                    Console.Write($"+ {combo} Combo!");
                    double multiplier = GetComboMultiplier();

                    if (IsCollapsed())
                    {
                        Console.SetCursorPosition(50, 25);
                        Console.WriteLine("버거의 균형이 무너졌습니다!");
                        Console.SetCursorPosition(50, 27);
                        Console.WriteLine("와르르르... 🍔");

                        Console.ReadKey(true);
                        return;
                    }

                    previousCenterX = currentCenterX;
                }

                stackY = landingY;
            }
        }

        public void MoveIngredient() // ingredients 좌/우 움직임
        {
            while (true)
            {
                EraseIngredient();

                ingredientX += direction;

                if (ingredientX >= maxX)
                {
                    direction = -1;
                }
                else if (ingredientX <= minX)
                {
                    direction = 1;
                }

                Console.SetCursorPosition(ingredientX, ingredientY);
                DrawIngredient();

                if (Console.KeyAvailable) // Enter나 Space누를시 착지
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
                    {
                        break;
                    }

                }
                Thread.Sleep(currentIngredient.MoveDelay);
            }
        }
        public void DropIngredient(int stackY) // 키 입력시 y좌표로 착지
        {
            while (ingredientY < stackY)
             {
                Console.SetCursorPosition(ingredientX, ingredientY);
                EraseIngredient();

                ingredientY++;

                Console.SetCursorPosition(ingredientX, ingredientY);
                DrawIngredient();

            
             }
        }

        private void DrawIngredient() // 이미지 출력
        {
            Console.ForegroundColor = currentIngredient.Color;

            for (int i = 0; i < currentIngredient.Image.Length; i++)
            {
                Console.SetCursorPosition(ingredientX, ingredientY + i);
                Console.Write(currentIngredient.Image[i]);
            }
        }

        private void EraseIngredient() // ingredients 이미지 외 공백
        {
            for (int i = 0; i < currentIngredient.Image.Length; i++)
            {
                Console.SetCursorPosition(ingredientX, ingredientY + i);

                Console.Write(new string(' ', currentIngredient.Image[i].Length));
            }
        }

        enum Result
        {
            Perfect,
            Good,
            Miss
        }

        private Result JudgePlacement(out int gap) // 판정
        {
            int currentCenterX =
                ingredientX + currentIngredient.Image[0].Length / 2;

            gap = currentCenterX - previousCenterX;

            int distance = Math.Abs(gap);

            if (distance == 0)
            {
                return Result.Perfect;
            }
            else if (distance <= 3)
            {
                return Result.Good;
            }
            else
            {
                return Result.Miss;
            }


        }

        private int AddScore(Result result) // 점수
        {
            int baseScore = 0;

            if (result == Result.Perfect)
            {
                baseScore = currentIngredient.Score;
            }
            else if (result == Result.Good)
            {
                baseScore = currentIngredient.Score / 2;
            }

            double multiplier = GetComboMultiplier();

            int addedScore = (int)(baseScore * multiplier);

            totalScore += addedScore;

            return addedScore;
        }

        private void UpdateCombo(Result result) // 콤보
        {
            if (result == Result.Perfect || result == Result.Good)
            {
                combo++;
            }
            else
            {
                combo = 0;
            }
        }

        private double GetComboMultiplier() // 콤보 점수
        {
            if (combo >= 5)
            {
                return 1.5;
            }
            else if (combo >= 3)
            {
                return 1.2;
            }
            else
            {
                return 1.0;
            }
        }

        private void UpdateTilt(Result result, int gap) // 기울기 처리 함수
        {
            if (result == Result.Perfect)
            {
                return;
            }

            tilt += gap;
        }

        private bool IsCollapsed() // 붕괴
        {
            return Math.Abs(tilt) >= collapseLimit;
        }

        private Ingredient[] GetRoundIngredients(int round) // 라운드 배열
        {
            if (round == 1)
            {
                return new Ingredient[]
                {
            new BottomBun(),
            new Patty(),
            new Cheese(),
            new TopBun()
                };
            }
            else if (round == 2)
            {
                return new Ingredient[]
                {
            new BottomBun(),
            new Patty(),
            new Cheese(),
            new Lettuce(),
            new Tomato(),
            new TopBun()
                };
            }
            else
            {
                return new Ingredient[]
                {
            new BottomBun(),
            new Patty(),
            new Cheese(),
            new Lettuce(),
            new Tomato(),
            new Pickle(),
            new TopBun()
                };
            }
        }
    }

}