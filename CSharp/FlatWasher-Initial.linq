<Query Kind="Program" />

void Main()
{
	int quantity = 2000; // total quantity
	double density = 5000.6; // density in kg / m^3
	double thickness = 3.3; // in milimeters;
	int outerDiameter = 8, innerDiameter = 5; // in milimeters
	
	double outerArea = Math.PI * (outerDiameter / 1000.0 / 2.0) * (outerDiameter / 1000.0 / 2.0);
	double innerArea = Math.PI * (innerDiameter / 1000.0 / 2.0) * (innerDiameter / 1000.0 / 2.0);
	double area = outerArea - innerArea;
	double volume = thickness / 1000 * area;
	double weight = density * volume;
	double totalWeight = quantity * weight;
	
	totalWeight.Dump();
}

// Define other methods and classes here



