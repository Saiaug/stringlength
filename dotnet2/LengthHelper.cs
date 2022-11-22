using NetMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet2
{
    public class LengthHelper
    {
        public static void Main()
        {
            string str;
            int strlen;
            Console.Write("\n\nFind the length of a string :\n");
            Console.Write("---------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            strlen = FindLength(str);


            Console.Write("Length of the string is : {0}\n", strlen);
            Console.ReadLine();
        }

        public static int FindLength(string str)
        {
            // string str;
            if (!string.IsNullOrEmpty(str))
            {
                int l = 0;
                /*
                            Console.Write("\n\nFind the length of a string :\n");
                            Console.Write("---------------------------------\n");
                            Console.Write("Input the string : ");
                            str = Console.ReadLine();*/



                foreach (char chr in str)
                {
                    l += 1;

                }


                return l;
            }
            else 
            
                
                throw new InvalidOperationException("Invalid number" );
            
            
            
              
            

        }
    }
}

