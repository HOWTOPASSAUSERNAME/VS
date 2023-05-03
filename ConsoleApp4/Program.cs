using System;

namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Func<int, int, string> right = (row, num) => { return new string('*', row).PadLeft(num, ' '); };


            Func<int, int, string> left = (row, num) => { return new string('*', row); };

            Func<int, int, string> middle = (row, num) =>
            {
                return new string(' ', num - row) + new string('*', 2 * row - 1);
            };


            Console.WriteLine(new Graphic().Add(5, right));
            Console.WriteLine(new Graphic().Add(5, left));
            Console.WriteLine(new Graphic().Add(5, middle));
        }
    }

    public class Graphic
    {
        public string Add(int num, Func<int, int, string> func)
        {
            var result = string.Empty;
            for (var row = 1; row <= num; row++) result += func(row, num) + "\r\n";

            return result;
        }
    }
}