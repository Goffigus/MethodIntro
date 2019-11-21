using System;

namespace MethodIntro
{
    class Program
    {
        private static int example = 8;
        static void Main(string[] args)
        {


            example = 8;
            double ED = Convert.ToDouble(example); //using a static methods
            string sd = example.ToString(); //using a non static method


            HelloWorld();
            HelloWorld();
            HelloWorld();
            TenHelloWorld();
        }


        
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        private static void TenHelloWorld()
        {
            example = 20;
            LineOfStars();
            for(int x = 0; x < 5; ++x)
            {
                for (int y = 0; y < 2; ++y)
                {
                    Console.Write("\tHello World!");
                }
                Console.WriteLine("");
            }
            LineOfStars();
        }

        private static void LineOfStars()
        {
            for (int x = 0; x < 30; ++x)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        
    }
}
