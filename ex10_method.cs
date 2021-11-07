using System;

namespace csharp_basic
{
    class ex10_method
    {
        public static void ex10()
        {
            /*string name = "John";

            int sex = 0;

            string sport = "hockey";

            displayBio(name, sex, sport);

            displayBio("Janifer", 1, "swimming");

            displayBio("Carl", 0, "football");*/

            int a = 10;
            int b = 25;
            Console.WriteLine(getText(a) + getSum(a));
            Console.WriteLine(getText(b) + getSum(b));
            Console.WriteLine(getEndText());
        }

        //Method Void
        static void displayBio(string n, int s, string sp)
        {
            if (s == 0) 
            {
                Console.WriteLine(n + " has " + sp + " as his favorite sport.");
            } else 
            {
                Console.WriteLine(n + " has " + sp + " as her favorite sport.");
            }
        }

        //Method Return

        static String getText(int n) {
            return "Sum bewteen 1-" + n + " is ";
        }
        
        static int getSum(int n) {
            int sum = 0;
            for (int i = 1; i <= n; i++) {
                sum += i;
            }
            return sum;
        }
        
        static String getEndText() {
            return "Program ended.";
        }
    }
}