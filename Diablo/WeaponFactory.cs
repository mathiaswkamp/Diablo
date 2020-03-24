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

        public string getPropertiesLegendaryItem()
        {
            return null;
        }

        public string getPrimaryProperties()
        {
            int rngChoosePrimaryProperty = r.Next(1, 9);
            int rngPercentProperty = r.Next(1, 50);
            int rngPrimaryStatValue = r.Next(100, 1500);
            int rngPrimaryStatProperty = r.Next(1, 3);


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

            if (newWeaponType.Equals("1haxe"))
            {
                string rarityAxe = getRarity();

                //NO GO
                string primaryPropertyAxe1 = getPrimaryProperties();

                string primaryPropertyAxe2 = getPrimaryProperties();

                string primaryPropertyAxe3 = getPrimaryProperties();

                string primaryPropertyAxe4 = getPrimaryProperties();

                string primaryPropertyAxe5 = getPrimaryProperties();
                //END NO GO

                
                //SWITCH-CASE
                if (rarityAxe == "common")
                {
                    newWeapon = new OneHandedAxe("1-Handed Axe", rngDamage, rarityAxe);
                }

                 if (rarityAxe == "magic")
                {
                    newWeapon = new OneHandedAxe("1-Handed Axe", rngDamage, rarityAxe, getPrimaryProperties(), getPrimaryProperties());
                }

                 if (rarityAxe =="rare")
                 {
                return new OneHandedAxe("1-Handed Axe", rngDamage, rarityAxe, primaryPropertyAxe1, primaryPropertyAxe2, primaryPropertyAxe3, primaryPropertyAxe4);
                }

                 if (rarityAxe == "legendary")
                 {
                    return new OneHandedAxe("1-Handed Axe", rngDamage, rarityAxe, primaryPropertyAxe1, primaryPropertyAxe2, primaryPropertyAxe3, primaryPropertyAxe4, primaryPropertyAxe5);
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
