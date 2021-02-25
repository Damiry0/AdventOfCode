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
            int min_row = 0;
            int max_row = 128;
            int min_seat = 0;
            int max_seat = 8;
            for (int i = 0; i < line.Length; i++)
            {
                switch (line[i])
                {
                    case 'F':
                        max_row = max_row - ((max_row - min_row) / 2);
                        break;
                    case 'B':
                        min_row = min_row + ((max_row - min_row) / 2);
                        break;
                    case 'L':
                        max_seat = max_seat - ((max_seat - min_seat) / 2);
                        break;
                    case 'R':
                        min_seat = min_seat + ((max_seat - min_seat) / 2);
                        break;
                }

            }

            return min_row * 8 + min_seat;
        }

        public static int HighestSeatId(string input)
        {
            int Highestvalue = 0; string line; int beka;
            StreamReader file = new System.IO.StreamReader(input);
            while ((line = file.ReadLine()) != null)
            {

                beka = FiningPlace(line);
                if (beka >= Highestvalue) Highestvalue = beka;

            }
            return Highestvalue;
        }

        public static int FindingOwnSeat(string input)
        {
            string line;
            int result=0;
            StreamReader file = new System.IO.StreamReader(input);
            List<int> list = new List<int>();
            while ((line = file.ReadLine()) != null)
            {
                list.Add(FiningPlace(line));
            }
            list.Sort();
            for (int i = 0; i < list.Count-2; i++)
            {
                if (list[i] != list[i + 2] - 2 ) result = list[i + 1]-1;
            }
            return result;
        }
    }
}