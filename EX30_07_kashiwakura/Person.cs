using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 人
    /// </summary>
    internal class Person : Creature
    {
        public int _lifeSpan;//寿命
        public int _age;//年齢
        public int Age
        {
            get { return _age; }
        }
        public int LifeSpan
        {
            get { return _lifeSpan; }
        }
        public Person(int age, int lifeSpan, DateTime birthDay, string name, float width, float height, float depth, float weight) : base(birthDay, name, width, height, depth, weight)
        {
            _age = age;
            _lifeSpan = lifeSpan;
        }
    }
}
