using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Addition_of_Bitwis_operator
{
    internal class Program
    {
        public static int add(int a, int b)
        {
            int hld;
            while(b!=0)
            {
                hld = a & b;
                a = a ^ b;
                b = hld << 1;

            }
            return a;
        }

        static void Main(string[] args)
        {
            int a, b, sum;

            Console.WriteLine("Enter two Numbers : ");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());

            sum = add(a, b);
            Console.WriteLine("The Sum of number is : "+ sum);

            Console.ReadLine();
        }
    }
}
