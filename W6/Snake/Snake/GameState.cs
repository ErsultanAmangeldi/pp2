using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;

namespace snake1
{
    public class GameState
    {
        public Worm worm = new Worm('O');
        public Food food = new Food('@');
        public Wall wall = new Wall('#');
        Timer timer = new Timer();
        
        XmlSerializer xmlSerizalizer = new XmlSerializer(typeof(GameState));
        public GameState()
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;

        }
        public void Reset()
        {
            Console.Clear();
            timer.Elapsed -= Timer_Elapsed;
        }
        public void Save()
        {
            using (FileStream fileStream = new FileStream("game.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerizalizer.Serialize(fileStream, this);
            }
        }
        public GameState  Load()
        {
            GameState res = null;
            using (FileStream fileStream = new FileStream("game.xml", FileMode.Open, FileAccess.Read))
            {
               res =xmlSerizalizer.Deserialize(fileStream) as GameState;
            }
            return res;
        }
        public void Run()
        {
           
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 220;
            timer.Start();
            food.Draw();
            wall.Draw();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            worm.Clear();
            worm.Move();
            worm.Draw();
            PrintInfo(worm.body[0].ToString() + "===" +food.body[0].ToString());
            CheckCollision();
        }
       

        public void PrintInfo(string message)
        {
            Console.SetCursorPosition(0, 37);
            Console.Write(message);
        }

        public void PressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Dx = 0;
                    worm.Dy =-1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.Dx = 0;
                    worm.Dy = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Dx = -1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.RightArrow:
                    worm.Dx=1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.Spacebar:
                    timer.Enabled = !timer.Enabled;
                    break;
                    
            }
            
        }

        public void CheckCollision()
        {
            if (worm.CheckIntersection(food.body) == true)
            {
                worm.Eat(food.body);
                food.Generate();
                food.Draw();
            }
        }
    }
}
