// ======== Module 1 - Assignment ===========


//  Write() = Single Line Display (no return, remain on same line)
Console.Write("How many cans of Monster did you drink today? ");
//Prevent user from entering something that cannot be converted into a number
//define a variable for data entered by the user
int userInput;
// is the users input Valid?  Boolean (True/False)
bool validUserInput = Int32.TryParse(Console.ReadLine(), out userInput);
/*Integer Tools used, try to change (string-user input) to (integer number-user input)
& if sucessful will set the value to the userInput variable */
//Loop until user enters WHOLE number
while(!validUserInput)
{
    //if user did not enter a valid input (s/b integer) inform the user to try again.
    Console.WriteLine("Please enter a WHOLE number.");
    //repeat original request
    Console.Write("How many cans of Monster did you drink today? ");
    // is the users input Valid?  Boolean (True/False)
    //continue to try until user enters WHOLE number.
    validUserInput = Int32.TryParse(Console.ReadLine(), out userInput);
}
// 16 oz servings needed - (2 servings/can)
int numOfServings = userInput * 2;
// per 8oz serving 
int caloriesConsumed  = 110;
int sugarInGramsConsumed = 27;
int caffineInMilligramConsumed = 80;
//  WriteLine() = Single Line display (return, start new line) 
Console.WriteLine("You consumed: ");
Console.WriteLine(numOfServings * caloriesConsumed + " calories ");
Console.WriteLine(numOfServings * sugarInGramsConsumed + "g sugar");
Console.WriteLine(numOfServings * caffineInMilligramConsumed + "mg caffeine ");



