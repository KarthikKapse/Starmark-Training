using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Assignment3
    {
       static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Enter the Numbers to be calculated");
                Console.WriteLine("Enter The First Number");               
                double input1 =Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter The Operator");
                String Operator = Console.ReadLine();

                Console.WriteLine("Enter The Second Number");
                double input2 = Convert.ToDouble(Console.ReadLine());
                double result=0.0;
                //int i = 0;
                switch (Operator)
                {
                    case "+":
                        {
                            result= input1 + input2;
                            Console.WriteLine("The Result is : " + result);
                            break;
                        }
                    case "-":
                        {
                            result= input1 - input2;
                            Console.WriteLine("The Result is : " + result);
                            break;
                        }
                    case "/":
                        {
                            result = input1 / input2;
                            Console.WriteLine("The Result is : " + result);

                            break;
                        }
                    case "*":
                        {
                            result = input1 * input2;
                            Console.WriteLine("The Result is : " + result);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You entered The wrong Operator");
                           // i++;
                            break;
                        }
                }
                
                
            }

        }
    }
}
