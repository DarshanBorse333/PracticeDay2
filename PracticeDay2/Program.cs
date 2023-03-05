
using PatternStaticNonStatic;


public class Program
{
    public static void Main()
    {
        //NestedLoop1();
        //NestedLoop2();
        //NestedLoop3();
        //NestedLoop4();
        //NestedLoop5();
        //NestedLoop6();


        Pattern.Pattern0();
        //Pattern.Pattern1();
        //Pattern.Pattern2();
        //Pattern.Pattern3();
        //Pattern.Pattern4();
        //Pattern.Pattern5();
        //Pattern.Pattern6();


        Pattern pattern= new Pattern();       //the funtion is non static that's why we have to create object/instance
        pattern.Pattern7();

        Pattern.StaticFunction1();          // direct call for static function with class name
        Pattern.StaticFunction2();




        Pattern pattern1 = new Pattern();   // create object for calling nonstatic function from outside of the class 
        pattern1.NonStaticFunction1();

        Pattern pattern2 = new Pattern();
        pattern2.NonStaticFunction2();


    }

    //static void NestedLoop1()
    //{

    //    for (int i = 1; i <= 5; i++)
    //    {
    //        for (int j = 1; j <= 5; j++)
    //        {
    //            Console.Write(j);
    //        }

    //        Console.WriteLine();
            
    //    }
    //    Console.WriteLine("-------------------------------------------");
    //}

    //static void NestedLoop2()
    //{
    //    for (int i = 5; i >= 1; i--)
    //    {
    //        for (int j = 5; j >= 1; j--)
    //        {
    //            Console.Write(j);
    //        }

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine("-------------------------------------------");
    //}

    //static void NestedLoop3()
    //{
    //    for (int i = 1; i <= 5; i++)
    //    {
    //        for (int j = 1; j <= 5; j++)
    //        {
    //            Console.Write(i);
    //        }

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine("-------------------------------------------");
    //}

    //static void NestedLoop4()
    //{
    //    for (int i = 5; i >= 1; i--)
    //    {
    //        for (int j = 5; j >= 1; j--)
    //        {
    //            Console.Write(i);
    //        }

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine("-------------------------------------------");
    //}

    //static void NestedLoop5()
    //{
    //    for (int i = 1; i <= 5; i++)
    //    {
    //        for (int j = 1; j <= i; j++)
    //        {
    //            Console.Write("*");
    //        }

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine("-------------------------------------------");
    //}


    //static void NestedLoop6()
    //{
    //    for (int i = 5; i >= 1; i--)
    //    {
    //        for (int j = 1; j <= i; j++)
    //        {
    //            Console.Write("*");
    //        }

    //        Console.WriteLine();
    //    }
    //    Console.WriteLine("-------------------------------------------");

    //}


}
