using sortieren;
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Suche suche = new Suche();

        Console.Write("Geben Sie einen Vornamen ein, nach dem gesucht werden soll: ");
        string name = Console.ReadLine();

        Stopwatch watch = new Stopwatch();
        bool gefunden;
        int wiederholungen = 10000;

        // Lineare Suche
        watch.Start();
        for (int i = 0; i < wiederholungen; i++)
        {
            gefunden = suche.LineareSuche(name);
        }
        watch.Stop();
        Console.WriteLine($"Lineare Suche: {(suche.LineareSuche(name) ? "gefunden" : "nicht gefunden")} - Zeitdauer: {watch.Elapsed}");

        // Binäre Suche
        watch.Reset();
        watch.Start();
        for (int i = 0; i < wiederholungen; i++)
        {
            gefunden = suche.BinaereSuche(name);
        }
        watch.Stop();
        Console.WriteLine($"Binäre Suche: {(suche.BinaereSuche(name) ? "gefunden" : "nicht gefunden")} - Zeitdauer: {watch.Elapsed}");
    }
}