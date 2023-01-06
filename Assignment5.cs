using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Prime
    {
        public static bool IsPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }                
            }
            if (count == 2)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Assignment5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number to find prime or not");
            int num =Convert.ToInt32(Console.ReadLine());
            bool value = Prime.IsPrime(num);
            Console.WriteLine(value);
        }
    }
}
