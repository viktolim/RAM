using System;

namespace ConsoleApp1
{
    class Program
    {
        private bool euklidoAlgorithm(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a > b) a = a % b;
                else { b = b % a; }

            }
            if (a + b == 1) return true;
            else { return false; }
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
        private void privatusRaktas(int e, int f)
        {
            int p = 0;
            int temp;
            for (int i = 0; p <= 5; i++)
            {
                temp = (i * e) % f;
                if (temp == 1)
                {
                    Console.Write(i + " ");
                    p++;
                }
            }
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
                 for (int i = 0; i <= prog.raktoGeneravimas(a, b); i++)
                 {
                     if (prog.euklidoAlgorithm(i, prog.raktoGeneravimas(a, b))) Console.Write(i+" ");
                 }
                 Console.WriteLine("Pasirinkimas: ");
                 string pas = Console.ReadLine();
                 int e = int.Parse(pas);
                
                prog.privatusRaktas(e, prog.raktoGeneravimas(a, b));

            }
            catch(Exception e)
            {
                Console.WriteLine(e+"pirmi laukai turi buti skaiciai");
            }




        }
       
    }
}
