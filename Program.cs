//if else and ternary
Console.Write("Type your age: ");
int userAge = int.Parse(Console.ReadLine()!);

if (userAge <= 13)
{
    Console.WriteLine("child");
} else if (userAge > 13 && userAge <= 20)
{
    Console.WriteLine("teenager");
} else
{
    Console.WriteLine("adult");
}

string userAgeRange = userAge <= 13 ? "child" : userAge > 13 && userAge <= 20 ? "teenager" : "adult";
Console.WriteLine($"The user is {userAge}, therefore the user is: {userAgeRange}");

// switch
Console.Write("Type your grade (A, B or C): ");
string userGrade = Console.ReadLine()!;

switch (userGrade)
{
    case "A":
        Console.WriteLine("Excellent");
        break;
    case "B":
        Console.WriteLine("Average");
        break;
    case "C":
        Console.WriteLine("Fail");
        break;
    default:
        Console.WriteLine("Unknown grade");
        break;
}

// while loop
int sum = 0;
int num = 1;

while (num <= 100)
{
    sum += num;
    num += 1;
    Console.WriteLine(sum);
}

// do while
int chosenNumber = 7;
int userNumber;

do
{
    Console.Write("A number was chosen. Guess what number: ");
    userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber < chosenNumber)
    {
        Console.WriteLine("The chosen number is greater. Guess again.");
    } else if ( userNumber > chosenNumber)
    {
        Console.WriteLine("The chosen number is smaller. Guess again.");
    } else
    {
        Console.WriteLine("Ta-da! Correct number!");
    }
} while (userNumber != chosenNumber); // after the execution of "do", "while" will be checked: if true, loop again; if false, break

// break and continue

int number = 0;

for (number = 0; number < 20; number++)
{
    if (number % 2 != 0)
    {
        Console.WriteLine(number);
    }
    
    if (number == 15)
    {
        break;
    }

}