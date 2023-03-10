
Console.WriteLine("== 1 Params Constructor ==");
Product product = new Product("Laptop"); // Calls only single parameter constructor
Console.WriteLine(product.Name);

Console.WriteLine("== 2 Params Constructor ==");
Product product2 = new Product("Laptop", 1500); // Calls 1, 2  parameter constructor respectively
Console.WriteLine(product2.Name);
Console.WriteLine(product2.UnitPrice);


Console.WriteLine("== 3 Params Constructor ==");
Product product3 = new Product("Laptop", 1500, "Asus Laptop"); // Calls 1,2,3 paramater constructor respectively
Console.WriteLine(product3.Name);
Console.WriteLine(product3.UnitPrice);
Console.WriteLine(product3.Description);





class Product
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public string Description { get; set; }

    public Product(string name)
    {
        this.Name = name;
    }

    public Product(string name, decimal unitPrice) : this(name)
    {
        this.UnitPrice = unitPrice;
    }

    public Product(string name, decimal unitPrice, string description) : this(name, unitPrice)
    {
        this.Description = description;
    }
}