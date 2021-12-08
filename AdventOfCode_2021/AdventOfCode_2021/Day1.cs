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

        private static int LargerThreeMeasurment(List<int> input)
        {
            int count = 0,temp1,temp2;

            for (var i = 0; i < input.Count - 3; i++)
            {
                temp1 = input[i] + input[i + 1] + input[i + 2];
                temp2 = input[i+1] + input[i + 2] + input[i + 3];
                if (temp2 > temp1) count++;
            }
            
            return count;
        }

        public static void Day1PartOne()
        {
            Console.WriteLine("DayOnePartOne: Output{0}",LargerMeasurment(ReadFileInts(filename)));
        }
        public static void Day1PartTwo()
        {
            Console.WriteLine("DayOnePartTwo: Output{0}",LargerThreeMeasurment(ReadFileInts(filename)));
        }
    }
}