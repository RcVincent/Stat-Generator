using System;
using System.Collections.Generic;
using System.Text;

namespace StatGenerator
{
    class main
    {

        private static void Main(string[] args)
        {
            
            Console.Write("Please choose a system: ");
            String system = Console.ReadLine();
            if (system.Equals("DnD", StringComparison.InvariantCultureIgnoreCase))
            {
                DND d = new DND();
                //allocate the DND stats array, and generate each element 
                int[] stats = new int[6];
                for (int i = 0; i < stats.Length; i++)
                {
                    stats[i] = d.generateDnDStat();
                    Console.WriteLine("Stat Total: " + stats[i]);
                }
            }

            if (system.Equals("Warhammer", StringComparison.InvariantCultureIgnoreCase))
            {
                Warhammer w = new Warhammer();
                int[] stats = new int[9];
                for (int i = 0; i < stats.Length; i++)
                {
                    stats[i] = w.generateWarhammerStat() + 30;
                    Console.WriteLine("Stat Total: " + stats[i]);
                }
            }





        }
    }
}
