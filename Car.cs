using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Без_тормазов
{
    class Car
    { 
        public readonly Vector Location;
        public readonly Vector Velocity;
        public readonly double Direction;

        public Car(Vector location, Vector velocity, double direction)
        {
            Location = location;
            Velocity = velocity;
            Direction = direction;
        }
    }
}
