using System;

namespace ConsoleApp1
{
    class Program
    {
        private int euklidoAlgorithm(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a > b) a = a % b;
                else { b = b % a; }

            }
            return a + b;
        }
        private int raktoGeneravimas(int p, int q)
        {
            int n = p * q;
            int f = (p - 1) * (q - 1);
            
            return f;
        }
        private bool isPirminis(int n)
        {
            int k = 0;
            for(int i=1; i<=n; i++)
            {
                if (n % i == 0)k++;
            }
            if (k == 2) return true;
            else { return false; }
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.Write("Iveskite du pirminius laukus p= ");
            string p = Console.ReadLine();
            Console.Write("q= ");
            string q = Console.ReadLine();
            Console.Write("ir pradini teksta x= ");
            string x = Console.ReadLine();
        
            try
            {
               
                int a = int.Parse(p);
                int b = int.Parse(q);
                Console.WriteLine("Pasirinkite is galimu variantu eksponentine reikšme: ");
                Console.Write("1");
                for (int i = 2; i <= prog.raktoGeneravimas(a, b); i++)
                {
                    if (prog.isPirminis(i)) Console.Write(" "+i);
                }
                Console.WriteLine("");
                string pas = Console.ReadLine();
                int e = int.Parse(pas);
                Console.Write(prog.euklidoAlgorithm(e, prog.raktoGeneravimas(a, b)));
            }
            catch(Exception e)
            {
                Console.WriteLine(e+"pirmi laukai turi buti skaiciai");
            }



        }
       
    }
}
