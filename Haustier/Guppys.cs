using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public class Guppys : Fisch
    {
        public Guppys(string Name) : base(Name){ }

        public override void Schwimmen()
        {
            Console.WriteLine("{0} schwimmt hin und her", Name);
        }
    }
}
