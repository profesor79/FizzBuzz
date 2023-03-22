using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class _02ThomasLevesque
    {
        public string DoFizzBuzz(int i)
        {
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;
            if (fizz && buzz)
                return "FizzBuzz";
            if (fizz)
                return "Fizz";
            if (buzz)
                return "Buzz";

            return i.ToString();
        }
    }
}