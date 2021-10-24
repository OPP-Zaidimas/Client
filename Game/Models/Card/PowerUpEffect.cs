using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class PowerUpEffect : EffectDecorator
    {
        HealingItem healingItem;

        public PowerUpEffect(HealingItem h)
        {
            healingItem = h;
        }
        public override String ApplyEffect()
        {
            return healingItem.ApplyEffect() + "It improves";
        }

    }
}
