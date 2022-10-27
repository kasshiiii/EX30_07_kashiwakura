using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 猫
    /// </summary>
    internal class Cat : Creature
    {
        public string _catType;//猫種
        public string CatType
        {
            get { return _catType; }
        }
        public Cat(string catType,DateTime birthDay, string name, float width, float height, float depth, float weight) : base(birthDay,name, width, height, depth, weight)
        {
            _catType = catType;
        }
    }
}
