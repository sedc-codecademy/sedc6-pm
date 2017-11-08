<Query Kind="Program" />

void Main()
{
	float xyz = 1;
	var area = GetCircleArea(xyz);
	area.Dump();
	
	xyz = 2;
	area = GetCircleArea(xyz);
	area.Dump();
	
	xyz = 3;
	area = GetCircleArea(xyz) + 2;
	area.Dump();
	
	GetCircleArea(10).Dump();
}

// Define other methods and classes here

double GetCircleArea(double radius) {
	var area = Math.PI * Math.Pow(radius,2);
	return area;
}
