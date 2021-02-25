using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;



namespace AdventOfCode_2020
{
    class Day8
    {
        //static List<(string Value, int)> input;

       /* public enum OperationType
        {
            acc, jmp, nop
        }*/

        public static int Loop(string source)
        {
            int Accumulator=0;
            var regex = new Regex(@"^(\w+) ([+-]\d+)$", RegexOptions.Compiled);
            List<(string Value, int)>  input = File.ReadAllLines(@"C:\Users\damir\Desktop\Visual\AdventOfCode_2020\AdventOfCode_2020\Input8.txt")
                .Select(line => regex.Match(line).Groups)
                .Select(groups => (groups[1].Value, int.Parse(groups[2].Value)))
                .ToList();
            int[] array = new int[input.Count]; int i=0;
            while (true)//zastap do 2 czesci
            {
                  if (array[i] == 1) break;
                switch (input[i].Value)
                {
                    case "nop":
                    {
                        array[i]++;
                        }
                        break;
                    case "acc":
                    {
                        array[i]++;
                            Accumulator += input[i].Item2;
                    }
                        break;
                    case "jmp":
                    {
                        array[i]++;
                        i += input[i].Item2 -1;
                    }
                        break;
                }
                 i++;
            }
            return Accumulator;
        }
    }
}
