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

        static int Lettura(int num)
        {
            while (num < 0)
            {
                num = int.Parse(Console.ReadLine()); 
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

            Console.WriteLine("Inserisci un numero: ");

        }
    }
}
