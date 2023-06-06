using ClassLibrarytest;

internal class Program
{
    private static void Main(string[] args)
    {
        Square_Triangle_Circle my_area = new(2, 4, 3, 6);


        string[] menuItems = new string[] { "Area Circle", "Area Triangle", "Leave" };

        Console.WriteLine("Menu");
        Console.WriteLine();

        int row = Console.CursorTop;
        int col = Console.CursorLeft;
        int index = 0;
        while (true)
        {
            DrawMenu(menuItems, row, col, index);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.DownArrow:
                    if (index < menuItems.Length - 1)
                        index++;
                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0)
                        index--;
                    break;
                case ConsoleKey.Enter:
                    switch (index)
                    {
                        case 0:
                            Console.Clear();
                            Console.WriteLine("Menu");
                            Console.WriteLine();
                            DrawMenu(menuItems, row, col, index);
                            my_area.PrintCircle();
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Menu");
                            Console.WriteLine();
                            DrawMenu(menuItems, row, col, index);
                            my_area.PrintTriangle();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("leave the console");
                            return;
                        
                    }
                    break;
            }
        }
    }


    private static void DrawMenu(string[] items, int row, int col, int index) {
            Console.SetCursorPosition(col, row);
            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
    }
    
}