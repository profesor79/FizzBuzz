﻿namespace FizzBuzz;

public class Wug
{
    /// <summary>
    /// can't do anything as this always runs in batches of 15...
    /// </summary>
    public void FizzBuzz()
    {
        const string FIZZ = "Fizz";
        const string BUZZ = "Buzz";
        const string FIZZBUZZ = "FizzBuzz";

        int i = 0;
        while (i < 150)
        {
            Console.WriteLine(++i);
            Console.WriteLine(++i);
            Console.WriteLine(FIZZ); ++i;
            Console.WriteLine(++i);
            Console.WriteLine(BUZZ); ++i;
            Console.WriteLine(FIZZ); ++i;
            Console.WriteLine(++i);
            Console.WriteLine(++i);
            Console.WriteLine(FIZZ); ++i;
            Console.WriteLine(BUZZ); ++i;
            Console.WriteLine(++i);
            Console.WriteLine(FIZZ); ++i;
            Console.WriteLine(++i);
            Console.WriteLine(++i);
            Console.WriteLine(FIZZBUZZ); ++i;
        }
    }
}