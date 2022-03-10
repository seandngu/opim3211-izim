using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZIM
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }

    public class Locations
    {
        public string Location { get; set; }
    }

    public class Items
    {
        public string Barcode_ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

    public class Insert
    {
        public int Confirmation { get; set; }
    }
    public class Inventory
    {
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Last_Modified { get; set; }
    }
}
