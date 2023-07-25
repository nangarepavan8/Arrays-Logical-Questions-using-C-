using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[25];
            int n, i, j, temp;

            Console.WriteLine("Enter the Number : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array Element : ");
            for(i =0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(i = 0; i<(n-1); i++)
            {
                for(j = 0; j<(n-i-1); j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("The sorted array elements : ");
             
            for(i=0;i<n; i++)
            {
                Console.WriteLine(arr[i] +" ");
            }
            Console.ReadLine();    
        }
    }
}
