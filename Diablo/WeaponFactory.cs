using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Diablo
{
    public class WeaponFactory
    {
        private string rarity;
        private string primaryProperty;

        Random r = new Random();

        public string getRarity()
        {
            int rngRarity = r.Next(1, 4);

            if (rngRarity == 1)
            {
                rarity = "common";
            }
            else if (rngRarity == 2)
            {
                rarity = "magic";
            }

            else if (rngRarity == 3)
            {
                rarity = "rare";
            }

            else if (rngRarity == 4)
            {
                rarity = "legendary";
            }

            else
            {
                return null;
            }

            return rarity;
        }

        

        public string getPrimaryProperties()
        {
            int rngChoosePrimaryProperty = r.Next(1, 9);
            int rngPercentProperty = r.Next(1, 50);
            int rngPrimaryStatValue = r.Next(100, 1500);
            int rngPrimaryStatProperty = r.Next(1, 4);


            if (rngChoosePrimaryProperty == 1)
            {
                primaryProperty = $"{rngPercentProperty}%  Damage";
            }
            else if (rngChoosePrimaryProperty == 2)
            {
                primaryProperty = $"Critical hit chance :{rngPercentProperty} %";
            }

            else if (rngChoosePrimaryProperty == 3)
            {
                primaryProperty = $"Critical hit damage :{rngPercentProperty} %";
            }

            else if (rngChoosePrimaryProperty == 4)
            {
                switch (rngPrimaryStatProperty)
                {
                    case 1:
                        primaryProperty = $"Strength :{rngPrimaryStatProperty}";
                        break;
                    case 2:
                        primaryProperty = $"Intellect :{rngPrimaryStatProperty}";
                        break;
                    case 3:
                        primaryProperty = $"Dexterity :{rngPrimaryStatProperty}";
                        break;
                }
            }

            else if (rngChoosePrimaryProperty == 5)
            {
                primaryProperty = $"Attack speed {rngPercentProperty} %";
            }

            else if (rngChoosePrimaryProperty == 6)
            {
                primaryProperty = $" {rngPrimaryStatValue} Life per hit ";
            }

            else if (rngChoosePrimaryProperty == 7)
            {
                primaryProperty = $"Chance to deal  {rngPercentProperty} % area damage";
            }

            else if (rngChoosePrimaryProperty == 8)
            {
                primaryProperty = $"Reduces colddown of all skill by  {rngPercentProperty}";
            }

            else if (rngChoosePrimaryProperty == 9)
            {
                primaryProperty = $"Reduces all resource costs by  {rngPercentProperty} %";
            }

            return primaryProperty;
        }


        public Weapon createWeapon(string newWeaponType)
        {
            int rngDamage = r.Next(1000, 1500);

            Weapon newWeapon = null;


            if (newWeaponType.Equals("axe"))
            {
                string rarityAxe = getRarity();
                List<string> magic = new List<string>();

                switch (rarityAxe)
                {
                    case "common":
                        newWeapon = new Axe(true, "1Handed Axe", rngDamage, rarityAxe, null);
                        break;

                    case "magic":
                        for (int i = 0; i < 1; i++)
                        {
                            magic.Add(getPrimaryProperties());
                        }
                        newWeapon = new Axe(true, "1Handed Axe", rngDamage, rarityAxe, magic);
                        break;

                    case "rare":
                        for (int i = 0; i <= 3; i++)
                        {
                            magic.Add(getPrimaryProperties());
                        }
                        newWeapon = new Axe(true, "1Handed Axe", rngDamage, rarityAxe, magic);
                        break;

                    case "legendary":
                        for (int i = 0; i <= 4; i++)
                        {
                            magic.Add(getPrimaryProperties());
                        }
                        newWeapon = new Axe(true, "1Handed Axe", rngDamage, rarityAxe, magic);
                        break;
                }

                return newWeapon;
            }
            else
            {
                if (newWeaponType.Equals("1hsword"))
                {
                    return null; //new OneHandedSword(name:"1-Handed Sword",damage:rngDamage);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}