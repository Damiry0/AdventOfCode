using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_2021
{
    public class Day3
    {
        
        /*private static int[,] ReadFile(string text)
        {
            var lines = File.ReadAllLines(text).ToList();
            var array = new int[lines.Count, 12];
            var i = 0;
            foreach (var line in lines)
            {
                for (var j = 0; j < line.Length; j++)
                {
                    array[i, j] = line[j];
                }
                i++;
            }
            return array;
        }

        private static int[,] ReverseArray(int[,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    
                }
            }
        }*/
        
        public static void Day3PartOne()
        {
            // Monkey Brain Solution
            var input = File.ReadAllLines(@"./input3.txt").ToList();

            var gamma = new int[12];
            var epsilon = new int[12];
            
            gamma[0] = input.Count(x => x[0] == '1') > (input.Count / 2) ? 2048 : 0;
            gamma[1] = input.Count(x => x[1] == '1') > (input.Count / 2) ? 1024 : 0;
            gamma[2] = input.Count(x => x[2] == '1') > (input.Count / 2) ? 512 : 0;
            gamma[3] = input.Count(x => x[3] == '1') > (input.Count / 2) ? 256 : 0;
            gamma[4] = input.Count(x => x[4] == '1') > (input.Count / 2) ? 128 : 0;
            gamma[5] = input.Count(x => x[5] == '1') > (input.Count / 2) ? 64 : 0;
            gamma[6] = input.Count(x => x[6] == '1') > (input.Count / 2) ? 32 : 0;
            gamma[7] = input.Count(x => x[7] == '1') > (input.Count / 2) ? 16 : 0;
            gamma[8] = input.Count(x => x[8] == '1') > (input.Count / 2) ? 8 : 0;
            gamma[9] = input.Count(x => x[9] == '1') > (input.Count / 2) ? 4 : 0;
            gamma[10] = input.Count(x => x[10] == '1') > (input.Count / 2) ? 2 : 0;
            gamma[11] = input.Count(x => x[11] == '1') > (input.Count / 2) ? 1 : 0;

            epsilon[0] = input.Count(x => x[0] == '1') < (input.Count / 2) ? 2048 : 0;
            epsilon[1] = input.Count(x => x[1] == '1') < (input.Count / 2) ? 1024 : 0;
            epsilon[2] = input.Count(x => x[2] == '1') < (input.Count / 2) ? 512 : 0;
            epsilon[3] = input.Count(x => x[3] == '1') < (input.Count / 2) ? 256 : 0;
            epsilon[4] = input.Count(x => x[4] == '1') < (input.Count / 2) ? 128 : 0;
            epsilon[5] = input.Count(x => x[5] == '1') < (input.Count / 2) ? 64 : 0;
            epsilon[6] = input.Count(x => x[6] == '1') < (input.Count / 2) ? 32 : 0;
            epsilon[7] = input.Count(x => x[7] == '1') < (input.Count / 2) ? 16 : 0;
            epsilon[8] = input.Count(x => x[8] == '1') < (input.Count / 2) ? 8 : 0;
            epsilon[9] = input.Count(x => x[9] == '1') < (input.Count / 2) ? 4 : 0;
            epsilon[10] = input.Count(x => x[10] == '1') < (input.Count / 2) ? 2 : 0;
            epsilon[11] = input.Count(x => x[11] == '1') < (input.Count / 2) ? 1 : 0;

            Console.WriteLine(gamma.Sum());
            Console.WriteLine(epsilon.Sum());

            Console.WriteLine("Output: " + gamma.Sum()*epsilon.Sum());
        }
      
    }
}