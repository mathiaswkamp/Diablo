using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    class Program
    {
        static void Main(string[] args)
        {


            WeaponFactory weaponFactory = new WeaponFactory();   // create new factory of weapons

            Weapon weapon = null;

            Console.WriteLine("What type of weapon would you want (axe / sword)");
            string userinput = Console.ReadLine();

           

            if (userinput == "axe")
            {
                weapon = weaponFactory.createWeapon(userinput);

                

            }

        }
    }

}
