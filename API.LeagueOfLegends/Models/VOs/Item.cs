using System;

namespace API.LeagueOfLegends.Models.VOs
{
    public class Item
    {
        public Item(string name, int price, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }
        public string Description { get; private set; }
    }
}