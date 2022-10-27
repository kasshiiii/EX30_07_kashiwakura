using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 学生
    /// </summary>
    internal class Student : Person
    {
        public int _studentNumber;//学籍番号
        public int StudentNumber
        {
            get { return _studentNumber; }
        }
        public Student(int studentNumber,int age, int lifeSpan, DateTime birthDay, string name, float width, float height, float depth,float weight) : base(age, lifeSpan, birthDay, name,  width, height, depth, weight)
        {
            _studentNumber = studentNumber;
        }
    }
}
