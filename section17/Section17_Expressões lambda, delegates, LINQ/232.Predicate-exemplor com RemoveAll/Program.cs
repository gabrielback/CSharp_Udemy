
using _232.Predicate_exemplor_com_RemoveAll.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.00));
list.Add(new Product("HD Case", 89.90));


list.RemoveAll(ProductTest); // deleta tudo que for verdadeiro baseado na função ProductTest

foreach (Product p in list)
{
    Console.WriteLine(p);
}

static bool ProductTest(Product p)
{
    return p.Price >= 100;
}