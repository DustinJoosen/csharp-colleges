using College3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College3
{
    public static class Menu
    {
        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static string StringRepeat(char c, int n)
        {
            string result = string.Empty;
            for (var i = 0; i < n; i++)
            {
                result += c;
            }

            return result;
        }

        public static void Run()
        {
            // Init the MenuItems
            List<MenuItemOpdracht> items = new()
            {
                new MenuItemOpdracht { Name = "Exit", Action = Menu.Exit },
                new MenuItemOpdracht { Name = "Opdracht 1", Action = Opdracht1.Run },
                new MenuItemOpdracht { Name = "Opdracht 2", Action = Opdracht2.Run },
                new MenuItemOpdracht { Name = "Opdracht 3", Action = Opdracht3.Run },
                new MenuItemOpdracht { Name = "Opdracht 4", Action = Opdracht4.Run },
            };

            // Select the item
            int idx = 0;
            bool running = true;
            
            while (running)
            {
                // Clear and set position
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;

                // Get char size
                int longest_name_count = items.OrderBy(mi => mi.Name).Last().Name.Length;
                int using_size = ((longest_name_count % 2 == 0) ? longest_name_count : longest_name_count + 1) + 2;

                // Display all items
                Console.WriteLine("Hoofdmenu\n");
                Console.WriteLine(Menu.StringRepeat('=', using_size + 1));
                
                // Display all current list items
                for (var i = 0; i < items.Count(); i++)
                {
                    int current_item_size = items[i].Name.Length;
                    int chars_left_over = using_size - current_item_size;

                    if (i == idx)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.Write("|");
                        Console.Write(items[i].Name);
                        Console.Write(Menu.StringRepeat(' ', chars_left_over - 1));
                        Console.Write("|");

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("|");
                        Console.Write(items[i].Name);
                        Console.Write(Menu.StringRepeat(' ', chars_left_over - 1));
                        Console.Write("|");
                    }

                    Console.Write("\n");
                }

                Console.WriteLine(Menu.StringRepeat('=', using_size + 1));

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
                        Menu.Exit();
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.CursorVisible = true;

                        items[idx].Action();
                        
                        Console.CursorVisible = false;

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
