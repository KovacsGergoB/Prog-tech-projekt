using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTeszteles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algoritmusok alg = new Algoritmusok();

            Console.WriteLine($"Ötszög kerület: {alg.OtszogKer(6)}");
            Console.WriteLine($"Ötszög terület: {alg.OtszogTer(7)}");
            Console.WriteLine();

            Console.WriteLine($"Hatszög terület: {alg.HatszogKer(5)}");
            Console.WriteLine($"Hatszög terület: {alg.HatszogTer(5)}");
            Console.WriteLine();

            List<int> fibo = alg.Fibonacci(11);

            for( int i = 0; i < fibo.Count; i++)
            {
                Console.Write(fibo[i] + ", ");
            }
            Console.WriteLine();

            Console.Write("Adja meg melyik algoritmust szeretné: (1: Fibonacci, 2: Ötszög, 3: Hatszög) ");
            int prog = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg egy értéket: ");
            int ertek = int.Parse(Console.ReadLine());
            alg.Valaszto(prog, ertek);

            Console.ReadKey();
        }

        
    }

    public class Algoritmusok
    {
        public void Valaszto(int prog, int ertek)
        {
            switch (prog)
            {
                case 1: Fibonacci(ertek).ForEach(i => Console.Write("{0}, ", i)); ; break;
                case 2: Console.WriteLine($"Kerülete: {OtszogKer(ertek)}  Terület: {OtszogTer(ertek)}"); break;
                case 3: Console.WriteLine($"Kerülete: {HatszogKer(ertek)}  Terület: {HatszogTer(ertek)}"); break;
                default:
                    break;
            }
        }

       public List<int> Fibonacci(int szam)
       {
           List<int> fibonacciszamok = new List<int>();

           int a = 0, b = 1, c = 0;
           fibonacciszamok.Add(a);
           fibonacciszamok.Add(b);
           for (int i = 2; i < szam; i++)
           {
               c = a + b;
               fibonacciszamok.Add(c);
               a = b;
               b = c;
           }

            return fibonacciszamok;
       }

        public double OtszogKer(int oldal)
        {
            return 5 * oldal;
        }

        public double OtszogTer(int oldal)
        {
            double terulet = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(oldal, 2);

            return Math.Round(terulet);
        }

        public double HatszogKer(int oldal)
        {
            return 6 * oldal;
        }

        public double HatszogTer(int oldal)
        {
            double terulet = (3 * Math.Sqrt(3) * Math.Pow(oldal, 2)) / 2;

            return Math.Round(terulet);
        }

    }
    
}
