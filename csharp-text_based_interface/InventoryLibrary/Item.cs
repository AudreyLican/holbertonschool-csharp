using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string name { get; set; }
        public string description { get; set; }
        private float _price;
        public float price
        {
            get { return _price; }
            set
            {
                _price = (float)Math.Round(value, 2);
            }
        }
        public List<string> tags { get; set; }

        public Item(string name, float price)
        {
            if (string.Is)
            this.name = name;
            this.price = price;
        }
    }
}