using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace AdventOfCode_2021
{
    public class Day2
    {
        private static readonly string filename = @"./input2.txt";
        private static IEnumerable<Tuple<string, int>> ReadFile(string text)
        {
            var lines = File.ReadAllLines(text);
            return lines.Select(line => line.Split(' ')).Select(temp => new Tuple<string, int>(temp[0], int.Parse(temp[1]))).ToList();
        }

        private static long FinalPosition(IEnumerable<Tuple<string, int>> input)
        {
            int horizontal=0,depth=0;
            foreach (var (item1, item2) in input)
            {
                switch (item1)
                {
                    case "forward":
                    {
                        horizontal+=item2;
                    } break;
                    case "down":
                    {
                        depth+=item2;
                    } break;
                    case "up":
                    {
                        depth-=item2;
                    } break;
                }
            }
            return horizontal*depth;
        }

        public static void Day2PartOne()
        {
            Console.WriteLine("DayTwoPartOne: Output{0}",FinalPosition(ReadFile(filename)));
        }
    }
}