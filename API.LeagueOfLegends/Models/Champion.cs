using API.LeagueOfLegends.Enums;
using API.LeagueOfLegends.Models.VOs;

namespace API.LeagueOfLegends.Models{
    public class Champion{
        public Champion()
        {
            
        }

        public string Name { get; private set; }
        public string NickName { get; private set; }
        public Attributes Statistics { get; private set; }
        public ClassType Type { get; private set; }
        
    }
}