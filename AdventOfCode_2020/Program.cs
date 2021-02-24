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
            Console.WriteLine("###### DAY_1 ###############");
            (int firstNumber, int secondNumber) = FindingNumbersGivenSum(lines);
            Console.WriteLine("========Part One========== \nFirstNumber:{0},SecondNumber:{1},Multiplied:{2}", firstNumber, secondNumber, Multiply(firstNumber, secondNumber));
            (int first, int second, int third) = FindingThreeNumbersGivenSum(lines);
            Console.WriteLine("========Part Two========== \nFirstNumber:{0},SecondNumber:{1},ThirdNumber:{2}Multiplied:{3}", first, second,third, Multiply1(first, second,third));
            /*Day Two */
            Console.WriteLine("###### DAY_2 ###############");
            var sPattern = @"^(?<min>\d{1,2})-(?<max>\d{1,2})\s(?<looked>\w):\s(?<sample>\w+)$"; // XD
            Console.WriteLine("Number of Valid Passowrds:{0}",NumberOfValidPassowords(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input2.txt",sPattern));






        }
    }

}
