using System;

namespace HeighwayDragon.Classes
{
    public class DragonPoint
    {
        public double X { get; }
        public double Y { get; }

        public DragonPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        // TODO extract transformation to the UI
        public int CalculateXPosition(double minValueInPoints, double maxValueInPoints, int width)
        {
            if (X != maxValueInPoints)
            {
                double distance = maxValueInPoints - minValueInPoints;
                double proportionToMaxWidth = (maxValueInPoints - X) / distance;
                double position = proportionToMaxWidth * width;
                return (int)Math.Ceiling(position) - 1;
            }
            return width - 1;
        }

        public int CalculateYPosition(double minValueInPoints, double maxValueInPoints, int width)
        {
            if (Y != maxValueInPoints)
            {
                double distance = maxValueInPoints - minValueInPoints;
                double proportionToMaxWidth = (maxValueInPoints - Y) / distance;
                double position = proportionToMaxWidth * width;
                return (int)Math.Ceiling(position) - 1;
            }
            return width - 1;
        }
    }
}
