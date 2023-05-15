using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Kaninchen : Saeuger
    {
        public Kaninchen(string Name) : base(Name) { }

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
