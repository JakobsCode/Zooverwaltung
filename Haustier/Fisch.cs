using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public abstract class Fisch : Haustier
    {
        public Fisch(string Name) : base(Name){ }

        public abstract void Schwimmen();

        private void WasserWechseln()
        {
            Console.WriteLine("Vom Fisch {0} wird das Wasser gewechselt", Name);
        }

        public override void Pflegen()
        {
            WasserWechseln();
        }
    }
}
