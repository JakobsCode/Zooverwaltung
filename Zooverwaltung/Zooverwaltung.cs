using Haustier;

namespace Zooverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Startet...");

            Goldfische dieter = new Goldfische("Dieter");
            dieter.Schwimmen();
            dieter.Pflegen();
            dieter.Streicheln();

            Guppys guppy = new Guppys("Hans");
            guppy.Schwimmen();
            guppy.Pflegen();

            Kaninchen Hoppy = new Kaninchen("Hoppy");
            Hoppy.Pflegen();
            Hoppy.Fortbewegen();
            Hoppy.Streicheln();

            Katzen Günter = new Katzen("Günter");
            Günter.Pflegen();
            Günter.Fortbewegen();
            Günter.Streicheln();


            Fisch[] Aquarium = new Fisch[100];
            for (int i = 0; i < 25; i=i+4) {
                Aquarium[i] = new Guppys($"Guppy-{i}");
                Aquarium[i+2] = new Goldfische($"Goldfisch-{i+2}");
            }

            foreach (Fisch f in Aquarium)
            {
                if (f != null)
                {
                    f.Pflegen();
                    f.Schwimmen();
                }
            }
        }
    }
}