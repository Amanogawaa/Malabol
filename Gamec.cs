using System.Runtime.CompilerServices;

namespace newgame;

public class Game
{
    public static List<Player> currentPlayer = new List<Player>();
    public static void GameStart()
    {
        int user;
        bool playerCreation = true;
        while (playerCreation)
        {
            Console.WriteLine("Welcome to Realms of Malabol!");
            Console.WriteLine("Would you like to create your character?");
            Console.WriteLine("[1] Yes");
            Console.WriteLine("[2] No");
            Console.Write("- ");
            string? userInput = Console.ReadLine();
            if (int.TryParse(userInput, out user) && user == 1)
            {
                bool isCreating = true;
                while (isCreating)
                {
                    int choice;
                    Console.WriteLine("May I ask your name?");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Enter you gender");
                    Console.WriteLine("[1] Male");
                    Console.WriteLine("[2] Female");
                    Console.Write("- ");
                    string? gender = Console.ReadLine();
                    if (int.TryParse(gender, out choice) && choice == 1)
                    {
                        Console.WriteLine("Understood!");
                    }
                    else if (int.TryParse(gender, out choice) && choice == 2)
                    {
                        Console.WriteLine("Understood!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice!");
                    }
                    Player player = new Player(name, gender, true);
                    AdClass.PrintStats();
                    Console.WriteLine("Choose your class: ");
                    string? chosenClass = Console.ReadLine();
                    isCreating = false;
                }
            }

            playerCreation = false;

            if (int.TryParse(userInput, out user) && user == 2)
            {
                Console.WriteLine("D Wag!");
                playerCreation = false;
            }
        }
    }
}