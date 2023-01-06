using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            // string[] arr= ne
            /* Console.WriteLine("Enter the values");
             string value = Console.ReadLine();
             Console.WriteLine(value);

             for(int i = 0; i < value.Length; i++)
             {
                 if (Convert.ToInt32(value[i]) % 2 == 0)
                 {

                 }
             }*/
            int[] arr = new int[5];
            int[] even = new int[5];
            int[] odd = new int[5];
            int j = 0;
            int k = 0;
            Console.WriteLine("Enter The Five Numbers");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[j] = arr[i];
                    j++;
                }
                else
                {
                    odd[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("The Even Numbers are");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(even[i]);
            }
            Console.WriteLine("The Odd Numbers are");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(odd[i]);
            }
        }
    }
}
