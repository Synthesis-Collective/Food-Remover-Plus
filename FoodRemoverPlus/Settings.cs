using Mutagen.Bethesda;
using System;
using System.Collections.Generic;
using System.Text;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace FoodRemoverPlus
{
    public record Settings
    {
        [SettingName("Remove Frostfall Effects from Food"), Tooltip("Remove Frostfall Effects from Food")]
        public bool removeFFFood = true;

        [SettingName("Remove Frostfall Effects from Drinks"), Tooltip("Remove Frostfall Effects from Drinks")]
        public bool removeFFDrink = true;

        [SettingName("Remove Alchemy Effects from Food"), Tooltip("Remove Alchemy Effects from Food")]
        public bool removeEffects = true;

        [SettingName("Remove Owned Food"), Tooltip("Remove Owned Food")]
        public bool removeOwned = true;

        [SettingName("Shop Reduction %"), Tooltip("Reduces food in shops")]
        public int chanceShop = 95;

        [SettingName("House Reduction %"), Tooltip("Reduces food in houses")]
        public int chanceHab = 100;

        [SettingName("Wealthy House Reduction %"), Tooltip("Reduces food in wealthy houses")]
        public int chanceWealthy = 90;

        [SettingName("Camp Reduction %"), Tooltip("Reduces food in Bandit, Imperial and Stormcloak Camps")]
        public int chanceCamp = 90;

        [SettingName("Dungeon Reduction %"), Tooltip("Reduces food in dungeons")]
        public int chanceDungeon = 100;

        [SettingName("Base Reduction %"), Tooltip("Base reduction for all other locations")]
        public int chanceBase = 100;

        [SettingName("Special Locations"), Tooltip("Special locations"),
            FormLinkPickerCustomization(typeof(FormLink<ILocation>), typeof(FormLink<ILocation>))]
        public List<FormLink<ILocation>> specialLocs = new List<FormLink<ILocation>>();

        [SettingName("Special Locations Reduction %"), Tooltip("Reduces food in special locations")]
        public int chanceSpecial = 80;

        [SettingName("Change Ownership of Remaining Food"), Tooltip("Change Ownership of any Food, not removed, to match Cell Ownership")]
        public bool changeOwnership = true;

        [SettingName("Ignore Locations"), Tooltip("Ignore these locations"),
            FormLinkPickerCustomization(typeof(FormLink<ILocation>), typeof(FormLink<ILocation>))]
        public List<FormLink<ILocation>> skipLocs = new List<FormLink<ILocation>>();

        [SettingName("Ignore Plugins"), Tooltip("Ignore food located in cells from these plugins"),
            FormLinkPickerCustomization(typeof(ModKey), typeof(ModKey))]
        public List<ModKey> skipPlugins = new List<ModKey>({"Wyrmstooth.esp"}, );

        //[SettingName("Custom Reductions"), Tooltip("EditorID, Reduction")]
        //public Dictionary<FormLink<ILocation>, int> customChance = new Dictionary<FormLink<ILocation>, int>();

    }
}
