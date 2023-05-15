namespace Haustier
{
    public abstract class Haustier
    {
        private string _Name;
        protected string Name
        {
            get { return _Name; }
            set { _Name =  value; }
        }

        public Haustier(string Name)
        {
            _Name = Name;
        }

        public abstract void Pflegen();
    }
}