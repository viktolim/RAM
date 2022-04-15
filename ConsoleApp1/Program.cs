using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        public bool isPirminis(int n)
        {
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) k++;
            }
            if (k == 2) return true;
            else { return false; }

        }
        private int privatusRaktas(int n)
        {
            int[] temp = new int[2];
            for (int i = 0; i <= n; i++)
            {
                if (isPirminis(i))
                {
                    for (int j = 0; j <= n; j++)
                    {
                        if (isPirminis(j))
                        {
                            if (i * j == n)
                            {
                             
                                return i*j;
                            }

                        }
                    }

                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            
            KodoGeneravimas kodoGeneravimas = new KodoGeneravimas();
           kodoGeneravimas.generuoti();
            int[] kodas = kodoGeneravimas.getKodas();

            program.encryption(kodas);*/
            Console.WriteLine(Math.Pow(16, 23) % 33);
     
            //program.descryption();
         
                


        }
        private int[] getKeyFromName()
        {
            DataService data = new DataService();
            Console.Write("Iveskite varda kuris uzsifravo koda: ");
            string name = Console.ReadLine();

            int[] key = data.getData(name);
            return key;
        }
        private void encryption(int[] temp)
        {
            int[] key = getKeyFromName();

            double[] sifr = new double[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                sifr[i] = Math.Pow(temp[i], key[1]) % key[0];

            }
            Console.WriteLine("Sifruotas kodas: ");
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(sifr[i]+" ");
            }
            Console.Write("kuris issaugotas tekstiniame faile: sifruotas");
            DataService data = new DataService();
            data.putDataInTxt(sifr);

        }
        private void descryption()
        {
            DataService data = new DataService();
            Console.Write("Iveskite varda kuris uzsifravo koda: ");
            string name = Console.ReadLine();
            int[] key = data.getPrivateKey(name);
            DataService dataService = new DataService();
            int[] text=dataService.GetDataFromTxt();
            Console.WriteLine(text[0].ToString()+" "+key[1].ToString()+" "+ key[0].ToString());
            int[] temp = new int[text.Length];
            for (int i=0; i<text.Length; i++)
            {
               temp[i]=(int)(Math.Pow(double.Parse("23"), double.Parse("25"))) % 33;
            }
            Console.WriteLine("Desifruotas kodas: ");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(temp[i] + " ");
            }
        }
       
    }
}
