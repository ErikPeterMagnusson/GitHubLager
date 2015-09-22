using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubLager
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int Weigth { get; set; }
        public Item()
        {
        }
        public Item(Item item)
        {
            this.Id = item.Id;
            this.Name = item.Name;
            this.Type = item.Type;
            this.Length = item.Length;
            this.Width = item.Width;
            this.Heigth = item.Heigth;
            this.Weigth = item.Weigth;
        }
    }
}
