using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30
{
    /// <summary>
    /// 生き物
    /// </summary>
    internal class Creature:Thing
    {
        readonly private string _name;//名前
        readonly private DateTime _birthday = new DateTime();//誕生日
        public DateTime Birthday
        {
            get { return _birthday; }
        }
        public string Name
        {
            get { return _name; }
        }
        public bool GetTodayBirthDay()
        {
            if(Birthday.Date == DateTime.Today.Date)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
            return false;
        }
        public Creature(DateTime birthDay, string name, float width, float height, float depth, float weight) : base(name, width, height, depth, weight)
        {
            this._birthday = birthDay;
            this._name = name;
        }
    }
}
