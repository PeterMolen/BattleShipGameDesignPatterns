using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGameDesignPatterns.Strategies
{
    // Strategy Design Pattern
    public class TargetedAttackStrategy : IAttackStrategy
    {
        public void Attack(int x, int y)
        {
            Console.WriteLine($"Targeted attack at ({x}, {y})");
        }
    }
}
