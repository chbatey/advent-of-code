using System;
using System.IO;
using System.Threading;

namespace AdventOfCode
{
    public class ValidTriangles
    {

        public static void Main(string[] args)
        {
            var lines = File.ReadAllLines("C:\\Users\\chris\\Downloads\\day3-input.txt");
            int count = 0;
            for (int i = 0; i < lines.Length; i += 3)
            {
                string[] one = lines[i].Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string[] two = lines[i+1].Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string[] three = lines[i+2].Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (Valid(int.Parse(one[0]), int.Parse(two[0]), int.Parse(three[0])))
                    count++;
                if (Valid(int.Parse(one[1]), int.Parse(two[1]), int.Parse(three[1])))
                    count++;
                if (Valid(int.Parse(one[2]), int.Parse(two[2]), int.Parse(three[2])))
                    count++;
            }
            Console.WriteLine("Triangles: {0}", count);
            Console.ReadLine();
        }
        public static bool Valid(int one, int two, int three)
        {
            return one + two > three
                   && one + three > two
                   && two + three > one;
        }
    }
}