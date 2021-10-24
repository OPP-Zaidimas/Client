using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class HealingEffect : EffectDecorator
    {
        HealingItem healingItem;

        public HealingEffect(HealingItem h) 
        {
            healingItem = h;
        }
        public override String applyEffect()
        {
            return healingItem.applyEffect() + "It heals";
        }
    }
}
