using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superHero
{
    class SpiderMan:Humen, Iclimb
    {
        public int _Speed { get; private set; }
        public SpiderMan(int speed, string name,int age) : base(name,age)
        {
            _Speed = speed;
        }

        public void climb()
        {
            Console.WriteLine("climb");
        }

        public void ActiveSuperPowers()
        {
            climb();
        }
        public override string ToString()
        {
            return base.ToString()+$"_Speed: {_Speed} ";
        }
    }
}
