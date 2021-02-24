using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode_2020
{
    class Day4
    {
        public static int DumbWay(string input)
        {
            int result = 0;
            int temp = 0; string line;
            StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ':') temp++;
                }
                if (line=="")
                {
                    if (temp == 7 || temp == 8) result++;
                    temp = 0;
                }
            }
            return result;
        }
    }
}
