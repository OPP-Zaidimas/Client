using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    public abstract class EffectDecorator : HealingItem
    {
        public new abstract String ApplyEffect();
    }
}
