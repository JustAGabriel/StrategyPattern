using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>(){ 1.0, 5.5, 3.2, 4.1, 2.3 };
            ISortingStrategy sortingStrategy;

            sortingStrategy = new SortAscending();
            var result = sortingStrategy.SortCollection(numbers);

            Console.WriteLine("Sort numbers ascending: ");
            Console.WriteLine(string.Join(", ", result));

            sortingStrategy = new SortDescending();
            var result2 = sortingStrategy.SortCollection(numbers);

            Console.WriteLine("Sort numbers descending: ");
            Console.WriteLine(string.Join(", ", result2));
        }
    }
}
