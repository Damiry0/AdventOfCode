using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode_2020
{
    class Program
    {
        static readonly string textfilename = @"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input1.txt";
        public static List<int> ReadFileInts(string text)
        {
            string[] lines = File.ReadAllLines(text);
            List<int> result = new List<int>();
            foreach (var line in lines)
            {
                int Parsedline = int.Parse(line);
                result.Add(Parsedline);
                Console.WriteLine(line);
            }
            return result;
        }

        public static (int FirstNumber,int SecondNumber) FindingNumbersGivenSum(List<int>list)
        {
            var hash = new HashSet<int>();
            const int year = 2020;
            int a=0,b=0;
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
        
        public static Func<int, int, int> Multiply = (x, y) => x * y;
        static void Main(string[] args)
        {
            var lines = ReadFileInts(textfilename);
            (int FirstNumber, int SecondNumber) = FindingNumbersGivenSum(lines);
            Console.WriteLine("========Part One========== \nFirstNumber:{0},SecondNumber:{1},Multiplied:{2}",FirstNumber,SecondNumber, Multiply(FirstNumber,SecondNumber));


        }
    }

}
