using System;

namespace Desert_Tank_Battle
{
    /// <summary>
    /// Represents the player's tank
    /// </summary>
    public class Tank
    {
        int _ammo;
        int _shotDirection;
        double _shotDistance;

        /// <summary>
        /// How far the last shot was
        /// </summary>
        public double ShotDistance { get { return _shotDistance; } }
        
        /// <summary>
        /// The direction of the last shot
        /// </summary>
        public int ShotDirection {  get { return _shotDirection; } }
        
        /// <summary>
        /// How many shots remain
        /// </summary>
        public int RemainingShots { get {  return _ammo; } } 

        /// <summary>
        /// Create a tank with x number of shots
        /// </summary>
        /// <param name="ammo"></param>
        public Tank(int ammo)
        {
            _ammo = ammo;
        }

        /// <summary>
        /// Fire in a particular direction and elevation.  Will calculate the shot distance
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="elevation"></param>
        public void Fire(int direction, int elevation)
        {
            _ammo--;
            _shotDirection = direction;
            _shotDistance = Math.Sin(2 * (elevation / 180.0 * Math.PI));
        }
    }
}
