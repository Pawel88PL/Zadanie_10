using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    // Program oblicza wartość wielomianu. Do przechowywania współczynników przy wyrazach wielomianu użyć
    // tablicy jednowymiarowej. Wykorzystać schemat Hornera. Obsłużyć wyjątki.


    internal class Program
    {
        static void Main(string[] args)
        {
            string koniec;
            int wynik, stopien, wyraz, x;
            

            Console.WriteLine("Program oblicza wartość wielomianu do max 3 stopnia.");
            Console.WriteLine();

            do
            {
                Console.Write("Podaj stopień wielomianu: ");
                while (!(int.TryParse(Console.ReadLine(), out stopien) && stopien > 0))
                {
                    Console.WriteLine("Będna wartość.");
                    Console.Write("Podaj stopień wielomianu: ");
                }
                
                Console.Write("Podaj wyraz wolny: ");
                while (!(int.TryParse(Console.ReadLine(), out wyraz) && wyraz != 0))
                {
                    Console.WriteLine("Błędna wartość.");
                    Console.Write("Podaj wyraz wolny: ");
                }
                
                int[] tablica = new int[stopien];
                
                for (int i = 0; i < stopien; i++)
                {
                    Console.Write("Podaj współczynnik przy x^" + (i + 1) + ": ");
                    while (!(int.TryParse(Console.ReadLine(), out tablica[i])))
                    {
                        Console.WriteLine("Nieprawidłowa wartość");
                        Console.Write("Podaj współczynnik przy x^ " + (i + 1) + ": ");
                    }
                }
                
                Console.Write("Podaj wartość x: ");
                while(!(int.TryParse(Console.ReadLine(), out x) && x != 0))
                {
                    Console.WriteLine("Błędna wartość.");
                    Console.Write("Podaj wartość x: ");
                }
                
                wynik = (tablica[0] * (x * 1)) + (tablica[1] * (x * x)) + (tablica[2] * (x * x * x)) + wyraz;
                
                Console.WriteLine("Wartość wielomianu wynosi: {0}", wynik);
                Console.WriteLine();
                
                Console.WriteLine("Czy chcesz zakończyć program? Tak - Enter, Nie - wpisz słowo 'nie'.");
                koniec = Console.ReadLine();
            }
            while (koniec == "nie");
        }
    }
}
