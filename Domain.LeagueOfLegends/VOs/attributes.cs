namespace Domain.LeagueOfLegends.VOs
{
    public sealed class Attributes
    {
        public Attributes(double health, double healthRegeneration, double attackDamage, double attackSpeed, double armor, double magicResistance, double movimentSpeed, double range)
        {
            Health = health;
            HealthRegeneration = healthRegeneration;
            AttackDamage = attackDamage;
            AttackSpeed = attackSpeed;
            Armor = armor;
            MagicResistance = magicResistance;
            MovimentSpeed = movimentSpeed;
            Range = range;
        }

        public double Health { get; private set; }
        public double HealthRegeneration { get; private set; }
        public double? Mana { get; private set; }
        public double? ManaRegeneration { get; private set; }
        public double AttackDamage { get; private set; }
        public double AttackSpeed { get; private set; }
        public double Armor { get; private set; }
        public double MagicResistance { get; private set; }
        public double MovimentSpeed { get; private set; }
        public double Range { get; private set; }
    }
}