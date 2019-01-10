using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Die> dice = new List<Die>();
            for (int i = 0; i < 5; i++)
            {
                dice.Add(new Die());
            }
            //print roll values
            foreach (Die d in dice)
            {
                Console.WriteLine($"Rolled a {d.Value}");
            }

           // Die dice1 = new Die();
           //// dice1.Roll();

           // Console.WriteLine($"You rolled {dice1.Value}");
            Console.ReadKey();
        }
    }
}
