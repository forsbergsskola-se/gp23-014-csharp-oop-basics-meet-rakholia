
internal class Program
{
    private class Shield
    {
        
    }

    private class Sword
    {
        
    }

    private class Knight
    {
        public Shield shield;
        public Sword sword;

        public Sword Sword
        {
            get
            {
                return sword;
            }
            set
            {
                // Print a message when a Sword is assigned
                Console.WriteLine("Equipping Sword ......");
                sword = value;
            }
        }

        public void GetHit(Sword sword)
        {
            Sword currentSword = sword;
            if (currentSword == null)
            {
                Console.WriteLine("Output:Knight attacks Knight with Bare Hands.");
            }
            else
            {
                Console.WriteLine("Output:Knight attacks Knight with a Sword.");
            }
            
        }
        
        public Knight Attack(Knight knight)
        {
            Sword currentSword = sword;
            Shield currentShield = knight.shield;
            
            if (currentShield == null)
            {
                if (currentSword == null)
                {
                    Console.WriteLine("Output:The Knight has no Shield and is hit.");
                }
                else
                {
                    Console.WriteLine("Output:The Knight has no Shield and is wounded.");
                }
                
            }
            else
            {
                if (currentSword == null)
                {
                    Console.WriteLine("Output:Knights Shield fends off the strike.");
                }
                else
                {
                    Console.WriteLine("Output:Knights Shield was pierced by the Sword.");
                    knight.shield = null;
                }
            }

            return knight;
        }
    }

    public static void Main()
    {
        Knight attackerKnight = new Knight();
        Knight defenderKnight = new Knight();
        Shield shield = new Shield();
        Sword sword = new Sword();
        
        defenderKnight.shield = shield;
        
        attackerKnight.GetHit(null);
        defenderKnight = attackerKnight.Attack(defenderKnight);
        
        attackerKnight.Sword = sword;
        
        attackerKnight.GetHit(sword);
        defenderKnight = attackerKnight.Attack(defenderKnight);
        
        attackerKnight.GetHit(sword);
        defenderKnight = attackerKnight.Attack(defenderKnight);
    }
}