using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Katzen : Saeuger
    {
        public Katzen(string Name) : base(Name){ }

        public override void Streicheln()
        {
            Console.WriteLine($"Katze {Name} wird gestreichelt.");
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
