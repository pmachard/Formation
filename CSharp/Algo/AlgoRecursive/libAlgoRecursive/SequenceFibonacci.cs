using System;

// https://fr.linkedin.com/pulse/la-m%C3%A9thode-agile-et-suite-de-fibonacci-st%C3%A9phanie-pereira
// https://fr.wikipedia.org/wiki/Suite_de_Fibonacci

namespace AlgoRecursive
{
    public class SequenceFibonacci
    {
        public static int fctShort(int n)
        {
            return (n == 0) ? 0 : (n == 1) ? 1 : fctShort(n - 1) + fctShort(n - 2);
        }

        public static int fct(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return fct(n - 1) + fct(n - 2);
        }
    }
}
