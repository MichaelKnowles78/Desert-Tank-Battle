using System;

namespace Desert_Tank_Battle
{
    /// <summary>
    /// Represents the target the player is trying to hit
    /// </summary>
    public class Target
    {
        readonly int _direction;
        readonly double _distance;

        public int Direction { get { return _direction; } }
        public double Distance { get { return _distance; } }

        /// <summary>
        /// Using a given randomiser, will create a target in a random direction and at a random distance
        /// </summary>
        /// <param name="randomiser"></param>
        public Target(Random randomiser)
        {
            _direction = (randomiser.Next(0, 181)) - 90;
            _distance = randomiser.NextDouble();
        }

        /// <summary>
        /// Given a direction and a distance, determine if the target has been hit
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="distanceFired"></param>
        /// <returns>true if target was hit</returns>
        public bool WasHit(int direction, double distanceFired)
        {
            return Math.Abs(Direction - direction) < 2 && Math.Abs(Distance - distanceFired) < 0.05;
        }
    }
}
