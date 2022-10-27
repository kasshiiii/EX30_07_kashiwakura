using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 自動車
    /// </summary>
    internal class Car : Thing
    {
        public float _fuelConsumption;//燃費
        public float FuelConsumption
        {
            get { return _fuelConsumption; }
        }

        public Car(float fuelConsumption, string name, float width, float height, float depth, float weight) : base(name, width, height, depth, weight)
        {
            _fuelConsumption = fuelConsumption;
        }
    }
}
