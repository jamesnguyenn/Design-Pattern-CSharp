using System;
using System.Threading;
public class Program
{
    public static void Main()
    {
        var productFactory = new ProductFactory();
        var product1 = productFactory.createProduct(0);
        var product2 = productFactory.createProduct(99.000m);
        Console.WriteLine(product1.ToString());
        Console.WriteLine(product2.ToString());
    }
}


public class Product(string name, decimal price)
{
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;

    public override string ToString()
    {
        return String.Format($"Name: {Name} \nPrice: {Price}");
    }
}

// Hide Business Logic To Create Product 
public class ProductFactory
{
    public Product product;
    public Product createProduct(decimal price)
    {

        switch (price)
        {
            case 0:
                product = new Product("Free Product", 0);
                break;
            default:
                product = new Product("Fixed Product", price);
                break;
        }
        return product;
    }
}