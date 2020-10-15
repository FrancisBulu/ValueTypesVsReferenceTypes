using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesVsReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = a;
            //b = 55;
            //Console.WriteLine(b);

            int[] array1 = { 5, 15, 3, 53 }; // op moment dat de programma start (ctrl+F5) de waarden worden gedeclareerd in de heap en niet in de stack
           
            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }
          
            Console.WriteLine("****************************************");

            int[] array2 = array1;
            array2[2] = 99999;
            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
