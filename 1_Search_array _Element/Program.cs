using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Search_array__Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[44];
            int n, n1, i, flag = 0;

            Console.WriteLine("Enter the size of array");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the array element = ");

            for( i=0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter element to search ");
            n1 = int.Parse(Console.ReadLine());
            for ( i=0; i<n; i++)
            {
                if (arr[i] == n1 )
                {
                    flag = 1 ;
                    Console.WriteLine("Number "+ n1 +" Found at "+ (i+1) +" locations");
                    break;
                }    
            }
            if(flag == 0)
            {
                Console.WriteLine("Not found in array element "+ n1);
            }

            Console.ReadLine();


        }
    }
}
