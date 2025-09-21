namespace ECommerceINOOw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa kund med attributen id, name, email. Jag väljer att ha konstruktorn i klassen för att göra main renare. (Gäller samtliga klasser)
            Customer customer1 = new Customer(1, "Martin Johansson", "martin@example.com");
            Customer customer2 = new Customer(2, "Bianca Ingrosso", "bianca@famous.com");

            // Skapa produktlista med attributen id, name, price, category och vikt för fysiska produkter eller filstorlek för digitala produkter
            Product p1 = new PhysicalProduct(1, "Laptop", 12000, "Electronics", 2.5);
            Product p2 = new DigitalProduct(2, "E-bok", 199, "Books", 5.0);
            Product p3 = new PhysicalProduct(3, "Smartphone", 8000, "Electronics", 0.3);

            // Skapa order med attributen id, orderDate, customer, product och quantity
            Order o1 = new Order(1, DateTime.Now, customer1, p1, 1);
            Order o2 = new Order(2, DateTime.Now, customer1, p2, 2);
            Order o3 = new Order(3, DateTime.Now, customer2, p3, 1);

            // Visa info
            customer1.DisplayInfo();
            Console.WriteLine();
            o1.DisplayInfo();
            Console.WriteLine();
            o2.DisplayInfo();

            Console.WriteLine(); //För mellanrum

            customer2.DisplayInfo();
            Console.WriteLine();
            o3.DisplayInfo();

            Payment payment1 = new CardPayment(o1.CalculateTotal(), DateTime.Now, "1234-5678-9012-3456");
            o1.AddPayment(payment1);

            o1.DisplayInfo();

        }
    }
}
