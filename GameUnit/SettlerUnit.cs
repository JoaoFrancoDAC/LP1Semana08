using System;

namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit() : base(movement: 1, health: 3)
        {
            // O construtor da classe base é chamado com movement = 1 e health = 3
        }

        public override float Cost => 5;
    }
}