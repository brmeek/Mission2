using Mission2;
internal class DiceRoll
{
    private static Dictionary<double, double> calcPercent(List<double> rollTotals, double totRolls)
    {
        var percentDict = new Dictionary<double, double>
        {
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
            { 6, 0 },
            { 7, 0 },
            { 8, 0 },
            { 9, 0 },
            { 10, 0 },
            { 11, 0 },
            { 12, 0 }
        };
        var totalsDict = new Dictionary<double, double>
        {
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
            { 6, 0 },
            { 7, 0 },
            { 8, 0 },
            { 9, 0 },
            { 10, 0 },
            { 11, 0 },
            { 12, 0 }
        };


        foreach (double index in rollTotals)
        {

            totalsDict[index] = totalsDict[index] + 1;

        }

        foreach (var (key, numRolls) in totalsDict)
        {
            double tempPercent;

            tempPercent = numRolls / totRolls;
            percentDict[key] = tempPercent;
        }

        return percentDict;
    }

    public static void Main(string[] args)
    {
        double numRolls;
        var rollTotals = new List<double>();
        var percentDict = new Dictionary<double, double>();

        System.Console.WriteLine("How many times should the dice be rolled?");
        numRolls = double.Parse(System.Console.ReadLine());
        rollTotals = rollDie.rollLoop(numRolls);
        percentDict = calcPercent(rollTotals, numRolls);

        foreach(var(key, value) in percentDict)
        {
            string line = new string('*', (int)(value * 100));
            Console.WriteLine(key + ": " + line);
        }
    }

}