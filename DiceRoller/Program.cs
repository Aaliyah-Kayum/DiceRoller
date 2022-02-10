Random ran = new Random();

Console.WriteLine("Welcome to the Grand Circus Casino!");

while (true)
{
    Console.Write("How many sides should the die have? ");
    int sides = int.Parse(Console.ReadLine());
    
        Random rnd = new Random();
        int dice1 = rnd.Next(1, 6);
        int dice2 = rnd.Next(1, 6);
    int rolled = dice1 + dice2;
        
    Console.WriteLine("Roll: ");
    Console.WriteLine("You rolled at " + dice1 + " and " + dice2);
    if (rolled == 7 || rolled == 11)
    {
        Console.WriteLine("Win!");
    }
    else if (rolled == 3 || rolled == 2 || rolled == 12)
    {
        Console.WriteLine("Craps");
    }
    else if (rolled == 6 + 6)
    {
        Console.WriteLine("Boc Cars");
    }
    else if (rolled == 1 || rolled == 2)
    {
        Console.WriteLine("Ace Deuce");
    }
    else if (rolled == 1 + 1)
    {
        Console.WriteLine("Snake Eyes");
    }
    else if (rolled == 12)
    {
        Console.WriteLine("Craps");
    }
    else
    {
        Console.WriteLine("Damn! nothing special");
    }
    Console.Write("Would you like to roll again (y/n)?");
    string choice = Console.ReadLine();

    if (choice == "n")
    {
        Console.WriteLine("Thanks for playing!!");
    }
    else if (choice == "y")
    {
        Console.WriteLine();
        continue;
    }
    break;
}

