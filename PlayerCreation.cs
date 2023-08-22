
namespace newgame;

public class PLayerCreation
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

        bool isValid = false;

        do
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            if (InappropriateNames.Contains(name, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Sorry, the name is inappropriate, please try again");
            }
            else
            {
                isValid = true;
            }
        }
        while (!isValid);
    }

    public static void GenderPick()
    {
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
            Console.WriteLine("Pick a gender");
            Console.WriteLine("[Male]");
            Console.WriteLine("[Female]");
            string userInput = Console.ReadLine();
            if (notAGender.Contains(userInput, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("That's not a gender dumbass!");
            }
            else
            {
                Console.WriteLine("Understood!");
                isValid = true;
            }
        }
        while (!isValid);
    }
}


