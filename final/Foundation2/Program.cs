using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Order o1 = new Order();
        orders.Add(o1);
        var p1 = new Product("Tooth Brush", 111, 1.5, 2);
        o1.AddProduct(p1);
        var p2 = new Product("Tooth Paste", 222, 3.25, 1);
        o1.AddProduct(p2);
        var p3 = new Product("Flossers", 333, 4.20, 1);
        o1.AddProduct(p3);
        var address = new Address("123 E 456 E", "Quelimane", "Zambezia", "Mozambique");
        var customer = new Customer("Junior Mangacao", address);
        o1.SetCustomer(customer);

        Order o2 = new Order();
        orders.Add(o2);
        var p4 = new Product("Mountain Bike", 777, 2758.37, 1);
        o2.AddProduct(p4);
        var p5 = new Product("MTB Glasses", 888, 13.87, 3);
        o2.AddProduct(p5);
        var address2 = new Address("456 E 789 E", "McCall", "Idaho", "USA");
        var customer2 = new Customer("Bob Smith", address2);
        o2.SetCustomer(customer2);

        foreach (Order o in orders){
            Console.WriteLine($"Order Total: {o.CalcTotalCost()}");
            Console.WriteLine("");

            Console.WriteLine("Packing Label");
            o.CreatePackingLabel();
            Console.WriteLine("");         

            Console.WriteLine("Shipping Label");
            o.CreateShippingLabel();
            Console.WriteLine("______________________________________________\n");          
        }


    }
}