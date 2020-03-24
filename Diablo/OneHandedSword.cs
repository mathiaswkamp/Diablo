using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class OneHandedSword : Weapon
    {
        

        private string primaryProperty;

        public string PrimaryProperty
        {
            get { return primaryProperty; }
            set { primaryProperty = value; }
        }
        public OneHandedSword(string name, double damage, string rarity, string primaryProperty) : base(name, damage, rarity)
        {
            this.name = name;
            this.damage = damage;
            this.rarity = rarity;
            this.primaryProperty = primaryProperty;

        }
}
}
