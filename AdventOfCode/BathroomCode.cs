using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Cli
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there");
        }
    }

    public class BathroomCode
    {
        private string code = "";
        private char[][] board;
        private int xLocation = 0;
        private int yLocation = 2;

        public BathroomCode()
        {
            board = new[]
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
                        xLocation++;
                        break;
                    case 'L':
                        break;
                    case 'D':
                        if (board[yLocation + 1][xLocation] != '-')
                        {
                            yLocation++;
                        }
                        break;
                    case 'U':
                        if (board[yLocation - 1][xLocation] != '-')
                        {
                            yLocation--;
                        }
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            code += board[yLocation][xLocation];
        }

        public string Code()
        {
            return code;
        }
    }
}