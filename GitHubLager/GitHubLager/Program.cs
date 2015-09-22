using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubLager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till GitHubLager");
            Console.WriteLine("");
            Console.ReadKey();

            var order1 = new Order();
            order1.Item = "Test produkt";
            order1.Customer = "Test AB";
            order1.OrderDescription = "Nya varor till renovering.";
            order1.OrderNumber = 1;
            order1.ShippingAdress = "Testgatan 1, 81010 Testa";

            var order2 = new Order();
            order2.Item = "Koskötare";
            order2.Customer = "Mejeriet AB";
            order2.OrderDescription = "Uppgradera ladan";
            order2.OrderNumber = 2;
            order2.ShippingAdress = "Kogatan 1, 84420 Koland";

            var order3 = new Order();
            order3.Item = "Kylplatta";
            order3.Customer = "Datakompaniet AB";
            order3.OrderDescription = "Byggmaterial till serverlokal.";
            order3.OrderNumber = 3;
            order3.ShippingAdress = "Datagatan 4, 82250 Compland";


            var orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);


            foreach (Order x in orders)
            {               
                Console.WriteLine("Produktnamn: " + x.Item);
                Console.WriteLine("Kund: " + x.Customer);
                Console.WriteLine("Orderbeskrivning: " + x.OrderDescription);
                Console.WriteLine("Ordernummer: " + x.OrderNumber);
                Console.WriteLine("Vi skickar ordern till adressen: " + x.ShippingAdress);
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
