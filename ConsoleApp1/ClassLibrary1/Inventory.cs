using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Inventory
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Inventory(string ItemName, int Quantity)
        {
            this.ItemName = ItemName;
            this.Quantity = Quantity;
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"Inventory Item: {ItemName}, Quantity: {Quantity}");

        }
    }
}
