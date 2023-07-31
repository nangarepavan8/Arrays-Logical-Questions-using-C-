using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Palindrome_String_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, j, flag = 1;

            Console.WriteLine("Enter the string");
            str = Console.ReadLine();

            for (i = 0, j = str.Length - 1; j != 0; i++, j--)
            {
                if (str[i] == str[j])
                {
                    
                }
                else
                {
                    flag = 0;
                    break;
                }
            }

            if(flag == 1) {
                Console.WriteLine("The string is palindrom : "+ str);
            }
            else
            {
                Console.WriteLine("The string is Not Palindrome : "+ str);
            }



            Console.ReadLine();
        }
    }
}
