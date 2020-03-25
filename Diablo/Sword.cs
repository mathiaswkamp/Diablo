using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{

    /// <summary>
    /// this class is a sword class
    /// the sword class inherits from weapon class.
    /// It has a constructor with the parameters from weapon class
    /// but also another attribute of a blade.
    /// this class has a method that overrides toString so that i can print out
    /// my attributes.
    /// </summary>
    public class Sword : Weapon
    {
        private string blade;

        public string Blade
        {
            get { return blade; }
            set { blade = value; }
        }



        public Sword(bool oneHand, string name,string blade, double damage, string rarity, List<string> magic) : base(oneHand, name, damage, rarity, magic)
        {
            this.blade = blade;
        }

        public override string ToString()
        {
            return base.ToString() + "blade :" +blade;
        }
    }
}
