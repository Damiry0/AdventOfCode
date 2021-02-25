using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode_2020
{
    class Day9
    {
        
        public static List<long> Approval(string input)
        {
            List<long> result = new List<long>(); string line;
            StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                result.Add(long.Parse(line));
            }
            return result;
        }

    }
}
