using System.Threading.Tasks.Sources;

var games = new List<string>();
string name = GetName();
var date = DateTime.Now;

Menu(name);

string GetName()
{
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("------------------------------------------------------");
    Console.WriteLine($"Hello, {name}! It's {date}.This is your math's game. That's great that you're working on improving yourself");
    Console.WriteLine("\n");

    var isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine($@"What game would you like to play today? Choose from the option below:
V - View Game History
A - Addition
S - Substraction
M - Multiplication
D - Division
Q - Quit the program");
        Console.WriteLine("------------------------------------------------------");

        var gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToLower())
        {
            case "v":
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game");
                break;
            case "s":
                SubstractionGame("Substraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                Environment.Exit(1);
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input.");
                Environment.Exit(1);
                break;
        }
    } while (isGameOn);

}
void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History:");
    Console.WriteLine("---------------------------------------------------------");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("---------------------------------------------------------\n");
    Console.WriteLine("Press any key to go back to the main menu");
    Console.ReadLine();
}
void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over!, Your final score is {score}, Press any key to go back to the main menu;");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Addition");
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{gameType} game - {DateTime.Now} - Final score: {gameScore}/5");
}

void SubstractionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over!, Your final score is {score}, Press any key to go back to the main menu;");
            Console.ReadLine();
        }
    }
}
void MultiplicationGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over!, Your final score is {score}, Press any key to go back to the main menu;");
            Console.ReadLine();
        }
    }
}
void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question");
            Console.ReadLine();
        }
        if (i == 4)
        {
            Console.WriteLine($"Game Over!, Your final score is {score}, Press any key to go back to the main menu;");
            Console.ReadLine();
        }
    }
}


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }
    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;

}