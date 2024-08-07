﻿using PracticalChallenges.Programs;

namespace PracticalChallenges;

internal class PracticalChallenges()
{
    static void WelcomeMenu()
    {
        Challenge1 program = new Challenge1();
        Fundamentals fundamentals = new Fundamentals();

        Console.WriteLine(
            "\nSelect which program you want to use:\n"
                + "1. Welcome Message\n"
                + "2. Name Concat\n"
                + "3. Math Operations\n"
                + "4. Number of characters\n"
                + "5. Valid car plate\n"
                + "6. Format date\n\n"
                + "0. Fundamentas examples\n"
        );

        var option = Console.ReadLine() ?? "";

        switch (option)
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
            case "6":
                program.DisplayCurrentDateTime();
                break;

            case "0":
                fundamentals.Menu();
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
