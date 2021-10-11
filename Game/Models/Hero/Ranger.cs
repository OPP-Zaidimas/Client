namespace Game.Models.Hero
{
    public class Ranger : IHero
    {
        public string Name => "Ranger";
        public int MaxHp => 30;
        public int AttackDamage => 3;
    }
}
