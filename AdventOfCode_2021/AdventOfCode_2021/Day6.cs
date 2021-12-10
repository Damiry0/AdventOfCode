using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_2021
{
    public class Day6
    {
        public static void Day6PartOne()
        {
            var input = File.ReadAllLines(@"./input6.txt").First().Split(",");
            var list = input.Select(line => int.Parse(line)).ToList();
            for (var i = 0; i < 80; i++)
            {
                var listCount = list.Count;
                for (var j = 0; j < listCount; j++)
                {
                    list[j]--;
                    if (list[j] != -1) continue;
                    list[j] = 6;
                    list.Add(8);
                }
            }
            Console.WriteLine("Output:{0}",list.Count);

        }
        
    }
}