using System;
using System.Collections.Generic;

namespace CupsAndBottles
{
    class CupsAndBottles
    {
        static void Main()
        {
            Queue<int> cups = new Queue<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            Stack<int> bottles = new Stack<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            int wastedWater = 0;
            int cup;
            int bottle;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                cup = cups.Dequeue();
                bottle = bottles.Pop();

                while (cup > 0)
                {
                    cup -= bottle;
                    if (cup <= 0)
                    {
                        break;
                    }
                    if (bottles.Count > 0)
                    {
                        bottle = bottles.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
                wastedWater += Math.Abs(cup);
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
