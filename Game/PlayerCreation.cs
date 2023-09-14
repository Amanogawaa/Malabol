using System.Text;

namespace newgame;

public class PlayerCreation
{
    public static List<Player> currentPlayer = new List<Player>();
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
        string? playerName = "";
        string? genderChoice = "";
        do
        {
            Console.Write("Enter your name: ");
            playerName = Console.ReadLine();
            if (InappropriateNames.Contains(playerName, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Sorry, the name is inappropriate, please try again");
            }
            else
            {
                isValid = true;
            }

            Console.WriteLine("Pick a gender");
            Console.WriteLine("[1] Male");
            Console.WriteLine("[2] Female");
            Console.WriteLine("[3] Croissant");
            Console.WriteLine("[4] Walmart Bag");
            Console.Write(": ");
            string? playerGender = Console.ReadLine();
            if (notAGender.Contains(playerGender, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("That's not a gender dumbass!");
                isValid = false;
            }
            if (int.TryParse(playerGender, out int choice))
            {
                genderChoice = choice switch
                {
                    1 => "Male",
                    2 => "Female",
                    3 => "Croissant",
                    4 => "Walmart Bag",
                    _ => "Please try again"
                };

            }

            AdventurerClass.PrintStats();
            Console.Write("Choose a class: ");
            string? user = Console.ReadLine();

            if (int.TryParse(user, out int chosenClass) && chosenClass >= 1 && chosenClass <= AdventurerClass.AdventurerClassList.Count)
            {
                AdventurerClass? yourClass = AdventurerClass.AdventurerClassList[chosenClass - 1];
                Player newPlayer = new Player(playerName, playerGender, true, yourClass.classHp, yourClass.classMp, yourClass.physicalAttack, yourClass.magicAttack, yourClass.defense);
                newPlayer.playerClass = yourClass;
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("----Player Stats----");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Name: {playerName?.ToUpper() ?? "UNKNOWN"}");
                Console.WriteLine($"Gender: {genderChoice}");
                Console.WriteLine($"Class: {newPlayer.playerClass.className}");
                Console.WriteLine($"Health: {newPlayer.playerHp}");
                Console.WriteLine($"Mana: {newPlayer.playerMp}");
                Console.WriteLine($"Defense: {newPlayer.defense}");
                Console.WriteLine($"Physical Damage: {newPlayer.physicalAttack}");
                Console.WriteLine($"Magic Damage: {newPlayer.magicAttack}");
                Console.WriteLine("--------------------------------------------------");
                // foreach (var skill in newPlayer.playerClass.skills)
                // {
                //     Console.WriteLine($"Skill Name:{skill.skillName}");
                // }
                currentPlayer.Add(newPlayer);
                Console.WriteLine("--------------------------------------------------");
            }
        }
        while (!isValid);
    }
}


