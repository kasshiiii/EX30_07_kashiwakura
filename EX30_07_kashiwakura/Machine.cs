using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 機械
    /// </summary>
    internal class Machine : Thing
    {
        public float _boxW, _boxH, _boxD;//入れる箱の大きさ
        public float _powerConsumption;//消費電力
        public float PowerConsumption
        {
            get { return _powerConsumption; }
        }
        public float BoxHeight
        {
            get { return _boxH; }
        }
        public float BoxWidth
        {
            get { return _boxW; }
        }
        public float Boxdepth
        {
            get { return _boxD; }
        }
        public Machine(float powerConsumption,float boxW, float boxH, float boxD, string name, float width, float height, float depth, float weight) : base(name, width, height, depth, weight)
        {
            _powerConsumption = powerConsumption;
            _boxW = boxW;
            _boxH = boxH;
            _boxD = boxD;
        }

    }
}
