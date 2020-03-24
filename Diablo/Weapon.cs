using System;
using Microsoft.Win32;

namespace Diablo
{
    public abstract class Weapon
    {
        protected string name;
        protected double damage;
        protected string rarity;
        

        
        public string Rarity { get => name; set => name = value; }

        public string Name { get => name; set => name = value; }
        public double Damage { get => damage; set => damage = value; }
        

        protected Weapon(string name, double damage, string rarity)
        {
            this.name = name;
            this.damage = damage;
            this.rarity = rarity;
            

        }

        public override string ToString()
        {
            return Name;
        }
    }
}