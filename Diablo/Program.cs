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

            Console.WriteLine("What type of weapon would you want (axe / sword)");
            string userinput = Console.ReadLine();
            Weapon axe = new WeaponFactory().CreateWeapon(userinput);   // create new factory of weapons
            Console.WriteLine("What type of weapon would you want (axe / sword)");

            if (userinput == "axe")
            {
                Console.Clear();
                Console.WriteLine(axe.ToString());

            }
        }
    }
}
