using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class SpellEffect : IEffect
    {
        public int EffectStrength { get; set; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            throw new NotImplementedException();
        }
        
        public SpellEffect(int strength)
        {
            EffectStrength = strength;
        }
    }
}
