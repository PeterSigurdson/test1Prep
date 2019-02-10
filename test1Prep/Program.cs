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
        static int i, j = 0;

        public static void run()
        {
            
            for (Console.WriteLine("yippeeee!!!") ; MethodA() ; Console.WriteLine("Yeah!!!") ) 
            {
                Console.WriteLine(i--);
                if ( j < -11) { Console.WriteLine("method run: Point E");  break;}
            }
            // point A:
            Console.WriteLine("I am after Point A");
            Console.WriteLine("i is {0} ", i);
        }

        public static bool MethodA()
        {   i -= 1;
            if (i < -20)
            {
                Console.WriteLine("I am in MethodA return FALSE condition...");
                return false;
            }

            return true;
        }
    }
}