using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose the conversion mode:");
        Console.WriteLine("a. Seconds to Minutes");
        Console.WriteLine("b. Minutes to Hours");
        Console.WriteLine("c. Hours to Days");
        Console.WriteLine("d. Days to Months");

        Console.Write("Enter your choice (a,b,c,d):");
        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice)
        {
            case 'a':
                ConvertSecondsToMinutes();
                break;
            case 'b':
                ConvertMinutesToHours();
                break;
            case 'c':
                ConvertHoursToDays();
                break;
            case 'd':
                ConvertDaysToMonths();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;

        }
    }

    static void ConvertSecondsToMinutes()
    {
        Console.Write("Enter number of seconds: ");
        int seconds = int.Parse(Console.ReadLine());
        double minutes = seconds / 60.00;
        Console.WriteLine($"{seconds} seconds is equal to {minutes:F2} minutes.");
    }

    static void ConvertMinutesToHours()
    {
        Console.Write("Enter number of minutes: ");
        int minutes = int.Parse(Console.ReadLine());
        double hours = minutes / 60.00;
        Console.WriteLine($"{minutes} minutes is equal to {hours:F2} hours.");
    }

    static void ConvertHoursToDays()
    {
        Console.Write("Enter number of hours: ");
        int hours = int.Parse(Console.ReadLine());
        double days = hours / 24.00;
        Console.WriteLine($"{hours} hours is equal to {days:F2} days.");
    }

    static void ConvertDaysToMonths()
    {
        Console.Write("Enter number of days: ");
        int days = int.Parse(Console.ReadLine());
        double months = days / 30.00;
        Console.WriteLine($"{days} days is equal to {months:F2} months.");
    }
}