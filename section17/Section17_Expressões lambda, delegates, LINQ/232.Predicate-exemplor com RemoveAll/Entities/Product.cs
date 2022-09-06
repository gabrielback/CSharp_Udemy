namespace _232.Predicate_exemplor_com_RemoveAll.Entities
{
    internal class Product
    {
        string name;
        double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"Nome: {Name}, " +
                $"Price: {Price.ToString("F2")}";
        }
    }
}
