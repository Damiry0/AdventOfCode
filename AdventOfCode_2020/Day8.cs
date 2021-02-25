using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;



namespace AdventOfCode_2020
{
    class Day8
    {
        public static int Accumulator;
        static List<(string Value, int)> input;

        public enum OperationType
        {
            acc, jmp, nop
        }

        public static void Loop(string source)
        {
            var regex = new Regex(@"^(\w+) ([+-]\d+)$", RegexOptions.Compiled);
            input = File.ReadAllLines(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input8.txt")
                .Select(line => regex.Match(line).Groups)
                .Select(groups => (groups[1].Value, int.Parse(groups[2].Value)))
                .ToList();

            /*while (true)//zastap
            {

            }*/
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
        //private static void 
    }
}
