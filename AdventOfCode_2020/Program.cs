using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using static AdventOfCode_2020.Day1;
using static AdventOfCode_2020.Day2;
using static AdventOfCode_2020.Day3;
using static AdventOfCode_2020.Day4;
using static AdventOfCode_2020.Day5;
using static AdventOfCode_2020.Day9;
using static AdventOfCode_2020.Day8;
using static AdventOfCode_2020.Day10;

namespace AdventOfCode_2020
{
    class Program
    {
        private const string input3 = @"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input3.txt";

        private const string input10 =
            @"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input10.txt";
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
            Console.WriteLine("Number of Valid Passowrds Part One:{0}",NumberOfValidPassowords(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input2.txt",sPattern));
            Console.WriteLine("Number of Valid Passowrds Part Two:{0}", NumberOfValidPassowordsPartTwo(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input2.txt", sPattern));
            /*Day Three*/
            Console.WriteLine("###### DAY_3 ###############");
            Console.WriteLine("Number of three(Part one):{0}", SolvePartOne(3,1,input3));
            Console.WriteLine("Number of three(Part two):{0}",
                SolvePartOne(1, 1, input3) * SolvePartOne(3, 1, input3) * SolvePartOne(5, 1, input3) *
                SolvePartOne(7, 1, input3) * SolvePartOne(1, 2, input3,2));
            /*Day Four*/
            Console.WriteLine("###### DAY_4 ###############");
            Console.WriteLine("Result:{0}",DumbWay(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input4.txt"));
            /*Day Five*/
            Console.WriteLine("###### DAY_5 ###############");
            Console.WriteLine("Highest seat Id: {0}", HighestSeatId(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input5.txt"));
            Console.WriteLine("Own Seat Id: {0}", FindingOwnSeat(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input5.txt"));
            /*Day Eight*/
            Console.WriteLine("###### DAY_8 ###############");
            Console.WriteLine("Cos: {0} ", Loop(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input8.txt"));
            /*Day Nine*/
            Console.WriteLine("###### DAY_9 ###############");
            Console.WriteLine("Cos: {0} ", PartOneXD(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input9.txt"));
            /*Day Ten*/
            Console.WriteLine("###### DAY_10 ##############");
            Console.WriteLine("Part one:{0}",PartOneDay10(input10));
        }
    }

}
