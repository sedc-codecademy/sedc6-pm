<Query Kind="Program" />

void Main()
{
	int quantity = 2000; // total quantity
	double density = 5000.6; // density in kg / m^3
	double thickness = 3.3; // in milimeters;
	int outerDiameter = 8, innerDiameter = 5; // in milimeters
	
	double totalWeight = quantity * GetWasherWeight(density, thickness / 1000.0, outerDiameter / 1000.0, innerDiameter / 1000.0);
	totalWeight.Dump();
}

// Define other methods and classes here
double GetWasherWeight(double density, double thickness, double outerDiameter, double innerDiameter){
	double volume = GetCilinderVolume(thickness, outerDiameter, innerDiameter );
	return density * volume;
}

double GetCilinderVolume(double height, double outerDiameter, double innerDiameter){
	double baseArea = GetCircleArea(outerDiameter) - GetCircleArea(innerDiameter);
	return height * baseArea; 
}

double GetCircleArea(double diameter){
	double radius = diameter / 2;
	double area = Math.PI * radius * radius;
	return area;
}