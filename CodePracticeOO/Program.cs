using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //int dieRoll = random.Next(6) + 1;
            //Console.WriteLine(dieRoll);
            //Console.ReadKey();

            var blue = new Color(0, 255, 0);
            var red = new Color(255, 0, 0);
            var green = new Color(0, 0, 255);
            var blueBall = new Ball(10, blue);
            var redBall = new Ball(5, red);
            var greenBall = new Ball(15, green);

            for (int i = 1; i <= 10; i++)
            {
                blueBall.Throw();
            }
            
            for (int i = 1; i <= 5; i++)
            {
                redBall.Throw();
            }

            for (int i = 1; i <= 15; i++)
            {
                greenBall.Throw();
            }

            blueBall.Pop();

            for (int i = 1; i <= 10; i++)
            {
                blueBall.Throw();
            }

            Console.WriteLine($"Blue ball has been thrown {blueBall.DisplayTimesThrown()} times");
            Console.WriteLine($"Red ball has been thrown {redBall.DisplayTimesThrown()} times");
            Console.WriteLine($"Green ball has been thrown {greenBall.DisplayTimesThrown()} times");
            Console.ReadKey();
        }
    }
}
