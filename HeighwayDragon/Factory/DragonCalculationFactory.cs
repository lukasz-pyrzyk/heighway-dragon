// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

using HeighwayDragon.Calculations.DomainLayer;
using HeighwayDragon.Calculations.ServiceLayer;

namespace HeighwayDragon.Factory
{
	public class DragonCalculationFactory
	{
		public static IDragonCalculator NewCalculator()
		{
			return new DragonCalculator();
		}

		public static IDragonCalculator NewAsmCalculator()
		{
			return new AsmDragonCalculator();
		}
	}
}
