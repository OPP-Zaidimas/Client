namespace Game.Models.Card
{
    public class HealingSpell : ISpellCard, IEffect
    {
        public string Title => "Spell";
        public string Description => "Heals";
        public int? Attack => null;
        public int? Defense => null;

        public int EffectStrength { get => EffectStrength; set => EffectStrength = value; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, card_data.hp+EffectStrength);
        }
    }
}
