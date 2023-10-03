using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College1
{
    public class Opdracht11
    {
        private static void Exit()
        {
            Environment.Exit(0);
        }

        public static void Run()
        {
            // Init the MenuItems
            List<MenuItemOpdracht> items = new()
            {
                new MenuItemOpdracht { Name = "EXIT", Action = Opdracht11.Exit },
                new MenuItemOpdracht { Name = "Switch", Action = Opdracht1.Run },
                new MenuItemOpdracht { Name = "If-Else", Action = Opdracht2.Run },
                new MenuItemOpdracht { Name = "While", Action = Opdracht3.Run },
                new MenuItemOpdracht { Name = "Do-While", Action = Opdracht4.Run },
                new MenuItemOpdracht { Name = "For", Action = Opdracht5.Run },
                new MenuItemOpdracht { Name = "Foreach", Action = Opdracht6.Run },
                new MenuItemOpdracht { Name = "Break", Action = Opdracht7.Run },
                new MenuItemOpdracht { Name = "Continue", Action = Opdracht8.Run },
                new MenuItemOpdracht { Name = "Ternary", Action = Opdracht9.Run },
                new MenuItemOpdracht { Name = "Conditionals", Action = Opdracht10.Run },
            };

            // Select the item
            int idx = 0;
            bool running = true;
            
            while (running)
            {
                // Clear and set position
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;

                // Display all items
                Console.WriteLine("====Hoofdmenu====");
                Console.WriteLine("=================");

                for (var i = 0; i < items.Count(); i++)
                {
                    if (i == idx)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine($"|| {items[i].Name} ||");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"|| {items[i].Name} ||");
                    }
                }

                Console.WriteLine("=================");

                // Handle input
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        idx = (idx == 0) ? items.Count() : idx;
                        idx--;
                        break;
                    case ConsoleKey.DownArrow:
                        idx = (idx == items.Count() - 1) ? -1 : idx;
                        idx++;
                        break;
                    case ConsoleKey.Escape:
                        Opdracht11.Exit();
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        items[idx].Action();

                        Console.Write("\nDruk op een toets om naar het hoofdmenu te gaan");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }


        }

    }

    class MenuItemOpdracht
    {
        public string Name;
        public Action Action;
    }

}
