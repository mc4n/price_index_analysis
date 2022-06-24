#region xu100_dict
var xu100_hist = new Dictionary<int, int>()
{
    {1987,-3},
    {1988,42},
    {1989,251},

    {1990,-8},
    {1991,-22},
    {1992,-45},
    {1993,202},
    {1994,-42},
    {1995,-18},
    {1996,36},
    {1997,78},
    {1998,-56},
    {1999,247},

    {2000,-55},
    {2001,-13},
    {2002,-42},
    {2003,59},
    {2004,23},
    {2005,48},
    {2006,-10},
    {2007,31},
    {2008,-56},
    {2009,85},

    {2010,17},
    {2011,-30},
    {2012,44},
    {2013,-19},
    {2014,17},
    {2015,-23},
    {2016,0},
    {2017,32},
    {2018,-35},
    {2019,13},

    {2020,14},
    {2021,-12},
    {2022, -33}
};
#endregion


Console.WriteLine($"total change rate (in {xu100_hist.Count} years): {xu100_hist.Values.Sum()}%");
Console.WriteLine();

const int GROUP_LEN = 4;

const int START_INDEX = 0;

{
    for (int i = START_INDEX; i < xu100_hist.Count; i += GROUP_LEN)
    {
        System.Console.WriteLine("==========================================");
        var g_pairs = xu100_hist.Skip(i).Take(GROUP_LEN).ToDictionary(x => x.Key, x => x.Value);

        var g_total = g_pairs.Values.Sum();

        System.Console.WriteLine("group-" + (i / GROUP_LEN + 1).ToString("00") + ":");

        var sub_i = 0;
        foreach (var kvp in g_pairs)
        {
            sub_i++;
            Console.WriteLine("{0}.year: {1} => change_rate: {2}%", sub_i, kvp.Key, kvp.Value);
        }

        System.Console.WriteLine($"sum: {g_total}");
    }
}
