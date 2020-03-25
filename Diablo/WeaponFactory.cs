using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Diablo
{
    /// <summary>
    /// this class is made as a factory class. It is a factory of weapons.
    /// I have a few methods.
    /// Method GetBladeType gets a random blade for my sword object.
    /// Method GetRarity gets a random rarity of both axe and sword objects.
    /// Method GetPrimaryProperties gets a random property of the list to apply to the axe og sword object when
    /// its created.
    /// Method CreateWeapon. Creates an axe or a sword depending on what the user inputs .
    /// It will give the object a rarity, properties depending on which rarity the object got.
    /// if the object is a sword it will also give it a blade type.
    /// The method will return a weapon object to the user.
    /// </summary>
    public class WeaponFactory
    {
        private string rarity = null;
        private string primaryProperty = null;
        private string bladeType = null;
        Random r = new Random();


        public string GetBladeType()
        {
            int rngBladeType = r.Next(1, 5);

            if (rngBladeType == 1)
            {
                bladeType = "Stainless Steel";
            }
            else if (rngBladeType == 2)
            {
                bladeType = "Carbon Steel";
            }

            else if (rngBladeType == 3)
            {
                bladeType = "Damascus Steel";
            }

            else if (rngBladeType == 4)
            {
                bladeType = "Spring Steel";
            }


            return bladeType;
        }

        public string GetRarity()
        {
            int rngRarity = r.Next(1, 5);

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
            List<string> magic = new List<string>();
            int rngDamage = r.Next(1000, 1500);

            if (newWeaponType.Equals("axe"))
            {
                string rarityAxe = GetRarity();

                switch (rarityAxe)
                {
                    case "common":
                        magic.Add(null);
                        return new Axe(oneHand: true, name: "1-Handed Axe", damage: rngDamage, rarity: rarityAxe,
                            magic: magic);


                    case "magic":
                        for (int i = 0; i <= 1; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }

                        return new Axe(oneHand: false, name: "2-Handed Axe", damage: rngDamage, rarity: rarityAxe,
                            magic: magic);


                    case "rare":
                        for (int i = 0; i <= 3; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }

                        return new Axe(oneHand: true, name: "1-Handed Axe", damage: rngDamage, rarity: rarityAxe,
                            magic: magic);


                    case "legendary":
                        for (int i = 0; i <= 4; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }

                        return new Axe(oneHand: false, name: "2-Handed Axe", damage: rngDamage, rarity: rarityAxe,
                            magic: magic);


                    default:
                        return null;
                }
            }


            if (newWeaponType.Equals("sword"))
            {
                //List<string> magic = new List<string>();
                string raritySword = GetRarity();
                string bladeOfSword = GetBladeType();

                switch (raritySword)
                {
                    case "common":
                        magic.Add(null);
                        return new Sword(oneHand: true, name: "1-Handed Sword",blade:bladeOfSword, damage: rngDamage, rarity: raritySword, magic: magic);


                    case "magic":
                        for (int i = 0; i <= 1; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }

                        return new Sword(oneHand: true, name: "1-Handed Sword", blade: bladeOfSword, damage: rngDamage, rarity: raritySword,
                            magic: magic);


                    case "rare":
                        for (int i = 0; i <= 3; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }

                        return new Sword(oneHand: false, name: "2-Handed Sword", blade: bladeOfSword, damage: rngDamage, rarity: raritySword,
                            magic: magic);


                    case "legendary":
                        for (int i = 0; i <= 4; i++)
                        {
                            magic.Add(GetPrimaryProperties());
                        }

                        return new Sword(oneHand: true, name: "2-Handed Sword", blade: bladeOfSword, damage: rngDamage, rarity: raritySword,
                            magic: magic);


                    default:
                        return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}