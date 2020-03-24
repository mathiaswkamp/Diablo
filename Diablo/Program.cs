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

            Console.WriteLine("What type of weapon would you want (1haxe / 1hsword)");
            string userinput = Console.ReadLine();

           

            if (userinput == "1haxe")
            {
                weapon = weaponFactory.createWeapon(userinput);

                Console.WriteLine($"you´ve gotten a : {weapon.Name}");
                Console.WriteLine($"the rarity is : {weapon.Rarity}");
                Console.WriteLine($"damage : {weapon.Damage}");

            }

        }
    }

}
