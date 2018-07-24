using System;
using Domain.LeagueOfLegends.Enums;

namespace Domain.LeagueOfLegends.VOs
{
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

        public override string ToString() => Name;
    }
}