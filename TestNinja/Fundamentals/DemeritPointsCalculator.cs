
using System;

namespace TestNinja.Fundamentals
{
    public class DemeritPointsCalculator
    {
        private const int SPEEDLIMIT = 65;
        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException();

            if (speed <= SPEEDLIMIT)
                return 0;

            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - SPEEDLIMIT) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}
