using System;
using API.LeagueOfLegends.Enums;

namespace API.LeagueOfLegends.Models{
    public class Rune{
        public Rune(string name, RuneType type, RuneLevel level, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            this.level = level;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public RuneType Type { get; private set; }
        public RuneLevel level { get; private set; }
        public string Description { get; private set; }
    }
}