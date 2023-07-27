using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int i, j, x, y, n, temp;

            Console.WriteLine("Enter the size of an array : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements are : ");

            for(i=0; i < n;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(i=0; i<n-1;i++)
            {
                y= arr[i];
                x = i;

                for(j=i+1; j<n;j++)
                {

                    if (y > arr[j])
                    {
                        y = arr[j];
                        x = j;
                    }
                }

                temp = arr[i];
                arr[i] = arr[x];
                arr[x] = temp;
            }


            Console.WriteLine("Sorted elements arrray are : ");
            for(i=0; i<n;i++)
            {
                Console.WriteLine(arr[i] + " \t");
            }


            Console.ReadLine();
        }
    }
}
