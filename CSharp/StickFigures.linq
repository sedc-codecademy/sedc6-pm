<Query Kind="Program" />

void Main()
{
	DrawRocket();
	DrawDivider();
	DrawMale();
	DrawDivider();
	DrawFemale();
}

void DrawDivider(){
	Console.WriteLine("============");
}

// Define other methods and classes here
void DrawRocket(){
	DrawTriangle();
	DrawSquare();
	DrawInvertedV();
}

void DrawMale(){
	DrawCircle();
	DrawSquare();
	DrawInvertedV();
}

void DrawFemale(){
	DrawCircle();
	DrawTriangle();
	DrawInvertedV();
}

void DrawCircle(){
	Console.WriteLine("   **  ");
	Console.WriteLine(" *    *  ");
	Console.WriteLine(" *    *  ");
	Console.WriteLine("   **  ");
}

void DrawTriangle(){
	Console.WriteLine("   *   ");
	Console.WriteLine("  * *  ");
	Console.WriteLine(" *   * ");
	Console.WriteLine("*****");
}

void DrawSquare(){
	Console.WriteLine("*****");
	Console.WriteLine("*     *");
	Console.WriteLine("*     *");
	Console.WriteLine("*****");
}

void DrawInvertedV(){
	Console.WriteLine("   *   ");
	Console.WriteLine("  * *  ");
	Console.WriteLine(" *   * ");
	Console.WriteLine("*     *");
}