namespace EsRipassoFunzioni
{
    internal class Program
    {
        //Es1
        static double CalcolaArea(double b, double h)
        {
           double a = b * h;

            return a;
        }

        //Es2

        static bool IsPari(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Es3

        static int Potenza(int b, int exp)
        {

            int p = 1;

            for(int i=0; i < exp; i++)
            {
                p = p * b;
            }

            return p;

        }

        //Es 4

        static int Lettura()
        {
            int cont = 0, num = -1;

            while (num <= 0)
            {
                num = int.Parse(Console.ReadLine()); 

                cont++;
            }

            return cont;
        }

        //Es5

        static void StampaCornice(string s)
        {
            for(int i = 0; i < 3; i++)
            {
                if (i != 1)
                {
                    for (int j = 0; j < s.Length + 2; j++)
                    {
                        Console.Write("*");
                        
                    }

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("*" + s + "*");
                }
            }
        }

        static void Main(string[] args)
        {
            //Es1

            double b, h, ar;

            Console.Write("Inserisci b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Inserisci h: ");
            h = double.Parse(Console.ReadLine());

            ar = CalcolaArea(b, h);

            Console.WriteLine(ar);

            Console.WriteLine("--------------------------");

            //Es2

            int num;

            Console.Write("Inserisci numero: ");
            num=int.Parse(Console.ReadLine());

            Console.WriteLine(IsPari(num));

            Console.WriteLine("--------------------------");

            //Es3

            int ba, ex;

            Console.Write("Inserisci ba: ");
            ba=int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Inserisci ex: ");
            ex = int.Parse(Console.ReadLine());

            Console.WriteLine(Potenza(ba, ex));

            Console.WriteLine("--------------------------");

            //Es4

            Console.Write("Inserisci un numero: ");

            Console.WriteLine(Lettura());

            Console.WriteLine("--------------------------");

            //Es5

            string fr = "ciao a tutti";

            StampaCornice(fr);

        }
    }
}
