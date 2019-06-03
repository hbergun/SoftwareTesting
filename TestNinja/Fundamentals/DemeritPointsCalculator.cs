
using System;

namespace TestNinja.Fundamentals
{
    public class DemeritPointsCalculator
    {
        private const int SPEEDLIMIT = 65;
        private const int MAXSPEED = 300;

        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MAXSPEED)
                throw new ArgumentOutOfRangeException();

            if (speed <= SPEEDLIMIT)
                return 0;

            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - SPEEDLIMIT) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}
