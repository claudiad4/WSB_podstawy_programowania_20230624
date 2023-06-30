using System;

class Program
{
    static void Main(string[] args)
    {
        // Definicja 2-wymiarowej tablicy liczb
        int[,] tablicaLiczb =
        {
            {1,2,3,4,5 },
            {6,7,8,9,0 },
            {10, 11, 12, 13, 14 },
            {1, 3,3,4,5 }
        };

        // Wywołanie funkcji znajdującej najbardziej podobne wiersze
        int[] wynik = ZnajdzNajbardziejPodobneWiersze(tablicaLiczb);

        // Wyświetlenie wyniku
        Console.WriteLine("Najbardziej podobne wiersze: " + wynik[0] + " i " + wynik[1]);
    }

    // Funkcja szukająca dwóch najbardziej podobnych wierszy w tablicy
    static int[] ZnajdzNajbardziejPodobneWiersze(int[,] wejsciowaTablica)
    {
        int pierwszyWiersz = 0;
        int drugiWiersz = 0;
        long najmniejszaRoznica = long.MaxValue;

        int iloscWierszy = wejsciowaTablica.GetLength(0);
        int iloscKolumn = wejsciowaTablica.GetLength(1);

        // Przeszukiwanie wszystkich par wierszy
        for (int i = 0; i < iloscWierszy; i++)
        {
            for (int j = i + 1; j < iloscWierszy; j++)
            {
                // Obliczenie różnicy między wierszami
                long roznica = ObliczRoznice(wejsciowaTablica, i, j);

                // Sprawdzenie, czy jest to najmniejsza dotychczas znaleziona różnica
                if (roznica < najmniejszaRoznica)
                {
                    najmniejszaRoznica = roznica;
                    pierwszyWiersz = i;
                    drugiWiersz = j;
                }
            }
        }

        // Zwrócenie indeksów najbardziej podobnych wierszy
        return new int[] { pierwszyWiersz, drugiWiersz };
    }

    // Funkcja obliczająca różnicę między dwoma wierszami
    static long ObliczRoznice(int[,] tablica, int pierwszyIndeks, int drugiIndeks)
    {
        int iloscKolumn = tablica.GetLength(1);
        long roznica = 0;

        // Obliczenie sumy kwadratów różnic między elementami wierszy
        for (int i = 0; i < iloscKolumn; i++)
        {
            int roznicaWartosci = tablica[pierwszyIndeks, i] - tablica[drugiIndeks, i];
            roznica += roznicaWartosci * roznicaWartosci;
        }

        // Zwrócenie obliczonej różnicy
        return roznica;
    }
}
