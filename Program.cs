using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            Console.WriteLine("Enter the first number (n1): ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number(n2): ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime Numbers are: ");
            for (int i = n1; i <= n2; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                    }
                }
                if (i >= 2 && isprime == true)
                {
                    Console.WriteLine(i);
                }
                else
                    isprime = true;
            }
        }
    }
}
