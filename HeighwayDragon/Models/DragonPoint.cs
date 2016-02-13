using System;

namespace HeighwayDragon.Models
{
    public class DragonPoint
    {
        private const float Tolerance = 0.005f;

        public double X { get; }
        public double Y { get; }
        
        public DragonPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Calculates position for X property basing on the proportion
        /// </summary>
        /// <param name="minValueInPoints">Minimum X value in the all Dragon points</param>
        /// <param name="maxValueInPoints">Maximum X value in the all dragon points</param>
        /// <param name="width">Width of the output, for example: bmp file</param>
        /// <returns>Proportional value of X </returns>
        public int CalculateXPosition(double minValueInPoints, double maxValueInPoints, int width)
        {
            if (Math.Abs(X - maxValueInPoints) > Tolerance)
            {
                double distance = maxValueInPoints - minValueInPoints;
                double proportionToMaxWidth = (maxValueInPoints - X) / distance;
                double position = proportionToMaxWidth * width;
                return (int)Math.Ceiling(position) - 1;
            }

            return width - 1;
        }

        /// <summary>
        /// Calculates position for Y property basing on the proportion
        /// </summary>
        /// <param name="minValueInPoints">Minimum Y value in the all Dragon points</param>
        /// <param name="maxValueInPoints">Maximum X value in the all dragon points</param>
        /// <param name="height">Height of the output, for example: bmp file</param>
        /// <returns>Proportional value of X </returns>
        public int CalculateYPosition(double minValueInPoints, double maxValueInPoints, int height)
        {
            if (Math.Abs(Y - maxValueInPoints) > Tolerance)
            {
                double distance = maxValueInPoints - minValueInPoints;
                double proportionToMaxWidth = (maxValueInPoints - Y) / distance;
                double position = proportionToMaxWidth * height;
                return (int)Math.Ceiling(position) - 1;
            }

            return height - 1;
        }
    }
}
