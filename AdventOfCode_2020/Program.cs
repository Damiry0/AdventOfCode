using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using static AdventOfCode_2020.Day1;


namespace AdventOfCode_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Day One */ /* Do przemyslenia budowa klas*/
            var lines = ReadFileInts(textfilename);
            (int FirstNumber, int SecondNumber) = FindingNumbersGivenSum(lines);
            Console.WriteLine("========Part One========== \nFirstNumber:{0},SecondNumber:{1},Multiplied:{2}", FirstNumber, SecondNumber, Multiply(FirstNumber, SecondNumber));


            int min, max;
            char looked_character;
            string sample;
            string sPattern = @"^(?<min>\d{2})-(?<max>\d{2})\s(?<looked>\w):\s(?<sample>\w+)$"; // XD


            string input = @"17-19 p: pwpzpfbrcpppjppbmppp";
            Regex r = new Regex(sPattern, RegexOptions.None, TimeSpan.FromMilliseconds(150));
            Match m = r.Match(input);
            if (m.Success)
                Console.WriteLine(m.Result("${min},${max},${looked},${sample}"));

        }
    }

}
