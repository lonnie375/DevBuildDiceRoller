Console.WriteLine("Welcome to the Grand Circus Casino!");

Console.Write("How many sides should each die have?: "); 
string userInput = Console.ReadLine();
int numberSides; 
bool correction = int.TryParse(userInput, out numberSides);

bool integer = false;

while (integer == false)
{
    if (correction)
    {
        integer = true;
    }
    else
    {
        Console.WriteLine("Please enter a integer.");
        userInput = Console.ReadLine();
        correction = int.TryParse(userInput, out numberSides);
    }

}


int firstDice = DieGenerator(numberSides);
int secondDice = DieGenerator(numberSides);

if (numberSides == 6)
{
    Console.WriteLine("Roll:");
    Console.WriteLine($"You rolled a {firstDice} and a {secondDice} ({firstDice + secondDice} total)");
    Console.WriteLine(SixSided(firstDice, secondDice));

    

    bool end = false; 
    while (!end)
    {
        Console.Write("Roll again? (y/n): ");
        string input = Console.ReadLine().ToLower();
        if (input == "y")
        {
            int thirdDice = DieGenerator(numberSides);
            int fourthDice = DieGenerator(numberSides); 
            Console.WriteLine("Roll:");
            Console.WriteLine($"You rolled a {thirdDice} and a {fourthDice} ({thirdDice + fourthDice} total)");
            Console.WriteLine(SixSided(thirdDice, fourthDice));
            
        }
        else
        {
            end = true;
            Console.WriteLine("Thanks for Playing!!");
        }

    }
 
} 
else 
{
    Console.WriteLine("Roll 1:");
    Console.WriteLine($"You rolled a {firstDice} and a {secondDice} ({firstDice + secondDice} total)");
    Console.WriteLine(DiceCombo(firstDice, secondDice));

    bool end = false;
    while (!end)
    {
        Console.Write("Roll again? (y/n): ");
        string input = Console.ReadLine().ToLower();
        if (input == "y")
        {
            int thirdDice = DieGenerator(numberSides);
            int fourthDice = DieGenerator(numberSides);
            Console.WriteLine("Roll:");
            Console.WriteLine($"You rolled a {thirdDice} and a {fourthDice} ({thirdDice + fourthDice} total)");
            Console.WriteLine(DiceCombo(thirdDice, fourthDice));

        }
        else
        {
            end = true;
            Console.WriteLine("Thanks for Playing!!");
        }

    }








}







//Method to generate random numbers 
static int DieGenerator(int numberSides)
{
    Random random = new Random();
    int dieValue = random.Next(1, numberSides + 1);
    return dieValue;
}

//Create a method for six-sided dice that takes two dice values as parameters, and returns a string for one of the valid combinations
static string SixSided(int firstDice, int secondDice)
{
    if (firstDice == 1 && secondDice == 1)
    {
        return "Snake Eyes"; 
    }
    else if (firstDice == 1 && secondDice == 2)
    {
        return "Ace Deuce"; 
    }
    else if (firstDice == 6 && secondDice == 6)
    {
        return "Box Cars"; 
    }
    else if (firstDice + secondDice == 7 || firstDice + secondDice == 11)
    {
        return "You win"; 
    }
    else if (firstDice + secondDice == 2 || firstDice + secondDice == 3 || firstDice + secondDice == 12)
    {
        return "Craps"; 
    }
    else
    {
        return " "; 
    }
}

//Create a static method to implement output for different dice combinations 
static string DiceCombo(int firstDice, int secondDice)
{
    if (firstDice == secondDice)
    {
        return "Double Trouble"; 
    }
    else 
    {
        return " "; 
    }
}


