using HeighwayDragon.Calculations;

namespace HeighwayDragon.Factory
{
    public class DragonCalculationFactory
    {
        public static IDragonCalculator CSharpCalculator()
        {
            return new CSharpCalculator();
        }

        public static IDragonCalculator NewAsmCalculator()
        {
            return new AssemblerCalculator();
        }
    }
}
