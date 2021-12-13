using Game.Views.User_Controls;
using Game.Services.SignalR;

namespace Game.Services
{
    public class AttackController
    {
        private readonly ArenaSide _playerArenaSide;
        private readonly ArenaSide _enemyArenaSide;
        private (int, CardView) _attacker;
        private (int, CardView) _defender;
        private readonly SignalRService _service;

        public AttackController(ArenaSide playerSide, ArenaSide enemySide, SignalRService service)
        {
            _playerArenaSide = playerSide;
            _enemyArenaSide = enemySide;
            _attacker = (-1, null);
            _defender = (-1, null);
            _service = service;
        }

        public void HeroAttack()
        {
            if (IsAttackerNotNull())
            {
                SendHeroAttackMessageToServer();
            }

            ChangeHeroSelectionStatus(false);
            ResetAttackerAndDeffender();
        }

        public void MonsterAttack()
        {
            if (IsAttackerAndDeffenderNotNull())
            {
                SendMonsterAttackMessageToServer();
            }

            DisableEnemyMonsterSelection();
            MarkAsAttackedAlready();
            ResetAttackerAndDeffender();
        }

        public void ResetAttackerAndDeffender()
        {
            _attacker = (-1, null);
            _defender = (-1, null);
        }

        public void AttackingMonsterSelect(int id, CardView card)
        {
            _attacker = (id, card);
            if (_enemyArenaSide.CanAttackHero)
            {
                ChangeHeroSelectionStatus(true);
            }
            else
            {
                _enemyArenaSide.ChangeCardsSelectionStatus(true);
            }
        }

        public void DefendingMonsterSelect(int id, CardView card)
        {
            _defender = (id, card);
        }

        public bool IsAttackerNotNull()
        {
            return _attacker.Item1 != -1 && _attacker.Item2 != null;
        }

        public bool IsAttackerAndDeffenderNotNull()
        {
            return _attacker.Item1 != -1 && _attacker.Item2 != null
                                         && _defender.Item1 != -1 && _defender.Item2 != null;
        }

        public async void SendMonsterAttackMessageToServer()
        {
            await _service.MonsterAttack(_attacker.Item1, (int)
                _attacker.Item2.ViewModel.Attack,
                _defender.Item1,
                _defender.Item2.ViewModel.CurrentHp);
        }

        public void DisableEnemyMonsterSelection()
        {
            _enemyArenaSide.ChangeCardsSelectionStatus(false);
        }

        public void MarkAsAttackedAlready()
        {
            _playerArenaSide.ViewModel.SetCardStatus(_attacker.Item1, true);
        }

        public async void SendHeroAttackMessageToServer()
        {
            await _service.AttackOnHero((int)_attacker.Item2.ViewModel.Attack);
        }

        public void ChangeHeroSelectionStatus(bool status)
        {
            if (status)
            {
                _enemyArenaSide.EnableHeroSelection();
                return;
            }

            _enemyArenaSide.DisableHeroSelection();
        }
    }
}
