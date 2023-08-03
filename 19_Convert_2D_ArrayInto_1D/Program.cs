using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Convert_2D_ArrayInto_1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, j, k = 0;
            int[] str1 = new int[25];
            int[,] str2 = new int[25,25];

            Console.WriteLine("Enter the rows and coloumns : ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Two  Diamentional Array : ");
            for(i=0;  i<n1; i++)
            {
                for(j=0; j<n2; j++)
                {
                    str2[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("2D Array");
            for (i = 0; i < n1; i++)
            {
                for (j = 0; j < n2; j++)
                {
                    Console.WriteLine("a[{0}, {1}]  = {2}", i, j, str2[i,j]);
                }
            }


            Console.WriteLine("One-D Array");
            for (i=0;i<n1; i++)
            {
                for(j= 0; j<n2; j++)
                {
                    str1[k++] = str2[i, j];
                }
            }

            for(i=0;i<n1*n2; i++)
            {
                Console.WriteLine("str[{0}] = {1}", i, str1[i]);
            }


            Console.ReadLine();

        }
    }
}
