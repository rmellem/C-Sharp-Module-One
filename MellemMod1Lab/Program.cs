//  ========= LAB A ===========


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int (= integer)
//double (= fractional/decimal data)

Console.Write("Input first number: ");
string inputOne = Console.ReadLine();

//Console.WriteLine(inputOne);
// Object.Method(Arguement)

Console.Write("Input second number: ");
string inputTwo = Console.ReadLine();

int intOne = Convert.ToInt32(inputOne);
int intTwo = Convert.ToInt32(inputTwo);

Console.WriteLine(inputOne + " + " + inputTwo + " = " + (intOne + intTwo));
// PEMDAS Grouping operater
Console.WriteLine(inputOne + " - " + inputTwo + " = " + (intOne - intTwo));
Console.WriteLine(inputOne + " * " + inputTwo + " = " + (intOne * intTwo));


Console.Write("Input width: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Input height: ");
int height = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Area: " + width * height);


//========= LAB B ===========     


Console.Write("How many cupcakes would you like to make? " );
int numOfCupcakes = Convert.ToInt32(Console.ReadLine());
// per one cupcake
double eggsNeeded = .5;
double cupSugarNeeded = .125;
double creamCheeseNeeded = .375;
double vanillaNeeded = .125;

Console.WriteLine(numOfCupcakes * eggsNeeded + " eggs ");
Console.WriteLine(numOfCupcakes * cupSugarNeeded + " cup sugar ");
Console.WriteLine(numOfCupcakes * creamCheeseNeeded + " cream cheese ");
Console.WriteLine(numOfCupcakes * vanillaNeeded + " tsp vanilla ");













