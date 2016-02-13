namespace HeighwayDragon.Calculations
{
    public class CSharpCalculator : DragonCalculator
    {
        public override float CalculateX1(float x, float y)
        {
            float result = -0.4F * x - 1;
            return result;
        }

        public override float CalculateY1(float x, float y)
        {
            float result = -0.4F * y + 0.1F;
            return result;
        }

        public override float CalculateX2(float x, float y)
        {
            float result = 0.76F * x - 0.4F * y;
            return result;
        }

        public override float CalculateY2(float x, float y)
        {
            float result = 0.4F * x + 0.76F * y;
            return result;
        }
    }
}
