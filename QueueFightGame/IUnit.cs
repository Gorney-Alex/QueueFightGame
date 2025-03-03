﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFightGame
{
    internal interface IUnit
    {
        int Health { get; }
        float Protection { get; }
        float Damage { get; }

        void Attack(IUnit target);

    }
}
