using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGameDesignPatterns.Strategies
{
    // Strategy Design Pattern
    public interface IAttackStrategy
    {
        void Attack(int x, int y);
    }
}
