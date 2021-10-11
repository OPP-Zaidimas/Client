namespace Game.Models.Hero
{
    public interface IHero
    {
        public string Name { get; }

        public int MaxHp { get; }

        public int AttackDamage { get; }
    }
}
