using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = 200;
            
            Wall wall = new Wall(100, 30);
            wall.Draw();

            Point p1 = new Point(4, 5, '*');
            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreater foodCreator = new FoodCreater(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (wall.IsHit(snake) || snake.IsHitTail())
                    break;

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    if (speed > 30)
                        speed -= 5;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(speed);
                snake.Move();
            }

            Console.ReadLine();
        }

    }
}
