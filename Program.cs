#region xu100_dict
var xu100_hist = new Dictionary<int, int>()
{
    {87,-3},
    {88,42},
    {89,251},

    {90,-8},
    {91,-22},
    {92,-45},
    {93,202},
    {94,-42},
    {95,-18},
    {96,36},
    {97,78},
    {98,-56},
    {99,247},

    {0,-55},
    {1,-13},
    {2,-42},
    {3,59},
    {4,23},
    {5,48},
    {6,-10},
    {7,31},
    {8,-56},
    {9,85},

    {10,17},
    {11,-30},
    {12,44},
    {13,-19},
    {14,17},
    {15,-23},
    {16,0},
    {17,32},
    {18,-35},
    {19,13},

    {20,14},
    {21,-12},
    {22, -33}
};
#endregion


Console.WriteLine($"total change rate (in {xu100_hist.Count} years): %{xu100_hist.Values.Sum()}");
Console.WriteLine();

const int GROUP_LEN = 4;

const int START_INDEX = 0;

for (int i = START_INDEX; i < xu100_hist.Count; i += GROUP_LEN)
{
    var g_pairs = xu100_hist.Skip(i).Take(GROUP_LEN).ToDictionary(x => x.Key, x => x.Value); ;

    System.Console.WriteLine("group-" + (i / GROUP_LEN + 1));

    var sub_i = 0;
    foreach (var kvp in g_pairs)
    {
        sub_i++;
        Console.WriteLine("{0}.year: {1} => change: {2}", sub_i, kvp.Key, kvp.Value);
    }
    System.Console.WriteLine($"sum: {g_pairs.Values.Sum()}");
    System.Console.WriteLine();

}
