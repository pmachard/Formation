using System;

namespace fct1
{
    class Program
    {
        static int fctboo(int n)
        {
            return (n == 0) ? 0 : (n == 1) ? 1 : fctboo(n - 1) + fctboo(n - 2);
        }

        static int fctbo(int n)
        {
            if (n == 0)  return 0;
            if (n == 1) return 1;

            return fctbo(n - 1) + fctbo(n - 2);
        }

        static void Main(string[] args)
        {
            int cc0 = fctcc(0);
            int cc1 = fctcc(1);
            int cc2 = fctcc(1) + fctcc(0);
            int cc3 = fctcc(3);
            int cc4 = fctcc(4);
            int cc5 = fctcc(5);

            Console.WriteLine("Hello World!");
        }
    }
}
