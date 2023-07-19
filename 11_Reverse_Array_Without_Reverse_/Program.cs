using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Reverse_Array_Without_Reverse_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int i, j, n, temp;

            Console.WriteLine("Enter the number ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the element in the array : ");

            for(i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            j = i - 1;
            for(i =0; i<j; i++)
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }

            Console.WriteLine("After reverse of array Element ");
            for(i=0; i<n; i++)
            {
                Console.WriteLine("\t" + arr[i]);
            }


            Console.ReadLine();
        }
    }
}
