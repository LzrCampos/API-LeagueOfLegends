using System;
using Domain.LeagueOfLegends.Enums;
using Domain.LeagueOfLegends.Entities;
using Domain.LeagueOfLegends.VOs;
using Xunit;

namespace TEST.LeagueOfLegends
{
    public class RunesTest
    {
        [Fact]
        public void CheckIfThereIsAnEqualRune()
        {
            var rune1 = new Rune("Conquistador",RuneType.Precision,RuneLevel.Level4,"After 4 seconds in combat, your first attack against an enemy champion grants you 6-35 attack damage, based on level, for 3 seconds, and converts 20% of your damage to champions to true damage.");
            var rune2 = new Rune("Triunfo",RuneType.Precision,RuneLevel.Level3,"Takedowns restore 12% of your missing health and grant an additional 20 gold.");
            var rune3 = new Rune("Linhagem",RuneType.Precision,RuneLevel.Level2,"Takedowns on enemies grant permanent Lifesteal.");
            var rune4 = new Rune("Golpe de misericordia",RuneType.Precision,RuneLevel.Level1,"Deal more damage to low health enemy champions.");

            var runes = new Runes();

            runes.AddRune(rune1);
            runes.AddRune(rune2);
            runes.AddRune(rune2);
            runes.AddRune(rune1);

            Assert.True(runes.ListRunes.Count == 4);

        }
    }
}
