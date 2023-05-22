using Haustier;

namespace Zooverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Startet...");

            Goldfische dieter = new Goldfische("Dieter", "Peter Panzer");
            dieter.Schwimmen();
            dieter.Pflegen();
            dieter.Streicheln();

            Guppys guppy = new Guppys("Hans", "Peter Panzer");
            guppy.Schwimmen();
            guppy.Pflegen();

            Kaninchen Hoppy = new Kaninchen("Hoppy", "Wolt Packer");
            Hoppy.Pflegen();
            Hoppy.Fortbewegen();
            Hoppy.Streicheln();

            Katzen Günter = new Katzen("Günter", "Husler");
            Günter.Pflegen();
            Günter.Fortbewegen();
            Günter.Streicheln();


            Fisch[] Aquarium = new Fisch[100];
            for (int i = 0; i < 25; i+=4)
            {
                Aquarium[i] = new Guppys($"Guppy-{i}", "Klaus Schmaus");
                Aquarium[i+2] = new Goldfische($"Goldfisch-{i+2}", "Herr ChatGPT");
            }

            foreach (Fisch f in Aquarium)
            {
                if (f != null)
                {
                    f.Pflegen();
                    f.Schwimmen();
                }
            }

            Saeuger[] Garten = new Saeuger[50];
            for (int i = 1; i <= 25; i+=4) {
                Garten[i] = new Kaninchen($"Kaninchen-{i}", "Klaus Schmaus");
                Garten[i + 1] = new Hausschwein($"Hausschwein-{i+1}", "Schlamm Lover");
                Garten[i + 2] = new Katzen($"Katze-{i+2}", "Herr ChatGPT");
            }

            foreach(Saeuger s in Garten)
            {
                if (s != null)
                {
                    s.Pflegen();
                }
            }

            Haustier.Haustier[][] Zoo = new Haustier.Haustier[2][];
            Zoo[0] = Garten;
            Zoo[1] = Aquarium;

            foreach (Haustier.Haustier[] h in Zoo)
            {
                foreach (Haustier.Haustier h2 in h)
                {
                    if (h2 != null)
                    {
                        h2.Pflegen();
                        Console.WriteLine(h2.Besitzer);
                        Console.WriteLine(h2.ToString());
                        if (h2 is Fisch f2)
                        {
                            f2.Schwimmen();
                        } else if (h2 is Katzen k2){
                            k2.Fressen("Maus");
                        } else if (h2 is Kaninchen K2)
                        {
                            K2.Fressen("Salat");
                        } else if (h2 is IPflanzenfresser H2)
                        {
                            H2.Fressen("Salatblatt");
                        } else if (h2 is IFleischFresser P2)
                        {
                            P2.Fressen("Wurst");
                        }
                    }
                }
            }
        }
    }
}