using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 冷蔵庫
    /// </summary>
    class Refrigerator : Machine
    {
        public float _capacity;//容量
        public float Capacity
        {
            get { return _capacity; }
        }

        public Refrigerator(float capacity, float powerConsumption, float boxW, float boxH, float boxD, string name, float width, float height, float depth, float weight) : base(powerConsumption, boxW, boxH, boxD,name, width, height, depth, weight)
        {
            _capacity = capacity;
        }
    }
}
