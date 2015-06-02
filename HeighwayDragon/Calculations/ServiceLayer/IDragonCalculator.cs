// Copyright (c) Lukasz Pyrzyk
// https://linkedin.com/in/lukaszpyrzyk
// All Rights Reserved
// Licensed under the MIT License

namespace HeighwayDragon.Calculations.ServiceLayer
{
	public interface IDragonCalculator
	{
		bool ChooseTransformation();
		float CalculateX1(float x, float y);
		float CalculateX2(float x, float y);
		float CalculateY1(float x, float y);
		float CalculateY2(float x, float y);
	}
};
