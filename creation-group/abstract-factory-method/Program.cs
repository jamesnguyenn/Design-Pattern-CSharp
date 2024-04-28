using System;
using System.Threading;
public class Program
{
    public static void Main()
    {
        // if type == 0 create Apple , else create Samsung
        var random = new Random();
        var type = random.Next(0, 2);
        IProductAbstractFactory factory;
        if (type == 0)
        {
            factory = new AppleProductFactory();
        }
        else
        {
            factory = new SamsungProductFactory();
        }
        var product1 = factory.createProduct(0);
        var product2 = factory.createProduct(99.000m);
        Console.WriteLine($"Type: {type}");
        Console.WriteLine(product1.ToString());
        Console.WriteLine("--------------------");
        Console.WriteLine(product2.ToString());
    }
}


public class ProductAbstract(string name, decimal price, string brand)
{
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public string Brand { get; set; } = brand;

    public override string ToString()
    {
        return String.Format($"Name: {Name} \nPrice: {Price} \nBrand: {Brand}");
    }
}

// Hide Business Logic To Create Product

interface IProductAbstractFactory
{
    ProductAbstract createProduct(decimal price);
}
public abstract class ProductAbstractFactory : IProductAbstractFactory
{
    public abstract ProductAbstract createProduct(decimal price);

}

public class AppleProductFactory : ProductAbstractFactory
{
    public ProductAbstract product;
    public override ProductAbstract createProduct(decimal price)
    {
        {

            switch (price)
            {
                case 0:
                    product = new ProductAbstract("Free Apple Product", 0, "Apple");
                    break;
                default:
                    product = new ProductAbstract("Fixed Apple Product", price, "Apple");
                    break;
            }
            return product;
        }
    }
}
public class SamsungProductFactory : ProductAbstractFactory
{
    public ProductAbstract product;
    public override ProductAbstract createProduct(decimal price)
    {
        {

            switch (price)
            {
                case 0:
                    product = new ProductAbstract("Free Samsung Product", 0, "Samsung");
                    break;
                default:
                    product = new ProductAbstract("Fixed Samsung Product", price, "Samsung");
                    break;
            }
            return product;
        }
    }
}