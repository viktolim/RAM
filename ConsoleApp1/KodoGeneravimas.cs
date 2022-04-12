using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class KodoGeneravimas
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
            
            int f = (p - 1) * (q - 1);

            return f;
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
        public void generuoti()
        {
            
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
                for (int i = 0; i <= raktoGeneravimas(a, b); i++)
                {
                    if (euklidoAlgorithm(i, raktoGeneravimas(a, b))) Console.Write(i + " ");
                }
                Console.WriteLine("Pasirinkimas: ");
                string pas = Console.ReadLine();
                int e = int.Parse(pas);

               privatusRaktas(e, raktoGeneravimas(a, b));
                pas = Console.ReadLine();
                int d = int.Parse(pas);

                Console.Write("Iveskite savo varda: ");
                pas = Console.ReadLine();
                DataService data = new DataService();
                data.putData(pas, a*b, e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "pirmi laukai turi buti skaiciai");
            }
        }
    }
}
