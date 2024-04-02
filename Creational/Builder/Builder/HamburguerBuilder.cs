namespace Builder
{
    public class HamburguerBuilder
    {
        private readonly Hamburguer _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburguer();
        }

        public HamburguerBuilder SetTypeBread(string bread)
        {
            _hamburguer.TypeBread = bread;
            return this;
        }

        public HamburguerBuilder SetTypeMeat(string meat)
        {
            _hamburguer.TypeMeat = meat;
            return this;
        }

        public HamburguerBuilder HaveBacon()
        {
            _hamburguer.HaveBacon = true;
            return this;
        }

        public HamburguerBuilder HavePotatosFries()
        {
            _hamburguer.HavePotatoFries = true;
            return this;
        }

        public HamburguerBuilder HaveCheese()
        {
            _hamburguer.HaveCheese = true;
            return this;
        }

        public HamburguerBuilder HaveSalad()
        {
            _hamburguer.HaveSalad = true;
            return this;
        }

        public Hamburguer Build() => _hamburguer;
    }
}
