using System;


namespace StatGenerator
{
    class Warhammer
    {
        //an insertion sort method
        //the number of elements being used is never greater than 9, so this 
        //sort will have the best runtime and the smallest memory impact 
        
        public int generateWarhammerStat()
        {
            Sort sorter = new Sort();
            int[] dicePool = new int[3];
            int total = 0;
            Random dice = new Random();
            //generate each element in the pool randomly to simulate dice rolls. 
            for (int i = 0; i < dicePool.Length; i++)
            {
                dicePool[i] = dice.Next(1, 10);
                if (dicePool[i] == 1)
                {
                    //given a 1, there is a single chance for a reroll.
                    //if the result is another one, keep it
                    dicePool[i] = dice.Next(1, 10);
                }

            }

            //sort so the smallest value is in the front. 
            sorter.Insertsort(dicePool);

            //remove the smallest value from computation, or the first of a duplicate
            dicePool[0] = 0;

            //tally up the remaining data to return it 
            for (int i = 0; i < dicePool.Length; i++)
            {
                total += dicePool[i];
            }

            return total;
        }

    
    }
}
