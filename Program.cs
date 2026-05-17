// declarations and literals
int yearFoundationAsCity = 1238; // 32‑bit whole numbers, range about ±2 billion
long population = 74879; // 64‑bit whole numbers, much larger range
float lowestTemp = -10.2F; // 32‑bit floating‑point number
float highestTemp = 37.5F;
double spaguettieisPrice = 5.99D; // 64‑bit floating‑point number
string city = "Arnsberg"; // sequences of characters
// char firstLetter = 'a'; a single character - use ' instead of "

Console.WriteLine($"I live in {city}, a city with {population} habitants founded in {yearFoundationAsCity}. The lowest temperature in 2025 was {lowestTemp}C and the highest was {highestTemp}C. Funfact: by law, the Spaguettieis here costs only {spaguettieisPrice} euros.");

// arithmetic and integer division
int a = 10;
int b = 3;

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

// comparison and logical operators
Console.WriteLine(a > b);
Console.WriteLine(a < b);
Console.WriteLine(a == b);
Console.WriteLine(a != b);

bool resultOne = ((a + b) > 10) && ((a - b) < 10);
Console.WriteLine(resultOne);

bool resultTwo = ((a + b) < 10) || ((a - b) > 10);
Console.WriteLine(resultTwo);

// compound assignment and increment

int counter = 0;

while (counter < 5)
{
    Console.WriteLine(counter++);
}

// mini challenge
double weightKg = 101.21D;
double heightM = 1.75D;

int bmi = (int)(weightKg / heightM * heightM);

string bmiResult = bmi > 18.5F && bmi < 24.9F ? "Normal BMI" : bmi > 24.9F ? "High BMI" : "Low BMI";
Console.WriteLine($"{bmi} means {bmiResult}");