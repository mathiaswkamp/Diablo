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
            // create a new weapon that calls the createWeapon method and gives the userinput as parameter.
            Weapon weapon = new WeaponFactory().CreateWeapon(userinput);  
            Console.WriteLine("What type of weapon would you want (axe / sword)");

            // check if the user inputs axe.
            if (userinput == "axe")
            {
                Console.Clear();
                // this line prints out the properties given to the Axe
                Console.WriteLine(weapon.ToString());

            }
            // checks if the user inputs sword
            else if (userinput == "sword")
            {
              Console.Clear();
              // this line prints out the properties given to the Sword
                Console.WriteLine(weapon.ToString());
            }
        }
    }
}
