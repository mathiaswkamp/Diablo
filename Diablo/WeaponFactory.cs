using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Diablo
{
    public class WeaponFactory
    {

        private string rarity = null;
        private string primaryProperty = null;
        Random r = new Random();

        public string GetRarity()
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


            return rarity;
        }

        

        public string GetPrimaryProperties()
        {
            
            int rngChoosePrimaryProperty = r.Next(1, 10);
            int rngPercentProperty = r.Next(1, 51);
            int rngPrimaryStatValue = r.Next(100, 1501);
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
                        primaryProperty = $"Strength :{rngPrimaryStatValue}";
                        break;
                    case 2:
                        primaryProperty = $"Intellect :{rngPrimaryStatValue}";
                        break;
                    case 3:
                        primaryProperty = $"Dexterity :{rngPrimaryStatValue}";
                        break;
                }
            }

            else if (rngChoosePrimaryProperty == 5)
            {
                primaryProperty = $"Attack speed {rngPercentProperty} %";
            }

            else if (rngChoosePrimaryProperty == 6)
            {
                primaryProperty = $"{rngPrimaryStatValue} Life per hit ";
            }

            else if (rngChoosePrimaryProperty == 7)
            {
                primaryProperty = $"Chance to deal  {rngPercentProperty} % area damage";
            }

            else if (rngChoosePrimaryProperty == 8)
            {
                primaryProperty = $"Reduces cold-down of all skills by {rngPercentProperty} %";
            }

            else if (rngChoosePrimaryProperty == 9)
            {
                primaryProperty = $"Reduces all resource costs by  {rngPercentProperty} %";
            }

            return primaryProperty;
        }

        

        public Weapon CreateWeapon(string newWeaponType)
        {
            int rngDamage = r.Next(1000, 1500);

            if (newWeaponType.Equals("axe"))
            {
                List<string> magic = new List<string>();
                string rarityAxe = GetRarity();

                switch (rarityAxe)
                {
                    case "common":
                        magic.Add(null);
                        return new Axe(oneHand:true, name:"1Handed Axe", damage:rngDamage, rarity:rarityAxe, magic:magic);
                        

                    case "magic": for (int i = 0; i <= 1; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }
                        return new Axe(oneHand:true, name:"1Handed Axe", damage: rngDamage, rarity: rarityAxe, magic: magic);
                       

                    case "rare":
                        for (int i = 0; i <= 3; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }
                        return new Axe(oneHand:true, name:"1Handed Axe", damage: rngDamage, rarity: rarityAxe, magic: magic);
                        

                    case "legendary":
                        for (int i = 0; i <= 4; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }
                        return new Axe(oneHand: true, name: "1Handed Axe", damage: rngDamage, rarity: rarityAxe, magic: magic);
                        

                    default:
                        return null;
                }
            }
            else
            {
                if (newWeaponType.Equals("sword"))
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