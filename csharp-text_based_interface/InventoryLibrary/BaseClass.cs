using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        public string id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }

        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = new DateTime();
            date_updated = new DateTime();
        }
    }
}
