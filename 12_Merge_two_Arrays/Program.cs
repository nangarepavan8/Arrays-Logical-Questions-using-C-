using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Merge_two_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
            int[] arr = new int[50];
            int[] arr2 = new int[50];
            

            int size,size2, i;

            Console.WriteLine("Enter the size of an First Array : ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first array elements : ");
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the size of an second Array : ");
            size2 = int.Parse(Console.ReadLine());
            for (i = 0; i < size2;i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }


            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = j + 1;
                arr2[j] = (j + 1) * 10;
            }


            int[] arr3 = new int[arr.Length+arr2.Length];
            Array.Copy(arr, arr3, arr.Length);
            Array.Copy(arr2, 0, arr3, arr.Length, arr2.Length);

            foreach (int num in arr3)
            {
                Console.WriteLine(num);
            }

            /*
            Console.WriteLine("The Array elements are  : ");
            for(int j=0; j<arr.Length + arr2.Length; j++ )
            {
            }
            */
            Console.ReadLine();
        }
    }
}
