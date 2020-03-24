﻿using System;
using Microsoft.Win32;

namespace Diablo
{
    public abstract class Weapon
    {
        protected string name;
        protected double damage;
        protected string rarity;
        List<string> magicProps = new List<string>();

        
        public string Rarity { get => name; set => name = value; }

        public string Name { get => name; set => name = value; }
        public double Damage { get => damage; set => damage = value; }
        

        protected Weapon(string name, double damage, string rarity, List<string> magic)
        {
            this.name = name;
            this.damage = damage;
            this.rarity = rarity;
            this.magicProps = magic;
            

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
