// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

using System.Runtime.InteropServices;
using HeighwayDragon.Calculations.ServiceLayer;

namespace HeighwayDragon.Calculations.DomainLayer
{
    internal class AssemblerCalculator : DragonCalculator, IDragonCalculator
    {
        private const string DLLPath = @"ASM\HeighwayDragonCalc.DLL";

        [DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
        private static extern void CalcX1(ref float x, ref float xMultiplier, ref float c, ref float result);

        [DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
        private static extern void CalcY1(ref float y, ref float yMultiplier, ref float c, ref float result);

        [DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
        private static extern void CalcX2(ref float x, ref float y, ref float xMultiplier, ref float yMultiplier, ref float result);

        [DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
        private static extern void CalcY2(ref float x, ref float y, ref float xMultiplier, ref float yMultiplier, ref float result);

        /// <summary>
        /// First transformation for x property
        /// x' = -0.4 * x - 1
        /// </summary>
        public float CalculateX1(float x, float y)
        {
            float xMultiplier = -0.4F;
            float c = 1;
            float result = 0;
            CalcX1(ref x, ref xMultiplier, ref c, ref result);
            return result;
        }

        /// <summary>
        /// First transformation for y property
        /// y' = -0.4 * y + 0.1
        /// </summary>
        public float CalculateY1(float x, float y)
        {
            float xMultiplier = -0.4F;
            float c = 0.1F;
            float result = 0;
            CalcY1(ref y, ref xMultiplier, ref c, ref result);
            return result;
        }

        /// <summary>
        /// Second transformation for x property
        /// x' = 0.76 * x - 0.4 * y
        /// </summary>
        public float CalculateX2(float x, float y)
        {
            float xMultiplier = 0.76F;
            float yMultiplier = 0.4F;
            float result = 0;
            CalcX2(ref x, ref y, ref xMultiplier, ref yMultiplier, ref result);
            return result;
        }

        /// <summary>
        /// Second transformation for y property
        /// y' = 0.4 * x + 0.76 * y
        /// </summary>
        public float CalculateY2(float x, float y)
        {
            float xMultiplier = 0.4F;
            float yMultiplier = 0.76F;
            float result = 0;
            CalcY2(ref x, ref y, ref xMultiplier, ref yMultiplier, ref result);
            return result;
        }
    }
}
