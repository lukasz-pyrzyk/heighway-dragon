// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

using HeighwayDragon.Calculations.ServiceLayer;

namespace HeighwayDragon.Calculations.DomainLayer
{
	public class CSharpCalculator : DragonCalculator, IDragonCalculator
	{
		/// <summary>
		/// First transformation for x property
		/// x' = -0.4 * x - 1
		/// </summary>
		public float CalculateX1(float x, float y)
		{
			float result = -0.4F * x - 1;
			return result;
		}

		/// <summary>
		/// First transformation for y property
		/// y' = -0.4 * y + 0.1
		/// </summary>
		public float CalculateY1(float x, float y)
		{
			float result = -0.4F * y + 0.1F;
			return result;
		}

		/// <summary>
		/// Second transformation for x property
		/// x' = 0.76 * x - 0.4 * y
		/// </summary>
		public float CalculateX2(float x, float y)
		{
			float result = 0.76F * x - 0.4F * y;
			return result;
		}

		/// <summary>
		/// Second transformation for y property
		/// y' = 0.4 * x + 0.76 * y
		/// </summary>
		public float CalculateY2(float x, float y)
		{
			float result = 0.4F * x + 0.76F * y;
			return result;
		}
	}
}
