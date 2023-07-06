using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Count_Frequency_of_arrays_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int[] duplicateArray = new int[50];
            int size,count=0;
            int i, j;

            Console.WriteLine("Enter the size of an Array : ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements");
            for ( i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array elements are : ");
            for ( i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for( i = 0; i < size; i++)
            {
                count = 1;
                for ( j =i+1; j<size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        
                        count++;
                       duplicateArray[j]=0;
                    }
                    /*
                    if (duplicateArray[i]!=0)
                    {
                        duplicateArray[i] = count;
                    }*/
                }
                Console.WriteLine(arr[i] +" time" + count);
            }

            Console.WriteLine("dublicate array :");
            for( i = 0;i < size; i++)
            {
                if (duplicateArray[i]!=0)
                {
                    Console.WriteLine("array element "+ arr[i]  +" Times of "+ duplicateArray[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
