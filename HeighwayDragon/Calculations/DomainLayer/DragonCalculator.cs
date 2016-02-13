using System;

namespace HeighwayDragon.Calculations.DomainLayer
{
    public class DragonCalculator
    {
        private readonly Random random;

        protected DragonCalculator()
        {
            random = new Random();
        }

        /// <summary>
        /// Choose transformation by a random number
        /// </summary>
        /// <returns>Boolean, true if transformation 1, false if transformation 2</returns>
        public bool ChooseTransformation()
        {
            return random.Next(0, 2) == 0;
        }
    }
}
