using System;
using System.CodeDom;

namespace Diablo
{
    public class Axe :Weapon
    {
    
    private bool isOneHand = false;
    
        public OneHandedAxe(bool oneHand, string name, double damage, string rarity, List<string> magic):base(name, damage, rarity, magic)
        {   
        //NO GO - DOBBELT KODE
            this.name = name;
            this.damage = damage;
            this.rarity = rarity;
        
        }
    }
}
