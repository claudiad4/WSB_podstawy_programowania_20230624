using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Podaj liczbe sekund: "); // zapytaj uzytkownika o liczbe sekund
        string dane = Console.ReadLine(); // odczytaj tekst wprowadzony przez uzytkownika

        // Sprawdzenie, czy wprowadzona wartość jest liczbą
        if (Int32.TryParse(dane, out int sekundy))
        {
            // wylicz godziny, minuty i sekundy
            int godziny = sekundy / 3600;
            int reszta = sekundy - (godziny * 3600);
            int minuty = reszta / 60;
            sekundy = reszta - (minuty * 60);

            // formatowanie wyniku
            string godzinyTekst = godziny.ToString();
            if (godziny < 10)
            {
                godzinyTekst = "0" + godzinyTekst;
            }

            string minutyTekst = minuty.ToString();
            if (minuty < 10)
            {
                minutyTekst = "0" + minutyTekst;
            }

            string sekundyTekst = sekundy.ToString();
            if (sekundy < 10)
            {
                sekundyTekst = "0" + sekundyTekst;
            }

            // wyswietl wynik
            Console.WriteLine(godzinyTekst + ":" + minutyTekst + ":" + sekundyTekst);
        }
        else
        {
            Console.WriteLine("Podana wartość nie jest poprawna.");
        }
    }
}
