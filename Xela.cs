using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Xela
    {
        public string FMB
        {
            Enumerable.Range(1, 100).private ToList().private ForEach(i => Console.WriteLine(i % 3 * i % 5 == 0 ? (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "") : i.ToString()));
        }
}
    }