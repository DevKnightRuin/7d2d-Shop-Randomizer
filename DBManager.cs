using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Kaiserville_Shop_Randomizer
{
    
    public class DBManager
    {
        List<Item> itemListConstants = new List<Item>();

        List<Item> itemListResources = new List<Item>();
        List<Item> itemListBooks = new List<Item>();
        List<Item> itemListShotguns = new List<Item>();
        List<Item> itemListRifles = new List<Item>();
        List<Item> itemListPistols = new List<Item>();
        List<Item> itemListMachineGuns = new List<Item>();

        List<Item> itemInventoryShotguns = new List<Item>();
        List<Item> itemInventoryRifles = new List<Item>();
        List<Item> itemInventoryPistols = new List<Item>();
        List<Item> itemInventoryMachineGuns = new List<Item>();

        List<Item> MasterInventoryList = new List<Item>();

        RandomGenerator randomGenerator = new RandomGenerator();
        List<Item> itemShopList = new List<Item>();

        public DBManager()
        {
            InitMachineGuns();
            InitPistols();
            InitRifles();
            InitShotguns();
            
            InitBooks();
            InitResources();
            InitConstants();
            InitInventoryMachineGuns(); 
            InitInventoryPistols();
            InitInventoryRifles();   
            InitInventoryShotguns();




            GenerateShopList();
            
        }

        private void InitShotguns()
        {
            Item item1 = new Item("gunShotgunT0PipeShotgun", "Pipe Shotgun", 1, 2, 0, "Shotguns");
            Item item2 = new Item("gunShotgunT1DoubleBarrel", "Double Barrel", 1, 2, 0, "Shotguns");
            Item item3 = new Item("gunShotgunT2PumpShotgun", " Pump Shotgun", 1, 2, 0, "Shotguns");
            Item item4 = new Item("gunShotgunT2PumpShotgun", " Pump Shotgun", 1, 2, 0, "Shotguns");
            Item item5 = new Item("gunShotgunT3AutoShotgun", "Auto Shotgun", 1, 2, 0, "Shotguns");

            itemListShotguns.Add(item1);
            itemListShotguns.Add(item2);
            itemListShotguns.Add(item3);
            itemListShotguns.Add(item4);
            itemListShotguns.Add(item5);
        }

        private void InitRifles()
        {
            Item item1 = new Item("gunRifleT0PipeRifle", "Pipe Rifle", 1, 2, 0, "Rifles");
            Item item2 = new Item("gunRifleT1HuntingRifle", "Hunting Rifle", 1, 2, 0, "Rifles");
            Item item3 = new Item("gunRifleT2LeverActionRifle", "Lever Action Rifle", 1, 2, 0, "Rifles");
            Item item4 = new Item("gunRifleT3SniperRifle", "Sniper Rifle", 1, 2, 0, "Rifles");

            itemListRifles.Add(item1);
            itemListRifles.Add(item2);
            itemListRifles.Add(item3);
            itemListRifles.Add(item4);
        }

        private void InitPistols()
        {

            Item item1 = new Item("gunHandgunT0PipePistol", "Pipe Pistol", 1, 2, 0, "Pistols");
            Item item2 = new Item("gunHandgunT1Pistol", "Pistol", 1, 2, 0, "Pistols");
            Item item3 = new Item("gunHandgunT3SMG5", "SMG5", 1, 2, 0, "Pistols");
            Item item4 = new Item("gunHandgunT2Magnum44", ".44 Magnum", 1, 2, 0, "Pistols");
            Item item5 = new Item("gunHandgunT3DesertVulture", ".44 Desert Vulture", 1, 2, 0, "Pistols");

            itemListPistols.Add(item1);
            itemListPistols.Add(item2);
            itemListPistols.Add(item3);
            itemListPistols.Add(item4);
            itemListPistols.Add(item5);
        }

        private void InitMachineGuns()
        {
            Item item1 = new Item("gunMGT0PipeMachineGun", "Pipe Machine Gun", 1, 2, 0, "Machine Guns");
            Item item2 = new Item("gunMGT1AK47", "AK-47", 1, 2, 0, "Machine Guns");
            Item item3 = new Item("gunMGT2TacticalAR", "Tactical Assault Rifle", 1, 2, 0, "Machine Guns");
            Item item4 = new Item("gunMGT3M60", "M60", 1, 2, 0, "Machine Guns");

            itemListMachineGuns.Add(item1);
            itemListMachineGuns.Add(item2);
            itemListMachineGuns.Add(item3);
            itemListMachineGuns.Add(item4);
         
        }

        private void InitConstants()
        {
            
            Item item1 = new Item("ammoBundleShotgunShell", "Box of Shotgun Shells (100)", 1, 1, 150, "Ammo");
            Item item2 = new Item("ammoBundle762mmBulletBall", "Box of 7.62mm (100)", 1, 1, 150, "Ammo");
            Item item3 = new Item("ammoBundle9mmBulletBall", "Box of 9mm (100)", 1, 1, 120, "Ammo");
            Item item4 = new Item("ammoBundle44MagnumBulletBall", "Box of .44 Magnum (100)", 1, 1, 135, "Ammo");

            itemListConstants.Add(item1);
            itemListConstants.Add(item2);
            itemListConstants.Add(item3);    
            itemListConstants.Add(item4);    

        }

        private void InitInventoryShotguns()
        {

             Item item1 = new Item("gunShotgunT0PipeShotgun", "Pipe Shotgun", 1, 2, 200, "Shotguns");
             Item item2 = new Item("gunShotgunT0PipeShotgun", "Pipe Shotgun", 1, 3, 300, "Shotguns");
             Item item3 = new Item("gunShotgunT0PipeShotgun", "Pipe Shotgun", 1, 4, 400, "Shotguns");
             Item item4 = new Item("gunShotgunT0PipeShotgun", "Pipe Shotgun", 1, 5, 500, "Shotguns");
             Item item5 = new Item("gunShotgunT0PipeShotgun", "Pipe Shotgun", 1, 6, 1000, "Shotguns");
             Item item6 = new Item("gunShotgunT1DoubleBarrel", "Double Barrel", 1, 2, 300, "Shotguns");
             Item item7 = new Item("gunShotgunT1DoubleBarrel", "Double Barrel",  1, 3, 400, "Shotguns");
             Item item8 = new Item("gunShotgunT1DoubleBarrel", "Double Barrel", 1, 4, 500, "Shotguns");
             Item item9 = new Item("gunShotgunT1DoubleBarrel", "Double Barrel", 1, 5, 600, "Shotguns");
            Item item10 = new Item("gunShotgunT1DoubleBarrel", "Double Barrel", 1, 6, 1250, "Shotguns");
            Item item11 = new Item("gunShotgunT2PumpShotgun", " Pump Shotgun", 1, 2, 800, "Shotguns");
            Item item12 = new Item("gunShotgunT2PumpShotgun", "Pump Shotgun", 1, 3, 900, "Shotguns");
            Item item13 = new Item("gunShotgunT2PumpShotgun", "Pump Shotgun", 1, 4, 1000, "Shotguns");
            Item item14 = new Item("gunShotgunT2PumpShotgun", "Pump Shotgun", 1, 5, 1500, "Shotguns");
            Item item15 = new Item("gunShotgunT2PumpShotgun", "Pump Shotgun", 1, 6, 3000, "Shotguns");
            Item item16 = new Item("gunShotgunT3AutoShotgun", "Auto Shotgun", 1, 2, 1000, "Shotguns");
            Item item17 = new Item("gunShotgunT3AutoShotgun", "Auto Shotgun", 1, 3, 1250, "Shotguns");
            Item item18 = new Item("gunShotgunT3AutoShotgun", "Auto Shotgun", 1, 4, 1500, "Shotguns");
            Item item19 = new Item("gunShotgunT3AutoShotgun", "Auto Shotgun", 1, 5, 1750, "Shotguns");
            Item item20 = new Item("gunShotgunT3AutoShotgun", "Auto Shotgun", 1, 6, 5000, "Shotguns");



            itemInventoryShotguns.Add(item1);
            itemInventoryShotguns.Add(item2);
            itemInventoryShotguns.Add(item3);
            itemInventoryShotguns.Add(item4);
            itemInventoryShotguns.Add(item5);
            itemInventoryShotguns.Add(item6);
            itemInventoryShotguns.Add(item7);
            itemInventoryShotguns.Add(item8);
            itemInventoryShotguns.Add(item9);
            itemInventoryShotguns.Add(item10);
            itemInventoryShotguns.Add(item11);
            itemInventoryShotguns.Add(item12);
            itemInventoryShotguns.Add(item13);
            itemInventoryShotguns.Add(item14);
            itemInventoryShotguns.Add(item15);
            itemInventoryShotguns.Add(item16);
            itemInventoryShotguns.Add(item17);
            itemInventoryShotguns.Add(item18);
            itemInventoryShotguns.Add(item19);
            itemInventoryShotguns.Add(item20);
            
        }                    

        public void InitInventoryPistols()
        {
            Item item1 = new Item("gunHandgunT0PipePistol", "Pipe Pistol", 1, 2, 200, "Pistols");
            Item item2 = new Item("gunHandgunT0PipePistol", "Pipe Pistol", 1, 3, 300, "Pistols");
            Item item3 = new Item("gunHandgunT0PipePistol", "Pipe Pistol", 1, 4, 400, "Pistols");
            Item item4 = new Item("gunHandgunT0PipePistol", "Pipe Pistol", 1, 5, 500, "Pistols"); 
            Item item5 = new Item("gunHandgunT0PipePistol", "Pipe Pistol", 1, 6, 1000, "Pistols");
            Item item6 = new Item("gunHandgunT1Pistol", "Pistol", 1, 2, 400, "Pistols");
            Item item7 = new Item("gunHandgunT1Pistol", "Pistol", 1, 3, 500, "Pistols");
            Item item8 = new Item("gunHandgunT1Pistol", "Pistol", 1, 4, 600, "Pistols");
            Item item9 = new Item("gunHandgunT1Pistol", "Pistol", 1, 5, 700, "Pistols");
            Item item10 = new Item("gunHandgunT1Pistol", "Pistol", 1, 6, 1000, "Pistols");
            Item item11 = new Item("gunHandgunT3SMG5", "SMG5", 1, 2, 800, "Pistols");
            Item item12 = new Item("gunHandgunT3SMG5", "SMG5", 1, 3, 900, "Pistols");
            Item item13 = new Item("gunHandgunT3SMG5", "SMG5", 1, 4, 1000, "Pistols");
            Item item14 = new Item("gunHandgunT3SMG5", "SMG5", 1, 5, 1500, "Pistols");
            Item item15 = new Item("gunHandgunT3SMG5", "SMG5", 1, 6, 3000, "Pistols");
            Item item16 = new Item("gunHandgunT2Magnum44", ".44 Magnum", 1, 2, 1000, "Pistols");
            Item item17 = new Item("gunHandgunT2Magnum44", ".44 Magnum", 1, 3, 1250, "Pistols");
            Item item18 = new Item("gunHandgunT2Magnum44", ".44 Magnum", 1, 4, 1500, "Pistols");
            Item item19 = new Item("gunHandgunT2Magnum44", ".44 Magnum", 1, 5, 1750, "Pistols");
            Item item20 = new Item("gunHandgunT2Magnum44", ".44 Magnum", 1, 6, 5000, "Pistols");
            Item item21 = new Item("gunHandgunT3DesertVulture", ".44 Desert Vulture",  1, 2, 1000, "Pistols");
            Item item22 = new Item("gunHandgunT3DesertVulture", ".44 Desert Vulture",  1, 3, 1250, "Pistols");
            Item item23 = new Item("gunHandgunT3DesertVulture", ".44 Desert Vulture",  1, 4, 1500, "Pistols");
            Item item24 = new Item("gunHandgunT3DesertVulture", ".44 Desert Vulture",  1, 5, 1750, "Pistols");
            Item item25 = new Item("gunHandgunT3DesertVulture", ".44 Desert Vulture",  1, 6, 5000, "Pistols");


            itemInventoryPistols.Add(item1);
            itemInventoryPistols.Add(item2);
            itemInventoryPistols.Add(item3);
            itemInventoryPistols.Add(item4);
            itemInventoryPistols.Add(item5);
            itemInventoryPistols.Add(item6);
            itemInventoryPistols.Add(item7);
            itemInventoryPistols.Add(item8);
            itemInventoryPistols.Add(item9);
            itemInventoryPistols.Add(item10);
            itemInventoryPistols.Add(item11);
            itemInventoryPistols.Add(item12);
            itemInventoryPistols.Add(item13);
            itemInventoryPistols.Add(item14);
            itemInventoryPistols.Add(item15);
            itemInventoryPistols.Add(item16);
            itemInventoryPistols.Add(item17);
            itemInventoryPistols.Add(item18);
            itemInventoryPistols.Add(item19);
            itemInventoryPistols.Add(item20);
            itemInventoryPistols.Add(item21);
            itemInventoryPistols.Add(item22);
            itemInventoryPistols.Add(item23);
            itemInventoryPistols.Add(item24);
            itemInventoryPistols.Add(item25);
        }

        private void InitInventoryRifles()
        {
            Item item1 = new Item("gunRifleT0PipeRifle", "Pipe Rifle",  1, 2, 200, "Rifles");
            Item item2 = new Item("gunRifleT0PipeRifle", "Pipe Rifle", 1, 3, 300, "Rifles");
            Item item3 = new Item("gunRifleT0PipeRifle", "Pipe Rifle", 1, 4, 400, "Rifles"); 
            Item item4 = new Item("gunRifleT0PipeRifle", "Pipe Rifle", 1, 5, 500, "Rifles");
            Item item5 = new Item("gunRifleT0PipeRifle", "Pipe Rifle", 1, 6, 1000, "Rifles");
            Item item6 = new Item("gunRifleT1HuntingRifle", "Hunting Rifle", 1, 2, 800, "Rifles");
            Item item7 = new Item("gunRifleT1HuntingRifle", "Hunting Rifle", 1, 3, 900, "Rifles");
            Item item8 = new Item("gunRifleT1HuntingRifle", "Hunting Rifle", 1, 4, 1000, "Rifles");
            Item item9 = new Item("gunRifleT1HuntingRifle", "Hunting Rifle", 1, 5, 1250, "Rifles");
            Item item10 = new Item("gunRifleT1HuntingRifle", "Hunting Rifle", 1, 6, 2000, "Rifles");
            Item item11 = new Item("gunRifleT2LeverActionRifle", "Lever Action Rifle",  1, 2, 800, "Rifles");
            Item item12 = new Item("gunRifleT2LeverActionRifle", "Lever Action Rifle",  1, 3, 900, "Rifles");
            Item item13 = new Item("gunRifleT2LeverActionRifle", "Lever Action Rifle",  1, 4, 1000, "Rifles");
            Item item14 = new Item("gunRifleT2LeverActionRifle", "Lever Action Rifle",  1, 5, 1500, "Rifles");
            Item item15 = new Item("gunRifleT2LeverActionRifle", "Lever Action Rifle",  1, 6, 3000, "Rifles");
            Item item16 = new Item("gunRifleT3SniperRifle", "Sniper Rifle", 1, 2, 1000, "Rifles");
            Item item17 = new Item("gunRifleT3SniperRifle", "Sniper Rifle", 1, 3, 1250, "Rifles");
            Item item18 = new Item("gunRifleT3SniperRifle", "Sniper Rifle", 1, 4, 1500, "Rifles");
            Item item19 = new Item("gunRifleT3SniperRifle", "Sniper Rifle", 1, 5, 1750, "Rifles");
            Item item20 = new Item("gunRifleT3SniperRifle", "Sniper Rifle", 1, 6, 5000, "Rifles");



            itemInventoryRifles.Add(item1);
            itemInventoryRifles.Add(item2);
            itemInventoryRifles.Add(item3);
            itemInventoryRifles.Add(item4);
            itemInventoryRifles.Add(item5);
            itemInventoryRifles.Add(item6);
            itemInventoryRifles.Add(item7);
            itemInventoryRifles.Add(item8);
            itemInventoryRifles.Add(item9);
            itemInventoryRifles.Add(item10);
            itemInventoryRifles.Add(item11);
            itemInventoryRifles.Add(item12);
            itemInventoryRifles.Add(item13);
            itemInventoryRifles.Add(item14);
            itemInventoryRifles.Add(item15);
            itemInventoryRifles.Add(item16);
            itemInventoryRifles.Add(item17);
            itemInventoryRifles.Add(item18);
            itemInventoryRifles.Add(item19);
            itemInventoryRifles.Add(item20);
           
        }

        private void InitInventoryMachineGuns()
        {
            Item item1 = new Item("gunMGT0PipeMachineGun", "Pipe Machine Gun", 1, 2, 200, "Machine Guns");
            Item item2 = new Item("gunMGT0PipeMachineGun", "Pipe Machine Gun", 1, 3, 300, "Machine Guns");
            Item item3 = new Item("gunMGT0PipeMachineGun", "Pipe Machine Gun", 1, 4, 400, "Machine Guns");
            Item item4 = new Item("gunMGT0PipeMachineGun", "Pipe Machine Gun", 1, 5, 500, "Machine Guns");
            Item item5 = new Item("gunMGT0PipeMachineGun", "Pipe Machine Gun", 1, 6, 1000, "Machine Guns");
            Item item6 = new Item("gunMGT1AK47", "AK-47", 1, 2, 800, "Machine Guns");
            Item item7 = new Item("gunMGT1AK47", "AK-47", 1, 3, 900, "Machine Guns");
            Item item8 = new Item("gunMGT1AK47", "AK-47", 1, 4, 1000, "Machine Guns");
            Item item9 = new Item("gunMGT1AK47", "AK-47", 1, 5, 1500, "Machine Guns");
            Item item10 = new Item("gunMGT1AK47", "AK-47", 1, 6, 2000, "Machine Guns");
            Item item11 = new Item("gunMGT2TacticalAR", "Tactical Assault Rifle", 1, 2, 800, "Machine Guns");
            Item item12 = new Item("gunMGT2TacticalAR", "Tactical Assault Rifle", 1, 3, 900, "Machine Guns");
            Item item13 = new Item("gunMGT2TacticalAR", "Tactical Assault Rifle", 1, 4, 1000, "Machine Guns");
            Item item14 = new Item("gunMGT2TacticalAR", "Tactical Assault Rifle", 1, 5, 1500, "Machine Guns");
            Item item15 = new Item("gunMGT2TacticalAR", "Tactical Assault Rifle", 1, 6, 3000, "Machine Guns");
            Item item16 = new Item("gunMGT3M60", "M60", 1, 2, 1000, "Machine Guns");
            Item item17 = new Item("gunMGT3M60", "M60", 1, 3, 1250, "Machine Guns");
            Item item18 = new Item("gunMGT3M60", "M60", 1, 4, 1500, "Machine Guns");
            Item item19 = new Item("gunMGT3M60", "M60", 1, 5, 1750, "Machine Guns");
            Item item20 = new Item("gunMGT3M60", "M60", 1, 6, 5000, "Machine Guns");



            itemInventoryMachineGuns.Add(item1);
            itemInventoryMachineGuns.Add(item2);
            itemInventoryMachineGuns.Add(item3);
            itemInventoryMachineGuns.Add(item4);
            itemInventoryMachineGuns.Add(item5);
            itemInventoryMachineGuns.Add(item6);
            itemInventoryMachineGuns.Add(item7);
            itemInventoryMachineGuns.Add(item8);
            itemInventoryMachineGuns.Add(item9);
            itemInventoryMachineGuns.Add(item10);
            itemInventoryMachineGuns.Add(item11);
            itemInventoryMachineGuns.Add(item12);
            itemInventoryMachineGuns.Add(item13);
            itemInventoryMachineGuns.Add(item14);
            itemInventoryMachineGuns.Add(item15);
            itemInventoryMachineGuns.Add(item16);
            itemInventoryMachineGuns.Add(item17);
            itemInventoryMachineGuns.Add(item18);
            itemInventoryMachineGuns.Add(item19);
            itemInventoryMachineGuns.Add(item20);
        }


        private void InitResources()
        {
            Item item1 = new Item("resourceRockSmallBundle", "Small Rocks x6000",   1, 1, 1000, "Resources");
            Item item2 = new Item("resourceWoodBundle", "Wood x6000", 1, 1, 1000, "Resources");
            Item item3 = new Item("resourceScrapIronBundle", "Scrap Iron x6000",    1, 1, 1000, "Resources");
            Item item4 = new Item("resourcePotassiumNitratePowderBundle", "Potassium Nitrate x6000", 1, 1, 1000, "Resources");
            Item item5 = new Item("resourceLeadBundle", "Lead x6000", 1, 1, 1000, "Resources");
            Item item6 = new Item("resourceCoalBundle", "Coal x6000", 1, 1, 1000, "Resources");
            Item item7 = new Item("resourceOilShaleBundle", "Oil Shale x6000", 1, 1, 1000, "Resources");

            itemListResources.Add(item1);
            itemListResources.Add(item2);
            itemListResources.Add(item3);
            itemListResources.Add(item4);
            itemListResources.Add(item5);
            itemListResources.Add(item6);
            itemListResources.Add(item7);
        }

        private void InitBooks()
        {
            Item item1 = new Item("bookFiremansAlmanacHeat", "Fireman's Almanac vol 1", 1, 1, 850, "Perk Books");
            Item item2 = new Item("bookFiremansAlmanacAxes", "Fireman's Almanac vol 2", 1, 1, 850, "Perk Books");
            Item item3 = new Item("bookFiremansAlmanacMolotov", "Fireman's Almanac vol 3", 1, 1, 850, "Perk Books");
            Item item4 = new Item("bookFiremansAlmanacSpeed", "Fireman's Almanac vol 4", 1, 1, 850, "Perk Books");
            Item item5 = new Item("bookFiremansAlmanacPrevention", "Fireman's Almanac vol 5", 1, 1, 850, "Perk Books");
            Item item6 = new Item("bookFiremansAlmanacHarvest", "Fireman's Almanac vol 6", 1, 1, 850, "Perk Books");
            Item item7 = new Item("bookFiremansAlmanacEquipment", "Fireman's Almanac vol 7", 1, 1, 850, "Perk Books");
            Item item8 = new Item("bookNightStalkerStealthDamage", "Night Stalker vol 1", 1, 1, 850, "Perk Books");
            Item item9 = new Item("bookNightStalkerSilentNight", "Night Stalker vol 2", 1, 1, 850, "Perk Books");
            Item item10 = new Item("bookNightStalkerBlades", "Night Stalker vol 3", 1, 1, 850, "Perk Books");
            Item item11 = new Item("bookNightStalkerThiefAdrenaline", "Night Stalker vol 4", 1, 1, 850, "Perk Books");
            Item item12 = new Item("bookNightStalkerArchery", "Night Stalker vol 5", 1, 1, 850, "Perk Books");
            Item item13 = new Item("bookNightStalkerTwilightThief", "Night Stalker vol 6", 1, 1, 850, "Perk Books");
            Item item14 = new Item("bookNightStalkerSlumberParty", "Night Stalker vol 7", 1, 1, 850, "Perk Books");
            Item item15 = new Item("bookLuckyLooterDukes", "Lucky Looter vol 1", 1, 1, 850, "Perk Books");
            Item item16 = new Item("bookLuckyLooterAmmunition", "Lucky Looter vol 2", 1, 1, 850, "Perk Books");
            Item item17 = new Item("bookLuckyLooterBrass", "Lucky Looter vol 3", 1, 1, 850, "Perk Books");
            Item item18 = new Item("bookLuckyLooterLead", "Lucky Looter vol 4", 1, 1, 850, "Perk Books"); 
            Item item19 = new Item("bookLuckyLooterBooks", "Lucky Looter vol 5", 1, 1, 850, "Perk Books");
            Item item20 = new Item("bookLuckyLooterFood", "Lucky Looter vol 6", 1, 1, 850, "Perk Books");
            Item item21 = new Item("bookLuckyLooterMedical", "Lucky Looter vol 7", 1, 1, 850, "Perk Books");
            Item item22 = new Item("bookEnforcerDamage", "Magnum Enforcer vol 1", 1, 1, 850, "Perk Books");
            Item item23 = new Item("bookEnforcerApparel", "Magnum Enforcer vol 2", 1, 1, 850, "Perk Books");
            Item item24 = new Item("bookEnforcerPunks", "Magnum Enforcer vol 3", 1, 1, 850, "Perk Books");
            Item item25 = new Item("bookEnforcerIntimidation", "Magnum Enforcer vol 4", 1, 1, 850, "Perk Books");
            Item item26 = new Item("bookEnforcerAPAmmo", "Magnum Enforcer vol 5", 1, 1, 850, "Perk Books");
            Item item27 = new Item("bookEnforcerHPAmmo", "Magnum Enforcer vol 6", 1, 1, 850, "Perk Books");
            Item item28 = new Item("bookEnforcerCriminalPursuit", "Magnum Enforcer vol 7", 1, 1, 850, "Perk Books");
            Item item29 = new Item("bookBatterUpBigHits", "Batter Up! vol 1", 1, 1, 850, "Perk Books");
            Item item30 = new Item("bookBatterUpMetalChain", "Batter Up! vol 2", 1, 1, 850, "Perk Books");
            Item item31 = new Item("bookBatterUpGear", "Batter Up! vol 3", 1, 1, 850, "Perk Books");
            Item item32 = new Item("bookBatterUpSlowPitch", "Batter Up! vol 4", 1, 1, 850, "Perk Books");
            Item item33 = new Item("bookBatterUpKnockdown", "Batter Up! vol 5", 1, 1, 850, "Perk Books");
            Item item34 = new Item("bookBatterUpMaintenance", "Batter Up! vol 6", 1, 1, 850, "Perk Books");
            Item item35 = new Item("bookBatterUpBaseballBats", "Batter Up! vol 7", 1, 1, 850, "Perk Books");
            Item item36 = new Item("bookGreatHeistSafes", "Great Heist vol 1",   1, 1, 850, "Perk Books");
            Item item37 = new Item("bookGreatHeistGems", "Great Heist vol 2",   1, 1, 850, "Perk Books");
            Item item38 = new Item("bookGreatHeistTimedCharge", "Great Heist vol 3",   1, 1, 850, "Perk Books");
            Item item39 = new Item("bookGreatHeistClaimed", "Great Heist vol 4",   1, 1, 850, "Perk Books");
            Item item40 = new Item("bookGreatHeistAdrenalineFall", "Great Heist vol 5",   1, 1, 850, "Perk Books");
            Item item41 = new Item("bookGreatHeistSprintSneak", "Great Heist vol 6",   1, 1, 850, "Perk Books");
            Item item42 = new Item("bookGreatHeistMotionDetection", "Great Heist vol 7",   1, 1, 850, "Perk Books");
            Item item43 = new Item("bookWasteTreasuresHoney", "Wasteland Treasures vol 1", 1, 1, 850, "Perk Books");
            Item item44 = new Item("bookWasteTreasuresCoffins", "Wasteland Treasures vol 2", 1, 1, 850, "Perk Books");
            Item item45 = new Item("bookWasteTreasuresAcid", "Wasteland Treasures vol 3", 1, 1, 850, "Perk Books");
            Item item46 = new Item("bookWasteTreasuresWater", "Wasteland Treasures vol 4", 1, 1, 850, "Perk Books");
            Item item47 = new Item("bookWasteTreasuresDoors", "Wasteland Treasures vol 5", 1, 1, 850, "Perk Books");
            Item item48 = new Item("bookWasteTreasuresCloth", "Wasteland Treasures vol 6", 1, 1, 850, "Perk Books");
            Item item49 = new Item("bookWasteTreasuresSinks", "Wasteland Treasures vol 7", 1, 1, 850, "Perk Books");
            Item item50 = new Item("bookNeedleAndThreadWinterWear", "Needle and Thread vol 1", 1, 1, 850, "Perk Books");
            Item item51 = new Item("bookNeedleAndThreadLegwear", "Needle and Thread vol 2", 1, 1, 850, "Perk Books");
            Item item52 = new Item("bookNeedleAndThreadFootwear", "Needle and Thread vol 3", 1, 1, 850, "Perk Books");
            Item item53 = new Item("bookNeedleAndThreadDesertWear", "Needle and Thread vol 4", 1, 1, 850, "Perk Books");
            Item item54 = new Item("bookNeedleAndThreadDusters", "Needle and Thread vol 5", 1, 1, 850, "Perk Books");
            Item item55 = new Item("bookNeedleAndThreadPufferCoats", "Needle and Thread vol 6", 1, 1, 850, "Perk Books");
            Item item56 = new Item("bookNeedleAndThreadPockets", "Needle and Thread vol 7", 1, 1, 850, "Perk Books");
            Item item57 = new Item("bookHuntingJournalBears", "Hunter's Journal vol 1", 1, 1, 850, "Perk Books");
            Item item58 = new Item("bookHuntingJournalWolves", "Hunter's Journal vol 2", 1, 1, 850, "Perk Books");
            Item item59 = new Item("bookHuntingJournalCoyotes", "Hunter's Journal vol 3", 1, 1, 850, "Perk Books");
            Item item60 = new Item("bookHuntingJournalMountainLions", "Hunter's Journal vol 4", 1, 1, 850, "Perk Books");
            Item item61 = new Item("bookHuntingJournalDeer", "Hunter's Journal vol 5", 1, 1, 850, "Perk Books");
            Item item62 = new Item("bookHuntingJournalVultures", "Hunter's Journal vol 6", 1, 1, 850, "Perk Books");
            Item item63 = new Item("bookHuntingJournalSelfDefense", "Hunter's Journal vol 7", 1, 1, 850, "Perk Books");
            Item item64 = new Item("bookArtOfMiningLuckyStrike",  "Art of Mining vol 1", 1,   1,   850, "Perk Books");
            Item item65 = new Item("bookArtOfMiningDiamondTools", "Art of Mining vol 2", 1,   1,   850, "Perk Books");
            Item item66 = new Item("bookArtOfMiningPallets",      "Art of Mining vol 3", 1,   1,   850, "Perk Books");
            Item item67 = new Item("bookArtOfMiningCoffee",       "Art of Mining vol 4", 1,   1,   850, "Perk Books");
            Item item68 = new Item("bookArtOfMiningBlackStrap",   "Art of Mining vol 5", 1,   1,   850, "Perk Books");
            Item item69 = new Item("bookArtOfMiningAvalanche",    "Art of Mining vol 6", 1,   1,   850, "Perk Books");
            Item item70 = new Item("bookArtOfMiningLantern", "Art of Mining vol 7", 1, 1, 850, "Perk Books");
            Item item71 = new Item("bookRangersArrowRecovery",  "Ranger's Guide to Archery vol 1",	1,	1,	850,	"Perk Books");
            Item item72 = new Item("bookRangersExplodingBolts", "Ranger's Guide to Archery vol 2",	1,	1,	850,	"Perk Books");
            Item item73 = new Item("bookRangersCripplingShot",  "Ranger's Guide to Archery vol 3",	1,	1,	850,	"Perk Books");
            Item item74 = new Item("bookRangersAPAmmo",         "Ranger's Guide to Archery vol 4",	1,	1,	850,	"Perk Books");
            Item item75 = new Item("bookRangersFlamingArrows",  "Ranger's Guide to Archery vol 5",	1,	1,	850,	"Perk Books");
            Item item76 = new Item("bookRangersForestGuide",    "Ranger's Guide to Archery vol 6",	1,	1,	850,	"Perk Books");
            Item item77 = new Item("bookRangersKnockdown", "Ranger's Guide to Archery vol 7",   1, 1, 850, "Perk Books");
            Item item78 = new Item("bookPistolPeteTakeAim",     "Pistol Pete vol 1",   1,   1,   850, "Perk Books");
            Item item79 = new Item("bookPistolPeteSwissKnees",  "Pistol Pete vol 2",   1,   1,   850, "Perk Books");
            Item item80 = new Item("bookPistolPeteSteadyHand",  "Pistol Pete vol 3",   1,   1,   850, "Perk Books");
            Item item81 = new Item("bookPistolPeteMaintenance", "Pistol Pete vol 4",   1,   1,   850, "Perk Books");
            Item item82 = new Item("bookPistolPeteHPAmmo",      "Pistol Pete vol 5",   1,   1,   850, "Perk Books");
            Item item83 = new Item("bookPistolPeteAPAmmo", "Pistol Pete vol 6",   1, 1, 850, "Perk Books");
            Item item84 = new Item("bookPistolPeteDamage", "Pistol Pete vol 7",   1, 1, 850, "Perk Books");
            Item item85 = new Item("bookShotgunMessiahDamage", "Shotgun Messiah vol 1",   1, 1, 850, "Perk Books");
            Item item86 = new Item("bookShotgunMessiahBreachingSlugs", "Shotgun Messiah vol 2",   1, 1, 850, "Perk Books");
            Item item87 = new Item("bookShotgunMessiahLimbShot", "Shotgun Messiah vol 3",   1, 1, 850, "Perk Books");
            Item item88 = new Item("bookShotgunMessiahSlugs", "Shotgun Messiah vol 4",   1, 1, 850, "Perk Books");
            Item item89 = new Item("bookShotgunMessiahMaintenance", "Shotgun Messiah vol 5",   1, 1, 850, "Perk Books");
            Item item90 = new Item("bookShotgunMessiahMagazine", "Shotgun Messiah vol 6",   1, 1, 850, "Perk Books");
            Item item91 = new Item("bookShotgunMessiahPartyStarter", "Shotgun Messiah vol 7", 1, 1, 850, "Perk Books");
            Item item92 = new Item("bookSniperDamage", "Sniper vol 1", 1, 1, 850, "Perk Books");
            Item item93 = new Item("bookSniperCripplingShot", "Sniper vol 2", 1, 1, 850, "Perk Books");
            Item item94 = new Item("bookSniperHeadShot", "Sniper vol 3", 1, 1, 850, "Perk Books");
            Item item95 = new Item("bookSniperReload", "Sniper vol 4", 1, 1, 850, "Perk Books");
            Item item96 = new Item("bookSniperControlledBreathing", "Sniper vol 5", 1, 1, 850, "Perk Books");
            Item item97 = new Item("bookSniperAPAmmo", "Sniper vol 6", 1, 1, 850, "Perk Books");
            Item item98 = new Item("bookSniperHPAmmo", "Sniper vol 7", 1, 1, 850, "Perk Books");
            Item item99 = new Item("bookAutoWeaponsDamage", "Automatic Weapons Handbook vol 1", 1, 1, 850, "Perk Books");
            Item item100 = new Item("bookAutoWeaponsUncontrolledBurst", "Automatic Weapons Handbook vol 2", 1, 1, 850, "Perk Books");
            Item item101 = new Item("bookAutoWeaponsMaintenance", "Automatic Weapons Handbook vol 3", 1, 1, 850, "Perk Books");
            Item item102 = new Item("bookAutoWeaponsDrumMag", "Automatic Weapons Handbook vol 4", 1, 1, 850, "Perk Books");
            Item item103 = new Item("bookAutoWeaponsRecoil", "Automatic Weapons Handbook vol 5", 1, 1, 850, "Perk Books");
            Item item104 = new Item("bookAutoWeaponsRagdoll", "Automatic Weapons Handbook vol 6", 1, 1, 850, "Perk Books");
            Item item105 = new Item("bookAutoWeaponsMachineGuns", "Automatic Weapons Handbook vol 7", 1, 1, 850, "Perk Books");
            Item item106 = new Item("bookUrbanCombatLanding", "Urban Combat vol 1", 1, 1, 850, "Perk Books");
            Item item107 = new Item("bookUrbanCombatCigar", "Urban Combat vol 2", 1, 1, 850, "Perk Books");
            Item item108 = new Item("bookUrbanCombatSneaking", "Urban Combat vol 3", 1, 1, 850, "Perk Books");
            Item item109 = new Item("bookUrbanCombatJumping", "Urban Combat vol 4", 1, 1, 850, "Perk Books");
            Item item110 = new Item("bookUrbanCombatLandMines", "Urban Combat vol 5", 1, 1, 850, "Perk Books");
            Item item111 = new Item("bookUrbanCombatAdrenalineRush", "Urban Combat vol 6", 1, 1, 850, "Perk Books");
            Item item112 = new Item("bookUrbanCombatRoomClearing", "Urban Combat vol 7", 1, 1, 850, "Perk Books");
            Item item113 = new Item("bookTechJunkie1Damage", "Tech Junkie vol 1", 1, 1, 850, "Perk Books");
            Item item114 = new Item("bookTechJunkie2Maintenance", "Tech Junkie vol 2", 1, 1, 850, "Perk Books");
            Item item115 = new Item("bookTechJunkie3APAmmo", "Tech Junkie vol 3", 1, 1, 850, "Perk Books");
            Item item116 = new Item("bookTechJunkie4Shells", "Tech Junkie vol 4", 1, 1, 850, "Perk Books");
            Item item117 = new Item("bookTechJunkie5Repulsor", "Tech Junkie vol 5", 1, 1, 850, "Perk Books");
            Item item118 = new Item("bookTechJunkie6BatonCharge", "Tech Junkie vol 6", 1, 1, 850, "Perk Books");
            Item item119 = new Item("bookTechJunkie7Hydraulics", "Tech Junkie vol 7", 1, 1, 850, "Perk Books");
            Item item120 = new Item("bookBarBrawling1BasicMoves", "Bar Brawler vol 1", 1, 1, 850, "Perk Books");
            Item item121 = new Item("bookBarBrawling2DropABomb", "Bar Brawler vol 2", 1, 1, 850, "Perk Books");
            Item item122 = new Item("bookBarBrawling3KillerInstinct", "Bar Brawler vol 3", 1, 1, 850, "Perk Books");
            Item item123 = new Item("bookBarBrawling4FinishingMoves", "Bar Brawler vol 4", 1, 1, 850, "Perk Books");
            Item item124 = new Item("bookBarBrawling5AdrenalineHealing", "Bar Brawler vol 5", 1, 1, 850, "Perk Books");
            Item item125 = new Item("bookBarBrawling6RageMode", "Bar Brawler vol 6", 1, 1, 850, "Perk Books");
            Item item126 = new Item("bookBarBrawling7BoozedUp", "Bar Brawler vol 7", 1, 1, 850, "Perk Books");
            Item item127 = new Item("bookSpearHunter1Damage", "Spear Hunter vol 1", 1, 1, 850, "Perk Books");
            Item item128 = new Item("bookSpearHunter2Maintenance", "Spear Hunter vol 2", 1, 1, 850, "Perk Books");
            Item item129 = new Item("bookSpearHunter3SteelSpears", "Spear Hunter vol 3", 1, 1, 850, "Perk Books");
            Item item130 = new Item("bookSpearHunter4StrongArm", "Spear Hunter vol 4", 1, 1, 850, "Perk Books");
            Item item131 = new Item("bookSpearHunter5RapidStrike", "Spear Hunter vol 5", 1, 1, 850, "Perk Books");
            Item item132 = new Item("bookSpearHunter6PuncturedLung", "Spear Hunter vol 6", 1, 1, 850, "Perk Books");
            Item item133 = new Item("bookSpearHunter7QuickStrike", "Spear Hunter vol 7", 1, 1, 850, "Perk Books");


            itemListBooks.Add(item1);
            itemListBooks.Add(item2);
            itemListBooks.Add(item3);
            itemListBooks.Add(item4);
            itemListBooks.Add(item5);
            itemListBooks.Add(item6);
            itemListBooks.Add(item7);
            itemListBooks.Add(item8);
            itemListBooks.Add(item9);
            itemListBooks.Add(item10);
            itemListBooks.Add(item11);
            itemListBooks.Add(item12);
            itemListBooks.Add(item13);
            itemListBooks.Add(item14);
            itemListBooks.Add(item15);
            itemListBooks.Add(item16);
            itemListBooks.Add(item17);
            itemListBooks.Add(item18);
            itemListBooks.Add(item19);
            itemListBooks.Add(item20);
            itemListBooks.Add(item21);
            itemListBooks.Add(item22);
            itemListBooks.Add(item23);
            itemListBooks.Add(item24);
            itemListBooks.Add(item25);
            itemListBooks.Add(item26);
            itemListBooks.Add(item27);
            itemListBooks.Add(item28);
            itemListBooks.Add(item29);
            itemListBooks.Add(item30);
            itemListBooks.Add(item31);
            itemListBooks.Add(item32);
            itemListBooks.Add(item33);
            itemListBooks.Add(item34);
            itemListBooks.Add(item35);
            itemListBooks.Add(item36);
            itemListBooks.Add(item37);
            itemListBooks.Add(item38);
            itemListBooks.Add(item39);
            itemListBooks.Add(item40);
            itemListBooks.Add(item41);
            itemListBooks.Add(item42);
            itemListBooks.Add(item43);
            itemListBooks.Add(item44);
            itemListBooks.Add(item45);
            itemListBooks.Add(item46);
            itemListBooks.Add(item47);
            itemListBooks.Add(item48);
            itemListBooks.Add(item49);
            itemListBooks.Add(item50);
            itemListBooks.Add(item51);
            itemListBooks.Add(item52);
            itemListBooks.Add(item53);
            itemListBooks.Add(item54);
            itemListBooks.Add(item55);
            itemListBooks.Add(item56);
            itemListBooks.Add(item57);
            itemListBooks.Add(item58);
            itemListBooks.Add(item59);
            itemListBooks.Add(item60);
            itemListBooks.Add(item61);
            itemListBooks.Add(item62);
            itemListBooks.Add(item63);
            itemListBooks.Add(item64);
            itemListBooks.Add(item65);
            itemListBooks.Add(item66);
            itemListBooks.Add(item67);
            itemListBooks.Add(item68);
            itemListBooks.Add(item69);
            itemListBooks.Add(item60);
            itemListBooks.Add(item61);
            itemListBooks.Add(item62);
            itemListBooks.Add(item63);
            itemListBooks.Add(item64);
            itemListBooks.Add(item65);
            itemListBooks.Add(item66);
            itemListBooks.Add(item67);
            itemListBooks.Add(item68);
            itemListBooks.Add(item69);
            itemListBooks.Add(item70);
            itemListBooks.Add(item80);
            itemListBooks.Add(item81);
            itemListBooks.Add(item82);
            itemListBooks.Add(item83);
            itemListBooks.Add(item84);
            itemListBooks.Add(item85);
            itemListBooks.Add(item86);
            itemListBooks.Add(item87);
            itemListBooks.Add(item88);
            itemListBooks.Add(item89);
            itemListBooks.Add(item90);
            itemListBooks.Add(item91);
            itemListBooks.Add(item92);
            itemListBooks.Add(item93);
            itemListBooks.Add(item94);
            itemListBooks.Add(item95);
            itemListBooks.Add(item96);
            itemListBooks.Add(item97);
            itemListBooks.Add(item98);
            itemListBooks.Add(item99);
            itemListBooks.Add(item100);
            itemListBooks.Add(item101);
            itemListBooks.Add(item102);
            itemListBooks.Add(item103);
            itemListBooks.Add(item104);
            itemListBooks.Add(item105);
            itemListBooks.Add(item106);
            itemListBooks.Add(item107);
            itemListBooks.Add(item108);
            itemListBooks.Add(item109);
            itemListBooks.Add(item110);
            itemListBooks.Add(item111);
            itemListBooks.Add(item112);
            itemListBooks.Add(item113);
            itemListBooks.Add(item114);
            itemListBooks.Add(item115);
            itemListBooks.Add(item116);
            itemListBooks.Add(item117);
            itemListBooks.Add(item118);
            itemListBooks.Add(item119);
            itemListBooks.Add(item120);
            itemListBooks.Add(item121);
            itemListBooks.Add(item122);
            itemListBooks.Add(item123);
            itemListBooks.Add(item124);
            itemListBooks.Add(item125);
            itemListBooks.Add(item126);
            itemListBooks.Add(item127);
            itemListBooks.Add(item128);
            itemListBooks.Add(item129);
            itemListBooks.Add(item130);
            itemListBooks.Add(item131);
            itemListBooks.Add(item132);
            itemListBooks.Add(item133);


        }



        private void GenerateShopList()
        {
            itemShopList.Clear();
            //add all items from contants list

            //pick 2 random from each gun category / cycle all weapons that can have a random Rarity(Quality), apply the rarity then add the rest to the shoplist
           
            randomGenerator.ReturnRandomItems(2, itemListMachineGuns, itemShopList);
            randomGenerator.ReturnRandomItems(2, itemListShotguns, itemShopList);
            randomGenerator.ReturnRandomItems(2, itemListRifles, itemShopList);
            randomGenerator.ReturnRandomItems(2, itemListPistols, itemShopList);

            //Combine Inventory for ease of code
            combineInventoryLists();
            
            //Generate random rarity in each item, and get its price from the Inventory Lists
            foreach(Item item in itemShopList)
            {
                item.quality = randomGenerator.ReturnRandomRarity();
                Thread.Sleep(10);
                searchForItemPrice(MasterInventoryList, item);
            }

            //Add the items that don't require a rarity(quality)
            randomGenerator.ReturnRandomItems(2, itemListResources, itemShopList);
            randomGenerator.ReturnRandomItems(15, itemListBooks, itemShopList);
            //Add all constant items
            foreach (Item item in itemListConstants)
                itemShopList.Add(item);
            

        }
        private void searchForItemPrice(List<Item> itemInventoryList, Item ShopListItem)
        {
            foreach (Item item in itemInventoryList)
            {
                if (item.itemName == ShopListItem.itemName && item.quality == ShopListItem.quality)
                    ShopListItem.price = item.price;
            }
        }

        public string ConvertToXmlFormat(Item itemToConvert)
        {

            var mystring = String.Format("<Item Name=\"{0}\" SecondaryName=\"{1}\" Count=\"{2}\" Quality=\"{3}\" Price=\"{4}\" Category=\"{5}\" />", itemToConvert.itemName, itemToConvert.secondayName, itemToConvert.count, itemToConvert.quality, itemToConvert.price, itemToConvert.category);
            
            return mystring;
        }
        public List<Item> GetItemShopList()
        {
            return itemShopList;
        }

        //Shortuct function for searching
        private void combineInventoryLists()
        {
            MasterInventoryList.Clear();

            foreach(Item item in itemInventoryMachineGuns)
                MasterInventoryList.Add(item);
            foreach (Item item in itemInventoryRifles)
                MasterInventoryList.Add(item);
            foreach (Item item in itemInventoryPistols)
                MasterInventoryList.Add(item);
            foreach (Item item in itemInventoryShotguns)
                MasterInventoryList.Add(item);
        }



    }




}


/*
 
<Shop>
<ST Version="20.2.0"/>
<!--  Secondary name is what will show in chat instead of the item name  -->
<Item Name="ammoBundle762mmBulletBall" SecondaryName="7.62mm Box" Count="10" Quality="1" Price="5" Category="Ammo"/>
<Item Name="ammoBundle9mmBulletBall" SecondaryName="9mm Box" Count="10" Quality="1" Price="5" Category="Ammo"/>
<Item Name="ammoBundleShotgunShell" SecondaryName="Shotgun Shell Box" Count="10" Quality="1" Price="5" Category="Ammo"/>
<!--  <Item Name="ammoBundle" SecondaryName="7.62mm Box" Count="10" Quality="1" Price="5" Category="Ammo" />  -->
</Shop>  

 */