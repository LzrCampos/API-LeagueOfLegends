using System.Collections.Generic;
using Domain.LeagueOfLegends.VOs;

namespace Domain.LeagueOfLegends.Entities{
    public class Runes{
        public List<Rune> ListRunes { get; private set; }

        public void AddRune(Rune rune){
            ListRunes.Add(rune);
        }
    }
}