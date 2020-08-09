using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superHero
{
    class Humen
    {
        public string _Name { get; set; }
        int _age;

        public int getAge()
        {
            return _age;
        }

        public Humen(string name, int age)
        {

            _Name = name;
            _age = age;

        }

        public override string ToString()
        {
            return base.ToString()+$"_age: {_age} Name {_Name}";
        }
    }
}
