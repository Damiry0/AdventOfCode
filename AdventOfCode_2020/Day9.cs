using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode_2020
{
    class Day9
    {
        // zadanie z grafów, bruteforce
        private static List<long> ReadFileLine(string input)
        {
            var result = new List<long>(); string line;
            var file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                result.Add(long.Parse(line));
            }
            return result;
        }

        private static List<long> CalculatePossibleOutcomes(List<long> input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            var possibilitiesList = new HashSet<long>();
            foreach (var t in input)
            {
                foreach (var t1 in input)
                {
                    possibilitiesList.Add(t+t1);
                }
            }
            return possibilitiesList.ToList();
        }

        public static int PartOneXD(string input)
        {
            var list = ReadFileLine(input);
            var result = 0;
            for (var i = 25; i < input.Length; i++)
            {
                var list1= CalculatePossibleOutcomes(list.GetRange(i, 25));
                var list2 = CalculatePossibleOutcomes(list.GetRange(i + 1, 25));
                foreach (var t in list2)
                {
                    if (list1.Contains(t)) { }
                    else
                    {
                        result = i;
                        break;
                    }
                }
                
            }
            return result;
        }


    }
}
