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
            var result = new List<string>(); string line;
            var file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                result.Add(line);
            }
            return result;
        }
        public static long SolvePartOne(int aX, int aY,string input, int step = 1)
        {
            var list = LoadList(input);
            var treeCounter = 0;
            var x = 0;
            for (var i = step; i < list.Count; i=i+aY)
            {
                x += aX;
                if (x >= list[i].Length)
                    x -= list[i].Length;
                if (list[i][x] == '#')
                    treeCounter++;
            }
            return treeCounter;
        }

    }
}
