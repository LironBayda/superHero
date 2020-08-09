using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superHero
{
    class Program
    {
        static void ActivateHero(ISuperHero superHero)
        { superHero.ActiveSuperPowers();
        }

        static void IdentifyHero(ISuperHero superHero)
        {
            if (superHero is Flash)
                Console.WriteLine("Flash detected");
            else if (superHero is SuperMan)
                Console.WriteLine("SuperMan detected");
            else if (superHero is SpiderMan)
                Console.WriteLine("SpiderMan detected");
        }
        static void GetMoreHeroData(ISuperHero superHero)
        {
            if (superHero is Flash)
            {
                Flash flash = superHero as Flash;
                Console.WriteLine($" flash._Voltage { flash._Voltage}");

            }
            else if (superHero is SuperMan)
            {
                SuperMan superMan = superHero as SuperMan;
                Console.WriteLine($" superMan._WebLeft { superMan._WebLeft}");

            }
            else if (superHero is SpiderMan)
            {
                SpiderMan spiderMan = superHero as SpiderMan;
                Console.WriteLine($" spiderMan._Speed { spiderMan._Speed}");

            }
        }

        static ISuperHero CreateHero(string type)
        {
            ISuperHero superHero;
            switch (type)
            {
                case "SuperMan":
                    superHero = new SuperMan(33,"pol",33);
                    break;
                case "SpiderMan":
                    superHero = new SpiderMan(33, "pol", 33);
                    break;
                case "Flash":
                    superHero = new Flash(33, "pol", 33);
                    break;
                default:
                    superHero = null;
                    break;
            }

            return superHero;


        }

        static void Main(string[] args)
        {
            Flash flash = new Flash(44, "Dan", 40);
            SpiderMan spiderMan = new SpiderMan(33, "pol", 22);
            SuperMan superMan = new SuperMan(66, "bar", 33);
            ISuperHero[] superHeros = { flash, spiderMan, superMan };
        foreach(ISuperHero superHero in superHeros)
            {
                ActivateHero(superHero);
            }

            IdentifyHero(flash);
            IdentifyHero(spiderMan);
            IdentifyHero(superMan);

            GetMoreHeroData(flash);
            GetMoreHeroData(spiderMan);
            GetMoreHeroData(superMan);

            SuperMan superMan1 = CreateHero("SuperMan") as SuperMan;
            Console.WriteLine(superMan1._WebLeft);


            Console.ReadLine();


        }
    }
}
