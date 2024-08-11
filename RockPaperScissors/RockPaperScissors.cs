const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
int winCounter = 0;
int drawCounter = 0;
int loseCounter = 0;

while (true)
{

    Console.Write("Choose [r]ock, [p]aper or [s]cissors:    ");
    
    string playerMove = Console.ReadLine();
    
    if (playerMove == "r" ||  playerMove == "rock")
    {
        playerMove = Rock;
    }
    else if (playerMove == "p" || playerMove == "paper")
    {
        playerMove = Paper;
    }
    else if (playerMove == "s" || playerMove == "scissors")
    {
        playerMove = Scissors;
    } 
    else
    {
        Console.WriteLine("Invalid Input. Try   Againg...");
        return;
    }
    
    Random random = new Random();
    int computerRandomNumber = random.Next(1, 3);
    
    string computerMove = "";
    
    switch (computerRandomNumber)
    {
        case 1:
            computerMove = Rock;
            break;
        case 2:
            computerMove = Paper;
            break;
        case 3:
            computerMove = Scissors;
            break;
    }
    
    Console.WriteLine($"The computer chose  {computerMove}.");

    if (playerMove == Rock && computerMove == Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper)
    {
        winCounter++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win!", Console.ForegroundColor);
    }
    else if (playerMove == computerMove)
    {
        drawCounter++;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Draw", Console.ForegroundColor);
    }
    else
    {
        loseCounter++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You  lose!", Console.ForegroundColor);
    }

    Console.WriteLine("Would you like to see statistics?|   y/n");
    string human = Console.ReadLine();
    if (human == "y")
    {
        Console.WriteLine($"Win counter: {winCounter} \n" +
            $"Draw counter: {drawCounter} \n" +
            $"Lose counter: {loseCounter}");
    }

    Console.WriteLine("Do you wish to continue?|    y/n");
    string response = Console.ReadLine();

    if (response != "y")
    {
        Console.WriteLine("See you nex time!");
        break;
    }

}