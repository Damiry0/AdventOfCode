using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode_2020
{
    class Day4
    {
        public static int DumbWay(string input) // nie dziala i dobrze
        {
            var result = 0;
            var temp = 0;
            var dumb=false; string line;
            var file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {
                for (var i = 0; i < line.Length; i++)
                {
                    if (line[i] != ':') continue;
                    if (line[i - 3] != 'c')
                    {
                        temp++;
                    }
                    else
                    {
                        dumb = true;
                    }
                }

                if (line != "") continue;
                if (temp == 8 ||( temp == 7 && dumb == true)) result++;
                temp = 0;
            }
            return result;
        }
    }
}
