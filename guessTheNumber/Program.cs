// See https://aka.ms/new-console-template for more information





Random random = new Random();
int number = random.Next(1, 20);

Console.WriteLine("Guess a number between 1-20.\n(type 'exit' to leave the game)");

while (true)
{
	string userInput = Console.ReadLine();

	if(userInput.Trim().ToLower() == "exit")
	{
        Console.WriteLine("Thank you for playing, GOODBYE");
		break;
    }

	int guess;
	if (int.TryParse(userInput, out guess))
	{
		if (guess < 1 || guess > 20)
		{
            Console.WriteLine("Invalid number, guess a number between 1-20");
        }
		else if (guess == number)
		{
			Console.WriteLine("CORRECT");
			break;
		}
		else
		{
            Console.WriteLine("Try again!");
        }
		

	}
	else
	{
		Console.WriteLine("Invalid. Write a NUMBER between 1-20");
	}
}

Console.ReadKey();