using System.Collections.Generic;
using System.Linq;
using Domain.LeagueOfLegends.VOs;

namespace Domain.LeagueOfLegends.Entities{
    public class Runes{
        public Runes()
        {
            _runes = new List<Rune>();
        }
        private readonly List<Rune> _runes;
        public ICollection<Rune> ListRunes => _runes.ToArray();

        public bool AddRune(Rune rune){
            if(!Checked(rune))
                return false;
            _runes.Add(rune);
            return true;
        }

        private bool Checked(Rune rune)
        {
            var res = _runes.Exists(x => x.Name == rune.Name || x.level == rune.level);
            if(res)
                return false;
            return true;
        }
    }
}