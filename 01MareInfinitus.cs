namespace FizzBuzz;

/// <summary>
/// source before refactoring https://stackoverflow.com/q/11764539/5919473
/// </summary>
internal class _01MareInfinitus
{
    private static Tuple<int, string>[] _combinations = new Tuple<int, string>[]
        {
            new Tuple<int, string> (3, "Fizz"),
            new Tuple<int, string> (5, "Buzz"),
        };

    public string DoFizzBuzz(int i)
    {
        var fibu = string.Empty;
        bool found = false;

        foreach (var comb in _combinations)
        {
            if (i % comb.Item1 == 0)
            {
                found = true;
                fibu += comb.Item2;
            }
        }

        if (!found)
        {
            fibu = i.ToString();
        }

        return fibu;
    }
}