using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    // Program oblicza wartość wielomianu.


    internal class Program
    {
        static void Main(string[] args)
        {
            string koniec;
            
            Console.WriteLine("Program oblicza wartość wielomianu.");
            do
            {
                Console.Write("Podaj stopień wielomianu: ");

                Console.Write("Podaj wyraz wolny: ");

                Console.Write("Podaj współczynnik przy x^1: ");

                Console.Write("Podaj współczynnik przy x^2: ");

                Console.Write("Podaj współczynnik przy x^3: ");

                Console.Write("Podaj wartość x: ");


                Console.WriteLine("Czy chcesz zakończyć program? Tak - Enter, Nie - wpisz słowo 'nie'.");
                koniec = Console.ReadLine();
            }
            while (koniec == "nie");
        }
    }
}
