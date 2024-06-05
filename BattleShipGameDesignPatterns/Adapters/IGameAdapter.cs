using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGameDesignPatterns.Adapters
{
    // Adapter Design Pattern
    public interface IGameAdapter
    {
        void ExecuteAttack(int x, int y);
    }

}
