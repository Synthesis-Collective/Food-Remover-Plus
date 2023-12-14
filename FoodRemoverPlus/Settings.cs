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
        // These are the Food Effect removal settings.
        // Was asked to add this functionality in, but don't remember by who or why. Can not get to work anyway
        // have decided it's no longer worth the effort. Will revist later if a need arises again.
        // [SettingName("Remove Frostfall Effects from Food"), Tooltip("Remove Frostfall Effects from Food")]
        // public bool removeFFFood = true;

        // [SettingName("Remove Frostfall Effects from Drinks"), Tooltip("Remove Frostfall Effects from Drinks")]
        // public bool removeFFDrink = true;

        // [SettingName("Remove Alchemy Effects from Food"), Tooltip("Remove Alchemy Effects from Food")]
        // public bool removeEffects = true;

        [SettingName("Remove Owned Food"), Tooltip("Include any Food that is already Owned (Leave unticked if you want owned food to be left untouched)")]
        public bool removeOwned = true;

        [SettingName("Change Ownership of Remaining Food"), Tooltip("Change Ownership of any Food, not removed, to match Cell Ownership")]
        public bool changeOwnership = true;

        [SettingName("Shop Reduction %"), Tooltip("Reduce food in shops by this much")]
        public int chanceShop = 95;

        [SettingName("House Reduction %"), Tooltip("Reduce food in houses by this much")]
        public int chanceHab = 100;

        [SettingName("Wealthy House Reduction %"), Tooltip("Reduce food in wealthy houses and palaces by this much")]
        public int chanceWealthy = 90;

        [SettingName("Camp Reduction %"), Tooltip("Reduce food in Bandit, Imperial and Stormcloak Camps by this much")]
        public int chanceCamp = 90;

        [SettingName("Dungeon Reduction %"), Tooltip("Reduce food in dungeons by this much")]
        public int chanceDungeon = 100;

        [SettingName("Base Reduction %"), Tooltip("Base reduction for all other locations")]
        public int chanceBase = 100;

        [SettingName("Special Locations"), Tooltip("Add any Special locations that require a custom reduction value"),
            FormLinkPickerCustomization(typeof(FormLink<ILocation>), typeof(FormLink<ILocation>))]
        public List<FormLink<ILocation>> specialLocs = new List<FormLink<ILocation>>();

        [SettingName("Special Locations Reduction %"), Tooltip("Reduce food in special locations by this much")]
        public int chanceSpecial = 80;

        [SettingName("Ignore Locations"), Tooltip("Ignore these locations"),
            FormLinkPickerCustomization(typeof(FormLink<ILocation>), typeof(FormLink<ILocation>))]
        public List<FormLink<ILocation>> skipLocs = new List<FormLink<ILocation>>();

        [SettingName("Ignore Plugins"), Tooltip("Ignore food located in cells from these plugins"),
            FormLinkPickerCustomization(typeof(ModKey), typeof(ModKey))]
        public List<ModKey> skipPlugins = new List<ModKey>();

        //[SettingName("Custom Reductions"), Tooltip("EditorID, Reduction")]
        //public Dictionary<FormLink<ILocation>, int> customChance = new Dictionary<FormLink<ILocation>, int>();

    }
}
