using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Hausschwein : Saeuger, IFleischFresser, IPflanzenfresser
    {
        public Hausschwein(string Name, string Besitzer)
        {
            base.Name = Name;
            _Besitzer = Besitzer;
        }
        public void Fressen(string nahrung)
        {
            Console.WriteLine($"Hauschein {Name} frisst komisches Ding Namens {nahrung}");
        }
        void IFleischFresser.Fressen(string nahrung) {
            Console.WriteLine($"Hausschwein {Name} frisst fleischigen {nahrung}.");
        }
        void IPflanzenfresser.Fressen(string nahrung)
        {
            Console.WriteLine($"Hausschwein {Name} frisst pflanzlichen {nahrung}.");
        }
        public override void Fortbewegen()
        {
            Console.WriteLine($"Hausschwein {Name} geht.");
        }

        public override void Pflegen()
        {
            Console.WriteLine($"Hausschwein {Name} springt in den Schlamm.");
        }

        public override void Streicheln()
        {
            Console.WriteLine($"Hausschwein {Name} wird gestreichelt.");
        }
    }
}
