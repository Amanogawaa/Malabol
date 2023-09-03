using System;

namespace newgame
{
    public enum Buttons
    {
        Battle = 1,
        Inventory = 2,
        Skill = 3,
        Equipments = 4,
        Exit = 5
    }

    public class Menu
    {
        public static void UI()
        {
            Buttons menu;

            do
            {
                Console.ReadLine();
                Console.Clear(); // Clear the console to refresh the menu
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("----What do you want to do?----");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("[1] Battle");
                Console.WriteLine("[2] Inventory");
                Console.WriteLine("[3] Skill");
                Console.WriteLine("[4] Equipments");
                Console.WriteLine("[5] Exit");
                Console.Write("Enter your choice: ");

                if (Enum.TryParse(Console.ReadLine(), out menu))
                {
                    switch (menu)
                    {
                        case Buttons.Battle:
                            Console.WriteLine("Starting a battle...");
                            break;
                        case Buttons.Inventory:
                            Console.WriteLine("Opening the inventory...");
                            break;
                        case Buttons.Skill:
                            Console.WriteLine("Viewing your skills...");
                            foreach (var skill in Player.players[0].Skills)
                            {
                                Console.WriteLine($"Skill Name: {skill.skillName}");
                            }
                            //going to fix tom
                            break;
                        case Buttons.Equipments:
                            Console.WriteLine("Accessing your equipment...");
                            break;
                        case Buttons.Exit:
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

            } while (menu != Buttons.Exit);
        }
    }
}
