namespace Game.Models.Card
{
    public class HealingSpell : ISpellCard
    {
        public string Title => "Spell";
        public string Description => "Heals";
        public int? Attack => null;
        public int? Defense => null;
    }
}
