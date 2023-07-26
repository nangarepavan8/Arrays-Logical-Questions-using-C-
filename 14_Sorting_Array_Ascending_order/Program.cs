using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Sorting_Array_Ascending_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,temp, j, n;
            int[] arr =  new int[50];

            Console.WriteLine("Enter the size of an Array : ");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter thes array elements are : ");
            for(i=0;i<n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }

            for(i=0;i<n;i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if (arr[i] > arr[j])
                    {
                       temp = arr[j];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("After ascending oder : ");
            for(i=0;i<n; i++)
            {
                Console.WriteLine(arr[i] +"\t ");
            }

            Console.ReadLine();

        }
    }
}
