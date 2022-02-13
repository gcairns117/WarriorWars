using WarriorWars.Equipment.Weapons;
using WarriorWars.Enum;
using System.Threading;

namespace WarriorWars
{
    class Program
    {

        static Random roll = new Random();

        static void Main(string[] args)
        {
            Warrior Red = new Warrior("Red", Faction.RedTeam);
            Warrior Blue = new Warrior("Blue", Faction.BlueTeam);

            while (Blue.IsAlive && Red.IsAlive)
            {
                int redRoll = roll.Next(0, 12) + Red.getModifier(Red);
                int blueRoll = roll.Next(0, 12) + Blue.getModifier(Blue);

                Console.WriteLine("Red Roll:" + redRoll + " | Blue Roll:" + blueRoll);
                
                if (blueRoll > redRoll)
                {
                    Blue.Attack(Blue, Red);
                }
                else if (redRoll > blueRoll)
                {
                    Red.Attack(Red, Blue);
                }
                else if (blueRoll == redRoll)
                {
                    Console.WriteLine("Both warriors lunge, weapons colliding with a clash of steel!");
                    Console.WriteLine("------");
                    continue;
                }

                Thread.Sleep(1000);
            }
            
        }
    }
}
