namespace Game.Models.Card
{
    public class DamagingSpell : ISpellCard, IEffect
    {
        public string Title => "Spell";
        public string Description => "Damages";
        public int? Attack => null;
        public int? Defense => null;

        public int EffectStrength { get => EffectStrength; set => EffectStrength = value; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, EffectStrength < card_data.hp ? card_data.hp - EffectStrength : 0);
        }
    }
}
