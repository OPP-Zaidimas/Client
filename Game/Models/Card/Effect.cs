using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class Effect
    {
        public int EffectStrength { get; set; }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, EffectStrength < card_data.hp ? card_data.hp - EffectStrength : 0);
        }
    }
}
