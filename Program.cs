using System;
using System.Globalization;


namespace ParamsKeyword
{
    class Program
    {
        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

        static void Main(string[] args)
        {
            var result = Add(3, 5,100);
            Console.WriteLine(result);
        }
    }
}