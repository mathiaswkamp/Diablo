using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo
{
    public class OneHandedSword : Weapon
    {
        
        
        public OneHandedSword(bool oneHand, string name, double damage, string rarity, List<string> magic) : base(oneHand, name, damage, rarity, magic)
        {
            
        }
    }
}
