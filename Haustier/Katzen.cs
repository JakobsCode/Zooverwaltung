using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Katzen : Saeuger, IFleischFresser
    {
        public Katzen(string Name, string Besitzer) /*: base(Name, Besitzer) */
        {
            base.Name = Name;
            _Besitzer = Besitzer;
        }

        public void Fressen(string nahrung)
        {
            Console.WriteLine($"Katze {Name} frisst {nahrung}.");
        }

        public override void Streicheln()
        {
            Console.WriteLine($"Katze {Name} wird gestreichelt.");
            Schnurren();
        }

        private void Schnurren()
        {
            Console.WriteLine($"Katze {Name} schnurrt.");
        }

        private void Schleichen() 
        {
            Console.WriteLine($"Katze {Name} schleicht sich voran.");
        }
        public override void Fortbewegen()
        {
            Schleichen();    
        }

        private void FellBuersten()
        {
            Console.WriteLine($"Katze {Name} wird gebürstet.");
        }

        public override void Pflegen()
        {
            FellBuersten();
        }
    }
}
