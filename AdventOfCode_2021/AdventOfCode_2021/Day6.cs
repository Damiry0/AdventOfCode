using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_2021
{
    public class Day6
    {
        public static void Day6PartOne() //o(n^2) RIP
        {
            var input = File.ReadAllLines(@"./input6.txt").First().Split(",");
            var list = input.Select(int.Parse).ToList();
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
                Console.WriteLine("Line:{0}",i);
            }
            Console.WriteLine("Output:{0}",list.Count);
        }
        public static void Day6PartTwo()
        {
            var input = File.ReadAllLines(@"./input6.txt").First().Split(",").Select(int.Parse).ToList();
            
            var fishGeneration = new long[9];
            foreach (var i in input)
            {
                fishGeneration[i]++;
            }

            for (var i = 0; i < 256; i++)
            {
                var newOnes = fishGeneration[0];
                for (var j = 1; j < fishGeneration.Length; j++)
                {
                    fishGeneration[j - 1] = fishGeneration[j];
                }

                fishGeneration[8] = newOnes;
                fishGeneration[6] += newOnes;
            }
            
            Console.WriteLine("Output:{0}",fishGeneration.Sum());
        }
        
    }
}