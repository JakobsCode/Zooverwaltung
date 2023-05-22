namespace Haustier
{
    public abstract class Haustier
    {
        public override string ToString()
        {
            return $"<Name: {_Name} | Typ: {this.GetType()}>";
        }

        private string _Name;
        protected string _Besitzer;
        protected string Name
        {
            get { return _Name; }
            set { _Name =  value; }
        }

        public string Besitzer
        {
            get { return _Besitzer; }
        }

        //public Haustier(string Name, string Besitzer)
        //{
        //    _Name = Name;
        //    _Besitzer = Besitzer;
        //}

        public abstract void Pflegen();
    }
}