using ConsoleApp1;

Player player = new Player();

Console.WriteLine("Welcome to P3LevelUp!");
Console.WriteLine("Current Level: " + player.Level);
Console.WriteLine("Current P3LevelUp: " + player.Experience);

while (true)
{
    Console.Write("Enter the amount of P3LevelUp to grant (or type 'exit' to quit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (int.TryParse(input, out int experience))
    {
        player.GrantExperience(experience);

        Console.WriteLine("Current Level: " + player.Level);
        Console.WriteLine("Current P3LevelUp: " + player.Experience);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number or 'exit' to quit.");
    }
}