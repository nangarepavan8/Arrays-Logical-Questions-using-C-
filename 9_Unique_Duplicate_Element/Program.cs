using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Unique_Duplicate_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[50];
            int[] duplicateArray = new int[50];
            int size, loc, count, flag;// = 0;
            int i, j = 0;

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


            for(i = 0; i < size;i++)
            {
                count = 1;
                for (j = i+1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        duplicateArray[j] = 0;
                    }
                }

                if (duplicateArray[i] != 0)
                {
                    duplicateArray[i] = count;
                }
            }
            Console.WriteLine("Unique elements are : ");
            for(i = 0; i < size; i++) {
                if (duplicateArray[i] == 1) {
                    Console.Write("\t" + arr[i]);
                }
            }
            Console.WriteLine("Duplicate elements are : ");
            for (i = 0; i < size; i++)
            {
                if (duplicateArray[i] > 1)
                {
                    Console.Write("\t" + arr[i]);
                }
            }



            Console.ReadLine();
        }
    }
}
