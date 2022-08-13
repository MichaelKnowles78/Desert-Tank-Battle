using System;

namespace Desert_Tank_Battle
{
    /// <summary>
    /// Class to handle the inputting of data from the user
    /// </summary>
    public static class UserInput
    {
        /// <summary>
        /// Get an integer value between -90 and 90
        /// </summary>
        /// <returns></returns>
        public static int GetDirection()
        {
            int attemptDirection;
            do
            {
                Console.WriteLine("DIRECTION (-90 TO 90) ?");
            } while (!int.TryParse(Console.ReadLine(), out attemptDirection) || attemptDirection < -90 || attemptDirection > 90);

            return attemptDirection;
        }

        /// <summary>
        /// Get an integer value between 0 and 90
        /// </summary>
        /// <returns></returns>
        public static int GetElevation()
        {
            int attemptElevation;
            do
            {
                Console.WriteLine("ELEVATION (0 TO 90) ?");
            } while (!int.TryParse(Console.ReadLine(), out attemptElevation) || attemptElevation < 0 || attemptElevation > 90);

            return attemptElevation;
        }
    }
}
