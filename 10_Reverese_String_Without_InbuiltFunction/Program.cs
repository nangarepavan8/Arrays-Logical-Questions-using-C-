using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Reverese_String_Without_InbuiltFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 0;
            string str, revStr = " ";

            Console.WriteLine("enter the string");
            str=Console.ReadLine();
            
            len  = str.Length-1;
            while(len >= 0)
            {
                revStr  =revStr + str[len];
                len--;
            }

            Console.WriteLine("The Reverse String are : " + revStr);

            Console.ReadLine();
        
        }
    }
}
