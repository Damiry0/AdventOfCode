using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace AdventOfCode_2020
{

    class Day3
    {
  
        private static List<string> LoadList(string input)
        {
            List<string> result = new List<string>(); string line;
            StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                result.Add(line);
            }
            return result;
        }
        public static long SolvePartOne(int a_X, int a_Y,string input, int step = 1)
        {
            var list = LoadList(input);
            int treeCounter = 0;
            int x = 0;
            for (int i = step; i < list.Count; i=i+a_Y)
            {
                x = x + a_X;
                if (x >= list[i].Length)
                    x -= list[i].Length;
                if (list[i][x] == '#')
                    treeCounter++;
            }
            return treeCounter;
        }

    }
}
