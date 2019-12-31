using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleRPG
{


    class Program
    {

        static void Main(string[] args)
        {
            var gameTitle = "ConsoleRPG";
            Console.Title = gameTitle;
            Console.ForegroundColor = ConsoleColor.Green;

            //Game Startup Music
            Console.Beep(200, 100);
            Console.Beep(600, 100);
            Console.Beep(300, 100);
            Console.Beep(800, 100);
            Console.Beep(600, 100);
            Console.Beep(900, 100);
            Console.Beep(800, 400);

            Thread.Sleep(200);
            var promptStart = "Press 's' to start.";
            Console.WriteLine(promptStart);
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.S)
            {
                Console.Clear();
                Console.Beep(300, 100);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Loading...");
                Thread.Sleep(1000);
                Console.Clear();
                if (i % 1 == 1)
                    Thread.Sleep(50);

            }
            //Variables:
            var leatherArmorUpgrade = new ArmorUpgrade();
            leatherArmorUpgrade.NewArmorRating = 16;

            //Potions
            var healthPotionI = new Potion();
            healthPotionI.Name = "Healing Potion";
            healthPotionI.PotionEffect = "Healing";
            healthPotionI.PotionStrength = 1;
            healthPotionI.IsUsed = false;
            var healthPotionII = new Potion();
            healthPotionII.Name = "Healing Potion";
            healthPotionII.PotionEffect = "Healing";
            healthPotionII.PotionStrength = 2;
            healthPotionII.IsUsed = false;


            //Chests
            var starterChest = new Chest();
            starterChest.Name = "Storage Chest";
            starterChest.IsOpened = false;
            starterChest.IsLocked = false;
            starterChest.IsLooted = false;


            //Races
            var human = new Race();//Human instance
            human.Name = "Human";
            var elf = new Race();//Elf instance
            elf.Name = "Elf";
            var darkElf = new Race();//Dark Elf instance
            darkElf.Name = "Dark Elf";

            //Classes
            var warrior = new Class();//Warrior instance
            warrior.Name = "Warrior";
            var ranger = new Class();//Ranger instance
            ranger.Name = "Ranger";
            var necromancer = new Class();//Necromancer instance
            necromancer.Name = "Necromancer";

            //Abilities
            var str = new Ability();//Strength instance
            str.Name = "Strength";
            str.AbilityLvl = 1;
            var con = new Ability();//Constitution instance
            con.Name = "Constitution";
            con.AbilityLvl = 1;
            var dex = new Ability();//Dexterity instance
            dex.Name = "Dexterity";
            dex.AbilityLvl = 1;
            var intl = new Ability();//Intelligence instance
            intl.Name = "Intelligence";
            intl.AbilityLvl = 1;
            var wis = new Ability();//Wisdom instance
            wis.Name = "Wisdom";
            wis.AbilityLvl = 1;
            var cha = new Ability();//Charisma instance
            cha.Name = "Charisma";
            cha.AbilityLvl = 1;

            //Weapons
            var broadSword = new Weapon();//Steel Broadsword instance
            broadSword.Name = "Steel Broadsword";
            broadSword.Type = "Melee";
            broadSword.Material = "Steel";
            broadSword.DamagePoints = 10;
            var dagger = new Weapon();//Steel Dagger instance
            dagger.Name = "Steel Dagger";
            dagger.Type = "Melee";
            dagger.Material = "Steel";
            dagger.DamagePoints = 5;
            var bow = new Weapon();//Oak Bow instance
            bow.Name = "Oak Bow";
            bow.Type = "Ranged";
            bow.Material = "Oak";
            var staff = new Weapon();//Steel Staff instance
            staff.Name = "Steel Staff";
            staff.Type = "Ranged";
            staff.Material = "Steel";
            staff.DamagePoints = 10;

            //Projectiles
            var steelArrow = new Projectile();//Steel Arrow instance
            steelArrow.Name = "Steel Arrow";
            steelArrow.Type = "Ammunition";
            steelArrow.Material = "Steel";
            steelArrow.DamagePoints = 10;
            steelArrow.Count = 20;

            //Armor:

            //Cotton Armor
            var cottonRobe = new Armor();
            cottonRobe.Name = "Cotton Robe";
            cottonRobe.Type = "Upper/Lower Body";
            cottonRobe.Material = "Cotton";
            cottonRobe.ArmorPoints = 4;

            //Leather Armor
            var leatherHelm = new Armor();//Leather Helm instance
            leatherHelm.Name = "Leather Helm";
            leatherHelm.Type = "Head";
            leatherHelm.Material = "Leather";
            leatherHelm.ArmorPoints = 2;
            var leatherCops = new Armor();//Leather Cops instance
            leatherCops.Name = "Leather Cops";
            leatherCops.Type = "Shoulders";
            leatherCops.Material = "Leather";
            leatherCops.ArmorPoints = 1;
            var leatherChestplate = new Armor();//Leather Chestplate instance
            leatherChestplate.Name = "Leather Chestplate";
            leatherChestplate.Type = "Chest";
            leatherChestplate.Material = "Leather";
            leatherChestplate.ArmorPoints = 4;
            var leatherBracers = new Armor();//Leather Bracers instance
            leatherBracers.Name = "Leather Bracers";
            leatherBracers.Type = "Arms";
            leatherBracers.Material = "Leather";
            leatherBracers.ArmorPoints = 1;
            var leatherGloves = new Armor();//Leather Chestplate instance
            leatherGloves.Name = "Leather Gloves";
            leatherGloves.Type = "Hands";
            leatherGloves.Material = "Leather";
            leatherGloves.ArmorPoints = 1;
            var leatherWaistband = new Armor();//Leather Chestplate instance
            leatherWaistband.Name = "Leather Waistband";
            leatherWaistband.Type = "Waist";
            leatherWaistband.Material = "Leather";
            leatherWaistband.ArmorPoints = 1;
            var leatherGreaves = new Armor();//Leather Chestplate instance
            leatherGreaves.Name = "Leather Greaves";
            leatherGreaves.Type = "Legs";
            leatherGreaves.Material = "Leather";
            leatherGreaves.ArmorPoints = 4;
            var leatherBoots = new Armor();//Leather Chestplate instance
            leatherBoots.Name = "Leather Boots";
            leatherBoots.Type = "Feet";
            leatherBoots.Material = "Leather";
            leatherBoots.ArmorPoints = 2;
            //Jewelry:

            //Rings
            var projectionRing = new Jewelry();
            projectionRing.Name = "Projection Ring";
            projectionRing.JewelryMaterials = "Silver" + "Clear Quartz";
            projectionRing.MagicalEffects = "Project Spells";
            projectionRing.BonusToArcanaSkill = 1;
            var attractionRing = new Jewelry();
            attractionRing.Name = "Attraction Ring";
            attractionRing.JewelryMaterials = "Silver" + "Black Obsidian";
            attractionRing.MagicalEffects = "Absorb/Ward Spells";
            attractionRing.BonusToArcanaSkill = 1;

            //Circlet
            var thirdEyeCirclet = new Jewelry();
            thirdEyeCirclet.Name = "Circlet of Third-Eye";
            thirdEyeCirclet.JewelryMaterials = "Silver" + "Purple Amethyst";
            thirdEyeCirclet.MagicalEffects = "Bonus To Wisdom and Intelligence Abillites";
            thirdEyeCirclet.BonusToWisAndIntlAbility = 2;

            //Characters:
            var garik = new Character();//Garik instance
            garik.Name = "Garik";
            garik.Race = human;
            garik.Gender = "Male";
            garik.Age = 37;
            garik.Size = "Buff";
            garik.Health = 20;
            garik.ArmorRating = 0;
            garik.ExpLvl = 1;
            garik.Abilities = new List<Ability>();
            garik.Abilities.Add(str);
            garik.Abilities.Add(con);
            garik.Abilities.Add(dex);
            garik.Abilities.Add(intl);
            garik.Abilities.Add(wis);
            garik.Abilities.Add(cha);
            garik.Class = warrior;
            if (starterChest.IsOpened == true)
            {
                garik.Weapons = new List<Weapon>();
                garik.Weapons.Add(broadSword);
                garik.Weapons.Add(dagger);
                garik.ArmorPieces = new List<Armor>();
                garik.ArmorPieces.Add(leatherHelm);
                garik.ArmorPieces.Add(leatherCops);
                garik.ArmorPieces.Add(leatherChestplate);
                garik.ArmorPieces.Add(leatherBracers);
                garik.ArmorPieces.Add(leatherGloves);
                garik.ArmorPieces.Add(leatherWaistband);
                garik.ArmorPieces.Add(leatherGreaves);
                garik.ArmorPieces.Add(leatherBoots);
                var leatherArmorRating = new List<ArmorUpgrade>();
                leatherArmorRating.Add(leatherArmorUpgrade);
                garik.Potions = new List<Potion>();
                garik.Potions.Add(healthPotionI);


            }


            var kynerth = new Character();//Kynerth instance
            kynerth.Name = "Kynerth";
            kynerth.Race = elf;
            kynerth.Gender = "Male";
            kynerth.Age = 29;
            kynerth.Size = "Average";
            kynerth.Health = 20;
            kynerth.ExpLvl = 1;
            kynerth.Abilities = new List<Ability>();
            kynerth.Abilities.Add(str);
            kynerth.Abilities.Add(con);
            kynerth.Abilities.Add(dex);
            kynerth.Abilities.Add(intl);
            kynerth.Abilities.Add(wis);
            kynerth.Abilities.Add(cha);
            kynerth.Class = ranger;
            kynerth.Weapons = new List<Weapon>();
            kynerth.Weapons.Add(bow);
            kynerth.Weapons.Add(dagger);
            kynerth.Projectiles = new List<Projectile>();
            kynerth.Projectiles.Add(steelArrow);

            var jorizor = new Character();//Jo'rizor Instance
            jorizor.Name = "Jo'rizor";
            jorizor.Race = darkElf;
            jorizor.Gender = "Male";
            jorizor.Age = 42;
            jorizor.Size = "Slim";
            jorizor.Health = 20;
            jorizor.ExpLvl = 1;
            jorizor.Abilities = new List<Ability>();
            jorizor.Abilities.Add(str);
            jorizor.Abilities.Add(con);
            jorizor.Abilities.Add(dex);
            jorizor.Abilities.Add(intl);
            jorizor.Abilities.Add(wis);
            jorizor.Abilities.Add(cha);
            jorizor.Class = necromancer;
            if (starterChest.IsOpened == true)
            {
                jorizor.Weapons = new List<Weapon>();
                jorizor.Weapons.Add(staff);
                jorizor.Weapons.Add(dagger);
                jorizor.ArmorPieces = new List<Armor>();
                jorizor.ArmorPieces.Add(cottonRobe);
                jorizor.ArmorPieces.Add(leatherBoots);
                jorizor.JewelryPieces = new List<Jewelry>();
                jorizor.JewelryPieces.Add(thirdEyeCirclet);
                jorizor.JewelryPieces.Add(attractionRing);
                jorizor.JewelryPieces.Add(projectionRing);
            }
            




            Console.WriteLine("Press: 1, 2, or 3 to select your character...");
            Thread.Sleep(1050);
            Console.WriteLine(" (1) " + garik.Name + " is a " + human.Name + " " + warrior.Name);
            Thread.Sleep(1050);
            Console.WriteLine(" (2) " + kynerth.Name + " is an " + elf.Name + " " + ranger.Name);
            Thread.Sleep(1050);
            Console.WriteLine(" (3) " + jorizor.Name + " is a " + darkElf.Name + " " + necromancer.Name);
            ConsoleKeyInfo numKeys = Console.ReadKey();
            if (numKeys.Key == ConsoleKey.D1)//if number one key is pressed
            {

                Console.Clear();
                Console.Beep(300, 100);
                Console.WriteLine("You chose " + garik.Name + ", the " + human.Name + " " + warrior.Name + "!");
                Thread.Sleep(1000);
                Console.WriteLine("Gender: " + garik.Gender);
                Thread.Sleep(1000);
                Console.WriteLine("Age: " + garik.Age);
                Thread.Sleep(1000);
                Console.WriteLine("Size: " + garik.Size);
                Thread.Sleep(1000);
                Console.WriteLine("HP: " + garik.Health);
                Thread.Sleep(1000);
                Console.WriteLine("Exp Level: " + garik.ExpLvl);
                Thread.Sleep(1000);
                Console.WriteLine("Ability: ");
                Thread.Sleep(1000);
                Console.WriteLine(str.Name + " ( " + str.AbilityLvl + " ) ");
                Thread.Sleep(1000);
                Console.WriteLine(con.Name + " ( " + con.AbilityLvl + " ) ");
                Thread.Sleep(1000);
                Console.WriteLine(dex.Name + " ( " + dex.AbilityLvl + " ) ");
                Thread.Sleep(1000);
                Console.WriteLine(intl.Name + " ( " + intl.AbilityLvl + " ) ");
                Thread.Sleep(1000);
                Console.WriteLine(wis.Name + " ( " + wis.AbilityLvl + " ) ");
                Thread.Sleep(1000);
                Console.WriteLine(cha.Name + " ( " + cha.AbilityLvl + " ) ");
                Console.Write("Press 's' to begin your quest!");
                ConsoleKeyInfo startQuest1 = Console.ReadKey();
                if (startQuest1.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Console.Beep(300, 100);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Loading...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (i % 1 == 1)
                        {
                            Thread.Sleep(50);

                        }
                    }

                    Console.Write("You awaken in your house of Crestmarch City...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.Write("You feel the warm sunlight on your skin...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("You got dressed and headed over to your storage chest...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("Press 'o' to open the chest");
                    ConsoleKeyInfo openChest0 = Console.ReadKey();
                    if (openChest0.Key == ConsoleKey.O)
                    {
                        starterChest.IsOpened = true;
                    }
                    if (starterChest.IsOpened == true)//Check if Chest is opened
                    {
                        Console.Clear();
                        Console.WriteLine("You found... ");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Weapons: ");
                        Thread.Sleep(2000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(broadSword.Name + ", Dmg Lvl: " + broadSword.DamagePoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(dagger.Name + ", Dmg Lvl: " + dagger.DamagePoints);
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Armor: ");
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherHelm.Name + ", Armor Lvl: " + leatherHelm.ArmorPoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherCops.Name + ", Armor Lvl: " + leatherCops.ArmorPoints);

                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherChestplate.Name + ", Armor Lvl: " + leatherChestplate.ArmorPoints);

                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherBracers.Name + ", Armor Lvl: " + leatherBracers.ArmorPoints);

                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherGloves.Name + ", Armor Lvl: " + leatherGloves.ArmorPoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherWaistband.Name + ", Armor Lvl: " + leatherWaistband.ArmorPoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherGreaves.Name + ", Armor Lvl: " + leatherGreaves.ArmorPoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherBoots.Name + ", Armor Lvl: " + leatherBoots.ArmorPoints);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Potions: ");
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(healthPotionI.Name + ", Strength: " + healthPotionI.PotionStrength);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Your Armor Rating is now: " + 16 +  "!");
                        Thread.Sleep(2500);
                        Console.Clear();

                        starterChest.IsLooted = true;
                    }
                    if (starterChest.IsLooted == true)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(starterChest.Name + " is " + "empty!");
                            Thread.Sleep(1000);
                            Console.Clear();
                            if (i % 1 == 1)
                            {
                                Thread.Sleep(50);

                            }
                        }

                    }

                }
            }
            else if (numKeys.Key == ConsoleKey.D2)//if number two key is pressed
            {
                Console.Clear();
                Console.Beep(300, 100);
                Console.WriteLine("You chose " + kynerth.Name + ", the " + elf.Name + " " + ranger.Name + "!");
                Thread.Sleep(1050);
                Console.WriteLine("Gender: " + kynerth.Gender);
                Thread.Sleep(1050);
                Console.WriteLine("Age: " + kynerth.Age);
                Thread.Sleep(1050);
                Console.WriteLine("Size: " + kynerth.Size);
                Thread.Sleep(1050);
                Console.WriteLine("HP: " + kynerth.Health);
                Thread.Sleep(1050);
                Console.WriteLine("Exp Level: " + kynerth.ExpLvl);
                Thread.Sleep(1050);
                Console.WriteLine("Ability: ");
                Thread.Sleep(1050);
                Console.WriteLine(str.Name + " ( " + str.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(con.Name + " ( " + con.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(dex.Name + " ( " + dex.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(intl.Name + " ( " + intl.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(wis.Name + " ( " + wis.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(cha.Name + " ( " + cha.AbilityLvl + " ) ");
                Console.Write("Press 's' to begin your quest!");
                ConsoleKeyInfo startQuest2 = Console.ReadKey();
                if (startQuest2.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Console.Beep(300, 100);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Loading...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (i % 1 == 1)
                        {
                            Thread.Sleep(50);
                        }
                    }
                    Console.Write("You awaken in your house of Oakengale City...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.Write("You feel the warm sunlight on your skin...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("You got dressed and headed to your storage chest...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("Weapons: ");
                    Thread.Sleep(1050);
                    Console.Beep(200, 300);
                    Console.Beep(230, 300);
                    Console.WriteLine(bow.Name + ", with " + steelArrow.Name + ", Count: " + steelArrow.Count + ", Dmg Lvl: " + steelArrow.DamagePoints);
                    Thread.Sleep(1050);
                    Console.Beep(200, 300);
                    Console.Beep(230, 300);
                    Console.WriteLine(dagger.Name + ", Dmg Lvl: " + dagger.DamagePoints);
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("Armor: ");








                }

            }
            else if (numKeys.Key == ConsoleKey.D3)//if number two key is pressed
            {
                Console.Clear();
                Console.Beep(300, 100);
                Console.WriteLine("You chose " + jorizor.Name + ", the " + darkElf.Name + " " + necromancer.Name + "!");
                Thread.Sleep(1050);
                Console.WriteLine("Gender: " + jorizor.Gender);
                Thread.Sleep(1050);
                Console.WriteLine("Age: " + jorizor.Age);
                Thread.Sleep(1050);
                Console.WriteLine("Size: " + jorizor.Size);
                Thread.Sleep(1050);
                Console.WriteLine("HP: " + jorizor.Health);
                Thread.Sleep(1050);
                Console.WriteLine("Exp Level: " + jorizor.ExpLvl);
                Thread.Sleep(1050);
                Console.WriteLine(str.Name + " ( " + str.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(con.Name + " ( " + con.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(dex.Name + " ( " + dex.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(intl.Name + " ( " + intl.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(wis.Name + " ( " + wis.AbilityLvl + " ) ");
                Thread.Sleep(1050);
                Console.WriteLine(cha.Name + " ( " + cha.AbilityLvl + " ) ");
                Console.Write("Press 's' to begin your quest!");
                ConsoleKeyInfo startQuest3 = Console.ReadKey();
                if (startQuest3.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    Console.Beep(300, 100);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Loading...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (i % 1 == 1)
                        {
                            Thread.Sleep(50);
                        }
                    }
                    Console.Write("You awaken in your house of D'nar City...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.Write("You feel the warm sunlight on your skin...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("You got dressed and head over to your storage chest...");
                    Thread.Sleep(2050);
                    Console.Clear();
                    Console.WriteLine("Press 'o' to open the chest");
                    ConsoleKeyInfo openChest0 = Console.ReadKey();
                    if (openChest0.Key == ConsoleKey.O)
                    {
                        starterChest.IsOpened = true;
                    }
                    if (starterChest.IsOpened == true)//Check if Chest is opened
                    {
                        Console.Clear();
                        Console.WriteLine("You found... ");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Weapons: ");
                        Thread.Sleep(2000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(staff.Name + ", Dmg Lvl: " + staff.DamagePoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(dagger.Name + ", Dmg Lvl: " + dagger.DamagePoints);
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("Armor: ");
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(cottonRobe.Name + ", Armor Lvl: " + cottonRobe.ArmorPoints);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(leatherBoots.Name + ", Armor Lvl: " + leatherBoots.ArmorPoints);
                        Thread.Sleep(2050);
                        Console.Clear();
                        Console.WriteLine("Jewelry: ");
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(attractionRing.Name + ", " +  attractionRing.MagicalEffects);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(projectionRing.Name + ", " + projectionRing.MagicalEffects);
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(thirdEyeCirclet.Name + ", " + thirdEyeCirclet.MagicalEffects);
                        Thread.Sleep(2050);
                        Console.Clear();
                        Console.WriteLine("Potions: ");
                        Thread.Sleep(1000);
                        Console.Beep(200, 300);
                        Console.Beep(230, 300);
                        Console.WriteLine(healthPotionI.Name + ", Strength: " + healthPotionI.PotionStrength);
                        Thread.Sleep(2050);
                        Console.Clear();
                        Console.WriteLine("Your Armor Rating is now: " + 6 + "!");
                        Thread.Sleep(2050);
                        Console.Clear();
                        
                        Console.WriteLine("Your Wisdom & Intelligence abilities increased to " + 2);
                        Thread.Sleep(2050);
                        Console.Clear();
                        Console.WriteLine("Bonus To Abilities: ");
                        Thread.Sleep(1000);
                        Console.WriteLine(wis.Name + " = " + 2);
                        Thread.Sleep(1000);
                        Console.WriteLine(intl.Name + " = " + 2);
                        Thread.Sleep(2050);
                        Console.Clear();

                        starterChest.IsLooted = true;
                    }
                    if (starterChest.IsLooted == true)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(starterChest.Name + " is " + "empty!");
                            Thread.Sleep(1000);
                            Console.Clear();
                            if (i % 1 == 1)
                            {
                                Thread.Sleep(50);

                            }
                        }

                    }
                }
                Console.ReadLine();
            }
        }

        
        //Classes:

        public class Character //Character Class
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public Race Race { get; set; }
            public string Size { get; set; }
            public int Age { get; set; }
            public int Health { get; set; }
            public int ExpLvl { get; set; }
            public Class Class { get; set; }
            public List<Ability> Abilities { get; set; } = new List<Ability>();
            public List<Weapon> Weapons { get; set; } = new List<Weapon>();
            public List<Projectile> Projectiles { get; set; } = new List<Projectile>();
            public List<Armor> ArmorPieces { get; set; } = new List<Armor>();
            public List<Jewelry> JewelryPieces { get; set; } = new List<Jewelry>();
            public List<Potion> Potions { get; set; } = new List<Potion>();
            public int ArmorRating { get; set; }
            
        }
        public class ArmorUpgrade
        {
            public int NewArmorRating { get; set; }
            public List<ArmorUpgrade> ArmorUpgrades { get; set; } = new List<ArmorUpgrade>();
        }
        public class ArmorRating : ArmorUpgrade
        {
            public ArmorRating()
            {
                NewArmorRating = 16;
            }
        }
        public class Race //Race Class
        {
            public string Name { get; set; }
            
        }
        public class Human : Race//Human inherited from Race class
        {
            public Human()
            {
                Name = "Human";
                
            }
        }
        public class Elf : Race//Elf inherited from Race class
        {
            public Elf()
            {
                Name = "Elf";
            }
        }
        public class DarkElf : Race//DarkElf inherited from Race class
        {
            public DarkElf()
            {
                Name = "Dark Elf";
            }
        }
        public class Class //Class class
        {
            public string Name { get; set; }
        }
        public class Warrior : Class//Warrior inherited from Class class
        {
            public Warrior()
            {
                Name = "Warrior";
            }
        }
        public class Ranger : Class//Ranger inherited from Class class
        {
            public Ranger()
            {
                Name = "Ranger";
            }
        }
        public class Necromancer : Class//Necromancer inherited from Class class
        {
            public Necromancer()
            {
                Name = "Necromancer";
            }
        }
        public class Ability//Ability Class
        {
            public string Name { get; set; }
            public int AbilityLvl { get; set; }
        }
        public class Str : Ability
        {
            public Str()
            {
                Name = "Strength";
                AbilityLvl = 1;
            }
        }
        public class Con : Ability
        {
            public Con()
            {
                Name = "Constitution";
                AbilityLvl = 1;
            }
        }
        public class Dex : Ability
        {
            public Dex()
            {
                Name = "Dexterity";
                AbilityLvl = 1;
            }
        }
        public class Intl : Ability
        {
            public Intl()
            {
                Name = "Intelligence";
                AbilityLvl = 1;
            }
        }
        public class Wis : Ability
        {
            public Wis()
            {
                Name = "Wisdom";
                AbilityLvl = 1;
            }
        }
        public class Cha : Ability
        {
            public Cha()
            {
                Name = "Charisma";
                AbilityLvl = 1;
            }
        }
        public class Weapon //Weapon class
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Material { get; set; }
            public int DamagePoints { get; set; }
        }
        public class Broadsword : Weapon//Broadsword inherited from Weapon class
        {
            public Broadsword()
            {
                Name = "Steel Broadsword";
                Type = "Melee";
                Material = "Steel";
                DamagePoints = 10;
            }
        }
        public class Dagger : Weapon//Dagger inherited from Weapon class
        {
            public Dagger()
            {
                Name = "Steel Dagger";
                Type = "Melee";
                Material = "Steel";
                DamagePoints = 5;
            }
        }
        public class Bow : Weapon//Bow inherited from Weapon class
        {
            public Bow()
            {
                Name = "Oak Bow";
                Type = "Ranged";
                Material = "Oak";

            }
        }
        public class Staff : Weapon//Staff inherited from Weapon class
        {
            public Staff()
            {
                Name = "Steel Staff";
                Type = "Ranged";
                Material = "Steel";
                DamagePoints = 10;
            }
        }
        public class Projectile
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Material { get; set; }
            public int DamagePoints { get; set; }
            public int Count { get; set; }
        }
        public class SteelArrow : Projectile//SteelArrow inherited from Projectile class
        {
            public SteelArrow()
            {
                Name = "Steel Arrow";
                Type = "Ammunition";
                Material = "Steel";
                DamagePoints = 10;
                Count = 20;
            }
        }
        public class Armor
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public string Material { get; set; }
            public int ArmorPoints { get; set; }
        }
        public class LeatherHelm : Armor
        {
            public LeatherHelm()
            {
                Name = "Leather Helm";
                Type = "Head";
                Material = "Leather";
                ArmorPoints = 2;

            }
        }
        public class LeatherCops : Armor
        {
            public LeatherCops()
            {
                Name = "Leather Cops";
                Type = "Shoulders";
                Material = "Leather";
                ArmorPoints = 1;

            }
        }
        public class LeatherChestplate : Armor
        {
            public LeatherChestplate()
            {
                Name = "Leather Chestplate";
                Type = "Chest";
                Material = "Leather";
                ArmorPoints = 4;

            }
        }
        public class LeatherBracers : Armor
        {
            public LeatherBracers()
            {
                Name = "Leather Bracers";
                Type = "Arms";
                Material = "Leather";
                ArmorPoints = 1;

            }
        }
        public class LeatherGloves : Armor
        {
            public LeatherGloves()
            {
                Name = "Leather Gloves";
                Type = "Hands";
                Material = "Leather";
                ArmorPoints = 1;

            }
        }
        public class LeatherWaistband : Armor
        {
            public LeatherWaistband()
            {
                Name = "Leather Waistband";
                Type = "Waist";
                Material = "Leather";
                ArmorPoints = 1;

            }
        }
        public class LeatherGreaves : Armor
        {
            public LeatherGreaves()
            {
                Name = "Leather Greaves";
                Type = "Legs";
                Material = "Leather";
                ArmorPoints = 4;

            }
        }
        public class LeatherBoots : Armor
        {
            public LeatherBoots()
            {
                Name = "Leather Boots";
                Type = "Feet";
                Material = "Leather";
                ArmorPoints = 2;

            }
        }
        public class CottonRobe : Armor
        {
            public CottonRobe()
            {
                Name = "Cotton Robe";
                Type = "Upper/Lower Body";
                Material = "Cotton";
                ArmorPoints = 4;
            }
        }
        public class Jewelry
        {
            public string Name { get; set; }
            public string JewelryMaterials { get; set; }
            public string MagicalEffects { get; set; }
            public int BonusToWisAndIntlAbility { get; set; }
            public int BonusToArcanaSkill { get; set; }
            
        }
        public class Circlet : Jewelry
        {
            public Circlet()
            {
                Name = "Circlet of Third-Eye";
                JewelryMaterials = "Silver" + "Purple Amethyst";
                MagicalEffects = "Bonus To Wisdom and Intelligence Abillites";
                BonusToWisAndIntlAbility = 3;
            }
        }
        public class ProjectionRing : Jewelry
        {
            public ProjectionRing()
            {
                Name = "Projection Ring";
                JewelryMaterials = "Silver" + "Clear Quartz";
                MagicalEffects = "Project Spells";
                BonusToArcanaSkill = 1;
            }

        }
        public class AttractionRing : Jewelry
        {
            public AttractionRing()
            {
                Name = "Reception Ring";
                JewelryMaterials = "Silver" + "Black Obsidian";
                MagicalEffects = "Absorb/Ward Spells";
                BonusToArcanaSkill = 1;
            }
        }
        public class Chest
        {
            public string Name { get; set; }
            public bool IsOpened { get; set; }
            public bool IsLooted { get; set; }
            public bool IsLocked { get; set; }
            public int LockLevel { get; set; }
        }
        public class StarterChest : Chest
        {
            public StarterChest()
            {
                Name = "Storage Chest";
                IsLocked = false;
                IsLooted = false;
                IsOpened = false;

            }
        }
        public class Potion
        {
            public string Name { get; set; }
            public string PotionEffect { get; set; }
            public int PotionStrength { get; set; }
            public bool IsUsed { get; set; }
            
            
        }
        public class HealthPotionI : Potion
        {
            public HealthPotionI()
            {
                Name = "Healing Potion";
                PotionEffect = "Healing";
                PotionStrength = 1;
                IsUsed = false;
            }
        }
        public class HealthPotionII : Potion
        {
            public HealthPotionII()
            {
                Name = "Healing Potion";
                PotionEffect = "Healing";
                PotionStrength = 2;
                IsUsed = false;
            }
        }
    }
}