using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class _04pythonic
    {
        private string[] s = new string[6] { "Fizz", "Buzz", "", "", "", "" };

        public string FizzBuzz(int i)
        {
            string output = s[(i % 3) * 2] + s[(i % 5) + 1];
            return string.IsNullOrEmpty(output) ? "" + i : output;
        }
    }
}