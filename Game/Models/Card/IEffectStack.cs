using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models.Card
{
    interface IEffectStack
    {

        public void Add(Effect d)
        {
        }

        public void Remove(Effect d)
        {
        }

        public (int, int) ApplyEffect((int index, int hp) card_data);
    }
}
