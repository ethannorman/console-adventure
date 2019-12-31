using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Classes
{
    class HumanCharacterInfo
    {

        int humanHealthPoints = 20;
        int humanExpLevel = 1;
        int humanInvBagSpace = 20;
        int[] armorPoints = { 4, 2, 8, 4, 2, 6, 4 };
        string[] humanTraits = { "Stregnth", "Intelligence", "Wisdom", "Dexterity" };
        string[] humanTraitsLevels = { };
        string[] humanWeapons = { "Steel Broadsword", "Steel Dagger" };
        int[] weaponDamagePoints = { 10, 5 };
        string[] humanApperal = {
                "Steel Helm",
                "Steel Pauldrons",
                "Steel Chestplate",
                "Steel Gaunlets",
                "Steel Waistband",
                "Steel Greaves",
                "Steel Boots"
            };

    }
}
