using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start of the range: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect numbers are: ");
            for (int i = n1; i < n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
