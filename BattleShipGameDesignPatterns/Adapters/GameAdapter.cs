using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipGameDesignPatterns.Strategies;

namespace BattleShipGameDesignPatterns.Adapters
{
    // Adapter Design Pattern
    public class GameAdapter : IGameAdapter
    {
        private readonly IAttackStrategy _attackStrategy;

        public GameAdapter(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void ExecuteAttack(int x, int y)
        {
            _attackStrategy.Attack(x, y);
        }
    }
}
