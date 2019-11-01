using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4HWSpelunky
{
    /// <summary>
    /// These are the parent classes
    /// </summary>
    class Player
    {

        private int health = 4;
        private bool isHoldingWeapon = false;
        private int ropes = 4;
        private int bombs = 4;

        public Player()
        {

        }

        public Player(bool isHoldingWeapon)
        {
            this.isHoldingWeapon = isHoldingWeapon;
        }

        public Player(int health, bool isHoldingWeapon, int ropes, int bombs)
        {
            this.health = health;
            this.isHoldingWeapon = isHoldingWeapon;
            this.ropes = ropes;
            this.bombs = bombs;
        }

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int value)
        {
            if (value > 99)
            {
                health = 99;
            }
            else
            {
                health = value;
            }
        }
        public bool getIsHoldingWeapon()
        {
            return isHoldingWeapon;
        }
        public void setIsHoldingWeapon(bool value)
        {
            isHoldingWeapon = value;
        }
        public int getRopes()
        {
            return ropes;
        }
        public void setRopes(int value)
        {
            if (value > 99)
            {
                ropes = 99;
            }
            else
            {
                ropes = value;
            }

        }

        public int getBombs()
        {
            return bombs;
        }
        public void setBombs(int value)
        {
            if (value > 99)
            {
                bombs = 99;
            }
            else
            {
                bombs = value;
            }
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is the Player");
        }

    }

    class Items
    {
        private int equipAmount = 1;


        public Items()
        {

        }

        public Items(int equipAmount)
        {
            this.equipAmount = equipAmount;
        }


        public int getEquipAmount()
        {
            return equipAmount;
        }

        public void setEquipAmount(int value)
        {
            if (value > 99)
            {
                equipAmount = 99;
            }
            else
            {
                equipAmount = value;
            }
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is a Item");
        }


    }

    class Enemies
    {
        private int health = 1;
        private int damage = 1;
        private string heldItem;
        private bool canFly = false;
        private bool isHostile = false;
        private object[] totalEnemies = new object[10];

        public Enemies()
        {

        }

        public Enemies(int health)
        {
            this.health = health;
        }

        public Enemies(string heldItem)
        {
            this.heldItem = heldItem;
        }

        public Enemies(bool isHostile)
        {
            this.isHostile = isHostile;
        }

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int value)
        {
            health = value;
        }

        public int getDamage()
        {
            return damage;
        }

        public void setDamage(int value)
        {
            damage = value;
        }

        public string getHeldItem()
        {
            return heldItem;
        }

        public void setHeldItem(string value)
        {
            heldItem = value;
        }

        public bool getCanFly()
        {
            return canFly;
        }

        public void setCanFly(bool value)
        {
            canFly = value;
        }

        public bool getIsHostile()
        {
            return isHostile;
        }

        public void setIsHostile(bool value)
        {
            isHostile = value;
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is a Enemy");
        }
    }

    class Levels
    {
        private string entrance;
        private string exit;
        private string damsel;
        private bool isShopAvaliable;
        private bool isVaultAvaliable;
        private bool isSecretLevelEntrance;
        private ArrayList listOfReferences = new ArrayList();
        public Levels()
        {

        }

        public Levels(ArrayList listOfReferences)
        {
            listOfReferences.Add(new Player());
            listOfReferences.Add(new Shopkeeper(5));
            listOfReferences.Add(new Items());
            // This doesn't seem legal but its something you could try later
            //this.listOfReferences.Add(listOfReferences);
        }

        public string getEntrance()
        {
            return entrance;
        }

        public void setEntrance(string value)
        {
            entrance = value;
        }

        public string getExit()
        {
            return exit;
        }

        public void setExit(string value)
        {
            exit = value;
        }

        public string getDamsel()
        {
            return damsel;
        }

        public void setDamesel(string value)
        {
            damsel = value;
        }

        public bool getIsShopAvaliable()
        {
            return isShopAvaliable;
        }

        public void setIsShopAvaliable(bool value)
        {
            isShopAvaliable = value;
        }

        public bool getIsVaultAvaliable()
        {
            return isVaultAvaliable;
        }

        public void setIsVaultAvaliable(bool value)
        {
            isVaultAvaliable = value;
        }

        public bool getIsSecretLevelEntrance()
        {
            return isSecretLevelEntrance;
        }

        public void setIsSecretLevelEntrance(bool value)
        {
            isSecretLevelEntrance = value;
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This a Level");
        }
    }



    /// <summary>
    ///  These are the children
    /// </summary>
    class Shopkeeper : Enemies
    {
        private bool isThrowPlayer;

        public Shopkeeper()
        {

        }

        public Shopkeeper(bool isThrowPlayer)
        {

        }

        public Shopkeeper(int health) : base(health)
        {

        }

        public bool getIsThrowPlayer()
        {
            return isThrowPlayer;
        }

        public void setIsThrowPlayer(bool value)
        {
            isThrowPlayer = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Shopkeeper");
        }
    }

    class Cavemen : Enemies
    {
        private bool isRunning;

        public Cavemen()
        {

        }

        public Cavemen(int health) : base(health)
        {

        }

        public bool getIsRunning()
        {
            return isRunning;
        }

        public void setIsRunning(bool value)
        {
            isRunning = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Caveman");
        }

    }

    class Weapons : Items
    {
        private int damage = 1;
        // The different attributes to test different ways of working with variables
        private string[] listOfWeapons = { "Rock", "Sword", "Gun" };
        private Hashtable tableOfWeapons = new Hashtable();
        private Dictionary<int, object> weaponsDictionary = new Dictionary<int, object>();

        public Weapons()
        {
            tableOfWeapons.Add(1,"Rock");
            tableOfWeapons.Add(2, "Sword");
            tableOfWeapons.Add(3, "Gun");
        }
        
        // This Constructor converts a Hashtable<Objects> into a Dictionary
        public Weapons (Hashtable weaponTable)
        {
            int count = 1;
            foreach(Object obj in weaponTable)
            {
                weaponsDictionary.Add(count,obj);
                count++;
            }

            Console.WriteLine(weaponsDictionary);
        }

        public Weapons(int positionInArray)
        {
            string currrentWeapon = listOfWeapons[positionInArray];
        }

        public Weapons(int positionInArray, int damage) : base(positionInArray)
        {
            //string currrentWeapon = listOfWeapons[positionInArray];
            this.damage = damage;
        }

        public int getDamage()
        {
            return damage;
        }

        public void setDamage(int value)
        {
            damage = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Weapon");
        }
    }

    class Powerups : Items
    {
        private string effect;
        private string[] listOfPowerups = { "Speed Boots", "Health Container", "Damage Boost" };

        public Powerups()
        {

        }

        public Powerups(string effect)
        {
            this.effect = effect;
        }

        public string getEffect()
        {
            return effect;
        }

        public void setEffect(string value)
        {
            effect = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Powerup");
        }
    }

    class Mines : Levels
    {
        private string minecart;

        public Mines()
        {

        }

        public Mines(string minecart)
        {
            this.minecart = minecart;
        }

        public string getMinecart()
        {
            return minecart;
        }
        public void setMinecart(string value)
        {
            minecart = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is the Mines");
        }
    }

    class Jungle : Levels
    {
        private string vines;

        public Jungle()
        {

        }

        public Jungle(string vines)
        {
            this.vines = vines;
        }

        public string getVines()
        {
            return vines;
        }

        public void setVines(string value)
        {
            vines = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is the Jungle Level");
        }
    }

    class Icecaves : Levels
    {
        private string icicles;

        public Icecaves()
        {

        }

        public string getIcicles()
        {
            return icicles;
        }

        public void setIcicles(string value)
        {
            icicles = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is the Icecave Level");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Player!");

            // Initialising some objects
            Player adventurer = new Player();
            Levels firstLevel = new Mines();
            Weapons firstWeapon = new Weapons(1);
            Weapons secondWeapon = new Weapons(2, 5);
            Shopkeeper shopkeeper = new Shopkeeper();

            // Enemy array, Testing the Constructors for the Parent Class
            Enemies[] enemies =
            {
                new Cavemen(),
                new Shopkeeper(),
                new Cavemen(3),
                new Shopkeeper(5),

            };

            // Testing the hashtable Constructor for weapons
            Hashtable ht = new Hashtable();

            ht.Add(1,"Baseball bat");
            ht.Add(2,"Broken bottle");
            ht.Add(3, "Chair");

            Weapons weaponsHT = new Weapons(ht);
            Console.WriteLine(weaponsHT);

            // Prininting methods
            firstLevel.PrintMethod();
            firstWeapon.PrintMethod();
            secondWeapon.PrintMethod();
        }
    }
}
