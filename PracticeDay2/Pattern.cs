using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
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
            Console.WriteLine("__________________________________________________");
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

        public static void Pattern3()
        {
            Console.WriteLine("Enter the limit ");
            string str = Console.ReadLine();
            int limit = Convert.ToInt32(str);


            for(int i = 1; i <= limit; i++)
            {
                for(int j = 1; j <= limit; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public static void Pattern4()
        {
            Console.WriteLine("Enter the Limit ");
            string str = Console.ReadLine();
            var limit = Convert.ToInt32(str);

            for(int i = 1; i <= limit; i++)
            {
                for(int j = limit; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }

        public static void Pattern5()
        {
            Console.WriteLine("Please enter the value for rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for column");
            int columns = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for(int j = 1; j <= columns; j++)
                {
                    Console.Write(" "+ Convert.ToChar(64+j));
                }

                Console.WriteLine();
            }
        }

        public static void Pattern6()
        {
            int k = 1;
            for(int i = 1; i <= 3; i++)
            {
                for(int j = 1; j <= 3; j++)
                {
                    Console.Write(" "+ Convert.ToChar(64 + k++));
                }

                Console.WriteLine();
            }
        }
    }
}
