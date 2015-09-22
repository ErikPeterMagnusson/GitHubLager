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

            var item1 = new Item();
            var item2 = new Item();
            var item3 = new Item();
            var item4 = new Item();
            item1.Name = "Item 1";
            item2.Name = "Item 2";
            item3.Name = "Item 3";
            item4.Name = "Item 4";

            List<Item> orderItems = new List<Item>();
            orderItems.Add(item4);
            orderItems.Add(item3);
            orderItems.Add(item2);
            orderItems.Add(item1);

            var order1 = new Order();
            order1.Item = "Test produkt";
            order1.Customer = "Test AB";
            order1.OrderItems = orderItems;
            order1.OrderNumber = 1;
            order1.OrderDescription = "Nya varor till renovering.";
            order1.ShippingAdress = "Testgatan 1, 81010 Testa";

            var order2 = new Order();
            order2.Item = "Koskötare";
            order2.Customer = "Mejeriet AB";
            order2.OrderItems = orderItems;
            order2.OrderNumber = 2;
            order2.OrderDescription = "Uppgradera ladan";
            order2.ShippingAdress = "Kogatan 1, 84420 Koland";

            var order3 = new Order();
            order3.Item = "Kylplatta";
            order3.Customer = "Datakompaniet AB";
            order3.OrderItems = orderItems;
            order3.OrderNumber = 3;
            order3.OrderDescription = "Byggmaterial till serverlokal.";
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
                Console.WriteLine("Kund: " + x.Customer);
                Console.WriteLine("");
                Console.ReadKey();
            }
            foreach (Item i in orderItems)
            {               
            Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}
