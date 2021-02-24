using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using static AdventOfCode_2020.Day1;
using static AdventOfCode_2020.Day2;


namespace AdventOfCode_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Day One */ /* Do przemyslenia budowa klas*/
            var lines = ReadFileInts(textfilename);
            (int firstNumber, int secondNumber) = FindingNumbersGivenSum(lines);
            Console.WriteLine("========Part One========== \nFirstNumber:{0},SecondNumber:{1},Multiplied:{2}", firstNumber, secondNumber, Multiply(firstNumber, secondNumber));
            (int first, int second, int third) = FindingThreeNumbersGivenSum(lines);
            Console.WriteLine("========Part Two========== \nFirstNumber:{0},SecondNumber:{1},ThirdNumber:{2}Multiplied:{3}", first, second,third, Multiply_1(first, second,third));

            int min, max;
            char looked_character;
            string sample;
            var sPattern = @"^(?<min>\d{1,2})-(?<max>\d{1,2})\s(?<looked>\w):\s(?<sample>\w+)$"; // XD


            var input = @"8-10 k: kkkkkkkfkkks";

            var groups = ExtractingGroupCollection(input, sPattern);
            Console.WriteLine("{0}, {1},{2},{3}", groups[1], groups[2], groups[3], groups[4]);
            //var beka = ValidPasswordNumber(input, sPattern);
            /*Regex r = new Regex(sPattern, RegexOptions.None, TimeSpan.FromMilliseconds(150));
            Match m = r.Match(input);
            GroupCollection x = m.Groups;
            
            if (m.Success)
                Console.WriteLine(m.Result("${min},${max},${looked},${sample}"));*/

        }
    }

}
