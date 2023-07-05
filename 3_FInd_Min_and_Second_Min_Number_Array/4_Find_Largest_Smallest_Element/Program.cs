using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Find_Largest_Smallest_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
           
            int min = arr[0];
            int max = arr[0];
            int size;
            Console.WriteLine("Enter the size of an Array : ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array elements");
            for(int i=0; i < size; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array elements are : ");
            for(int i=0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

          
            foreach(int item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }

            }

            Console.WriteLine("Smallest element is : "+ min);
            Console.WriteLine("Lagest element is : "+ max);
            Console.ReadLine();

        }
    }
}
