//Console.ForegroundColor = ConsoleColor.Blue;
////Console.BackgroundColor = ConsoleColor.DarkGreen;
//Console.WriteLine("WELCOME TO `GRADE CALCULATOR(RB)`");

//int grade;

//while(true)
//{
//    Console.Write("Enter a valid integer score: ");
//    string input = Console.ReadLine();
//    try
//    {
//        grade = int.Parse(input);
//        break;
//    }
//    catch (Exception)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Invalid input. Please enter a valid integer score like '49'");
//        Console.ResetColor();
//    }
//}

//Console.WriteLine($"You entered {grade}.");
//Console.Write($"That is an ");
//if (grade >= 90) Console.WriteLine("A.");
//else if (grade >= 80) Console.WriteLine("B.");
//else if (grade >= 70) Console.WriteLine("C.");
//else if (grade >= 60) Console.WriteLine("D.");
//else Console.WriteLine("F.");

//Console.ResetColor();
//// END OF GRADE CALCULATOR
///


Console.WriteLine("WELCOME TO `Ticket Price Calculator (RB)`");
Console.Write("Enter the age: ");
int age = int.Parse(Console.ReadLine());
int price = (age <= 12 || age>= 65 ? 7 : 10);
Console.WriteLine($"Ticket Price: GHC {price}.00");
Console.WriteLine("END OF `Ticket Price Calculator (RB)`");