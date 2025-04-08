using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public User user_id;
        public Item item_id;
        public quantity = 1;

        public Inventory (string userId, string itemId, int quantityy = 1)
        {
            this.user_id = userId;
            this.item_id = itemId;
            this.quqntity = quantityy;
        }
    }
}
