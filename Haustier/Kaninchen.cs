using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Kaninchen : Saeuger, IPflanzenfresser
    {
        public Kaninchen(string Name, string Besitzer) /*: base(Name, Besitzer) */{
            base.Name = Name;
            _Besitzer = Besitzer;
        }

        public void Fressen(string nahrung)
        {
            Console.WriteLine($"Kaninchen {Name} frisst {nahrung}.");
        }

        public override void Streicheln()
        {
            Console.WriteLine($"Kaninchen {Name} wird gestreichelt.");
        }

        private void Hoppeln()
        {
            Console.WriteLine($"Kaninchen {Name} hoppelt nach vorne.");
        }

        public override void Fortbewegen()
        {
            Hoppeln();
        }

        private void StallAusmisten()
        {
            Console.WriteLine($"Der Stall von Kaninchen {Name} wird ausgemistet.");
        }

        public override void Pflegen()
        {
            StallAusmisten();
        }
    }
}
