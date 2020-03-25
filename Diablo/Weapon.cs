using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace Diablo
{

    /// <summary>
    /// this is my super class.
    /// My weapons inhertis from this Weapon class.
    /// It has attributes of name, damage, rarity, isOneHand and a list og magicProperties
    /// it has a protected constructor so i can inherit from this to my other classes of weapon.
    /// I have made an override on the method ToString so that i can print out my attributes
    /// very easily
    /// </summary>
    public abstract class Weapon
    {
        protected string name;
        protected double damage;
        protected string rarity;
        protected bool isOneHand;
        protected List<string> magicProperties = new List<string>();



        public bool IsOneHand { get => isOneHand; set => isOneHand = value; }
        public string Rarity { get => rarity; set => rarity = value; }
        public string Name { get => name; set => name = value; }
        public double Damage { get => damage; set => damage = value; }
        

        protected Weapon(bool oneHand, string name, double damage, string rarity, List<string> magic)
        {
            this.isOneHand = oneHand;
            this.name = name;
            this.damage = damage;
            this.rarity = rarity;
            this.magicProperties = magic;


        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            foreach (string magicProperty in magicProperties)
            {
                st.AppendLine($"{magicProperty}" + "");
            }
        
            return "Is one hand: "+isOneHand +"\n" + "Name :" +Name + "\n"+"Damage: " +Damage + "\n"+ "Rarity :" +Rarity  +"\n" +"magic properties: " +"\n" + st.ToString();
        }
    }
}