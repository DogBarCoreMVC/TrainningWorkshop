using System;

namespace csharp_basic
{
    public class ex12_objects
    {
        //create Object a
        public static void ex12()
        {
            Square a = new Square();
            a.name = "Paper";
            a.SetDimension(8, 11);

            Square b = new Square();
            b.name = "Computer Screen";
            b.SetDimension(16, 9);

            Console.WriteLine("Object " + a.name + " has area = " + a.CalculateArea() + " in^2");
            Console.WriteLine("Object " + b.name + " has area = " + b.CalculateArea() + " in^2");
        }

    }

    //create Object b
    class Square
    {
        public string name;
        private int width;
        private int height;

        public void SetDimension(int w, int h)
        {
            width = w;
            height = h;
        }
        public int CalculateArea()
        {
            return width * height;
        }
    }
}