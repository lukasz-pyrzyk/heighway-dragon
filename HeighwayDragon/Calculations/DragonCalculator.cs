using System;

namespace HeighwayDragon.Calculations
{
    public class DragonCalculator
    {
        private readonly Random _random = new Random();

        /// <summary>
        /// Choose transformation by a _random number
        /// </summary>
        /// <returns>Boolean, true if transformation 1, false if transformation 2</returns>
        public bool ChooseTransformation()
        {
            return _random.Next(0, 2) == 0;
        }

        /// <summary>
        /// First transformation for x property
        /// x' = -0.4 * x - 1
        /// </summary>
        public virtual float CalculateX1(float x, float y)
        {
            float result = -0.4F * x - 1;
            return result;
        }

        /// <summary>
        /// First transformation for y property
        /// y' = -0.4 * y + 0.1
        /// </summary>
        public virtual float CalculateY1(float x, float y)
        {
            float result = -0.4F * y + 0.1F;
            return result;
        }

        /// <summary>
        /// Second transformation for x property
        /// x' = 0.76 * x - 0.4 * y
        /// </summary>
        public virtual float CalculateX2(float x, float y)
        {
            float result = 0.76F * x - 0.4F * y;
            return result;
        }

        /// <summary>
        /// Second transformation for y property
        /// y' = 0.4 * x + 0.76 * y
        /// </summary>
        public virtual float CalculateY2(float x, float y)
        {
            float result = 0.4F * x + 0.76F * y;
            return result;
        }
    }
}
