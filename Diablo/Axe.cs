using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Diablo
{
    /// <summary>
    /// this class is an Axe class
    /// the Axe class inherits from weapon class.
    /// It has a constructor with the parameters from weapon class
    /// </summary>
    public class Axe :Weapon
    {
        


        public Axe(bool oneHand, string name, double damage, string rarity, List<string> magic):base(oneHand,name,damage,rarity,magic)
        {

            
        }

    }
}