using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class _06DaemonFire
    {
        public ABC()
        {
            foreach (var item in Enumerable.Range(1, 100).Select(FizzBuzz))
            {
                Console.WriteLine(item);
            }
        }

        public string FizzBuzz(int number)
        {
            return (number % 3, number % 5) switch
            {
                (0, 0) => "FizzBuzz",
                (0, _) => "Fizz",
                (_, 0) => "Buzz",
                _ => number.ToString(),
            };
        }
    }
}