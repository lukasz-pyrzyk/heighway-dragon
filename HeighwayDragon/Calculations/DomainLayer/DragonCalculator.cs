// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

using System;
using HeighwayDragon.Calculations.ServiceLayer;

namespace HeighwayDragon.Calculations.DomainLayer
{
	internal class DragonCalculator : IDragonCalculator
	{
		private readonly Random random;

		public DragonCalculator()
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

		/// <summary>
		/// First transformation for x property
		/// x' = -0.4 * x - 1
		/// </summary>
		public double CalculateX1(double x, double y)
		{
			double result = -0.4 * x - 1;
			return result;
		}

		/// <summary>
		/// First transformation for y property
		/// y' = -0.4 * y + 0.1
		/// </summary>
		public double CalculateY1(double x, double y)
		{
			double result = -0.4 * y + 0.1;
			return result;
		}

		/// <summary>
		/// Second transformation for x property
		/// x' = 0.76 * x - 0.4 * y
		/// </summary>
		public double CalculateX2(double x, double y)
		{
			double result = 0.76 * x - 0.4 * y;
			return result;
		}

		/// <summary>
		/// Second transformation for y property
		/// y' = 0.4 * x + 0.76 * y
		/// </summary>
		public double CalculateY2(double x, double y)
		{
			double result = 0.4 * x + 0.76 * y;
			return result;
		}
	}
}
