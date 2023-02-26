using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay2
{
    internal class Pattern
    {


        public static void Pattern1()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write(" "+Convert.ToChar(64+j));
                }

                Console.WriteLine();

            }
            Console.WriteLine("_________________________________________________");
        }

        public static void Pattern2()
        {
            for (int i = 5; i >= 1; i--)
            {
                for(int j = 1; j <= 6; j++)
                {
                    Console.Write(" " + Convert.ToChar(64 + i));
                }

                Console.WriteLine();
            }

        }
    }
}
