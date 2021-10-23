namespace Game.Models.Card
{
    public class DamagingSpell : ISpellCard, IEffect
    {
        public string Title
        {
            get => "Spell";
            set => throw new System.NotImplementedException();
        }

        public string Description
        {
            get => "Damages";
            set => throw new System.NotImplementedException();
        }

        public int? Attack
        {
            get => null;
            set => throw new System.NotImplementedException();
        }

        public int? Defense
        {
            get => null;
            set => throw new System.NotImplementedException();
        }

        public int EffectStrength { get; set; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, EffectStrength < card_data.hp ? card_data.hp - EffectStrength : 0);
        }
    }
}
