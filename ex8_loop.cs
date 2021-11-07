using System;

namespace csharp_basic
{
    class ex8_loop
    {
        public static void ex8()
        {
            //Loop While
            /*int n = 1;
            while (n <= 10)
            {
                Console.WriteLine("loop " + n);
                n++;
            }
            Console.WriteLine("Loop ended");*/

            //Loop do while
            /*int n;

            Console.WriteLine("Enter 0 to exit the loop");
            do
            {
                Console.Write("Your number: ");
                int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("Number you enter is " + n);
            }
            while(n != 0);
            Console.WriteLine("loop end");

            Console.WriteLine("--------------");*/

            //Loop For

            /*for (int i = 11 ; i > 11; i++)
            {
                Console.WriteLine("loop " + i);
            }
            Console.WriteLine("Loop ended");

            Console.WriteLine("--------------");*/

            //Loop foreach

            /*int[] number = {2,4,-1,5,0,8,9};
            foreach (int i in number)
            {
                Console.WriteLine("froeach " + i);
            }
            Console.WriteLine("Loop ended");

            Console.WriteLine("--------------");*/

            //break

            /*for (int i = 1 ; i <= 10; i++)
            {
                Console.WriteLine(i);
                if(i == 5) break;
            }
            Console.WriteLine("Loop end");

            Console.WriteLine("--------------");*/

            //Continue

            for (int i = 1 ; i <= 10; i++)
            {
                if (i % 2 == 0) continue;//หาร 2 ลงตัว เลขคี่
                // (i % 2 != 0) continue;//หาร 2 ไม่ลงตัว เลขคู่
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop end");

            Console.WriteLine("--------------");
        }
    }
}