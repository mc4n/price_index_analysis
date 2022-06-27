internal class Program
{
    private static void Main(string[] args)
    {
        GroupCombinator.PrintCombinations(
            new Dictionary<string, double>()
        {
            {"1987",-3},
            {"1988",42},
            {"1989",251},

            {"1990",-8},
            {"1991",-22},
            {"1992",-45},
            {"1993",202},
            {"1994",-42},
            {"1995",-18},
            {"1996",36},
            {"1997",78},
            {"1998",-56},
            {"1999",247},

            {"2000",-55},
            {"2001",-13},
            {"2002",-42},
            {"2003",59},
            {"2004",23},
            {"2005",48},
            {"2006",-10},
            {"2007",31},
            {"2008",-56},
            {"2009",85},

            {"2010",17},
            {"2011",-30},
            {"2012",44},
            {"2013",-19},
            {"2014",17},
            {"2015",-23},
            {"2016",0},
            {"2017",32},
            {"2018",-35},
            {"2019",13},

            {"2020",14},
            {"2021",-12},
        },
            keyAlias: "year",
            valueAlias: "growth",
            valueSuffix: "%",
            aggregateAlias: "accum",
            aggregateSuffix: " try",
            aggregateFn: (dict) =>
                dict.Values.Aggregate(100.0,
                    (double i, double n) => Math.Round(i + i * (n / 100), 2)),

            //startKey: "2002",
            minGroupLen: 2,
            maxGroupLen: 10,
            checkInvalidity: true,
            invalidityPred: aggVal => aggVal < 90
        );
    }
}
