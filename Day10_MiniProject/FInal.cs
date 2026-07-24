using BurgerDream.Game;

namespace BurgerDream
{
    internal class FInal
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(220, 60);
            Console.SetWindowSize(220, 60);

            GameManager gameManager = new GameManager();
            Console.CursorVisible = false;

            gameManager.Start();
            
        }
    }
}

   

    

  
