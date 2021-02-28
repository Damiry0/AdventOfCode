using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Text;

namespace AdventOfCode_2020
{
    class Day5
    {
        private static int FiningPlace(string line)
        {
            var minRow = 0;
            var maxRow = 128;
            var minSeat = 0;
            var maxSeat = 8;
            foreach (var t in line)
            {
                switch (t)
                {
                    case 'F':
                        maxRow -= ((maxRow - minRow) / 2);
                        break;
                    case 'B':
                        minRow += ((maxRow - minRow) / 2);
                        break;
                    case 'L':
                        maxSeat -= ((maxSeat - minSeat) / 2);
                        break;
                    case 'R':
                        minSeat += ((maxSeat - minSeat) / 2);
                        break;
                }
            }

            return minRow * 8 + minSeat;
        }

        public static int HighestSeatId(string input)
        {
            var highestvalue = 0; string line; int high;
            using var file = new StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {

                high = FiningPlace(line);
                if (high >= highestvalue) highestvalue = high;

            }
            return highestvalue;
        }

        public static int FindingOwnSeat(string input)
        {
            string line;
            var result=0;
            var file = new StreamReader(input);
            var list = new List<int>();
            while ((line = file.ReadLine()) != null)
            {
                list.Add(FiningPlace(line));
            }
            list.Sort();
            for (var i = 0; i < list.Count-2; i++)
            {
                if (list[i] != list[i + 2] - 2 ) result = list[i + 1]-1;
            }
            return result;
        }
    }
}