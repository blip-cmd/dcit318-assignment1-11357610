while (true)
{
    Console.WriteLine("\n=== MAIN MENU ===");
    Console.WriteLine("1. Grade Calculator");
    Console.WriteLine("2. Ticket Price Calculator");
    Console.WriteLine("3. Triangle Type Identifier");
    Console.WriteLine("0. Exit");
    Console.Write("Select an option: ");
    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        //Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("WELCOME TO `GRADE CALCULATOR(RB)`");

        int grade;

        while (true)
        {
            Console.Write("Enter a valid integer score: ");
            string input = Console.ReadLine();
            try
            {
                grade = int.Parse(input);
                break;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter a valid integer score like '49'");
                Console.ResetColor();
            }
        }

        Console.WriteLine($"You entered {grade}.");
        Console.Write($"That is an ");
        if (grade >= 90) Console.WriteLine("A.");
        else if (grade >= 80) Console.WriteLine("B.");
        else if (grade >= 70) Console.WriteLine("C.");
        else if (grade >= 60) Console.WriteLine("D.");
        else Console.WriteLine("F.");

        Console.ResetColor(); }
    // END OF GRADE CALCULATOR }

    else if (choice == "2")
    {
        Console.WriteLine("WELCOME TO `Ticket Price Calculator (RB)`");
        Console.Write("Enter the age: ");
        int age = int.Parse(Console.ReadLine());
        int price = (age <= 12 || age >= 65 ? 7 : 10);
        Console.WriteLine($"Ticket Price: GHC {price}.00");
        Console.WriteLine("END OF `Ticket Price Calculator (RB)`");
    }

        if (choice == "3")
        {
            Console.WriteLine("WELCOME TO `Triangle Type Identifier (RB)`");
            Console.Write("Enter Length of Side (1): ");
            int s1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Length of Side (2): ");
            int s2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Length of Side (3): ");
            int s3 = int.Parse(Console.ReadLine());
            if (s1 == s2 && s2 == s3) Console.WriteLine("Equilateral");
            else if (s1 == s2 || s2 == s3 || s1 == s3) Console.WriteLine("Isosceles");
            else Console.WriteLine("Scalene");
            Console.WriteLine("END OF `Triangle Type Identifier (RB)`");
        }

    else if (choice == "0")
        {
            Console.WriteLine("Exiting. Goodbye!");
            break;
        }
    }
