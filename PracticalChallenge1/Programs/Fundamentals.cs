using System.Globalization;

namespace PracticalChallenges.Programs;

public class Fundamentals
{
    public void Menu()
    {
        Console.WriteLine(
        "\nSelect which fundamental example you want to execute:\n"
            + "1. Date\n"
            + "2. Enum\n"
            + "3. Arrays \n"
            + "4. Lists\n"
            + "5. Dictionary\n"
            + "6. Format date\n"
    );

        var option = Console.ReadLine() ?? "";

        switch (option)
        {
            case "1":
                Dates();
                break;
            case "2":
                Enum();
                break;
            case "3":
                Arrays();
                break;
            case "4":
                Lists();
                break;
            case "5":
                Dictionary();
                break;
            default:
                Arrays();
                break;
        }
    }
    void Dates()
    {
        DateOnly date = new DateOnly(2001, 09, 11);

        Console.WriteLine("DateOnly datatype unformatted");
        Console.WriteLine(date);

        string dateText = date.ToLongDateString();

        Console.WriteLine("We can use toLongDateString() and ToShortDateSgring() to transformit");
        Console.WriteLine($"{date.ToLongDateString()} vs {date.ToShortDateString()}");

        Console.WriteLine("Or toSTring and give it more granular options of formatting");
        string dateTextBR = date.ToString("D", new CultureInfo("pt-BR"));
        // https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-8.0#system-datetime-tostring(system-string-system-iformatprovider)

        Console.WriteLine(dateTextBR);
    }
    enum ElementalPower
    {
        //need to be positive
        Earth = 4,
        Air = 3,
        Water = 2,
        Fire = 1,
    }
    void Enum()
    {
        ElementalPower element = ElementalPower.Fire;

        Console.WriteLine(element);

        // if we atribute a numeric value to our enum we can use a cast (int) to show it
        Console.WriteLine((int)element);
    }

    void Arrays()
    {
        int[] integers = new int[10];

        integers[0] = 4;
        integers[1] = 9;

        Console.WriteLine(integers.Length);
        Console.WriteLine($"{integers[0]}, {integers[1]}\n\n");

        int[] definedIntegers = [4, 16 , 64, 128];
        Console.WriteLine(definedIntegers.Length);
        Console.WriteLine($"{definedIntegers[0]}, {definedIntegers[1]}, {definedIntegers[2]}, {definedIntegers[3]}");

        int[,] array2d = new int[10, 10];
        array2d[0, 0] = 1;
        array2d[0, 3] = 3;

    }

    void Lists()
    {
        List<int> integers = new List<int>();

        integers.Add(1);
        integers.Add(2);

        Console.WriteLine(integers.Count);

        Console.WriteLine(integers[0]);
        Console.WriteLine(integers[1]);
        // Console.WriteLine(integers[2]); -> exception

        integers.Remove(0);
        Console.WriteLine(integers[0]);

        List<string> strings = new List<string>(["sapato"]);
        strings.Add("pato");

        Console.WriteLine(string.Join(" ", strings));
        // hashsets are like lists, but it does not accept repeating values
    }
    void Dictionary()
    {
        Dictionary<string, string> deathdex = new Dictionary<string, string>();

        deathdex.Add("drowning", "And marshall legs cave in and he drown at the lake border while kids unsuspectedly played around him.");
        deathdex.Add("fire", "Marshall tried to do some stupid trick with matches in his mouth but a deathly gurp made his body enter in instant combustion.");
        deathdex.Add("runover", "A kid in bike run over Marshall, break all his bones, he screams, still alive, but not for long.");
        deathdex.Add("default", "Marshall has no reason to live anymore, he is severely depressed, lonely, has a drinking problem, and no money for booze anymore, the thrilling bridge jump, however, is free.");

        Console.WriteLine("Press eenter to see Marshall how Marshall will die");
        var input = Console.ReadLine();

        Random random = new Random();

        var deathdexKeys = deathdex.Keys.ToList();

        Console.WriteLine(deathdex[deathdexKeys[random.Next(0, deathdexKeys.Count)]]);
    }

}
