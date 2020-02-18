using System;
using System.IO;


namespace StatGenerator
{
    class Program
    {
        //an insertion sort method
        //the number of elements being used is never greater than 6, so this 
        //sort will have the best runtime and the smallest memory impact 
        static void sort(int[] arr)
        {
            //itterate along the array
            for (int i = 1; i < arr.Length; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                //move the elements to their sorted position in the array
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        static int generateStat()
        {
            int[] dicePool = new int[4];
            int total = 0;
            Random dice = new Random();
            //generate each element in the pool randomly to simulate dice rolls. 
            for(int i = 0; i < dicePool.Length; i++)
            {
                dicePool[i] = dice.Next(1, 6);
                if(dicePool[i] == 1)
                {
                    //given a 1, there is a single chance for a reroll.
                    //if the result is another one, keep it
                    dicePool[i] = dice.Next(1, 6);
                }
                
            }

            //sort so the smallest value is in the front. 
            sort(dicePool);

            //remove the smallest value from computation, or the first of a duplicate
            dicePool[0] = 0;

            //tally up the remaining data to return it 
            for(int i = 0; i < dicePool.Length; i++)
            {
                total += dicePool[i];
            }

            return total;
        }
        static void Main(string[] args)
        {
            //allocate the stats array, and generate each element  
            int[] stats = new int[6];
            for(int i = 0; i < stats.Length; i++)
            {
                stats[i] = generateStat();
                Console.WriteLine("Stat Total: " + stats[i]);
            }


            
        }
    }
}
