using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desert_Tank_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESERT TANK BATTLE");

            Random rnd = new Random();
            int targetDirection = (rnd.Next(0, 181))-90;
            double targetDistance = rnd.NextDouble();
            bool success = false;

            for (int attempts = 0; attempts < 5; attempts++)
            {
                int attemptDirection;
                do
                {
                    Console.WriteLine("DIRECTION (-90 TO 90) ?");
                } while (!int.TryParse(Console.ReadLine(), out attemptDirection) || attemptDirection < -90 || attemptDirection > 90);

                int attemptElevation;
                do
                {
                    Console.WriteLine("ELEVATION (0 TO 90) ?");
                } while (!int.TryParse(Console.ReadLine(), out attemptElevation) || attemptElevation < 0 || attemptElevation > 90);

                double attemptDistance = Math.Sin(2 * (attemptElevation / 180.0 * Math.PI));
                if (Math.Abs(targetDirection - attemptDirection) < 2 && Math.Abs(targetDistance - attemptDistance) < 0.05)
                {
                    Console.WriteLine("*KABOOOMMM*");
                    Console.WriteLine("YOU'VE DONE IT");
                    success = true;
                    break;
                }
                else
                {
                    Console.Write("MISSILE LANDED ");
                    if (attemptDirection < targetDirection)
                    {
                        Console.Write("TO THE LEFT ");
                    }
                    else if (attemptDirection > targetDirection)
                    {
                        Console.Write("TO THE RIGHT ");
                    }
                    if (Math.Abs(attemptDistance - targetDistance) > 0.05 && attemptDirection != targetDirection)
                    {
                        Console.Write("AND ");
                    }
                    if (targetDistance - attemptDistance > 0.05)
                    {
                        Console.Write("NOT FAR ENOUGH");
                    }
                    else if (attemptDistance - targetDistance > 0.05)
                    {
                        Console.Write("TOO FAR");
                    }
                    Console.WriteLine();
                }
            }

            if (!success)
            {
                Console.WriteLine("DISASTER - YOU FAILED");
                Console.WriteLine("RETREAT IN DISGRACE");
            }

            Console.ReadKey();
        }
    }
}
