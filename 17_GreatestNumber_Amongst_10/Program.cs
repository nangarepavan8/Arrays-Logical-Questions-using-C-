using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_GreatestNumber_Amongst_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];

            int i, high;

            Console.WriteLine("Enter the Numbers : ");
            for(i=0; i <10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            high = arr[0];
            
            for(i=1; i < 10;  i++)
            {
                if (arr[i] > high)
                {
                    high = arr[i];
                }
            }

            Console.WriteLine("[ Greatest of ten : "+ high+" ]");


            Console.ReadLine();

        }
    }
}
