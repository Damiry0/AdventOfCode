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
        /* public int find(int number)
         {
             string text=r
             int n = number / 2;

         }*/
        public static List<int> ReadFileInts(string text)
        {
            string[] lines = File.ReadAllLines(text);
            List<int> result = new List<int>();
            foreach (string line in lines)
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
            int year = 2020,a=0,b=0;
            foreach (var t in list)
            {
                int temp = year - t;
                if (hash.Contains(temp))
                {
                    a = temp;
                    b = t;
                }
                hash.Add(t);
            }

            return (a, b);
        }
        static void Main(string[] args)
        {
            var lines = ReadFileInts(textfilename);
            (int FirstNumber, int SecondNumber) = FindingNumbersGivenSum(lines);
            Console.WriteLine("FirstNumber:{0},SecondNumber:{1}",FirstNumber,SecondNumber);


        }
    }

}
