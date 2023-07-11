using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Remove_An_Element_From_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int[] duplicateArray = new int[50];
            int size,loc, count , flag= 0;
            int i, j;

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

            Console.WriteLine("Enter the number that you want to delete");
            int number = int.Parse(Console.ReadLine());

            for(i = 0; i< size; i++)
            {
                if (arr[i] == number )
                {
                    flag = 1;
                    loc = i;
                    break;
                }
            }
            if(flag == 1) 
            {
                loc = i;
                for(i = loc; i< size-1; i++) 
                {
                    arr[i]= arr[i+1];   
                }
                Console.WriteLine("The new array elements are : ");
                for(i = 0; i< size-1; i++)

                {
                    Console.WriteLine(arr[i] + " \n");
                }
            }else
            {
                Console.WriteLine("Element "+ number + " Not Found..!!");
            }

            Console.ReadLine();
        }


    }
}
