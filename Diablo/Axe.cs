﻿using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Diablo
{
    public class Axe :Weapon
    {
        private bool isOneHand;

        public bool IsOneHand
        {
            get { return isOneHand; }
            set { isOneHand = value; }
        }





        public Axe(bool oneHand, string name, double damage, string rarity, List<string> magic):base(name, damage,rarity, magic)
        {

            this.isOneHand = oneHand;
        }

    }
}