namespace NavigationLockDemo.Helpers;

public static class StaticStrings
{
    public const string BlogUrl = "https://mattjameschampion.com/";
}

public static class LazyLogHelpers
{
    public static void LazyLog(this List<IEnumerable<string>> logMessageGroups, params string[] logStrings)
    {
        //Just like logging things properly, except for all of the good parts
        logMessageGroups.Add(logStrings);
        
        foreach (var logString in logStrings)
        {
            Console.WriteLine(logString);
        }
        
        Console.WriteLine();
    }
}