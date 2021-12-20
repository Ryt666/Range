using System;

namespace _1_4
{
  
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, o;
            Console.WriteLine("Введите промежуток: ");
            Console.WriteLine("a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("точка: ");
            o = int.Parse(Console.ReadLine());
            Range R = new Range(a,b);
            R.check(o);
            Console.ReadKey();
        }
    }

}

