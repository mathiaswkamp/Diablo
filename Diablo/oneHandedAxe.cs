using System;
using System.CodeDom;

namespace Diablo
{
    public class OneHandedAxe :Weapon
    {

        private string primaryProperty1;

        public string PrimaryProperty1
        {
            get { return primaryProperty1; }
            set { primaryProperty1 = value; }
        }

        private string primaryProperty2;

        public string PrimaryProperty2
        {
            get { return primaryProperty2; }
            set { primaryProperty2 = value; }
        }


        private string primaryProperty3;

        public string PrimaryProperty3
        {
            get { return primaryProperty3; }
            set { primaryProperty3 = value; }
        }


        private string primaryProperty4;

        public string PrimaryProperty4
        {
            get { return primaryProperty4; }
            set { primaryProperty4 = value; }
        }


        private string primaryProperty5;

        public string PrimaryProperty5
        {
            get { return primaryProperty5; }
            set { primaryProperty5 = value; }
        }



        public OneHandedAxe(string name, double damage, string rarity):base(name, damage, rarity)
        {
            this.name = name;
            this.damage = damage;
            this.rarity = rarity;
            


        }

        public OneHandedAxe(string name, double damage, string rarity, string primaryProperty1):base(name,damage,rarity)
            
        {
            this.primaryProperty1 = primaryProperty1;
        }


        public OneHandedAxe(string name, double damage, string rarity, string primaryProperty1, string primaryProperty2) : base(name, damage, rarity)

        {
            this.primaryProperty1 = primaryProperty1;
            this.primaryProperty2 = primaryProperty2;
        }

        public OneHandedAxe(string name, double damage, string rarity, string primaryProperty1, string primaryProperty2, string primaryProperty3, string primaryProperty4) : base(name, damage, rarity)

        {
            this.primaryProperty1 = primaryProperty1;
            this.primaryProperty2 = primaryProperty2;
            this.primaryProperty3 = primaryProperty3;
            this.primaryProperty4 = primaryProperty4;
        }

        public OneHandedAxe(string name, double damage, string rarity, string primaryProperty1, string primaryProperty2, string primaryProperty3, string primaryProperty4, string primaryProperty5) : base(name, damage, rarity)

        {
            this.primaryProperty1 = primaryProperty1;
            this.primaryProperty2 = primaryProperty2;
            this.primaryProperty3 = primaryProperty3;
            this.primaryProperty4 = primaryProperty4;
            this.primaryProperty5 = primaryProperty5;
        }


    }
}