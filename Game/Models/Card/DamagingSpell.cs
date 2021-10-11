namespace Game.Models.Card
{
    public class DamagingSpell : ISpellCard
    {
        public string Title => "Spell";
        public string Description => "Damages";
        public int? Attack => null;
        public int? Defense => null;
    }
}
