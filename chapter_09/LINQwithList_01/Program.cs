// Program to demonstrate the use of Linq using List in C# with Visual Studio
// Programmer: Kavya Krishnan

namespace LINQwithList_01
{
    public record Racer(string FirstName, string LastName, string Country, int Starts, int Wins, IEnumerable<int> Years, IEnumerable<string> Cars) : 
        IComparable<Racer>, IFormattable
    {
        public Racer(string FirstName, string LastName, string Country, int Starts, int Wins) : this(FirstName, LastName, Country, Starts, Wins, new int[] { }, new string[] { })
        { }
        public override string ToString() => $"{FirstName} {LastName}";
        public int CompareTo(Racer? other) => LastName.CompareTo(other?.LastName);
        public string ToString(string? format, IFormatProvider? formatProvider) => format switch
        {
            null => ToString(),
            "N" => ToString(),
            "F" => FirstName,
            "L" => LastName,
            "C" => Country,
            "S" => Starts.ToString(),
            "W" => Wins.ToString(),
            "A" => $"{FirstName} {LastName}, country: {Country}, starts: {Starts}, wins: { Wins }", _ => throw new FormatException($"Format {format} not supported")
        };
    }
    public record Team
    {
        public Team(string name, params int[] years)
        {
            Name = name;
            Years = years != null ? new List<int>(years) : new List<int>();
        }
        public string Name { get; }
        public IEnumerable<int> Years { get; }
    }
    public static class Formula1
    {
        private static List<Racer> s_racers;
        public static IList<Racer> GetChampions() => s_racers ??= InitializeRacers();
        private static List<Racer> InitializeRacers() => new()
        {
            new ("Nino", "Farina", "Italy", 33, 5, new int[] { 1950 }, new string[] { "Alfa Romeo" }),
            new ("Alberto", "Ascari", "Italy", 32, 10, new int[] { 1952, 1953 }, new string[] { "Ferrari" }),
            new ("Juan Manuel", "Fangio", "Argentina", 51, 24, new int[] { 1951, 1954, 1955, 1956, 1957 }, new string[] { "Alfa Romeo", "Maserati", "Mercedes", "Ferrari" }),
            new ("Mike", "Hawthorn", "UK", 45, 3, new int[] { 1958 }, new string[] { "Ferrari" }),
            new ("Phil", "Hill", "USA", 48, 3, new int[] { 1961 }, new string[] { "Ferrari" }),
            new ("John", "Surtees", "UK", 111, 6, new int[] { 1964 }, new string[] { "Ferrari" }),
            new ("Jim", "Clark", "UK", 72, 25, new int[] { 1963, 1965 }, new string[] { "Lotus" }),
            new ("Ayrton", "Senna", "Brazil", 161, 41, new int[] { 1988, 1990, 1991 }, new string[] { "McLaren", "Lotus" }),
            new ("Nelson", "Piquet", "Brazil", 204, 23, new int[] { 1981, 1983, 1987 }, new string[] { "Brabham", "Williams" }),
            new ("Emerson", "Fittipaldi", "Brazil", 143, 14, new int[] { 1972, 1974 }, new string[] { "Lotus", "McLaren" })
        };
    };
    

    internal class Program
    {

        static void LinqQuery()
        {
            var query = from r in Formula1.GetChampions()
                        where r.Country == "Brazil"
                        orderby r.Wins descending
                        select r;
            foreach (Racer r in query)
            {
                Console.WriteLine($"{r:A}");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Program to demonstrate the use of Linq using List in C# with Visual Studio\n");

            LinqQuery();

        }
    }
}
