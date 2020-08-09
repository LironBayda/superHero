using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superHero
{
    class SuperMan : Humen, IFly
    {
        public int _WebLeft { get;private set; }

        public SuperMan(int webLeft,string name, int age):base(name,age)
        {
            _WebLeft = webLeft;
        }

        public void ActiveSuperPowers()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public override string ToString()
        {
            return base.ToString()+$"_WebLeft: {_WebLeft}";
        }
    }
}
