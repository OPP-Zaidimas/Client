namespace Game.Models.Hero
{
    public class Berserker : IHero
    {
        public string Name => "Berserker";
        public int MaxHp => 20;
        public int AttackDamage => 5;
    }
}
