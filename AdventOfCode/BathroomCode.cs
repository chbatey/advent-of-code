using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Cli
    {
        static void DayOne(string[] args)
        {
            Console.WriteLine("Loading file...");
            BathroomCode bc = new BathroomCode();
            var lines = File.ReadAllLines("C:\\Users\\chris\\Downloads\\week2-input.txt");

            foreach (var line in lines)
            {
                bc.AddCode(line);
            }

            Console.WriteLine("Code: {0}", bc.Code());
            Console.ReadLine();

        }
    }

    public class BathroomCode
    {
        private string _code = "";
        private readonly char[][] _board;
        private int _xLocation = 0;
        private int _yLocation = 2;

        public BathroomCode()
        {
            _board = new[]
            {
                new char[] {'-', '-', '1', '-', '-'},
                new char[] {'-', '2', '3', '4', '-'},
                new char[] {'5', '6', '7', '8', '9'},
                new char[] {'-', 'A', 'B', 'C', '-'},
                new char[] {'-', '-', 'D', '-', '-'},
            };
        }

        public void AddCode(string moves)
        {
            foreach (char move in moves.ToCharArray())
            {
                switch (move)
                {
                    case 'R':
                        if ((_xLocation + 1) < _board[_yLocation].Length && _board[_xLocation + 1][_yLocation] != '-')
                        {
                            _xLocation++;
                        }
                        break;
                    case 'L':
                        if ((_xLocation - 1) >= 0 && _board[_xLocation - 1][_yLocation] != '-')
                        {
                            _xLocation--;
                        }
                        break;
                    case 'D':
                        if ((_yLocation + 1) < _board.Length && _board[_yLocation + 1][_xLocation] != '-')
                        {
                            _yLocation++;
                        }
                        break;
                    case 'U':
                        if ((_yLocation - 1) >= 0 && _board[_yLocation - 1][_xLocation] != '-')
                        {
                            _yLocation--;
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            _code += _board[_yLocation][_xLocation];
        }

        public string Code()
        {
            return _code;
        }
    }
}