using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz;

public class Xela
{
    public string FMB(int i)
    {
        var sb = new StringBuilder();
        Enumerable.Range(i, i)
            .ToList()
            .ForEach(i => sb.AppendLine(i % 3 * i % 5 == 0 ? (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "") : i.ToString()));
        return sb.ToString();
    }
}