using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Size Of The Array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Array Type");
            string typeName=Console.ReadLine();
            Type type = Type.GetType(typeName, true, true);
            Array myArray = Array.CreateInstance(type, size);

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter The value of the Type {type.Name}");
                string enteredValue = Console.ReadLine();
                Object convertedValue = Convert.ChangeType(enteredValue, type);

                myArray.SetValue(convertedValue, i);
            }
            Console.WriteLine("All the values are set");
            foreach(Object item in myArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
