using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Func<int, int, StringBuilder, StringBuilder> right = (row, num,sb) =>
            {
                return sb.AppendLine(new string('*', row).PadLeft(num, ' '));

            };


            Func<int, int, StringBuilder, StringBuilder> left  = (row, num, sb) =>
            {
                return sb.AppendLine(new string('*', row));

            };

            Func<int, int, StringBuilder, StringBuilder> middle = (row, num, sb) =>
            {
                return sb.AppendLine(new string(' ', num-row)+new string('*', 2*row-1));

            };


            Console.WriteLine(new Graphic().Add(5, right));
            Console.WriteLine(new Graphic().Add(5, left));
            Console.WriteLine(new Graphic().Add(5,middle));

        }
    }

    public class Graphic { 
    
        public string Add(int num , Func<int, int, StringBuilder, StringBuilder> func)
        {

            StringBuilder sb = new StringBuilder();
            for (int row = 1; row <= num; row++)
            {
                 func(row,num,sb);
            }
            return sb.ToString();
            

        }
    
    }
}
