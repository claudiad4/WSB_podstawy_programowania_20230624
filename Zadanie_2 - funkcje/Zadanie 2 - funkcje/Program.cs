using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Obliczanie długości odcinka w układzie kartezjańskim dwuwymiarowym");

        //Pobranie danych od użytkownika

        Console.Write("Podaj współrzędną x punktu początkowego: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu początkowego: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współrzędną x punktu końcowego: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu końcowego: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double length = CalculateSegmentLength(x1, y1, x2, y2);
        Console.WriteLine($"Długość odcinka: {length}");
    }

    //Funkcja obliczająca długość odcinka
    static double CalculateSegmentLength(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        return length;
    }
}
