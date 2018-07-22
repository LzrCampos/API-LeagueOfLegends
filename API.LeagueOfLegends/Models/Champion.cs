using System;
using API.LeagueOfLegends.Enums;
using API.LeagueOfLegends.Models.VOs;

namespace API.LeagueOfLegends.Models
{
    public class Champion
    {
        public Champion(string name, string nickName, Attributes statistics, ClassType type, Difficulty difficulty, string history)
        {
            Id = Guid.NewGuid();
            Name = name;
            NickName = nickName;
            Statistics = statistics;
            Type = type;
            Difficulty = difficulty;
            History = history;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public Attributes Statistics { get; private set; }
        public ClassType Type { get; private set; }
        public Difficulty Difficulty { get; private set; }
        public string History { get; private set; }

    }
}