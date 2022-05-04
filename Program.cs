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
            int wynik;

            Console.WriteLine("Program oblicza wartość wielomianu.");
            do
            {
                Console.Write("Podaj stopień wielomianu: ");
                if (int.TryParse(Console.ReadLine(), out int stopien))
                {
                    
                    Console.Write("Podaj wyraz wolny: ");
                    if (int.TryParse(Console.ReadLine(), out int wyraz))
                    {
                        int [] tablica = new int [stopien];
                        for (int i = 0; i < stopien; i++)
                        {
                            Console.Write("Podaj współczynnik przy x^" + (i + 1) + ": ");
                            int.TryParse(Console.ReadLine(), out tablica[i]);
                            
                        }
                        Console.Write("Podaj wartość x: ");
                        if (int.TryParse(Console.ReadLine(), out int x))
                        {
                            wynik = (tablica[0] * (x * 1)) + (tablica[1] * (x * x)) + (tablica[2] * (x * x * x)) + wyraz;
                            Console.WriteLine("Wartość wielomianu wynosi: {0}", wynik);
                            Console.WriteLine("Czy chcesz zakończyć program? Tak - Enter, Nie - wpisz słowo 'nie'.");
                            koniec = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Błędna wartość");
                            koniec = "nie";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość.");
                        koniec = "nie";
                    }
                }
                else
                {
                    Console.WriteLine("Błędna wartość.");
                    koniec = "nie";
                }
            }
            while (koniec == "nie");
        }
    }
}
