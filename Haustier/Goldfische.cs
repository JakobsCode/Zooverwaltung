using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Goldfische : Fisch, IStreichelbar
    {
        public Goldfische(string Name, string Besitzer) /*: base(Name, Besitzer)*/
        {
            base.Name = Name;
            _Besitzer = Besitzer;
        }

        public void Streicheln()
        {
            Console.WriteLine($"Goldfisch {Name} wird gestreichelt.");
        }

        public override void Schwimmen()
        {
            Console.WriteLine("{0} schwimmt im Kreis", Name);
        }
    }
}
