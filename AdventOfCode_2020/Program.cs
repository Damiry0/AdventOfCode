using System;
using System.Collections.Generic;
using System.IO;
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


        }
    }

}
