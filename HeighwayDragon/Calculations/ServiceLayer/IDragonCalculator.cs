// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

namespace HeighwayDragon.Calculations.ServiceLayer
{
	public interface IDragonCalculator
	{
		bool ChooseTransformation();
		double CalculateX1(double x, double y);
		double CalculateX2(double x, double y);
		double CalculateY1(double x, double y);
		double CalculateY2(double x, double y);
	}
};
