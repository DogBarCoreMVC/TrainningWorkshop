using System;

namespace csharp_basic
{
    class ex6_operator
    {
        public static void ex6()
        {
            // Operator

            /*int a = 10;
            int b = 3;
            
            float c = 2.0f;
            
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * c = " + (a * c));
            Console.WriteLine("a / c = " + (a / c));
            Console.WriteLine("a % c = " + (a % c));
            Console.WriteLine("a % b = " + (a % b));*/

            /*int a = 5;
            int b = 5;
            
            Console.WriteLine("a =  {0}", ++a);
            Console.WriteLine("b =  {0}", b++);
            Console.WriteLine("----------------");
            Console.WriteLine("b =  {0}", b++);
            Console.WriteLine("a =  {0}", ++a);*/

            /*int n = 12;
            if (n % 2 == 0)
            {
                Console.WriteLine("n is even number.");
            }
            
            int x = 2, y = 6;
            if (x < y)
            {
                Console.WriteLine("x is less than y");
            }*/

            /*bool a = (3 == 4);
            bool b = (3 != 4);
            bool c = (3 < 4);
            bool d = a && c;
            bool e = !d;
            
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);*/

            //Ternary Operator
            string cc = "NY";
            Console.WriteLine(cc == "NY" ? "New York" : "Other states");
        }
    }
}