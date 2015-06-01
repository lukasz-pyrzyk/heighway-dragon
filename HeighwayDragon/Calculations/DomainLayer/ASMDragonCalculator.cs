// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

using System.Runtime.InteropServices;
using HeighwayDragon.Calculations.ServiceLayer;

namespace HeighwayDragon.Calculations.DomainLayer
{
	internal class AsmDragonCalculator : IDragonCalculator
	{
		private const string DLLPath = @"ASM\HeighwayDragonCalc.DLL";

		[DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
		private static extern int GetRandomNumber();

		[DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
		private static extern double CalcX1(double a, double b);

		[DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
		private static extern double CalcX2(double a, double b);

		[DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
		private static extern double CalcY1(double a, double b);

		[DllImport(DLLPath, CallingConvention = CallingConvention.StdCall)]
		private static extern double CalcY2(double a, double b);

		public bool ChooseTransformation()
		{
			//int random = GetRandomNumber();
			return 1 == 0;
		}

		public double CalculateX1(double x, double y)
		{
			double result = CalcX1(x, y);
			return result;
		}

		public double CalculateX2(double x, double y)
		{
			double result = CalcX2(x, y);
			return result;
		}

		public double CalculateY1(double x, double y)
		{
			double result = CalcY1(x, y);
			return result;
		}

		public double CalculateY2(double x, double y)
		{
			double result = CalcY2(x, y);
			return result;
		}
	}
}
