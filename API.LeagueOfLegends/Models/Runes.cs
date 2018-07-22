using System.Collections.Generic;
using API.LeagueOfLegends.Models.VOs;

namespace API.LeagueOfLegends.Models{
    public class Runes{
        public List<Rune> ListRunes { get; private set; }

        public void AddRune(Rune rune){
            ListRunes.Add(rune);
        }
    }
}