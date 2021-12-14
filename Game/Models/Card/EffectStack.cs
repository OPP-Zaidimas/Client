using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class EffectStack : IEffectStack
    {
        public List<EffectStack> effectList = new List<EffectStack>();
        public int EffectStrength;

        public void Add(EffectStack d)
        {
            effectList.Add(d);
        }

        public void Remove(EffectStack d)
        {
            effectList.Remove(d);
        }

        public (int, int) ApplyEffect((int index, int hp) card_data)
        {
            return (card_data.index, EffectStrength < card_data.hp ? card_data.hp - EffectStrength : 0);
        }
    }
}
