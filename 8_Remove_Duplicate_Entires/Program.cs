using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Remove_Duplicate_Entires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int[] duplicateArray = new int[50];
            int size, loc, count, flag = 0;
            int i, j =0;

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

            Console.WriteLine("Removing elements after : ");         
            for (i = 0; i < size; i++)
            {
              for(j = j+1;  j < size; )
                {
                    if (arr[i] == arr[j])
                    {
                        for(int x=j; x<size;x++)
                        {
                            arr[x] = arr[x+1];
                        }
                        size--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            for(i=0; i < size;i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();


        }
    }
}
