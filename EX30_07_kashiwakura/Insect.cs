using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 虫
    /// </summary>
    class Insect : Creature
    {
        public bool _flyable;//飛ぶことができるか
        public bool Flyable
        {
            get { return _flyable; }
        }

        public Insect(bool fryable, DateTime birthDay, string name, float width, float height, float depth, float weight) : base(birthDay, name, width, height, depth, weight)
        {
            _flyable = fryable;
        }
    }
}
