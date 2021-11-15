﻿namespace Ecommcerce2.Core.Models.FEModels
{

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ItemType Type { get; set; }

    }
}
