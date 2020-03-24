using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Diablo
{
    public class Axe :Weapon
    {
        


        public Axe(bool oneHand, string name, double damage, string rarity, List<string> magic):base(oneHand,name,damage,rarity,magic)
        {

            
        }

    }
}