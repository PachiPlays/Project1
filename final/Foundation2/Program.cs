using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine();


        Address A1 = new Address("123 Street", "Dallas", "Texas", "USA", true);
        Customer C1 = new Customer("Homer Simpson", A1);
        Order O1 = new Order(C1);

        Product O1P1 = new Product("Taco meat", 253, 30, 5);
        Product O1P2 = new Product("Sony 57 inch Monitor", 323, 3000, 1);
        O1.AddProduct(O1P1);
        O1.AddProduct(O1P2);
        string O1PackingLabel = O1.GetPackingLabel();
        string O1ShippingLabel = O1.GetShippingLabel();
        int O1TotalCost = O1.GetTotalCost();

        Console.WriteLine($"Packing Label: \n{O1PackingLabel}");
        Console.WriteLine($"Shipping Label: \n{O1ShippingLabel}\n");
        Console.WriteLine($"Total Cost: ${O1TotalCost}");
        Console.WriteLine();


        Address A2 = new Address("Atras de la estacion de policia", "La Lima", "Cortes", "Honduras", false);
        Customer C2 = new Customer("Juan Maria De La Cruz Rivera Torres Hernandez", A2);
        Order O2 = new Order(C2);

        Product O2P1 = new Product("Carne Molida", 553, 10, 3);
        Product O2P2 = new Product("Pelota de futbol", 948, 15, 2);
        Product O2P3 = new Product("Taqueritos", 234, 2, 30);
        O2.AddProduct(O2P1);
        O2.AddProduct(O2P2);
        O2.AddProduct(O2P3);

        string O2PackingLabel = O2.GetPackingLabel();
        string O2ShippingLabel = O2.GetShippingLabel();
        int O2TotalCost = O2.GetTotalCost();

        Console.WriteLine($"Packing Label: \n{O2PackingLabel}");
        Console.WriteLine($"Shipping Label: \n{O2ShippingLabel}\n");
        Console.WriteLine($"Total Cost: ${O2TotalCost}");




    }
}