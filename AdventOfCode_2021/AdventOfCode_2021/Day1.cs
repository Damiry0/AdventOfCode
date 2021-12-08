using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_2021
{
    public class Day1
    {
        private static readonly string filename = @"./input1.txt";
        private static List<int> ReadFileInts(string text)
        {
            var lines = File.ReadAllLines(text);
            return lines.Select(int.Parse).ToList();
        }

        private static int LargerMeasurment (List<int>input)
        {
            var count = 0;
            for (var i = 0; i < input.Count - 1; i++)
            {
                if (input[i] < input[i + 1]) count++;
            }

            return count;
        }

        public static void Day1PartOne()
        {
            Console.WriteLine("Output{0}",LargerMeasurment(ReadFileInts(filename)));
        }
    }
}