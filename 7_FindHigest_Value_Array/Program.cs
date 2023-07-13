using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FindHigest_Value_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int[] duplicateArray = new int[50];
            int size, loc, count, flag = 0;
            int i, j;

            Console.WriteLine("Enter the size of an Array : ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array elements are : ");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

           
            int highestValue = arr[0];
            for (i=0; i<size; i++)
            {
                if (arr[i] > highestValue)
                {
                    highestValue = arr[i]; // Update the highest value
                }
            }
            Console.WriteLine(" The Highest number is  : "+ highestValue);

            Console.ReadLine();

        }
    }
}
