using PracticalChallenges.Programs;

namespace PracticalChallenges;

internal class PracticalChallenges()
{
    static void WelcomeMenu()
    {
        Challenge1 program = new Challenge1();

        Console.WriteLine(
            "\nSelect which program you want to use:\n"
                + "1. Welcome Message\n"
                + "2. Name Concat\n"
                + "3. Math Operations\n"
                + "4. Number of characters\n"
                + "5. Valid car plate\n"
                + "6. Format date\n"
        );

        var answer = Console.ReadLine() ?? "";

        switch (answer)
        {
            case "1":
                program.WelcomeMessage();
                break;
            case "2":
                program.NameConcat();
                break;
            case "3":
                program.MathOperations();
                break;
            case "4":
                program.CheckNumberOfCharacters();
                break;
            case "5":
                program.ValidateCarPlate();
                break;
            default:
                break;
        }
        WelcomeMenu();
    }

    static void Main()
    {
        WelcomeMenu();
    }
}
