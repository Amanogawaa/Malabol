
namespace newgame;

public class PlayerCreation
{
    public List<Player> currentPlayers = new List<Player>();
    // Main Menu
    public static void MainMenu()
    {
        Console.WriteLine("Realm Of Malabol");
        List<string> Menu = new List<string>
        {
            "[1] Play",
            "[2] Option",
            "[3] Exit"
        };
        for (int i = 0; i < Menu.Count; i++)
        {
            Console.WriteLine($"{Menu[i]}");
        }

        int userInput;
        bool isValid = false;
        do
        {
            Console.Write("Please choose an option: ");
            isValid = int.TryParse(Console.ReadLine(), out userInput);

            if (!isValid || userInput < 1 || userInput > Menu.Count)
            {
                Console.WriteLine("Invalid choice! Please try again!");
                Console.ReadLine();
            }

            switch (userInput)
            {
                case 1:
                    CharacterCreation();
                    break;
                case 2:
                    Console.WriteLine("Wala pa tong function!");
                    isValid = false;
                    break;
                case 3:
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    isValid = true;
                    break;
            }
        }
        while (!isValid || userInput < 1 || userInput > Menu.Count);
    }

    //Name 
    public static void CharacterCreation()
    {
        List<string> InappropriateNames = new List<string>
        {
            "Pakyu",
            "Ulupong",
            "Bading",
            "Baluga",
            "Shit",
            "Bobo",
            "Shawn"
        };

        List<string> notAGender = new List<string>
        {
            "Gay",
            "Lesbian",
            "Queer",
            "Bisexual",
            "Transgender",
            "X-Men",
            "Transformer"
        };

        bool isValid = false;

        do
        {
            Console.Write("Enter your name: ");
            string? playerName = Console.ReadLine();
            if (InappropriateNames.Contains(playerName, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Sorry, the name is inappropriate, please try again");
            }
            else
            {
                isValid = true;
            }

            Console.WriteLine("Pick a gender");
            Console.WriteLine("[Male]");
            Console.WriteLine("[Female]");
            Console.WriteLine("[Croissant]");
            Console.Write(": ");
            string? playerGender = Console.ReadLine();
            if (notAGender.Contains(playerGender, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("That's not a gender dumbass!");
            }
            else
            {
                Console.WriteLine("Understood!");
            }

            AdventurerClass.PrintStats();
            Console.Write("Choose a class: ");
            string? user = Console.ReadLine();

            if (int.TryParse(user, out int chosenClass) && chosenClass >= 1 && chosenClass <= AdventurerClass.AdventurerClassName.Count)
            {
                AdventurerClass player = AdventurerClass.AdventurerClassName[chosenClass - 1];
                if (playerName != null && playerGender != null)
                {
                    Console.WriteLine($"Name: {playerName.ToUpper()}");
                    Console.WriteLine($"Name: {playerGender.ToUpper()}");
                    Console.WriteLine($"Class: {player.adventurerClass}");
                    Console.WriteLine($"Health: {player.playerHp}");
                    Console.WriteLine($"Defense: {player.defense}");
                    Console.WriteLine($"Mana: {player.playerMp}");
                    Console.WriteLine($"Physical Damage: {player.physicalAttack}");
                    Console.WriteLine($"Magic Damage: {player.magicAttack}");
                }
            }
            Player currentPlayer = new Player(playerName, playerGender, true);
        }
        while (!isValid);
    }


}


