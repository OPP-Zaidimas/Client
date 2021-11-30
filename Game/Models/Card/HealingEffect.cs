using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    class HealingEffect
    {
        HealingItem healingItem;

        public HealingEffect(HealingItem h) 
        {
            healingItem = h;
        }
        public (int, int) ApplyEffect((int index, int hp) card_data, int effectStrength)
        {
            return (card_data.index, card_data.hp + effectStrength);
        }
    }
}
