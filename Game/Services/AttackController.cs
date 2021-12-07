using Game.Views.User_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class AttackController
    {
        private ArenaSide _playerArenaSide;
        private ArenaSide _enemyArenaSide;

        public AttackController(ArenaSide playerSide, ArenaSide enemySide)
        {
            _playerArenaSide = playerSide;
            _enemyArenaSide = enemySide;
        }

    }
}
