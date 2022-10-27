using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    class Worker : Person
    {
        public string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
        }
        public Worker(string companyName,int age, int lifeSpan, DateTime birthDay, string name, float width, float height, float depth,float weight) : base(age, lifeSpan, birthDay, name, width, height, depth, weight)
        {
            _companyName = companyName;
        }
    }
}
