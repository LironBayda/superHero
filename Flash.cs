using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superHero
{
    class Flash : Humen, IFlash
    {
        public Flash(int voltage,string name,int age):base(name,age)
        {
            _Voltage = voltage;
        }

        public int _Voltage { get; private set; }
        public void ActiveSuperPowers()
        {
            FireLightnings();
        }

        public void FireLightnings()
        {
            Console.WriteLine("Fire Lightnings");
        }
        public override string ToString()
        {
            return base.ToString()+$"Voltage{_Voltage}";
        }
    }
}
