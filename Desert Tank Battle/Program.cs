using System;

namespace Desert_Tank_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESERT TANK BATTLE");

            Tank tank = new Tank(5);
            Target target = new Target(new Random());
            bool success = false;

            while (tank.RemainingShots > 0)
            {
                tank.Fire(UserInput.GetDirection(), UserInput.GetElevation());
                if (target.WasHit(tank.ShotDirection, tank.ShotDistance))
                {
                    Console.WriteLine("*KABOOOMMM*");
                    Console.WriteLine("YOU'VE DONE IT");
                    success = true;
                    break;
                }
                else
                {
                    Console.Write("MISSILE LANDED ");
                    if (tank.ShotDirection < target.Direction)
                    {
                        Console.Write("TO THE LEFT ");
                    }
                    else if (tank.ShotDirection > target.Direction)
                    {
                        Console.Write("TO THE RIGHT ");
                    }
                    if (Math.Abs(tank.ShotDistance - target.Distance) > 0.05 && tank.ShotDirection != target.Direction)
                    {
                        Console.Write("AND ");
                    }
                    if (target.Distance - tank.ShotDistance > 0.05)
                    {
                        Console.Write("NOT FAR ENOUGH");
                    }
                    else if (tank.ShotDistance - target.Distance > 0.05)
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
