
internal class Program
{
    class HandHeld:NonLiving
    {
        public void PrintH()
        {
            Console.WriteLine("can be held in hands");
        }
    }
    
    class Weapon:HandHeld
    {
        public void PrintW()
        {
            Console.WriteLine("can be used to attack");
        }
    }
    
    class Living
    {
        public void PrintL()
        {
            Console.WriteLine("is Alive");
        }
    }
    
    class NonLiving
    {
        public void PrintNL()
        {
            Console.WriteLine("is not Alive");
        }
    }
    
    class Nutrition:Eatable
    {
        public void PrintN()
        {
            Console.WriteLine("gives Vitamins");
        }
    }

    class Eatable:HandHeld
    {
        public void PrintE()
        {
            Console.WriteLine("can be eaten");
        }
    }

    class Bread : Eatable
    {
        public void PrintBread()
        {
            Console.WriteLine("\n **** Bread ****\n");
            PrintNL();
            PrintH();
            PrintE();
        }
    }

    class Banana : Nutrition
    {
        public void PrintBanana()
        {
            Console.WriteLine("\n **** Banana ****\n");
            PrintNL();
            PrintH();
            PrintE();
            PrintN();
        }
    }
    
    class Apple : Nutrition
    {
        public void PrintApple()
        {
            Console.WriteLine("\n **** Apple ****\n");
            PrintNL();
            PrintH();
            PrintE();
            PrintN();
        }
    }
    
    class Pear : Nutrition
    {
        public void PrintPear()
        {
            Console.WriteLine("\n **** Pear ****\n");
            PrintNL();
            PrintH();
            PrintE();
            PrintN();
        }
    }

    class Sword : Weapon
    {
        public void PrintSword()
        {
            Console.WriteLine("\n **** Sword ****\n");
            PrintNL();
            PrintH();
            PrintW();
        }
    }
    
    class Axe : Weapon
    {
        public void PrintAxe()
        { 
            Console.WriteLine("\n **** Axe ****\n");
            PrintNL();
            PrintH();
            PrintW();
        }
    }
    
    class Shield : Weapon
    {
        public void PrintShield()
        {
            Console.WriteLine("\n **** Shield ****\n");
            PrintNL();
            PrintH();
            PrintW();
        }
    }
    
    class Spear : Weapon
    {
        public void PrintSpear()
        {
            Console.WriteLine("\n **** Spear ****\n");
            PrintNL();
            PrintH();
            PrintW();
        }
    }
    
    class Pencil : HandHeld
    {
        public void PrintPencil()
        { 
            Console.WriteLine("\n **** Pencil ****\n");
            PrintNL();
            PrintH();
        }
    }

    class Tree : Living
    {
        public void PrintTree()
        {
            Console.WriteLine("\n **** Tree ****\n");
            PrintL();
        }
    }
    
    class Gorilla : Living
    {
        public void PrintGorilla()
        {
            Console.WriteLine("\n **** Gorilla ****\n");
            PrintL();
        }
    }
    
    class Chimpanzee : Living
    {
        public void PrintChimpanzee()
        {
            Console.WriteLine("\n **** Chimpanzee ****\n");
            PrintL();
        }
    }
    
    class Pigeon : Living
    {
        public void PrintPigeon()
        {
            Console.WriteLine("\n **** Pigeon ****\n");
            PrintL();
        }
    }
    
    class Sparrow : Living
    {
        public void PrintSparrow()
        {
            Console.WriteLine("\n **** Sparrow ****\n");
            PrintL();
        }
    }
    
    class Hawk : Living
    {
        public void PrintHawk()
        {
            Console.WriteLine("\n **** Hawk ****\n");
            PrintL();
        }
    }

    private static void Main()
    {
        Bread bread = new Bread();
        Banana banana = new Banana();
        Apple apple = new Apple();
        Pear pear = new Pear();
        Sword sword = new Sword();
        Axe axe = new Axe();
        Pencil pencil = new Pencil();
        Shield shield = new Shield();
        Spear spear = new Spear();
        Tree tree = new Tree();
        Gorilla gorilla = new Gorilla();
        Chimpanzee chimpanzee = new Chimpanzee();
        Sparrow sparrow = new Sparrow();
        Pigeon pigeon = new Pigeon();
        Hawk hawk = new Hawk();
        
        bread.PrintBread();
        banana.PrintBanana();
        apple.PrintApple();
        pear.PrintPear();
        sword.PrintSword();
        axe.PrintAxe();
        pencil.PrintPencil();
        shield.PrintShield();
        spear.PrintSpear();
        tree.PrintTree();
        gorilla.PrintGorilla();
        chimpanzee.PrintChimpanzee();
        sparrow.PrintSparrow();
        pigeon.PrintPigeon();
        hawk.PrintHawk();
    }
}