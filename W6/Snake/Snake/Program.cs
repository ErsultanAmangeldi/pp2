using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState game = new GameState();
            game.Run();
            while (true)
            {
                
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.F2:
                        game.Save();
                        break;
                    case ConsoleKey.F3:
                        game.Reset();
                        game = game.Load();
                        game.Run();
                        break;
                    default:
                        game.PressedKey(consoleKeyInfo);
                        break;
                }
                
            }
        }
    }
}
