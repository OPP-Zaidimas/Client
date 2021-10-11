namespace Game.Models.Hero
{
    class Tank : IHero
    {
        public string Name => "Tank";
        public int MaxHp => 50;
        public int AttackDamage => 2;
    }
}
