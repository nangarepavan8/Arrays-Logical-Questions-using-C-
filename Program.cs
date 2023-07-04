using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FInd_Min_and_Second_Min_Number_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, secondMin;
            int size, n, n2, count;
            int[] arr =new int [50];

            Console.WriteLine("Enter the size of any array");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("The "+ size +" elements are : ");
           // n = int.Parse(Console.ReadLine());
            for(int i =0; i<size; i++)
            {
               arr[i]=int.Parse(Console.ReadLine());
               // Console.WriteLine(arr[i]);
            }

            Console.WriteLine("The elements are : ");
            for(int i =0; i<size;i++)
            {
                Console.WriteLine(arr[i]);
            }
            if (arr[0] < arr[1])
            {
                min = arr[0];
                secondMin = arr[1];
            }
            else
            {
                min = arr[1];
                secondMin = arr[0];
            }

            Console.WriteLine("The smallest elements is : ");
            for (int i = 2; i < size; i++)
            {
                if (arr[i] < min)
                {
                    secondMin = min;
                    min = arr[i];
                }
                else if (arr[i]<secondMin)
                {
                    secondMin= arr[i];
                }
               
            }
            Console.WriteLine("second min is : "+ secondMin);
            Console.WriteLine("Min is : " + min);

            Console.ReadLine();

        }
    }
}
