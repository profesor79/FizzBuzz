using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class _null
    {
        private static string[] _dividers3 = new string[] { "f", string.Empty, string.Empty };
        private static string[] _dividers5 = new string[] { "bu", string.Empty, string.Empty, string.Empty, string.Empty };
        private static string[] _results = new string[] { "", "fizz", "buzz", "fizzbuzz" };

        public string FizzBuzz(int i)
        {
            _results[0] = i.ToString();
            var s = _dividers3[i % 3] + _dividers5[i % 5];
            return _results[s.Length];
        }
    }
}