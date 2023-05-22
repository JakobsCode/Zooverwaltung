using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustier
{
    public abstract class Saeuger : Haustier, IStreichelbar
    {
        //public Saeuger(string Name, string Besitzer) : base(Name, Besitzer) { }

        public abstract void Fortbewegen();

        public abstract void Streicheln();
    }

}
