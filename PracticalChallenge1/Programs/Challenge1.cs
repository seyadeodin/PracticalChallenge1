using System.Globalization;
using System.Text.RegularExpressions;

namespace PracticalChallenges.Programs;

public class Challenge1
{
    public void WelcomeMessage()
    {
        Console.WriteLine("Type your name out:");

        var name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}. We're glad you're here.");
    }

    public void NameConcat()
    {
        Console.WriteLine("Type your name out:");

        var name = Console.ReadLine();

        Console.WriteLine("Now your surname:");

        var surname = Console.ReadLine();

        Console.WriteLine($"{name} {surname}");
    }

    public void MathOperations()
    {
        double x;
        double y;

        Console.WriteLine("Type the first number:");
        Double.TryParse(Console.ReadLine(), out x);

        Console.WriteLine("Type the second number:");
        Double.TryParse(Console.ReadLine(), out y);

        double sum = x + y;
        double subtraction = x - y;
        double multiplication = x * y;
        double division = x / y;
        double mean = (x + y) / 2;

        Console.WriteLine(
            $"Sum is {sum}\n"
                + $"Subtraction is {subtraction}\n"
                + $"Multiplication is {multiplication}\n"
                + $"Divsion is {division}\n"
                + $"Mean is {mean}"
        );
    }

    public void CheckNumberOfCharacters()
    {
        Console.WriteLine("Type one or more words:");
        var words = Console.ReadLine();

        if (words is not null)
        {
            char[] wordsArr = words.ToArray();

            int numberOfWords = 0;

            foreach (var letter in wordsArr)
            {
                if (letter != ' ')
                {
                    numberOfWords += 1;
                }
            }
            Console.WriteLine($"The number of characters in this phrase is :{numberOfWords}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    public void ValidateCarPlate()
    {
        Console.WriteLine("Type the car plate:");

        var plate = Console.ReadLine();

        string plateRegex = @"^[A-Za-z]{3}[0-9]{4}$";

        var match = Regex.Match(plate, plateRegex);

        string validMessage = match.Success ? "Valid plate" : "Invalid palte";

        Console.WriteLine(validMessage);
    }

    public void DisplayCurrentDateTime()
    {
        Console.WriteLine(
            "\nSelect which program you want to use:\n"
                + "1. Complete date\n"
                + "2. dd/mm/YYYY\n"
                + "3. hh:mm \n"
                + "4. Long form\n"
        );
        var option = Console.ReadLine();

        var now = DateTime.Now;

        switch (option)
        {
            case "1":
                  Console.WriteLine(now.ToString("G", new CultureInfo("pt-BR")));
                break;
            case "2":
                  Console.WriteLine(now.ToString("d", new CultureInfo("pt-BR")));
                break;
            case "3":
                  Console.WriteLine(now.ToString("t", new CultureInfo("pt-BR")));
                break;
            case "4":
                  Console.WriteLine(now.ToString("d", new CultureInfo("pt-BR")));
                break;
        }
    }

    public void LearningDates()
    {
      DateOnly date = new DateOnly(2001, 09, 11);

      Console.WriteLine(date);
      
      string dateText = date.ToLongDateString();

      Console.WriteLine($"{date.ToLongDateString()} vs {date.ToShortDateString()}");

      string dateTextBR = date.ToString("D", new CultureInfo("pt-BR"));

      Console.WriteLine(dateTextBR);
    }
}
