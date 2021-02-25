using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AdventOfCode_2020
{
    class Day10
    {
        public static int PartOneDay10(string input)
        {
          List<int> list = File.ReadAllLines(input).Select(r => int.Parse(r)).ToList();
          list.Sort();
            int oneJolts = 1, threeJolts = 1;
            for (int i = 0; i < list.Count-1; i++)
          {
              var diff = list[i + 1] - list[i];
              if (diff == 1) oneJolts++;
              else if (diff == 3) threeJolts++;
          }
          
          return oneJolts * threeJolts;
        }
       
    }
}
