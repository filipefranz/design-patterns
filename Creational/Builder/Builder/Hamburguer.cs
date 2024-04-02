namespace Builder
{
    public class Hamburguer
    {
        public string? TypeBread { get; set; }
        public string? TypeMeat { get; set; }
        public bool HaveBacon { get; set; }
        public bool HavePotatoFries { get; set; }
        public bool HaveCheese { get; set; }
        public bool HaveSalad { get; set; }

        public string getDescription()
        {
            return $"Hamburguer meat {TypeMeat}" +
                $" and bread {TypeBread}: " +
                $" Bacon: {HaveBacon}," +
                $" Potato Fries: {HavePotatoFries}," +
                $" Cheese: {HaveCheese}," +
                $" Salad: {HaveSalad}";
        }
    }
}
