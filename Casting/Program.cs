using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 10;
            short num2 = 20;
            short sum = (short)(num1 + num2);
            int num01 = 100;
            double d01 = num01;

            int num = (int)(d01 + num01);

            int a = 10;
            object o = a; //boxing
            int b = (int)o; //unboxing

            Console.WriteLine(b);

            Console.WriteLine(num);

            Console.WriteLine(sum);
        }
    }
}
