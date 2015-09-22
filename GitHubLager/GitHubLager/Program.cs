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
            Console.ReadKey();

            var order1 = new Order();
            order1.Item = "Produkt Ett";
            order1.Customer = "Test AB";
            order1.OrderDescription = "Nya varor till renovering.";
            order1.OrderNumber = 1;
            order1.ShippingAdress = "Testgatan 1, 81010 Testa";

            var order2 = new Order();
            order2.Item = "Produkt Två";
            order2.Customer = "Mejeriet AB";
            order2.OrderDescription = "Uppgradera ladan";
            order2.OrderNumber = 2;
            order2.ShippingAdress = "Kogatan 1, 84420 Koland";


            var orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);


            foreach (Order x in orders)
            {               
                Console.WriteLine("Produktnamn: " + x.Item + "Kund: " + x.Customer + "Orderbeskrivning: " + x.OrderDescription +"ordernummer: " + x.OrderNumber + "vi skickar ordern till adressen: " + x.ShippingAdress);
                Console.ReadKey();
            }
        }
    }
}
