using System;

namespace HeighwayDragon.Calculations
{
    public abstract class DragonCalculator
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

        public abstract float CalculateX1(float x, float y);
        public abstract float CalculateX2(float x, float y);
        public abstract float CalculateY1(float x, float y);
        public abstract float CalculateY2(float x, float y);
    }
}
