using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode_2020
{
    class Day1
    {
        public static readonly string textfilename = @"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input1.txt";
        public static List<int> ReadFileInts(string text)
        {
            string[] lines = File.ReadAllLines(text);
            List<int> result = new List<int>();
            foreach (var line in lines)
            {
                int Parsedline = int.Parse(line);
                result.Add(Parsedline);
            }
            return result;
        }
        public static Func<int, int, int> Multiply = (x, y) => x * y;
        public static Func<int, int,int, int> Multiply1 = (x, y, z) => x * y *z; //can't overload anonymous function :(
        public static (int FirstNumber, int SecondNumber) FindingNumbersGivenSum(List<int> list) //O(n)
        {
            var hash = new HashSet<int>();
            const int year = 2020;
            int a = 0, b = 0;
            foreach (var t in list)
            {
                var temp = year - t;
                if (hash.Contains(temp))
                {
                    a = temp;
                    b = t;
                }
                hash.Add(t);
            }

            return (a, b);
        }
        public static (int FirstNumber, int SecondNumber, int ThirdNumber) FindingThreeNumbersGivenSum(List<int> list) //O(n^2020) brute force
        {
            const int year = 2020;
            int a = 0, b = 0,c = 0;
            for (int i = 0; i < list.Count-1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    for (int k = j+1; k < list.Count; k++)
                    {
                        if (list[i] + list[j] + list[k] == year)
                        {
                            a = list[i];
                            b = list[j];
                            c = list[k];
                        }
                    }
                }
            }
            return (a,b,c);
        }
    }
}
