using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    internal class Dog : Creature
    {
        public string _dogType;//猫種
        public string DogType
        {
            get { return _dogType; }
        }
        public Dog(string catType, DateTime birthDay, string name, float width, float height, float depth, float weight) : base(birthDay, name, width, height, depth, weight)
        {
            _dogType = catType;
        }
    }
}
