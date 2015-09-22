using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubLager
{
    // DEFINE CLASS
    class Order
    {
        public string       Item                { get; set; }
        public string       Customer            { get; set; }
        public List<Item>   OrderItems          { get; set; }
        public int          OrderNumber         { get; set; }
        public string       OrderDescription    { get; set; }
        public string       ShippingAdress      { get; set; }

        public void SetItems(IEnumerable<Item> ordItems)
        {
            OrderItems = new List<Item>();
            foreach (var item in ordItems)
            {
                OrderItems.Add(new Item(item));
            }
        }
    }

}
