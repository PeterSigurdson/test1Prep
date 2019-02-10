using System;

namespace test1Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1.run();
        }
    }

    class Example1
    {
        static int i = 0;

        public static void run()
        {
            
            for (; MethodA() ; )
            {
                Console.WriteLine(i--);
                if ( i < -11) { break;}
            }
            // point A:
            Console.WriteLine("I am after Point A");
            Console.WriteLine("i is {0} ", i);
        }

        public static bool MethodA()
        {
            i -= 1;
            return true;
        }
    }
}