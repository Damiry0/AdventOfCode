using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace AdventOfCode_2021
{
    public class Day7
    {
        public static void Day7PartOne()
        {
            var input = File.ReadAllLines(@"./input7.txt").First().Split(",").Select(int.Parse).ToList();
            input.Sort();
            var median = input[500];
            long fuel = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (input[i] < median) fuel += (median - input[i]);
                else if (input[i] > median) fuel += (input[i] - median);
            }
            Console.WriteLine("Output:{0}",fuel);
        }
        public static void Day7PartTwo()
        {
            var input = File.ReadAllLines(@"./input7.txt").First().Split(",").Select(int.Parse).ToList();
            input.Sort();
            var median = input[500];
            long fuel = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (input[i] < median) fuel += Sequence(median - input[i]);
                else if (input[i] > median) fuel += Sequence(input[i] - median);
            }
            Console.WriteLine("Output:{0}",fuel);
        }

        private static readonly Func<long, long> Sequence = (n) => ((n*(n + 1) / 2));

    }
}