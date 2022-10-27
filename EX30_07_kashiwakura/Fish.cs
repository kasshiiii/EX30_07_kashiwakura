using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 魚
    /// </summary>
    class Fish : Creature
    {
        public bool _eatable;//食べられるか

        public bool Eatable
        {
            get { return _eatable; }
        }
        public Fish(bool eatable, DateTime birthDay, string name, float width, float height, float depth, float weight) : base(birthDay, name, width, height, depth, weight)
        {
            _eatable = eatable;
        }
    }
    
}
