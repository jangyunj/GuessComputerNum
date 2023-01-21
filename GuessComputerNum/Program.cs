Random random = new Random();
var computerInput = random.Next(0, 10);

Console.Write("Guess the number the computer is thinking of (1-10): ");
var userInput = int.Parse(Console.ReadLine());

while (userInput != computerInput)
{
    Console.Write("Guess again: ");
    userInput = int.Parse(Console.ReadLine());
}
Console.WriteLine("You've guessed correctly!");