using System;

namespace ConsoleApp1
{
    class Program
    {
        private bool isPirminis(int n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) k++;
            }
            if (k == 2) return true;
            else { return false; }

        }
        static void Main(string[] args)
        {
           KodoGeneravimas kodoGeneravimas = new KodoGeneravimas();
           kodoGeneravimas.generuoti();
           

        }
    }
}
