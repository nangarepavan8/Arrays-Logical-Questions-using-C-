using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Search_EvenNUmber_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[44];

            int n, n1, count =0;
            Console.WriteLine("Enter the size of array");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()) ;
            }

            Console.WriteLine("The even numbers are = ");
            for(int i =0; i<n; i++)
            {
                if (arr[i]%2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
