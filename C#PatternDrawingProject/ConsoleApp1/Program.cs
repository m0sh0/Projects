using System;

class PatternDrawing
{
    static void Main(string[] args)
    {
        while (true) // Loop for restarting the program
        {
            // Step 1: Display a menu to the user
            Console.WriteLine("🌟 Welcome to the C# Pattern Drawing Program!");
            Console.WriteLine("Choose a pattern type:");
            Console.WriteLine("1. Right-angled Triangle");
            Console.WriteLine("2. Square with Hollow Center");
            Console.WriteLine("3. Diamond");
            Console.WriteLine("4. Left-angled Triangle");
            Console.WriteLine("5. Hollow Square");
            Console.WriteLine("6. Pyramid");
            Console.WriteLine("7. Reverse Pyramid");
            Console.WriteLine("8. Rectangle with Hollow Center");

            // Step 2: Get the user's choice
            Console.Write("Enter the number corresponding to your choice: ");
            int choice = int.Parse(Console.ReadLine());

            // Step 3: Get dimensions based on choice
            int rows = 0, width = 0, height = 0;
            if (choice >= 1 && choice <= 7)
            {
                Console.Write("Enter the amount of rows: ");
                rows = int.Parse(Console.ReadLine());
            }
            else if (choice == 8)
            {
                Console.Write("Enter the height of the rectangle: ");
                height = int.Parse(Console.ReadLine());

                Console.Write("Enter the width of the rectangle: ");
                width = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("❌ Invalid choice! Please restart the program.");
                continue;
            }

            // Step 4: Generate the selected pattern
            switch (choice)
            {
                case 1: // Right-angled Triangle
                    for (int i = 0; i <= rows; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;

                case 2: // Square with Hollow Center
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < rows; j++)
                        {
                            if (i == 0 || i == rows - 1 || j == 0 || j == rows - 1)
                            {
                                Console.Write("* ");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3: // Diamond
                    // TODO: Use nested loops to create a diamond shape
                    break;

                case 4: // Left-angled Triangle

                    for (int i = 0; i <= rows; i++)
                    {
                        for (int j = rows; j >= i; j--)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;

                case 5: // Hollow Square
                    // TODO: Use nested loops to create a hollow square
                    break;

                case 6: // Pyramid
                    // TODO: Use nested loops to create a centered pyramid
                    break;

                case 7: // Reverse Pyramid
                    // TODO: Use nested loops to create a reverse pyramid
                    break;

                case 8: // Rectangle with Hollow Center
                    // TODO: Use nested loops to create a rectangle with a hollow center
                    break;

                default:
                    Console.WriteLine("❌ Invalid choice! Please restart the program.");
                    break;
            }

            // Step 5: Optional - Allow the user to restart or exit
            Console.WriteLine("Do you want to restart the program? (y/n)");
            string restartChoice = Console.ReadLine();
            if (restartChoice.ToLower() != "y")
                break;
        }
    }
}