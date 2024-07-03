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

        Console.WriteLine($"Sum is {sum}\n" +
            $"Subtraction is {subtraction}\n" +
            $"Multiplication is {multiplication}\n" +
            $"Divsion is {division}\n" +
            $"Mean is {mean}");
    }

    public void CheckNumberOfCharacters()
    {
        Console.WriteLine("Type one or more words:");
        var words = Console.ReadLine();

        words.ToList().ForEach
    }
    public void List()
    {
        List<int> integers = new List<int>();
    }
}
